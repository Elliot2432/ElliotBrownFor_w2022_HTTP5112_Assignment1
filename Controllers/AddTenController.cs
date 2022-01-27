using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebApplication1.Controllers
{
    public class AddTenController : ApiController
    {
        //GET api/AddTen/21 --> 31
        //GET api/AddTen/0  --> 10
        //GET api/AddTen/-9 --> 1

        //This Will Add Ten to The Id
        /// <summary>
        /// This will get the user input, add ten to it, and then return it. 
        /// </summary>
        /// <param name="id">The User input</param>
        /// <returns>The user input but with a +10 to it</returns>
        ///GET api/AddTen/21 --> 31
        ///GET api/AddTen/0  --> 10
        ///GET api/AddTen/-9 --> 1

        public int Get(int id)
        {
            //This adds on ten to the id
            int plusnumber = id + 10;
            //This returns the result of plusnumber
            return plusnumber;
        }
    }
}
