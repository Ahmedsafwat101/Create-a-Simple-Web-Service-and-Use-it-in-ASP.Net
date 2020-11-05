using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace CalcualtorWebVersion
{
    /// <summary>
    /// Summary description for CalcService
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class CalcService : System.Web.Services.WebService
    {
        /**
         * This service will work as a simple calcalutor that have only 4 functions
         * Addition
         * Subtraction
         * Multiplication
         * Division 
        **/

        [WebMethod]
        public int Addition(int num1, int num2)
        {
            return num1 + num2;
        }

        [WebMethod]
        public int Subtraction(int num1, int num2)
        {
            return num1 - num2;
        }

        [WebMethod]
        public int Multiplication(int num1, int num2)
        {
            return num1 * num2;
        }

        [WebMethod]
        public int Divison(int num1, int num2)
        {
            return num1 / num2;
        }

    }
}
