using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace LibraryModels
{
    [Serializable()]
    public class Cd : Media
    {
        private string performer;
        private string producer;
        private string publisher;
        private bool isCheckedOut;

        // Constructor
        public Cd(string t, string pf, string pd, string pb)
            : base(t)
        {
            this.Id = AssignId();
            this.Title = t;
            this.performer = pf;
            this.producer = pd;
            this.publisher = pb;
            this.isCheckedOut = false;
        }

        public Cd(int i, string t, string pf, string pd, string pb)
            : base(t)
        {
            this.Id = i;
            this.Title = t;
            this.performer = pf;
            this.producer = pd;
            this.publisher = pb;
            this.isCheckedOut = false;
        }

        public string Performer
        {
            get { return performer; }
            set { performer = value; }
        }

        public string Producer
        {
            get { return producer; }
            set { producer = value; }
        }

        public string Publisher
        {
            get { return publisher; }
            set { publisher = value; }
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
            return String.Format("Id: {0}, Title:{1}, Performer:{2}, Producer:{3}, Publisher:{4}, Checked Out:{3}", Id, Title, performer, producer, publisher, isCheckedOut);
        }

        // Deserialization method
        public Cd(SerializationInfo info, StreamingContext ctxt)
        {
            this.Id = (int)info.GetValue("CdId", typeof(int));
            this.Title = (string)info.GetValue("CdTitle", typeof(string));
            this.performer = (string)info.GetValue("Performer", typeof(string));
            this.producer = (string)info.GetValue("Producer", typeof(string));
            this.publisher = (string)info.GetValue("Publisher", typeof(string));
            this.isCheckedOut = (bool)info.GetValue("CheckedOut", typeof(bool));
        }

        // Serialization method http://tech.pro/tutorial/618/csharp-tutorial-serialize-objects-to-a-file
        public override void GetObjectData(SerializationInfo info, StreamingContext ctxt)
        {
            info.AddValue("CdId", this.Id);
            info.AddValue("CdTitle", this.Title);
            info.AddValue("Performer", this.performer);
            info.AddValue("Producer", this.producer);
            info.AddValue("Publisher", this.publisher);
            info.AddValue("CheckedOut", this.isCheckedOut);
        }
    }
}
