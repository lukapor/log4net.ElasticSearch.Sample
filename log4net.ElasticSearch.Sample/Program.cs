using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using log4net;

namespace log4net.ElasticSearch.Sample
{
    class Program
    {
        private static readonly ILog _log = LogManager.GetLogger(typeof(Program));

        static void Main(string[] args)
        {
            _log.Info("log4net.ElsaticSearch Test");
            Console.WriteLine("Added a record.");
            Console.ReadKey();
        }
    }
}
