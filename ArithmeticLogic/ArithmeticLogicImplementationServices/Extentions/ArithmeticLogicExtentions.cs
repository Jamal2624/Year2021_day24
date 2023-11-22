using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ArithmeticLogicImplementationServices.Extentions
{
    public static class ArithmeticLogicExtentions
    {
        /// <summary>
        /// Method extracts value from script (string array)
        /// </summary>
        /// <param name="strArray">String array </param>
        /// <param name="line">Line number</param>
        /// <param name="position">Position of value to be extracted</param>
        /// <returns></returns>
       public static int ExtractValue(this string[] strArray, int line,int position)
        {
            string strValue = strArray[line].Split("\r\n")[position].Split(' ')[^1];

            return int.Parse(strValue);
        }
    }
}
