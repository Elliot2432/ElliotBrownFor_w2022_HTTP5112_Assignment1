using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebApplication1.Controllers
{
    public class SquareController : ApiController
    {


        /// <summary>
        /// This Will Square Root The Id
        /// </summary>
        /// <param name="id"> id number</param>
        /// <returns>It returns the id number squared</returns>
        /// Example: GET api/square/2 --> 4
        /// Example: GET api/square/-2 --> 4
        /// Example: GET api/square/10 --> 100
        public int Get(int id)
        {
            //This gets the id and multiples it by itself
            int squarednumber = id * id;
            //This returns the results of squarednumber
            return squarednumber;
        }
    }
}
