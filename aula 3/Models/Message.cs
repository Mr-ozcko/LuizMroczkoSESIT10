namespace message.Models
{
    public class Message
    {
        public string Content { get; set; } = "";
        public string Name { get; set; } = "";
        public string Email { get; set; } = "";

        public string Dest { get; set; } = "";
    }
}