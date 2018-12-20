using System.Collections.Generic;

namespace Data.Entities
{
    public class Question : EntityBase
    {
        public string Title { get; private set; }
        public byte[] Image { get; private set; }
        public string Description { get; private set; }
        public string Decision { get; private set; }
        public virtual ICollection<Answer> Answers { get; private set; }
    }
}
