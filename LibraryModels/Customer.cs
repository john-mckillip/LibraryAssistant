﻿using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace LibraryModels
{
    [Serializable()]
    public class Customer : ISerializable
    {
        private int accountNumber { get; set; }
        private string firstName { get; set; }
        private string lastName { get; set; }
        private string phoneNumber { get; set; }
        private string emailAddress { get; set; }
        private bool hasFines { get; set; }
        private decimal fines { get; set; }

        private int GetAccountNumber()
        {
            StreamReader sr = new StreamReader("account-num.txt");
            string line = sr.ReadLine();
            sr.Close();
            int aNum = Convert.ToInt32(line) + 1;
            System.IO.File.WriteAllText("account-num.txt", aNum.ToString());
            return aNum;
        }
        
        // Constructor
        public Customer(string fName, string lName, string pNum, string eAddy)
        {
            this.accountNumber = GetAccountNumber();
            this.firstName = fName;
            this.lastName = lName;
            this.phoneNumber = pNum;
            this.emailAddress = eAddy;
            this.hasFines = false; // New customer can't have fines
            this.fines = 0.00m; // So the total when created is 0
        }

        // Add a fine to a customer object
        public void AddFine(decimal fine) 
        {
            this.fines += fine;
        }

        public override string ToString()
        {
            return String.Format("Account Number: {0}, Name:{1}, Phone:{2}, Email:{3}, Fines:{4}", accountNumber, firstName + " " + lastName, phoneNumber, emailAddress, "$" + fines);
        }

        // Deserialization method
        public Customer(SerializationInfo info, StreamingContext ctxt)
        {
            this.accountNumber = (int)info.GetValue("AccountNumber", typeof(int));
            this.firstName = (string)info.GetValue("FirstName", typeof(string));
            this.firstName = (string)info.GetValue("FirstName", typeof(string));
            this.lastName = (string)info.GetValue("LastName", typeof(string));
            this.phoneNumber = (string)info.GetValue("PhoneNumber", typeof(string));
            this.emailAddress = (string)info.GetValue("EmailAddress", typeof(string));
            this.hasFines = (bool)info.GetValue("HasFines", typeof(bool));
            this.fines = (decimal)info.GetValue("TotalFines", typeof(decimal));
        }

        // Serialization method http://tech.pro/tutorial/618/csharp-tutorial-serialize-objects-to-a-file
        public void GetObjectData(SerializationInfo info, StreamingContext ctxt)
        {
            info.AddValue("AccountNumber", this.accountNumber);
            info.AddValue("FirstName", this.firstName);
            info.AddValue("LastName", this.lastName);
            info.AddValue("PhoneNumber", this.phoneNumber);
            info.AddValue("EmailAddress", this.emailAddress);
            info.AddValue("HasFines", this.hasFines); 
            info.AddValue("TotalFines", this.fines);
        }
    }
}
