using ArithmeticLogicImplementationServices;
using ArithmeticLogicImplementationServices.Services;
using ArithmeticLogicInterfaceServices;
using ArithmeticLogicInterfaceServices.Services;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace ArithmeticLogicApp
{
    public class ArithmeticLogicApp
    {
        public static int Main()
        {
            try
            {
                ServiceProvider serviceProvider = new ServiceCollection()
                        .AddSingleton<IArithmeticLogicReaderService, ArithmeticLogicReaderService>()
                        .AddSingleton<IArithmeticLogicWriterService, ArithmeticLogicWriterService>()
                        .AddSingleton<IArithmeticLogicProcessorService, ArithmeticLogicProcessorService>()
                        .BuildServiceProvider();


                Console.WriteLine("Starting application");
                IArithmeticLogicProcessorService? processingService = serviceProvider.GetService<IArithmeticLogicProcessorService>();
                processingService.ProcessProgram();

                Console.WriteLine("All done!");
            }
            catch (IOException e)
            {
                TextWriter errorWriter = Console.Error;
                errorWriter.WriteLine(e.Message);
                return 1;
            }
            Console.WriteLine("Press any key to continue...");
            _ = Console.ReadKey();
            return 0;
        }
    }
}

