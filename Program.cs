
namespace Document_Maker
{
    public class Program
    {
        static void Main(string[] args)
        {
            //some tests 
            Author author1 = new Author("John Doe", 1980, 5, 10);
            Author author2 = new Author("Jane Smith", 1975, 9, 11);

            List<Author> authors = new List<Author> { author1, author2 };

            Email email = new Email("Sample Email", DateTime.Now, authors, "Test Subject", new List<string> { "recipient1@example.com", "recipient2@example.com" });

            Book book = new Book("Sample Book", DateTime.Now, authors, "First Edition");

            Document_Manipulation documentManipulation = new Document_Manipulation(new List<Document> { email, book });

            List<Email> foundEmails = documentManipulation.SearchForBooks("Test Subject");
            foreach (var foundEmail in foundEmails)
            {
                Console.WriteLine(foundEmail.ToString());
            }

            List<Book> foundBooks = documentManipulation.SearchForEmails("First Edition");
            Console.WriteLine("Found Books:");
            foreach (var foundBook in foundBooks)
            {
                Console.WriteLine(foundBook.ToString());
            }

        }
    }
}