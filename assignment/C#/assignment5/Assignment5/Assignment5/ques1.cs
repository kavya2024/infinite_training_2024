using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace Assignment5
{
    public class Book //creating a Book class
    {
        //members
        public string BookName { get; }
        public string AuthorName { get; }

        //Instantiating the class
        public Book(string bookName, string authorName)
        {
            BookName = bookName;
            AuthorName = authorName;
        }

        public void Display() //function to display the bookname and authorname
        {
            Console.WriteLine($"Book Name: {BookName}, Author Name: {AuthorName}");
        }
    }

    public class BookShelf 
    {
        private Book[] books = new Book[5];

        public Book this[int index]
        {
            get 
            {
                if (index >= 0 && index < 5)
                {
                    return books[index];
                }
                else
                {
                    throw new IndexOutOfRangeException();
                }
            }
            set 
            {
                if (index >= 0 && index < 5)
                {
                    books[index] = value;
                }
                else
                {
                    throw new IndexOutOfRangeException();
                }
            }
        }
    }

    class ques1
    {
        static void Main(string[] args)
        {
            BookShelf bookShelf = new BookShelf();

            bookShelf[0] = new Book("verity", "Collen Hoover");
            bookShelf[1] = new Book("Silent patient", "Alex Michaelides");
            bookShelf[2] = new Book("the ovenhead", "viginia");
            bookShelf[3] = new Book("A room of one's own", "Virginia woolf");
            bookShelf[4] = new Book("It ends with us", "Coollen hoover");

            for (int i = 0; i < 5; i++)
            {
                bookShelf[i].Display();
            }

            Console.Read();
        }
    }
}