using System;
using System.Collections.Generic;
using MiniPricerRefactoring.Engine;
using MiniPricerRefactoring.Logger;

namespace MiniPricerRefactoring
{
    public class ServiceLocator
    {
        // a map between contracts -> concrete implementation classes
        private IDictionary<Type, Type> servicesType;
        private static readonly object TheLock = new Object();

        private static ServiceLocator instance;
        public ILoggerService Logger;
        public CalcEngine Calc;

        // a map containing references to concrete implementation already instantiated
        // (the service locator uses lazy instantiation).

        private ServiceLocator()
        {
            this.servicesType = new Dictionary<Type, Type>();
            this.BuildServiceTypesMap();
        }

        private void BuildServiceTypesMap()
        {
            Logger = new LoggerService(); 
            Calc = new CalcEngine();
        }

        public static ServiceLocator Instance
        {
            get
            {
                lock (TheLock) // thread safety
                {
                    if (instance == null)
                    {
                        instance = new ServiceLocator();
                    }
                }

                return instance;
            }
        }

        // rest of the methods
    }
}
