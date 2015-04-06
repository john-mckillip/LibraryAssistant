using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace LibraryModels
{
    [Serializable()]
    public abstract class Media : ISerializable
    {
        //private int id;
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
        public abstract void GetObjectData(SerializationInfo info, StreamingContext ctxt);

    }
}
