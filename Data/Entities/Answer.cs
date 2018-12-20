namespace Data.Entities
{
    public class Answer : EntityBase
    {
        public string Text { get; private set; }
        public int QuestionId { get; private set; }
        public virtual Question Question { get; private set; }
        public bool IsCorrect { get; private set; }
    }
}
