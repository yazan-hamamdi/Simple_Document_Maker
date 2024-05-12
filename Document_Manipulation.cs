
namespace Document_Maker
{
    public class Document_Manipulation
    {
        public List<Document> Documents ;
        public Document_Manipulation (List<Document> documents)
        {
            this.Documents = documents;
        } 
        public void CreateNewDocument(string title, DateTime dateOfTime, List<Author> authors, string subject, List<string> to)
        {
            Documents.Add(new Email(title, dateOfTime, authors, subject,to));
        }
        public void CreateNewDocument(string title, DateTime dateOfTime, List<Author> authors,string edition)
        {
            Documents.Add(new Book(title, dateOfTime, authors, edition));
        }
        public List<Email> SearchForBooks(string subject)
        {
            List<Email> emails = new List<Email>();
            foreach (var item in Documents)
            {
                if (item is Email email && email.Subject == subject)
                {
                    emails.Add(email);
                }
            }
            return emails;
        }
        public List<Book> SearchForEmails(string edition)
        {
            List<Book> books = new List<Book>();
            foreach (var item in Documents)
            {
                if (item is Book book && book.Edition == edition)
                {
                    books.Add(((Book)item));
                }
            }
            return books;
        }
    }
}
