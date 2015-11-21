using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labo21Nov
{
    public class CompanyContext : DbContext
    {
        private DbSet<Customer> customers;

        public CompanyContext()
               : base (@"Data Source=vm-sql.iesn.be\Stu3IG;Initial Catalog=DBIG3A3;User ID=IG3A3;Password=pwUserdb19")
        {
                      
        }        

        public DbSet<Customer> Customers
        {
            get { return customers; }
            set { customers = value; }
        }        
    }
}
