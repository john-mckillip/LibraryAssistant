using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryModels
{
    class Book
    {
        private int id { get; set; }
        private string title { get; set;}
        private string author { get; set; }
        private string publisher { get; set; }
        private double isbnNum { get; set; }
        private bool isCheckedOut { get; set; }

        public Book(string t, string a, string p, double i)
        {
            title = t;
            author = a;
            publisher = p;
            isbnNum = i;
            isCheckedOut = false;

            // ToDo: Build a way to store master id so it is
            // always unique
        }
    }
}
