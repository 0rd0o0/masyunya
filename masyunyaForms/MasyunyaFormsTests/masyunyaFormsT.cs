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

            double actual = calc2.Plus(x, y);
            
            Assert.AreEqual(expected,actual);
        }
        [Test]
        public void MinusT()
        {
            double x = 20.2;
            double y = 6.1;
            double expected = 14.1;

            double actual = calc2.Minus(x, y);

            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void ArifT()
        {
            double x = 20;
            double y = 6;
            double expected = 13;

            double actual = calc2.Arif(x, y);

            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void GeomT()
        {
            double x = 30.4;
            double y = 5.1;
            double expected = 12.451505933018705;

            double actual = calc2.Geom(x, y);

            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void DevisionT()
        {
            double x = 30;
            double y = 4;
            double expected = 7.5;

            double actual = calc2.Devision(x, y);

            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void PowerT()
        {
            double x = 20;
            double y = 6;
            double expected = 64000000;

            double actual = calc2.Power(x, y);

            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void MultiplexT()
        {
            double x = 30.5;
            double y = 2.5;
            double expected = 76.25;

            double actual = calc2.Multiplex(x, y);

            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void ExT()
        {
            double x = 3;
            double expected = 20.085536923187664;

            double actual = calc2.Ex(x);

            Assert.AreEqual(expected, actual);
        }
    }
}