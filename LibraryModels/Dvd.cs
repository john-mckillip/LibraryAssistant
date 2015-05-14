using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace LibraryModels
{
    [Serializable()]
    public class Dvd : Media
    {
        private string director;
        private string producer;
        private string star;
        private bool isCheckedOut;

        //Constructor
        public Dvd(string t, string d, string p, string s)
            : base(t)
        {
            this.Id = AssignId();
            this.Title = t;
            this.director = d;
            this.producer = p;
            this.star = t;
            this.isCheckedOut = false;
        }

        public Dvd(int i, string t, string d, string p, string s)
            : base(t)
        {
            this.Id = i;
            this.Title = t;
            this.director = d;
            this.producer = p;
            this.star = t;
            this.isCheckedOut = false;
        }

        public string Director
        {
            get { return director; }
            set { director = value; }
        }

        public string Producer
        {
            get { return producer; }
            set { producer = value; }
        }

        public string Star
        {
            get { return star; }
            set { star = value; }
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
            return String.Format("Id: {0}, Title:{1}, Director:{2}, Producer:{3}, Star:{4}, Checked Out:{3}", Id, Title, director, producer, star, isCheckedOut);
        }

         // Deserialization method
        public Dvd(SerializationInfo info, StreamingContext ctxt)
        {
            this.Id = (int)info.GetValue("DvdId", typeof(int));
            this.Title = (string)info.GetValue("DvdTitle", typeof(string));
            this.director = (string)info.GetValue("Director", typeof(string));
            this.producer = (string)info.GetValue("Producer", typeof(string));
            this.star = (string)info.GetValue("Star", typeof(string));
            this.isCheckedOut = (bool)info.GetValue("CheckedOut", typeof(bool));
        }

        // Serialization method http://tech.pro/tutorial/618/csharp-tutorial-serialize-objects-to-a-file
        public override void GetObjectData(SerializationInfo info, StreamingContext ctxt)
        {
            info.AddValue("DvdId", this.Id);
            info.AddValue("DvdTitle", this.Title);
            info.AddValue("Director", this.director);
            info.AddValue("Producer", this.producer);
            info.AddValue("Star", this.star);
            info.AddValue("CheckedOut", this.isCheckedOut);
        }
    }
}
