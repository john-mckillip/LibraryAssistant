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
    public class BookObjectToSerialize : ISerializable
    {
        private List<Book> books;

        public List<Book> Books
        {
            get { return this.books; }
            set { this.books = value; }
        }

        // Zero argument constructor
        public BookObjectToSerialize()
        {
        }

        public BookObjectToSerialize(SerializationInfo info, StreamingContext ctxt)
        {
            this.books = (List<Book>)info.GetValue("Books", typeof(List<Book>));
        }

        public void GetObjectData(SerializationInfo info, StreamingContext ctxt)
        {
            info.AddValue("Books", this.books);
        }
    }
}
