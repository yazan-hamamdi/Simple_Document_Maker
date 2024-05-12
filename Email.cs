
namespace Document_Maker
{
    public class Email : Document
    {
        public string Subject { set; get; }
        public List<string> To { set; get; }
        public Email(string title, DateTime dateOfTime, List<Author> authors, string subject,List<string>to)
        {
            Title = title;
            DateOfCreation = dateOfTime;
            Authors = authors;
            Subject = subject;
            To = to;
        }
        public override string ToString()
        {

            string toRecipients = string.Join(", ", To);
            string authors = string.Join(", ", Authors.Select(a => a.Name));
            return $"Name: {Title}, Date of Birth: {DateOfCreation}, Subject: {Subject}, To: {toRecipients}, Authors: {authors}";
        }
    }
}
