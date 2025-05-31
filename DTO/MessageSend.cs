using System;

public class MessageSend
{
    public int MessageID { get; set; }
    public int SenderID { get; set; }
    public int ReceiverID { get; set; }
    public string ReceiverName { get; set; }
    public string Content { get; set; }
    public DateTime? SentAt { get; set; }
}
