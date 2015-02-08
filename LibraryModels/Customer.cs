using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryModels
{
    [Serializable]
    public class Customer
    {
        private int accountNumber { get; set; }
        private string firstName { get; set; }
        private string lastName { get; set; }
        private string phoneNumber { get; set; }
        private string emailAddres { get; set; }
        private double fines { get; set; }
        private bool hasFines { get; set; }

        // Constructor
        public Customer(string fName, string lName, string pNum, string eAddy)
        {
            firstName = fName;
            lastName = lName;
            phoneNumber = pNum;
            emailAddres = eAddy;
            hasFines = false;
        }
    }
}
