using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebApplication1.Controllers
{
    public class NumberMachineController : ApiController
    {
        //GET api/numbermachine

        ///GET api/numbermachine/10 --> 100
        ///GET api/numbermachine/-5 --> 25
        ///GET api/numbermachine/30 --> 900

        //<summary> Id is the input the user puts in so when the users put in his input, it does all of these operations before returning result/id </summary>

        /// <summary>
        /// Id is the input the user puts in so when the users put in his input, it does all of these operations before returning result/id.
        /// // It adds then multiples, then subtract, and then divdes it
        /// </summary>
        /// <param name="id">The id number</param>
        /// <returns>The Input with </returns>
        public int Get(int id)
        {
            // It adds then multiples, then subtract, and then divdes it
            return id + id * id - id / id;
        }
    }
}
