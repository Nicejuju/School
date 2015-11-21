using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Data.Entity;
using Labo21Nov;
using System.Linq;

namespace UnitTestProject
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void InsertionFonctionnelle()
        {
            CompanyContext cpyCtx = new CompanyContext();
            Customer customer = new Customer(4500.75,"Rue de la Justice","Rue des francais","Chatelet","Belgique","robert.dupont@toto.be",0001,"Robert","6200","Gentil");

            Database.SetInitializer(new DropCreateDatabaseAlways<CompanyContext>());
            cpyCtx.Customers.Add(customer);
            cpyCtx.SaveChanges();
        }

        [TestMethod]
        public void TestMethod2()
        {
            CompanyContext cpyCtx = new CompanyContext();
            int nbCustomers = cpyCtx.Customers.Count();

            Assert.AreNotEqual(0,nbCustomers);
        }       
    }
}
