using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebApplication1.Controllers
{
    public class HostingCostController : ApiController
    {



        /*public IEnumerable<string> Values(HostingCostController.Get)
        {

            if (id >= 0 || id <= 13)// if id is less than 14 or is greater than/equal to 0 
            {

                return Fornight1();

            }
            else if (id >= 14 || id < 28)
            {
                return Fornight2();
            }
            else if (id >= 28 || id < 42)
            {
                return Fornight3();
            }
            return new string[] { "value1", "value2" };
        }*/
        //GET api/hostingcost
        /// <summary>
        /// It adds up all of the values to get the individual answers so it can input into the string output
        /// </summary>
        /// <param name="id">The user number input</param>
        /// <returns>It returns 3 strings of different numbers calculated in the method below</returns>
        /// Example : id = 1  
        ///--> 1 fornights at $5.50/FN = $5.50
        ///HST 13% = $0.72 CAD
        ///Total = $6.22 CAD
        public IEnumerable<string> Get(int id)
        {

            double fornightsnotrounded = id / 14 + 1;

            double fornight = Math.Floor(fornightsnotrounded);

            double price = fornight * 5.50;

            string priceformatted = string.Format("{0:c}", price);

            double saletax = price * 0.13;


            //double saletax = Math.Round(saletaxnotrounded);

            string saletaxformatted = string.Format("{0:c}", saletax);

            double total = price + saletax;

            string totalformatted = string.Format("{0:c}", total);
            // return fornight.ToString() + " fornights at $5.50/FN = $" + price.ToString() + " CAD" + " " +
            //  "HST 13% =$" + saletax.ToString() + " CAD" + " " +
            //"Total=$" + total.ToString() + " CAD";

            string firstline = fornight.ToString() + " fornights at $5.50/FN = " + priceformatted + " CAD";

            string secondline = "HST 13% = " + saletaxformatted + " CAD";

            string thirdline = "Total = " + totalformatted + " CAD";

            return new string[] { firstline, secondline, thirdline };
        }


        /*public int Get(int id)
        {
            //Variable that I'm trying to use for the Questions
            //int idsnumber = id;
            // Get double fornight;
            //double price;
            //double housesaletax;
            //double total;
            //string results;
            return id;
             
            double fornightsnotrounded = id / 14 + 1;

            double fornight = Math.Floor(fornightsnotrounded);

            double price = fornight * 5.50;

            double saletax = price * 0.13;

            double total = price + saletax;
            return fornight.ToString() + " fornights at $5.50/FN = $" + price.ToString() + " CAD" + " " +
               "HST 13% =$" + saletax.ToString() + " CAD" + " " +
               "Total=$" + total.ToString() + " CAD";*/

            /*while(id >= 0 || id < 14)
                {
                    double fornight = 1;
                    double housesaletax = 0.72;
                    double price = 5.50;
                    price = price * fornight;
                    double total = price + housesaletax;
                    return fornight.ToString() + " fornights at $5.50/FN = $" + price.ToString() + " CAD" + " " +
                   "HST 13% =$" + housesaletax.ToString() + " CAD" + " " +
                   "Total=$" + total.ToString() + " CAD";

                }

            while(id >= 14 || id < 28)
                {
                    double fornight = 2;
                    double housesaletax = 1.43;
                    double price = 5.50;
                    price = price * fornight;
                    double total = price + housesaletax;
                    return fornight.ToString() + " fornights at $5.50/FN = $" + price.ToString() + " CAD" + " " +
                    "HST 13% =$" + housesaletax.ToString() + " CAD" + " " +
                    "Total=$" + total.ToString() + " CAD";
                }*/


        }
        



       /*if (idsnumber >= 0 || idsnumber <= 13)// if id is less than 14 or is greater than/equal to 0 
       {
           fornight = 1;// fornight will equals 1
           housesaletax = 0.72; // house
       }
       else if (idsnumber >= 14 || idsnumber < 28)
       {
           fornight = 2;
           housesaletax = 1.43;
       }
       else if (idsnumber >= 28 || idsnumber < 42)
       {
           fornight = 3;
           housesaletax = 2.14;
       }
       price = 5.50;
       price = price * fornight;
       total = price + housesaletax;
       return fornight.ToString() + " fornights at $5.50/FN = $" + price.ToString() + " CAD" + " " +
       "HST 13% =$" + housesaletax.ToString() + " CAD" + " " +
       "Total=$" + total.ToString() + " CAD";*/



        }




    
