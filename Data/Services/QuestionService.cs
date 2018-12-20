using System.Collections.Generic;
using Data.Entities;

namespace Data.Services
{
    public class QuestionService
    {
        private readonly GenericRepository<Question> _repository = new GenericRepository<Question>(new ApplicationDbContext());

        public IEnumerable<int> GetAllQuestionIds() => _repository.GetAllIds();

        public Question GetQuestion(int id) => _repository.Get(id);
    }
}
