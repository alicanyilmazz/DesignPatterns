using AbstractFactoryPattern.AbstractFactories;
using AbstractFactoryPattern.CachingOperations;
using AbstractFactoryPattern.LoggingOperations;
using AbstractFactoryPattern.Operations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPattern.Factories
{
    public class Factory_Y : CrossCuttingConcernsFactory
    {
        public override Caching CreateCacher()
        {
            return new RedisCache();
        }

        public override Logging CreateLogger()
        {
            return new Log4NetLogger();
        }
    }
}
