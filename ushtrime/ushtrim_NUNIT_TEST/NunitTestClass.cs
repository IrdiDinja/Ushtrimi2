using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using ushtrim;

namespace ushtrim_NUNIT_TEST
{
    [TestFixture]
    class NunitTestClass
    {
        [Test]
        public void NunitDergimEmailTest()
        {
            DergimEmaili dg = new DergimEmaili();

            Assert.AreNotSame(true, dg.SendEmailTest("ffff"));
        }
        [Test]
        public void NunitRuajTest()
        {
            Ruaj r = new Ruaj();
            Assert.AreEqual(true, r.RuajNeDBTest("m", "m", "m", "m"));
        }

        [Test]
        public void NunitLexoSkedarTest()
        {
            LeximSkedari ls = new LeximSkedari();
            Assert.AreNotEqual(true, ls.toEmail);
        }
    }

  

}
