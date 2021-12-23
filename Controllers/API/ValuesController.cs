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
                new Book("BookOne", "WritterOne", 2010, random.Next(100, 500)),
                new Book("BookTwo", "WritterTwo", 2000, random.Next(100, 500)),
                new Book("BookThree", "WritterThree", 2003, random.Next(100, 500)),
                new Book("BookFour", "WritterFour", 2004, random.Next(100, 500)),
                new Book("BookFive", "WritterFive", 2005, random.Next(100, 500)),
                new Book("BookSix", "WritterSix", 2006, random.Next(100, 500)),
                new Book("BookSeven", "WritterSeven", 2007, random.Next(100, 500)),
                new Book("BookEigth", "WritterEigth", 2008, random.Next(100, 500))
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
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Values/5
        public void Delete(int id)
        {

        }
    }
}
