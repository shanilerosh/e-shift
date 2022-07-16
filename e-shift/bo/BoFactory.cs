using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace e_shift.bo
{
    internal class BoFactory
    {
        private static BoFactory boFactory;
        public BoFactory()
        {
        }

        public static BoFactory GetInstance(){
            return (boFactory == null) ?
                (boFactory = new BoFactory()) : boFactory;
        }

        public enum BoTypes { 
            LOGIN, CUSTOMER
        }

       
    }
}
