using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ushtrim;


namespace UshtrimTest
{
    [TestClass]
   public class ushtrimTest
    {
        [TestMethod]
        public void DergimEmailTest()
        {
            DergimEmaili dg = new DergimEmaili();
            Assert.AreNotSame(true,dg.SendEmailTest("ffff"));
            
        }
        [TestMethod]
        public void RuajTest()
        {
            Ruaj r = new Ruaj();
            Assert.AreEqual(true,r.RuajNeDBTest("m","m","m","m"));
        }

        [TestMethod]
        public void LexoSkedarTest()
        {
            LeximSkedari ls = new LeximSkedari();
            Assert.AreNotEqual(true,ls.toEmail);
        }
    }
}
