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
        public static ListView PopulateMainBooksViewList(ListView l, List<Media> mediaItems)
        {
            List<Media> booksFromFile = mediaItems;

            foreach (Media b in booksFromFile)
            {
                if (b is Book)
                {
                    Book itemAsBook = (Book)b;
                    ListViewItem itm;
                    string[] bk = new String[4];

                    bk[0] = itemAsBook.Id.ToString();
                    bk[1] = itemAsBook.Title;
                    bk[2] = itemAsBook.GetAuthor();
                    // Is it in stock?
                    if (itemAsBook.IsCheckedOut())
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

                    bk[0] = b.Id.ToString();
                    bk[1] = b.Title;
                    bk[2] = b.GetAuthor();
                    bk[3] = "Out of Stock";

                    itm = new ListViewItem(bk);
                    l.Items.Add(itm);
                }               
            }
            return l;
        }

        public static List<Book> GetBooksList()
        {
            BookSerializer serializer = new BookSerializer();
            BookObjectToSerialize serializedBooks = new BookObjectToSerialize();
            serializedBooks = serializer.DeSerializeObject("books.txt");

            List<Book> booksFromFile = new List<Book>();
            booksFromFile = serializedBooks.Books;

            return booksFromFile;
        }

        public static void SaveBooks(List<Media> mediaList)
        {
            List<Book> newBooksList = new List<Book>();
            foreach (Media item in mediaList)
            {
                if (item is Book)
                {
                    newBooksList.Add((Book)item);
                }
            }
            BookSerializer serializer = new BookSerializer();
            BookObjectToSerialize newSerializedBooks = new BookObjectToSerialize();
            newSerializedBooks.Books = newBooksList;
            serializer.SerializeObject("books.txt", newSerializedBooks);
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
                if (b.Id == id)
                {
                    break;
                }
                index++;
            }
            return booksFromFile[index];
        }

        public static List<Media> DeleteBook(int i, List<Media> books)
        {
            //bool success = false;
            int id = i;
            int counter = 0;

            foreach (Media b in books)
            {
                if (b.Id == i)
                {
                    books.RemoveAt(counter);
                    break;
                }
                counter++;
            }

            //success = true;

            return books;
        }

        public static bool UpdateBook(int i, string t, string a, string p, string isb) {

            bool success = false;
            int id = i;
            int counter = 0;

            try
            {
                Book updatedBook = new Book(i,t, a, p, isb);
                List<Book> books = new List<Book>();
                books = GetBooksList();

                foreach (Book b in books)
                {
                    if (b.Id == i)
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
                    books = GetBooksList();

                    foreach (Book b in books)
                    {
                        if (b.Id == i)
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
                    books = GetBooksList();

                    foreach (Book b in books)
                    {
                        if (b.Id == i)
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
