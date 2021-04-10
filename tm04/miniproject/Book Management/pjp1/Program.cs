using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pjp1
{ class author
    {
        private String authorName;
        private String authorEmail;
        private char Gender;
        public author(string authorName, string authorEmail, char Gender)
        {
            this.authorName = authorName;
            this.authorEmail = authorEmail;
            this.Gender = Gender;
        }
        public string Name
        {
            get { return authorName; }
            set { authorName = value; }
        }
        public string email
        {
            get { return authorEmail; }
            set { authorEmail = value; }
        }
        public char gender
        {
            get { return Gender; }
            set { Gender = value; }
        }

        public void DisplayAuthorDetails()
        {
            Console.WriteLine("Name of Author is {0}", authorName);
            Console.WriteLine("Gender of Author is {0}", Gender);
            Console.WriteLine("Email Address of Author is {0}", authorEmail);
        }
    }
    class book
    {
       private string ISBN, BookName, authorName, authorEmail;
       private int YearPublished;
       private decimal Price;
       private char Gender;
       public author authorDetails;
        public book(string ISBN, string BookName, string authorName, string authorEmail, int YearPublished, decimal Price, char Gender)
        {
            this.ISBN = ISBN;
            this.BookName = BookName;
            this.authorEmail = authorEmail;
            this.YearPublished = YearPublished;
            this.Price = Price;
            this.Gender = Gender;
            this.authorDetails = new author(authorName, authorEmail, Gender);
        }
        public string isbn
        {
            get { return ISBN; }
            set { ISBN = value; }
        }
        public string bookname
        {
            get { return BookName; }
            set { BookName = value; }
        }
        public int yearpublished
        {
            get { return YearPublished; }
            set { YearPublished = value; }
        }
        public decimal price
        {
            get { return Price; }
            set { Price = value; }

        }
        public author details
        {
            get { return authorDetails; }
            set { authorDetails = value; }

        }
        public void DisplayBookDetails()
        {
            Console.WriteLine("Book Name {0}", BookName);
            Console.WriteLine("Book Price {0}", Price);
            Console.WriteLine("Book Year published {0}", YearPublished);
            Console.WriteLine("Book ISBN {0} ", ISBN);
        }
    }
    class BookManagement
    {
        List<book> rack = new List<book>();
        public void AddBook()
        {
            Console.WriteLine("Enter Book name");
            String BookName = Console.ReadLine();
            Console.WriteLine("Enter International Standard Book Number(ISBN)");
            string ISBN = Console.ReadLine();
            Console.WriteLine("Enter Year Published");
            int YearPublished = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Price of the Book");
            decimal Price = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("Enter name of Author");
            string AuthorName = Console.ReadLine();
            Console.WriteLine("Enter Gender of Author");
            char Gender = Convert.ToChar(Console.ReadLine());
            Console.WriteLine("Enter Email Address of Author");
            string AuthorEmail = Console.ReadLine();
            if (rack.Count >= 10)
            {
                Console.WriteLine("Rack Array is Filled. Can't add more Books");
            }
            else
            {
               
              rack.Add(new book(ISBN, BookName, AuthorName, AuthorEmail, YearPublished, Price, Gender));
            }
        }
        public void SearchBook()
        {
            Console.WriteLine("Enter ISBN Value");
            string search = Console.ReadLine();
            int flag = 0;
            foreach (var a in rack)
            {
                int res = string.Compare(a.isbn, search);
                if (res == 0)
                {
                    flag = 1;
                    Console.WriteLine("True");
                }
                else if (flag == 0)
                {
                    Console.WriteLine("False");
                }
            }
        }
        public void ViewBook()
        {
            foreach (var a in rack)
            {
                a.DisplayBookDetails();
            }
        }
        public void ViewAuthor()
        {
            foreach (var a in rack)
            {
                a.details.DisplayAuthorDetails();
            }
        }
        public void UpdateBook()
        {
            Console.WriteLine("Enter ISBN: ");
            string searchISBN = Console.ReadLine();
            Console.WriteLine("What do you want to update? \n 1)Author details \n 2)Book details");
            int num = Convert.ToInt32(Console.ReadLine());
            if (num == 1)
            {
                Console.WriteLine("Which detail you want to update");
                Console.WriteLine("1. Author Name");
                Console.WriteLine("2. Author Email");
                Console.WriteLine("3. Author gender");
                int a1 = Convert.ToInt32(Console.ReadLine());
                for (int i = 0; i < rack.Count; i++)
                {
                    if (rack[i].isbn == searchISBN)
                    {
                        if(a1 == 1)
                        {
                            Console.WriteLine("Enter New Name");
                            string nn = Console.ReadLine();
                            rack[i].details.Name = nn;
                        }
                        else if (a1 == 2)
                        {
                            Console.WriteLine("Enter New Email");
                            string nn = Console.ReadLine();
                            rack[i].details.email = nn;
                        }
                       else if (a1 == 3)
                        {
                            Console.WriteLine("Enter New Gender");
                            Char nn = Convert.ToChar(Console.ReadLine());
                            rack[i].details.gender = nn;
                        }
                    }
                }
            }
            else if(num==2)
            {
                Console.WriteLine("Which detail you want to update");
                Console.WriteLine("1. Book Name ");
                Console.WriteLine("2. Year Published ");
                Console.WriteLine("3. Price ");
                int a2 = Convert.ToInt32(Console.ReadLine());
                for (int i = 0; i < rack.Count; i++)
                {
                    if (rack[i].isbn == searchISBN)
                    {

                        if (a2 == 1)
                        {
                            Console.WriteLine("Enter New Book Name");
                            string nn = Console.ReadLine();
                            rack[i].bookname = nn;
                        }
                        else if (a2 == 2)
                        {
                            Console.WriteLine("Enter New Year Published");
                            int nn = Convert.ToInt32(Console.ReadLine());
                            rack[i].price = nn;
                        }
                        else if (a2 == 3)
                        {
                            Console.WriteLine("Enter New Price");
                            decimal nn = Convert.ToDecimal(Console.ReadLine());
                            rack[i].price = nn;
                        }
                    }
                }
            }
        }
        static void Main(string[] args)
        {
            var book = new BookManagement();
            Console.WriteLine("\t\t\tBook Author Details\t\t\t");
            while (true)
            {
                Console.WriteLine("1. Add Book");
                Console.WriteLine("2. Search Book");
                Console.WriteLine("3. Update Book");
                Console.WriteLine("4. View All Books");
                Console.WriteLine("5. View All Authors");
                Console.WriteLine("6. Exit");

                int x = Convert.ToInt32(Console.ReadLine());

                if (x == 6)
                {
                    break;
                }
                else
                {
                    switch (x)
                    {
                        case 1:
                            book.AddBook();
                            break;
                        case 2:
                            book.SearchBook();
                            break;
                        case 3:
                            book.UpdateBook();
                            break;
                        case 4:
                            book.ViewBook();
                            break;
                        case 5:
                            book.ViewAuthor();
                            break;
                        default:
                            Console.WriteLine("Enter Correct Choice");
                            break;
                    }
                }
            }
        }
    }
}



    

    
    
        
