using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace autotication.Models
{
    public class Book
    {
        public string name;
        public string author;
        public int year;
        public int numOfPages;
        public int id;
        public int counter = 0;

        public Book(string name, string author, int year, int numOfPages)
        {
            this.name = name;
            this.author = author;
            this.year = year;
            this.numOfPages = numOfPages;
            this.id = counter++;

        }
    }
}