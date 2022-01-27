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
        //GET api/square/2
        //GET api/square/-2
        //GET api/square/10

        //This Will Square Root The Id
        public int Get(int id)
        {
            //This gets the id and multiples it by itself
            int squarednumber = id * id;
            //This returns the results of squarednumber
            return squarednumber;
        }
    }
}
