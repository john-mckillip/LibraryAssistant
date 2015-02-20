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
    public class CustomerObjectToSerialize : ISerializable
    {
        private List<Customer> customers;

        public List<Customer> Customers
        {
            get { return this.customers; }
            set { this.customers = value; }
        }

        // Zero argument constructor
        public CustomerObjectToSerialize()
        {
        }

        public CustomerObjectToSerialize(SerializationInfo info, StreamingContext ctxt)
        {
            this.customers = (List<Customer>)info.GetValue("Customers", typeof(List<Customer>));
        }

        public void GetObjectData(SerializationInfo info, StreamingContext ctxt)
        {
            info.AddValue("Customers", this.customers);
        }
    }
}
