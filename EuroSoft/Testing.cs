using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using Data.Entities;
using Data.Services;
using EuroSoft.Models;

namespace EuroSoft
{
    public partial class Testing : Form
    {
        private readonly QuestionService _questionService = new QuestionService();
        private QuestionPage _currentQuestionPage;
        private readonly Queue<int> _questionIds;
        private readonly TestResult _testResult;
        private bool _closeWitoutPrompt = false;
        private bool _testComplete = false;

        internal TestResult TestResult => _testComplete ? _testResult : null;

        public Testing()
        {
            InitializeComponent();

            _questionIds = new Queue<int>(_questionService.GetAllQuestionIds());
            if (_questionIds.Count == 0)
            {
                MessageBox.Show("No question found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                CloseWitoutPrompt();
            }

            _testResult = new TestResult((uint)_questionIds.Count);
        }

        private void Testing_Load(object sender, System.EventArgs e)
        {
            ShowNextQuestion();
        }

        private void Testing_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!_closeWitoutPrompt
                && !AbortTestPrompt())
            {
                e.Cancel = true;
            }
        }

        private void Answer_Click(object sender, System.EventArgs e)
        {
            CheckAnswer();
            if (!_currentQuestionPage.AnswerIsGiven)
            {
                MessageBox.Show("The answer is not selected.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Next_Click(object sender, System.EventArgs e)
        {
            if (!_currentQuestionPage.AnswerIsGiven)
            {
                if (MessageBox.Show(
                    "The answer is not selected. Skip the question?",
                    "Question",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question,
                    MessageBoxDefaultButton.Button2
                    ) == DialogResult.No)
                {
                    return;
                }
                else
                {
                    _testResult.AddMissedAnswers();
                }
            }

            if (!ShowNextQuestion())
            {
                _testComplete = true;
                CloseWitoutPrompt();
            }
        }

        private void Abort_Click(object sender, System.EventArgs e)
        {
            Close();
        }

        private bool ShowNextQuestion()
        {
            if (_questionIds.Count == 0)
            {
                return false;
            }

            Question question = _questionService.GetQuestion(_questionIds.Dequeue());
            _currentQuestionPage = new QuestionPage(question);

            SuspendLayout();
            QuestionPageBindingSource.DataSource = _currentQuestionPage;

            Answers.Controls.Clear();

            int tabIndex = 0;
            const int radioButtonHeight = 27;
            foreach (Answer answer in question.Answers)
            {
                RadioButton radioButton = new RadioButton
                {
                    Tag = answer,
                    Text = answer.Text,
                    TabIndex = tabIndex++,
                    Height = radioButtonHeight,
                    AutoSize = true
                };

                Answers.Controls.Add(radioButton);
            }
            ResumeLayout();

            return true;
        }

        private void CheckAnswer()
        {
            foreach (var control in Answers.Controls)
            {
                if ((control is RadioButton radioButton)
                    && radioButton.Checked)
                {
                    _currentQuestionPage.AnswerIsGiven = true;

                    bool answerIsCorrect = (radioButton.Tag as Answer) == _currentQuestionPage.CorrectAnswer;
                    radioButton.BackColor = answerIsCorrect ? Color.PaleGreen : Color.Coral;
                    if (answerIsCorrect)
                    {
                        _testResult.AddCorrectAnswers();
                    }
                    else
                    {
                        _testResult.AddIncorrectAnswers();
                    }

                    QuestionPageBindingSource.ResetBindings(false);

                    break;
                }
            }
        }

        private bool AbortTestPrompt() =>
            MessageBox.Show(
                "The test is not completed. Abort the test?",
                "Question",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button2
                ) == DialogResult.Yes;

        private void CloseWitoutPrompt()
        {
            _closeWitoutPrompt = true;
            Close();
        }
    }
}
