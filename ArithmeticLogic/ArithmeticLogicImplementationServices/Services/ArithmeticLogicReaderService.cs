using ArithmeticLogicInterfaceServices.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ArithmeticLogicImplementationServices.Services
{

    /// <summary>
    /// Data reader
    /// </summary>
    public class ArithmeticLogicReaderService : IArithmeticLogicReaderService
    {
        /// <summary>
        /// Method reads input text (in this program instructions)
        /// </summary>
        /// <returns>Text retrieved from the file</returns>
        public string ReadInstructions()
        {
            string text = "";
            var path = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
            if (!string.IsNullOrEmpty(path))
            {
                var filepath = Path.Combine(path, @"ArithmeticLogic Input.txt");
                var fileInfo = new FileInfo(filepath);
                if (fileInfo.Exists)
                {
                    text = File.ReadAllText(filepath);
                }
            }
            return text;
        }
    }
}
