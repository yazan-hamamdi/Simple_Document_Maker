

namespace Document_Maker
{
    public abstract class Document
    {
        public string? Title { set; get; }
        public DateTime DateOfCreation { set; get;}
        public List <Author> Authors { set; get; }
        public Document()
        {
            Title = null;
            DateOfCreation = new DateTime();
            Authors = new List<Author>();
        }

        public bool AddAuthor(Author author)
        {
            int size = Authors.Count;
            Authors.Add(author);
            if (size == Authors.Count) 
            {
                return false;
            }
            return true;
        }
    }
}
