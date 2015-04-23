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
    public class Book : Media
    {       
        private string author;
        private string publisher;
        private string isbnNum;
        private bool isCheckedOut;

        // Contstructor
        public Book(string t, string a, string p, string iNum)
            : base(t)
        {
            this.Id = AssignId();       
            this.author = a;
            this.publisher = p;
            this.isbnNum = iNum;
            this.isCheckedOut = false;
        }

        public Book(int i, string t, string a, string p, string iNum)
            : base(t)
        {
            this.Id = i;
            this.Title = t;
            this.author = a;
            this.publisher = p;
            this.isbnNum = iNum;
            this.isCheckedOut = false;
        }

        public string Author
        {
            get { return author; }
            set { author = value; }
        }

        public string Publisher
        {
            get { return publisher; }
            set { publisher = value; }
        }

        public string ISBN
        {
            get { return isbnNum; }
            set { isbnNum = value; }
        }

        public void CheckOut()
        {
            this.isCheckedOut = true;
        }

        public void CheckIn()
        {
            this.isCheckedOut = false;
        }

        public bool IsCheckedOut()
        {
            return this.isCheckedOut;
        }

        public override string ToString()
        {
            return String.Format("Id: {0}, Title:{1}, Author:{2}, Publisher:{3}, ISBN:{4}, Checked Out:{3}", Id, Title, author, publisher, isbnNum, isCheckedOut);
        }

        // Deserialization method
        public Book(SerializationInfo info, StreamingContext ctxt)
        {
            this.Id = (int)info.GetValue("BookId", typeof(int));
            this.Title = (string)info.GetValue("BookTitle", typeof(string));
            this.author = (string)info.GetValue("BookAuthor", typeof(string));
            this.publisher = (string)info.GetValue("BookPublisher", typeof(string));
            this.isbnNum = (string)info.GetValue("ISBNNumber", typeof(string));
            this.isCheckedOut = (bool)info.GetValue("CheckedOut", typeof(bool));
        }

        // Serialization method http://tech.pro/tutorial/618/csharp-tutorial-serialize-objects-to-a-file
        public override void GetObjectData(SerializationInfo info, StreamingContext ctxt)
        {
            info.AddValue("BookId", this.Id);
            info.AddValue("BookTitle", this.Title);
            info.AddValue("BookAuthor", this.author);
            info.AddValue("BookPublisher", this.publisher);
            info.AddValue("ISBNNumber", this.isbnNum);
            info.AddValue("CheckedOut", this.isCheckedOut);
        }
    }
}
