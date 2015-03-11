using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LibraryModels;

namespace LibraryViews.Controllers
{
    public class BooksController
    {
        public static ListView PopulateMainBooksViewList(ListView l)
        {
            List<Book> booksFromFile = new List<Book>();

            BookSerializer serializer = new BookSerializer();
            BookObjectToSerialize serializedBooks = new BookObjectToSerialize();
            serializedBooks = serializer.DeSerializeObject("books.txt");
            booksFromFile = serializedBooks.Books;

            foreach (Book b in booksFromFile)
            {
                ListViewItem itm;
                string[] bk = new String[4];

                bk[0] = b.GetId().ToString();
                bk[1] = b.GetTitle();
                bk[2] = b.GetAuthor();
                // Is it in stock?
                if (b.IsCheckedOut())
                {
                    bk[3] = "Out of Stock";
                }
                else
                {
                    bk[3] = "In Stock";
                }
                itm = new ListViewItem(bk);
                l.Items.Add(itm);
            }
            return l;
        }

        public static ListView PopulateCheckInBooksViewList(ListView l)
        {
            List<Book> booksFromFile = new List<Book>();

            BookSerializer serializer = new BookSerializer();
            BookObjectToSerialize serializedBooks = new BookObjectToSerialize();
            serializedBooks = serializer.DeSerializeObject("books.txt");
            booksFromFile = serializedBooks.Books;

            foreach (Book b in booksFromFile)
            {
                if (b.IsCheckedOut())
                {
                    ListViewItem itm;
                    string[] bk = new String[4];

                    bk[0] = b.GetId().ToString();
                    bk[1] = b.GetTitle();
                    bk[2] = b.GetAuthor();
                    bk[3] = "Out of Stock";

                    itm = new ListViewItem(bk);
                    l.Items.Add(itm);
                }               
            }
            return l;
        }

        public static List<Book> getBooksList()
        {
            BookSerializer serializer = new BookSerializer();
            BookObjectToSerialize serializedBooks = new BookObjectToSerialize();
            serializedBooks = serializer.DeSerializeObject("books.txt");

            List<Book> booksFromFile = new List<Book>();
            booksFromFile = serializedBooks.Books;

            return booksFromFile;
        }

        public static bool AddBookToExistingList(Book b) 
        {
            bool success = false;
            BookSerializer serializer = new BookSerializer();
            BookObjectToSerialize serializedBooks = new BookObjectToSerialize();
            serializedBooks = serializer.DeSerializeObject("books.txt");

            List<Book> booksFromFile = new List<Book>();
            booksFromFile = serializedBooks.Books;
            booksFromFile.Add(b);

            BookObjectToSerialize newSerializedBooks = new BookObjectToSerialize();
            newSerializedBooks.Books = booksFromFile;
            serializer.SerializeObject("books.txt", newSerializedBooks);
            success = true;

            return success;  
        }

        public static bool AddBookToNewList(Book b)
        {
            bool success = false;
            List<Book> booksNew = new List<Book>();
            booksNew.Add(b);

            BookSerializer serializer = new BookSerializer();
            BookObjectToSerialize serializeBook = new BookObjectToSerialize();
            serializeBook.Books = booksNew;
            serializer.SerializeObject("books.txt", serializeBook);
            success = true;

            return success;
        }

        public static Book GetBook(int id)
        {
            List<Book> booksFromFile = new List<Book>();
            int index = 0;

            BookSerializer serializer = new BookSerializer();
            BookObjectToSerialize serializedBooks = new BookObjectToSerialize();
            serializedBooks = serializer.DeSerializeObject("books.txt");
            booksFromFile = serializedBooks.Books;

            foreach (Book b in booksFromFile)
            {
                if (b.GetId() == id)
                {
                    break;
                }
                index++;
            }
            return booksFromFile[index];
        }

        public static bool DeleteBook(int i)
        {
            bool success = false;
            int id = i;
            int counter = 0;

            List<Book> books = new List<Book>();
            books = getBooksList();

            foreach (Book b in books)
            {
                if (b.GetId() == i)
                {
                    books.RemoveAt(counter);
                    break;
                }
                counter++;
            }

            BookSerializer serializer = new BookSerializer();
            BookObjectToSerialize newSerializedBooks = new BookObjectToSerialize();
            newSerializedBooks.Books = books;
            serializer.SerializeObject("books.txt", newSerializedBooks);
            success = true;

            return success;
        }

        public static bool UpdateBook(int i, string t, string a, string p, string isb) {

            bool success = false;
            int id = i;
            int counter = 0;

            try
            {
                Book updatedBook = new Book(i,t, a, p, isb);
                List<Book> books = new List<Book>();
                books = getBooksList();

                foreach (Book b in books)
                {
                    if (b.GetId() == i)
                    {
                        books.RemoveAt(counter);
                        books.Insert(counter, updatedBook);
                        break;
                    }
                    counter++;
                }

                BookSerializer serializer = new BookSerializer();
                BookObjectToSerialize newSerializedBooks = new BookObjectToSerialize();
                newSerializedBooks.Books = books;
                serializer.SerializeObject("books.txt", newSerializedBooks);
                success = true;

                return success;
            }

            catch
            {
                success = false;
                return success;
            } 
        }

        public static bool CheckoutBook(int i)
        {
            bool success = false;
            int counter = 0;

            try
            {
                Book book = GetBook(i);
                if (!book.IsCheckedOut())
                {
                    book.CheckOut();

                    List<Book> books = new List<Book>();
                    books = getBooksList();

                    foreach (Book b in books)
                    {
                        if (b.GetId() == i)
                        {
                            books.RemoveAt(counter);
                            books.Insert(counter, book);
                            break;
                        }
                        counter++;
                    }

                    BookSerializer serializer = new BookSerializer();
                    BookObjectToSerialize newSerializedBooks = new BookObjectToSerialize();
                    newSerializedBooks.Books = books;
                    serializer.SerializeObject("books.txt", newSerializedBooks);
                    success = true;
                }

                return success;
            }
            catch
            {
                success = false;
                return success;
            }   
        }

        public static bool CheckInBook(int i)
        {
            bool success = false;
            int counter = 0;

            try
            {
                Book book = GetBook(i);
                if (book.IsCheckedOut())
                {
                    book.CheckIn();

                    List<Book> books = new List<Book>();
                    books = getBooksList();

                    foreach (Book b in books)
                    {
                        if (b.GetId() == i)
                        {
                            books.RemoveAt(counter);
                            books.Insert(counter, book);
                            break;
                        }
                        counter++;
                    }

                    BookSerializer serializer = new BookSerializer();
                    BookObjectToSerialize newSerializedBooks = new BookObjectToSerialize();
                    newSerializedBooks.Books = books;
                    serializer.SerializeObject("books.txt", newSerializedBooks);
                    success = true;
                }

                return success;
            }
            catch
            {
                success = false;
                return success;
            }
        }
    }
}
