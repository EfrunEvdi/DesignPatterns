using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPattern.ChainOfResponsibility.DAL
{
    public class Context:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=EFRUN\\SQLEXPRESS; initial catalog=DesignPattern2; integrated security=true;");
        }

        public DbSet<CustomerProcess> CustomerProcesses { get; set; }
    }
}
