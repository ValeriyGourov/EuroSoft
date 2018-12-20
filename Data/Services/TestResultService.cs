using System;
using Data.Entities;

namespace Data.Services
{
    public class TestResultService
    {
        private readonly GenericRepository<TestResult> _repository = new GenericRepository<TestResult>(new ApplicationDbContext());

        public void AddResult(string name, uint correctAnswersCount, uint incorrectAnswersCount, uint missedAnswersCount)
        {
            TestResult testResult = new TestResult
            {
                Date = DateTime.Now,
                Name = name,
                CorrectAnswersCount = correctAnswersCount,
                IncorrectAnswersCount = incorrectAnswersCount,
                MissedAnswersCount = missedAnswersCount
            };

            _repository.Create(testResult);
            _repository.SaveChanges();
        }
    }
}
