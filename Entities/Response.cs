namespace Entities
{
    public class Response
    {
        public Status Status { get; set; }

        public string Description { get; set; }
    }
    public enum Status
    {
        Success, Failure
    }
}