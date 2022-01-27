using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebApplication1.Controllers
{
    public class GreetingController : ApiController
    {
        //GET api/greeting


        //GET localhost/Greeting/3 --> Greetings to 3 People
        //GET localhost/Greeting/6 --> Greetings to 6 People
        //GET localhost/Greeting/0 --> Greetings to 0 People





        /// <summary>
        /// This will return the string with the id input in the middle
        /// </summary>
        /// <param name="id">id number</param>
        /// <returns>Returns the id number with the string</returns>
        /// GET localhost/Greeting/3 --> Greetings to 3 People
        /// GET localhost/Greeting/6 --> Greetings to 6 People
        /// GET localhost/Greeting/0 --> Greetings to 0 People
        public string Get(int id)
        {
            return "Greetings to " + id + " people!";
        }







        //POST api/greeting

        //POST api/greeting --> Hello World
        //This will get the String and Post it inside of your Command prompt
        /// <summary>
        /// This will get the String and Post it inside of your Command prompt
        /// </summary>
        /// <returns>It will return "Hello World"</returns>
        /// Example: POST api/greeting --> Hello World 
        public string Post()
        {   
            //This is a string that contains "Hello World" in it
            string returningstring = "Hello World!";
            //This returns the result of returningstring
            return returningstring;
        }

    }
}
