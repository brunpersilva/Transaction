using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TransactionsDomain.Models.Interfaces;

namespace TransactionInfra
{
    public class ApplicationConfiguration : IApplicationConfiguration
    {
        public string ConnectionString { get; set; }
    }
}
