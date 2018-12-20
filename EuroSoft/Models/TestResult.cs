using System;

namespace EuroSoft.Models
{
    internal class TestResult
    {
        public uint CorrectAnswersCount { get; private set; }
        public uint IncorrectAnswersCount { get; private set; }
        public uint MissedAnswersCount { get; private set; }
        public uint QuestionsCount { get; private set; }

        public TestResult(uint questionsCount)
        {
            QuestionsCount = questionsCount;
        }

        private void CheckAnswersCount()
        {
            if (CorrectAnswersCount + IncorrectAnswersCount + MissedAnswersCount >= QuestionsCount)
            {
                throw new InvalidOperationException("The number of answers can not exceed the number of questions.");
            }
        }

        public void AddCorrectAnswers()
        {
            CheckAnswersCount();
            CorrectAnswersCount++;
        }

        public void AddIncorrectAnswers()
        {
            CheckAnswersCount();
            IncorrectAnswersCount++;
        }

        public void AddMissedAnswers()
        {
            CheckAnswersCount();
            MissedAnswersCount++;
        }
    }
}
