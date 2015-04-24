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
                    bk[2] = itemAsBook.Author;
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

            return books;
        }

        public static List<Media> UpdateBook(int i, string t, string a, string p, string isb, List<Media> m) 
        {

            int id = i;
            int counter = 0;

            try
            {
                Book updatedBook = new Book(i,t, a, p, isb);
                List<Media> media = new List<Media>();
                media = m;

                foreach (Media b in media)
                {
                    if (b.Id == i)
                    {
                        media.RemoveAt(counter);
                        media.Insert(counter, updatedBook);
                        break;
                    }
                    counter++;
                }

                return media;
            }

            catch
            {
                return m;
            } 
        }
    }
}
