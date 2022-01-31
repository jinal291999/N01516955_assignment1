using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace N01516955_assignment1_w2022.Controllers
{
    public class SquareController : ApiController
    {
        //Que:2 Returns the square of the integer input {id}.
        /// <summary>
        /// Returns the square of the input number 
        /// </summary>
        /// <param name="id">The input number</param>
        /// <returns>The input with square</returns>
        /// example:
        //Get api/Square/2 ->4
        //Get api/Square/-2 ->4
        //Get api/Square/10 ->100
        public int Get(int id)
        {
           
            return id*id;
        }
    }
}
