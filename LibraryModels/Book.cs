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
        private int id;
        private string title;
        private string author;
        private string publisher;
        private string isbnNum;
        private bool isCheckedOut;
        private int checkedOutBy; //ToDo: method to assign this value

        private int AssignId()
        {
            StreamReader sr = new StreamReader("book-id.txt");
            string line = sr.ReadLine();
            sr.Close();
            int iNum = Convert.ToInt32(line) + 1;
            System.IO.File.WriteAllText("book-id.txt", iNum.ToString());
            return iNum;
        }

        // Contstructor
        public Book(string t, string a, string p, string iNum)
        {
            this.id = AssignId();
            this.title = t;
            this.author = a;
            this.publisher = p;
            this.isbnNum = iNum;
            this.isCheckedOut = false;
        }

        public Book(int i, string t, string a, string p, string iNum)
        {
            this.id = i;
            this.title = t;
            this.author = a;
            this.publisher = p;
            this.isbnNum = iNum;
            this.isCheckedOut = false;
        }

        public int GetId()
        {
            return this.id;
        }

        public void SetId(int i)
        {
            this.id = i;
        }

        public string GetTitle()
        {
            return this.title;
        }

        public void SetTitle(string t)
        {
            this.title = t;
        }

        public string GetAuthor()
        {
            return this.author;
        }

        public void SetAuthor(string a)
        {
            this.author = a;
        }

        public string GetPublisher()
        {
            return this.publisher;
        }

        public void SetPublisher(string p)
        {
            this.publisher = p;
        }

        public string GetIsbn()
        {
            return this.isbnNum;
        }

        public void SetIsbn(string i)
        {
            this.isbnNum = i;
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
            return String.Format("Id: {0}, Title:{1}, Author:{2}, Publisher:{3}, ISBN:{4}, Checked Out:{3}", id, title, author, publisher, isbnNum, isCheckedOut);
        }

        // Deserialization method
        public Book(SerializationInfo info, StreamingContext ctxt)
        {
            this.id = (int)info.GetValue("BookId", typeof(int));
            this.title = (string)info.GetValue("BookTitle", typeof(string));
            this.author = (string)info.GetValue("BookAuthor", typeof(string));
            this.publisher = (string)info.GetValue("BookPublisher", typeof(string));
            this.isbnNum = (string)info.GetValue("ISBNNumber", typeof(string));
            this.isCheckedOut = (bool)info.GetValue("CheckedOut", typeof(bool));
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
