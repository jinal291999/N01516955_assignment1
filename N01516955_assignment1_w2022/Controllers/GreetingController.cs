using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace N01516955_assignment1_w2022.Controllers
{
    public class GreetingController : ApiController
    {
        //Que:3 
        //Post api/Greeting
        /// <summary>
        /// Returns the string “Hello World!”
        /// </summary>
        /// <param name="id">The input message</param>
        /// <returns>The same message that was inputed </returns>
        public string Post()
        {
            return "Hello World";
        }

        // Que:4 
        /// <summary>
        /// Inputs a number and returns the string “Greetings to {id} people!” where id is an integer value.
        /// </summary>
        /// <param name="id">The input number</param>
        /// <returns>The input with string </returns>
        /// example:
        //Get api/Greeting/3
        //Get api/Greeting/6
        //Get api/Greeting/0
        public string Get(int id)
        {
            
            return " Greetings" +" " +id+ " "+"people!";
        }
    }
}
