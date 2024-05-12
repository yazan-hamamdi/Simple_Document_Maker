

namespace Document_Maker
{
    public class Book : Document
    {
        public string? Edition { get; set; }
        public Book(string title, DateTime dateOfTime,List<Author>authors,string edition)
        {
            Title = title;
            DateOfCreation = dateOfTime;
            Authors = authors;
            Edition = edition;
        }
        public override string ToString()
        {
            string authors = string.Join(", ", Authors.Select(a => a.Name));
            return $"Name: {Title}, Date of Birth: {DateOfCreation}, Authors: {authors}, Edition: {Edition}";
        }
    }
}
