using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryModels
{
    [Serializable]
    public class Book
    {
        private int id { get; set; }
        private string title { get; set;}
        private string author { get; set; }
        private string publisher { get; set; }
        private string isbnNum { get; set; }
        private bool isCheckedOut { get; set; }

        // Contstructor
        public Book(string t, string a, string p, string iNum)
        {
            title = t;
            author = a;
            publisher = p;
            isbnNum = iNum;
            isCheckedOut = false;

            // ToDo: Build a way to create/store master id so it is
            // always unique
        }
    }
}
