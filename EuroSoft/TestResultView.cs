using System;
using System.Windows.Forms;
using Data.Services;
using EuroSoft.Models;

namespace EuroSoft
{
    public partial class TestResultView : Form
    {
        private readonly string _userName;
        private readonly TestResult _testResult;

        private TestResultView()
        {
            InitializeComponent();
        }

        internal TestResultView(string userName, TestResult testResult)
        {
            InitializeComponent();

            _userName = userName ?? throw new ArgumentNullException(nameof(userName));
            _testResult = testResult ?? throw new ArgumentNullException(nameof(testResult));
        }

        private void TestResultView_Load(object sender, EventArgs e)
        {
            string[] xValue = new string[] { "Percents" };
            AnswersPercentageRatio.Series["Correct"].Points.DataBindXY(xValue, new uint[] { _testResult.CorrectAnswersCount });
            AnswersPercentageRatio.Series["Incorrect"].Points.DataBindXY(xValue, new uint[] { _testResult.IncorrectAnswersCount });
            AnswersPercentageRatio.Series["Missed"].Points.DataBindXY(xValue, new uint[] { _testResult.MissedAnswersCount });

            TestResultBindingSource.DataSource = _testResult;
        }

        private void SaveResult_Click(object sender, EventArgs e)
        {
            new TestResultService().AddResult(
                _userName,
                _testResult.CorrectAnswersCount,
                _testResult.IncorrectAnswersCount,
                _testResult.MissedAnswersCount);

            SaveResult.Enabled = false;
        }
    }
}
