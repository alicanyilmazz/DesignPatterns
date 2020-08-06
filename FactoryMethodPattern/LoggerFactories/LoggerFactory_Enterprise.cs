using FactoryMethodPattern.Interfaceses;
using FactoryMethodPattern.Loggers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodPattern.LoggerFactories
{
    public class LoggerFactory_Enterprise: ILoggerFactory
    {
        public ILogger CreateLogger()
        {
            return new LogForNetLogger();
        }
    }
}
