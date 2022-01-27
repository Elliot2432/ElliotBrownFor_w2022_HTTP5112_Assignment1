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

        // I tried to do lots of stuff so I'm can't really explain everything because its would be paragraphs long. So short verison is I tried to use an if statement inside of a Controller


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


        public string Get1(int id)
        {
            //Variable that I'm trying to use for the Questions
            //int idsnumber = id;
            // Get double fornight;
            //double price;
            //double housesaletax;
            //double total;
            //string results;
            if(id >= 0 || id < 14)
            {

            }



        }
        

       private string Fornight1() 
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

       private string Fornight2()
       {
       double fornight = 2;
       double housesaletax = 1.43;
       double price = 5.50;
       price = price * fornight;
       double total = price + housesaletax;
       return fornight.ToString() + " fornights at $5.50/FN = $" + price.ToString() + " CAD" + " " +
       "HST 13% =$" + housesaletax.ToString() + " CAD" + " " +
       "Total=$" + total.ToString() + " CAD";
       }

       private string Fornight3()
       {
       double fornight = 3;
       double housesaletax = 2.14;
       double price = 5.50;
       price = price * fornight;
       double total = price + housesaletax;
       return fornight.ToString() + " fornights at $5.50/FN = $" + price.ToString() + " CAD" + " " +
       "HST 13% =$" + housesaletax.ToString() + " CAD" + " " +
       "Total=$" + total.ToString() + " CAD";
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




    }
