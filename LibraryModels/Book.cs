using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;


namespace LibraryModels
{
    [Serializable()]
    public class Book : ISerializable
    {
        private int id { get; set; }
        private string title { get; set;}
        private string author { get; set; }
        private string publisher { get; set; }
        private string isbnNum { get; set; }
        private bool isCheckedOut { get; set; }

        // Contstructor
        public Book(string t, string a, string p, string iNum)
        {
            this.title = t;
            this.author = a;
            this.publisher = p;
            this.isbnNum = iNum;
            this.isCheckedOut = false;

            // ToDo: Build a way to create/store master id so it is
            // always unique
        }
        // ToDo: Add a ToString() method

        // Deserialization method
        public Book(SerializationInfo info, StreamingContext ctxt)
        {
            this.id = (int)info.GetValue("BookId", typeof(int));
            this.title = (string)info.GetValue("BookTitle", typeof(string));
            this.author = (string)info.GetValue("BookAuthor", typeof(string));
            this.publisher = (string)info.GetValue("BookPublisher", typeof(string));
            this.isbnNum = (string)info.GetValue("ISBNNumber", typeof(string));
            this.isCheckedOut = (bool)info.GetValue("Checked", typeof(bool));
        }

        // Serialization method http://tech.pro/tutorial/618/csharp-tutorial-serialize-objects-to-a-file
        public void GetObjectData(SerializationInfo info, StreamingContext ctxt)
        {
            info.AddValue("BookId", this.id);
            info.AddValue("BookTitle", this.title);
            info.AddValue("BookAuthor", this.author);
            info.AddValue("BookPublisher", this.publisher);
            info.AddValue("ISBNNumber", this.isbnNum);
            info.AddValue("CheckedOut", this.isCheckedOut);
        }
    }
}
