using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labo21Nov
{
    public class Customer
    {
        
        public double AccountBalance { get; set; }

        public string AddressLine1 { get; set; }

        public string AddressLine2 { get; set; }

        public string City { get; set; }

        public string Country { get; set; }

        public string EMail { get; set; }

        public long Id { get; set; }

        public string Name { get; set; }

        public string PostCode { get; set; }

        public string Remark { get; set; }

        public Customer ()
        {

        }

        public Customer(double aB,string aL1, string aL2, string c, string co, string eM, long id, string n, string pC, string r)
        {
            AccountBalance = aB;
            AddressLine1 = aL1;
            AddressLine2 = aL2;
            City = c;
            Country = co;
            EMail = eM;
            Id = id;
            Name = n;
            PostCode = pC;
            Remark = r;
        }
    }
}
