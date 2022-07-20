using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using e_shift.dto;

namespace e_shift.utility
{
    internal class Assert
    {

        public static void IsTrue(Boolean expression, string message) {
            if (!expression) {
                throw new InvalidDataException(message);
            }
        }

        public static void IsFalse(Boolean expression, string message)
        {
            if (expression)
            {
                throw new InvalidDataException(message);
            }
        }

        public static void IsNull(Object obj, String message)
        {
            if (null == obj)
            {
                throw new InvalidDataException(message);
            }
        }
        
        public static void IsEmptyCollection(IList<JobItemDto> collection, string message)
        {
            if (0 == collection.Count)
            {
                throw new InvalidDataException(message);
            }
        }


        public static void HasText(string obj, string message)
        {
            if (string.IsNullOrEmpty(obj))
            {
                throw new InvalidDataException(message);
            }
        }

        public static void HasNumber(int obj, string message)
        {

            IsNull(obj, message);   

            if (string.IsNullOrEmpty(obj.ToString()))
            {
                throw new InvalidDataException(message);
            }
        }

        public static void IsNumeric(string obj, String message)
        {
            HasText(obj, message);

            //check if numerical
            try
            {
                int.Parse(obj);
            }
            catch (Exception)
            {

                throw new InvalidDataException(message);
            }
        }


    }
}
