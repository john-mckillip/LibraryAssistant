using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace LibraryModels
{
    [Serializable()]
    public abstract class Media : ISerializable
    {
        private int id;
        private string title;

        public Media()
        {

        }
        
        public Media(string t)
        {
            this.title = t;
        }

        public string Title
        {
            get { return title; }
            set { title = value; }
        }

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public int AssignId()
        {
            StreamReader sr = new StreamReader("book-id.txt");
            string line = sr.ReadLine();
            sr.Close();
            int iNum = Convert.ToInt32(line) + 1;
            System.IO.File.WriteAllText("book-id.txt", iNum.ToString());
            return iNum;
        }
        
        public abstract void GetObjectData(SerializationInfo info, StreamingContext ctxt);

    }
}
