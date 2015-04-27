﻿using System;
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
            List<Media> mediaFromFile = mediaItems;

            foreach (Media b in mediaFromFile)
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

        public static List<Media> GetMediaList()
        {
            ObjectSerializer serializer = new ObjectSerializer();
            ObjectToSerialize serializedMedia = new ObjectToSerialize();
            serializedMedia = serializer.DeSerializeObject("media.txt");

            List<Media> mediaFromFile = new List<Media>();
            mediaFromFile = serializedMedia.Media;

            return mediaFromFile;
        }

        public static void SaveMedia(List<Media> mediaList)
        {
            List<Media> newMediaList = mediaList;
            
            ObjectSerializer serializer = new ObjectSerializer();
            ObjectToSerialize newSerializedMedia = new ObjectToSerialize();
            newSerializedMedia.Media = newMediaList;
            serializer.SerializeObject("media.txt", newSerializedMedia);
        }

        public static bool AddBookToNewList(Book b)
        {
            bool success = false;
            List<Media> mediaNew = new List<Media>();
            mediaNew.Add(b);

            ObjectSerializer serializer = new ObjectSerializer();
            ObjectToSerialize serializeMedia = new ObjectToSerialize();
            serializeMedia.Media = mediaNew;
            serializer.SerializeObject("media.txt", serializeMedia);
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
