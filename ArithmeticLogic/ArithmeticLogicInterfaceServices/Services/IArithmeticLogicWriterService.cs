namespace ArithmeticLogicInterfaceServices.Services
{
    /// <summary>
    /// Writer of results
    /// </summary>
    public interface IArithmeticLogicWriterService
    {
        /// <summary>
        /// Method writes results
        /// In this case in console
        /// </summary>
        void WriteResult(string maxSerialNumber);
    }
}
