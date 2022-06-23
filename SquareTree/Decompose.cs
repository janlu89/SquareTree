using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SquareTree
{
    public class Decompose
    {
        public string decompose(long number)
        {
            if (number == 1)
                return "1";
            try
            {
                List<long> lresult = recursion(number * number, number - 1);
                return string.Join(", ", lresult);
            }
            catch (ArgumentNullException)
            {
                return null;
            }
        }

        List<long> recursion(long numberSquared, long recurred)
        {
            if (numberSquared == 0) 
                return new List<long>();
            if (recurred <= 0 || numberSquared < 0) 
                return null; 
            if (numberSquared < recurred * recurred) 
                recurred = Convert.ToInt64(Math.Sqrt(numberSquared));

            List<long> collection = recursion(numberSquared - recurred * recurred, recurred - 1);

            if (collection != null)
            {
                collection.Add(recurred);
                return collection;
            }
            else
            {
                return recursion(numberSquared, recurred - 1);
            }
        }
    }
}
