using System.Linq;
using Data.Entities;

namespace EuroSoft.Models
{
    internal class QuestionPage
    {
        public string Title { get; private set; }
        public byte[] Image { get; private set; }
        public string Description { get; private set; }
        public string Decision { get; private set; }

        public Answer CorrectAnswer { get; private set; }
        public bool AnswerIsGiven { get; set; }
        public bool AnswerIsNotGiven => !AnswerIsGiven;

        public QuestionPage(Question question)
        {
            Title = question.Title;
            Image = question.Image;
            Description = question.Description;
            Decision = question.Decision;

            CorrectAnswer = question.Answers.First(answer => answer.IsCorrect);
        }
    }
}
