

namespace Document_Maker
{
    public class Author
    {
        public Author(string name, int year, int month,int day ) {
            counter++;
            Name = name;
            authorDOB = new DateTime(year, month,day);
            Id = _assignd();
        }
        private int Id = counter;
        private static int counter  = 0;
        public string Name { get; set; }
        private DateTime authorDOB;
        public int GetAuthorId()
        { 
            return Id; 
        }
        public void SetAuthorDOB(int day,int month,int year) 
        {
            authorDOB = new DateTime(day,month,year);
        }
        public DateTime GetAuthorDOB()
        {
            return authorDOB;
        }
        private  int _assignd()
        {
            return Id+1;
        }
        public override string ToString()
        {
            return $"Name: {Name}, Date of Birth: {authorDOB}, ID: {Id}";
        }

    }
}
