using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace LibraryModels
{
    [Serializable()]
    public class ObjectToSerialize : ISerializable
    {
        private List<Media> media;

        public List<Media> Media
        {
            get { return this.media; }
            set { this.media = value; }
        }

        // Zero argument constructor
        public ObjectToSerialize()
        {
        }

        public ObjectToSerialize(SerializationInfo info, StreamingContext ctxt)
        {
            this.media = (List<Media>)info.GetValue("Books", typeof(List<Media>));
        }

        public void GetObjectData(SerializationInfo info, StreamingContext ctxt)
        {
            info.AddValue("Books", this.media);
        }
    }
}
