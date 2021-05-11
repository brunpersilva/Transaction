using System;
using System.Collections.Generic;
using System.Text;

namespace TransactionsDomain.Models.Interfaces
{
   public interface IApplicationConfiguration
    {
        string ConnectionString { get; set; }
    }
}
