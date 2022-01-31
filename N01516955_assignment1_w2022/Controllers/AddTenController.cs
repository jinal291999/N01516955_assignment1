using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace N01516955_assignment1_w2022.Controllers
{
    public class AddTenController : ApiController
    {
        //Que:1 Returns 10 more than the integer input {id}.
        /// <summary>
        /// Returns the input number plus 10
        /// </summary>
        /// <param name="id">The input number</param>
        /// <returns>The input with 10 added</returns>
        /// example:
        //Get api/AddTen/21 -> 31
        //Get api/AddTen/0 -> 10
        //Get api/AddTen/-9 -> 1
        public int Get(int id)
        {
            return id + 10;
        }
    }
}
