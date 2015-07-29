using System;

namespace MiniPricerRefactoring.Logger
{
    public class LoggerService : ILoggerService
    {
        public void Log(string mess)
        {
            mess = "Error 500 : " + mess;
            Console.WriteLine(mess);
        }
    }
}