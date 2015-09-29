using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConsoleApplication1;


namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Pupil p = new Pupil("Julien",21);

            p.AddEvaluation("env dev", 'd');

            var evaluation = p.GetEvaluationFor("env dev");
            Assert.AreEqual('d', evaluation);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void TestMethod2()
        {
            Pupil p = new Pupil("Julien", 21);

            p.AddEvaluation(null, 'd');

            var evaluation = p.GetEvaluationFor(null);
            Assert.AreEqual('d', evaluation);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void TestMethod3()
        {
            Pupil p = new Pupil("Julien", 21);            

            var evaluation = p.GetEvaluationFor("bidon");
            Assert.AreEqual('d', evaluation);
        }

    }
}
