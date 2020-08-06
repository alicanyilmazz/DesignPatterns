﻿using FactoryMethodPattern.Interfaceses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodPattern.Loggers
{
    class OracleLogger : ILogger
    {
        public void Log()
        {
            Console.WriteLine("Logged with OracleLogger!");
        }
    }
}
