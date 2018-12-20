using System;
using System.ComponentModel.DataAnnotations;

namespace Data.Entities
{
    internal class TestResult : EntityBase
    {
        [Required]
        public DateTime Date { get; set; }

        [Required]
        public string Name { get; set; }

        [Range(0, uint.MaxValue)]
        public long CorrectAnswersCount { get; set; }

        [Range(0, uint.MaxValue)]
        public long IncorrectAnswersCount { get; set; }

        [Range(0, uint.MaxValue)]
        public long MissedAnswersCount { get; set; }
    }
}
