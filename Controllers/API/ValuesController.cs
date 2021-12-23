using autotication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace autotication.Controllers.API
{
    public class ValuesController : ApiController
    {
        
        List<Book> listofbooks = new List<Book>();
        void books()
        {
            Random random = new Random();

            Book[] arrayofbooks = new Book[]
               {
                new Book("BookOne", "WritterOne", 2010, random.Next(100, 500),0),
                new Book("BookTwo", "WritterTwo", 2000, random.Next(100, 500),1),
                new Book("BookThree", "WritterThree", 2003, random.Next(100, 500),2),
                new Book("BookFour", "WritterFour", 2004, random.Next(100, 500),3),
                new Book("BookFive", "WritterFive", 2005, random.Next(100, 500),4),
                new Book("BookSix", "WritterSix", 2006, random.Next(100, 500),5),
                new Book("BookSeven", "WritterSeven", 2007, random.Next(100, 500),6),
                new Book("BookEigth", "WritterEigth", 2008, random.Next(100, 500),7)
               };

            listofbooks.AddRange(arrayofbooks);

        }


        // GET: api/Values
        public IHttpActionResult Get()
        {
            books();
            return Ok(listofbooks);
        }

        // GET: api/Values/5
        public IHttpActionResult Get(int id)
        {
            books();
            Book samebook = listofbooks.Find(item => item.id == id);
            return Ok(samebook);
        }

        //POST: api/Values
        public IHttpActionResult Post([FromBody] Book value)
        {
            List<Book> newBook = new List<Book>();
            newBook.Add(value);


            return Ok(newBook);

        }

        // PUT: api/Values/5
        public IHttpActionResult Put(int id, [FromBody] Book value)
        {
            books();
             Book samebook = listofbooks.Find(item => item.id == id);
            listofbooks[listofbooks.IndexOf(samebook)].name = value.name;
            listofbooks[listofbooks.IndexOf(samebook)].author = value.author;
            listofbooks[listofbooks.IndexOf(samebook)].year = value.year;
            listofbooks[listofbooks.IndexOf(samebook)].numOfPages = value.numOfPages;
     


            listofbooks.Add(samebook);

            return Ok(listofbooks);
        }

        // DELETE: api/Values/5
        public IHttpActionResult Delete(int id)
        {
            books();
            Book samebook = listofbooks.Find(item => item.id == id);
            listofbooks.Remove(samebook);
            return Ok(listofbooks);



        }
    }
}
