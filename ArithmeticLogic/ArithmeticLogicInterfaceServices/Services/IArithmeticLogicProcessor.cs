
namespace ArithmeticLogicInterfaceServices.Services
{
    /// <summary>
    /// Class processes main logic of the program
    /// </summary>
    public interface IArithmeticLogicProcessorService
    {
        /// <summary>
        /// Main method
        /// </summary>
        void ProcessProgram();

   /// <summary>
    /// Method processes algorith of finding pairs of instructions 
    /// and calculates digits which corresponds to maximal Serial NUmber
    /// </summary>
    /// <param name="instructions"></param>
    /// <returns></returns>
        string ParseInstructions(string instructions);
    }

}
