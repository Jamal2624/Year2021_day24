namespace ArithmeticLogicInterfaceServices.Services
{
    /// <summary>
    /// Data reader
    /// </summary>
    public interface IArithmeticLogicReaderService
    {
        /// <summary>
        /// Method reads input text (in this program instructions)
        /// </summary>
        /// <returns>Text retrieved from the file</returns>
        string ReadInstructions();
    }
}
