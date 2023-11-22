using ArithmeticLogicInterfaceServices.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArithmeticLogicImplementationServices.Services
{
    /// <summary>
    /// Writer of results
    /// </summary>
    public class ArithmeticLogicWriterService : IArithmeticLogicWriterService
    {

        /// <summary>
        /// Method writes results
        /// In this case in console
        /// </summary>
        public void WriteResult(string maxSerialNumber)
        {
            Console.WriteLine($"Maximal Serial Number: {maxSerialNumber}");
        }
    }
}
