using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace N01516955_assignment1_w2022.Controllers
{
    public class NumberMachineController : ApiController
    {
        // Que:5 
        /// <summary>
        /// Returns the output with four mathematical operations performed
        /// </summary>
        /// <param name="id">The input number</param>
        /// <returns>The input with applied four mathematical operations</returns>
        /// example:
        //Get api/NumberMachine/10 = 109
        //Get api/NumberMachine/-5 = 19
        //Get api/NumberMachine/30 = 929
        public int Get(int id)
        {
            return id + id * id -id /id;
        }
    }

}
