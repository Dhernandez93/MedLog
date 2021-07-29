using MedLog.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MedLog.Data
{
    public class Context : DbContext
    {
        public Context(DbContextOptions<Context> options):base(options) 
        {

        }

        public DbSet<EIR> EIR { get; set; }
    }
}
