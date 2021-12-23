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
        

        public Book(string name, string author, int year, int numOfPages,int id)
        {
            this.name = name;
            this.author = author;
            this.year = year;
            this.numOfPages = numOfPages;
            this.id = id;

        }
    }
}