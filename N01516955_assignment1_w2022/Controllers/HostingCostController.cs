using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace N01516955_assignment1_w2022.Controllers
{
    public class HostingCostController : ApiController
    {
        public IEnumerable<string> Get(int id)
        {
            //Que:6


            /// <summary>
            /// Returns the three strings which describe the total hosting cost
            /// </summary>
            /// <param name="id">The input number</param>
            /// <returns>The three strings which describe the total hosting cost</returns>
            /// example:
            // Get api/HostingCost/0
            // Get api/HostingCost/14
            // Get api/HostingCost/15
            // Get api/HostingCost/21
            // Get api/HostingCost/28

            double fortnight = id / 14;
            int fortnight1=Convert.ToInt32( fortnight + 1);
            double chargeoffortnight = 5.50 * fortnight1;
            double HostTotal = fortnight1 * 0.72;
            double TotalHostingcost = chargeoffortnight + HostTotal;
            return new string[] { fortnight1 + "fortnight at t $5.50/FN =$" + chargeoffortnight + "CAD", "HST 13% = $" + HostTotal + "CAD", "Total = $" + TotalHostingcost + "CAD" };


        }
    }

}