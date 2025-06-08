using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P2POO.Services.Logging
{
    public class ConsoleLogger : ILogger
    {
        public void Log(string mensagem)
        {
            Console.WriteLine($"[LOG - {DateTime.Now}] {mensagem}");
        }
    }
}
