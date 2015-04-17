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

        public int GetId()
        {
            return this.Id;
        }

        public void SetId(int i)
        {
            this.Id = i;
        }

        public string GetTitle()
        {
            return this.Title;
        }

        public void SetTitle(string t)
        {
            this.Title = t;
        }

        public string GetDirector()
        {
            return this.director;
        }

        public void SetDirector(string d)
        {
            this.director = d;
        }

        public string GetProducer()
        {
            return this.producer;
        }

        public void SetProducer(string p)
        {
            this.producer = p;
        }

        public string GetStar()
        {
            return this.star;
        }

        public void SetStar(string s)
        {
            this.star = s;
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
