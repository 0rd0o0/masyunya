using NUnit.Framework;
using masyunyaForms;

namespace MasyunyaFormsTests
{ 
    public class masyunyaFormsT
    {

        [Test]
        public void PlusT()
        {
            double x = 10.3;
            double y = 7.7;
            double expected = 18;
            plus c = new plus();
            double actual = c.Calculate(x, y);
            
            Assert.AreEqual(expected,actual);
        }
        //advanced test
        [TestCase(0,2,2)]
        public void PlusT2(double x, double y, double expected)
        {
            plus c = new plus();
            double actual = c.Calculate(x, y);

            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void MinusT()
        {
            double x = 20.2;
            double y = 6.1;
            double expected = 14.1;
            minus c = new minus();
            double actual = c.Calculate(x, y);

            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void ArifT()
        {
            double x = 20;
            double y = 6;
            double expected = 13;
            arif c = new arif();
            double actual = c.Calculate(x, y);

            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void GeomT()
        {
            double x = 30.4;
            double y = 5.1;
            double expected = 12.451505933018705;
            geom c = new geom();
            double actual = c.Calculate(x, y);

            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void DevisionT()
        {
            double x = 30;
            double y = 4;
            double expected = 7.5;
            devision c = new devision();
            double actual = c.Calculate(x, y);

            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void PowerT()
        {
            double x = 20;
            double y = 6;
            double expected = 64000000;
            power c = new power();
            double actual = c.Calculate(x, y);

            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void MultiplexT()
        {
            double x = 30.5;
            double y = 2.5;
            double expected = 76.25;
            multiplex c = new multiplex();
            double actual = c.Calculate(x, y);

            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void ExT()
        {
            double x = 3;
            double expected = 20.085536923187664;
            ex c = new ex();
            double actual = c.Calculate(x);

            Assert.AreEqual(expected, actual);
        }
    }
    /*Testing fabrics
    [TestCase("", typeof())]
    */

}