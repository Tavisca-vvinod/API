namespace Entities
{
    public class Response
    {
        public string Status { get; set; } //can either be success or failure

        public string Description { get; set; } //adds description if failure
    }
}