using ArithmeticLogicImplementationServices.Extentions;
using ArithmeticLogicInterfaceServices.Services;
using static System.Net.Mime.MediaTypeNames;

namespace ArithmeticLogicImplementationServices.Services
{
    /// <summary>
    /// Class processes main logic of the program
    /// </summary>
    public class ArithmeticLogicProcessorService : IArithmeticLogicProcessorService
    {
        private readonly IArithmeticLogicReaderService _readerService;
        private readonly IArithmeticLogicWriterService _writerService;

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="readerService">Data reader</param>
        /// <param name="writerService">Data writer/shower</param>
        public ArithmeticLogicProcessorService(
                IArithmeticLogicReaderService readerService,
                IArithmeticLogicWriterService writerService
            ) {
            _readerService = readerService;
            _writerService = writerService;
        }

        /// <summary>
        /// Main method
        /// </summary>
        public void ProcessProgram()
        {
            var text = _readerService.ReadInstructions();
            var maxSerialNumber = ParseInstructions(text);
            _writerService.WriteResult(maxSerialNumber);
        }

        /// <summary>
        /// Method processes algorith of finding pairs of instructions 
        /// and calculates digits which corresponds to maximal Serial NUmber
        /// </summary>
        /// <param name="instructions"></param>
        /// <returns></returns>
        public string ParseInstructions(string instructions) {
            var evailableDigits = Enumerable.Range(1, 9).ToArray();

            // Splitting entire instructions into chunks separated by "inp w" instruction
            var instChunks = instructions.Split("inp w\r\n", StringSplitOptions.RemoveEmptyEntries);

            // using stack as paring tool for instruction parameters (a,b)
            var paringStack = new Stack<int>();

            // Placeholder for keepng digits of Serial Number.
            int[] maxSerialNUmber = Enumerable.Repeat(int.MinValue, 14).ToArray();

            for (var j = 0; j < 14; j++)
            {
                if (instChunks[j].Contains("div z 1"))
                {
                    // j is reference to first part of  shift
                    paringStack.Push(j);
                }
                else
                {
                    // in this case 
                    // j is second part of shift

                    // i - is reference to first part of  shift, retrieved from stack
                    var i = paringStack.Pop();

                    // Extracting parts of shift and combining into complete shift
                    var shifter = instChunks.ExtractValue(i, 14) + instChunks.ExtractValue(j, 4);

                    // Searching for digits of maximal serial number
                    foreach (var aParameter in evailableDigits)
                    {
                        var bParameter = aParameter + shifter;
                        if (evailableDigits.Contains(bParameter))
                        {
                            if (aParameter > maxSerialNUmber[i])
                            {
                                (maxSerialNUmber[i], maxSerialNUmber[j]) = (aParameter, bParameter);
                            }
                        }
                    }
                }
            }

            return string.Join("", maxSerialNUmber);
        }


    }
}
