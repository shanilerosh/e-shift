using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace e_shift.utility
{
    internal class Constants
    {

        //entites
        public static readonly string CUSTOMER = "Customer";
        public static readonly string ITEM = "Item";
        public static readonly string TRANSPORT_UNIT = "Transport Unit";
        public static readonly string JOB = "Job";

        //System error
        public static readonly string SYSTEM_ERROR = 
            "System Error. Please contact the administrator";
        public static readonly string JOB_ERROR = 
            "Job cannot be created/updated without items";


        //Success
        public static readonly string SUCCESSFULLY_CREATED =
            "{0} Successfully Created";
        public static readonly string SUCCESSFULLY_DELETED =
            "{0} Successfully Deleted";
        public static readonly string SUCCESSFULLY_UPDATED =
            "{0} Successfully Updated";
        public static readonly string SUCCESSFULLY_LOGGED_IN =
            "User {0} Successfully Logged In";
        
        
        //SQL Querries
         




    }
}
