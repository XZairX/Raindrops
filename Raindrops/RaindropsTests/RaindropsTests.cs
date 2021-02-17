using NUnit.Framework;
using RaindropsLibrary;

namespace RaindropsTests
{
    [TestFixture]
    public class RaindropTests
    {
        private readonly Raindrops _sut = new Raindrops();

        [TestCase(-34)]
        [TestCase(-8)]
        [TestCase(-1)]
        [TestCase(1)]
        [TestCase(8)]
        [TestCase(34)]
        public void PlingPlangPlong_NumberDoesNotHaveAFactorOf3Or5Or7_ReturnsNumber(int number)
        {
            var result = _sut.PlingPlangPlong(number);

            Assert.That(result, Is.EqualTo(number.ToString()));
        }

        [TestCase(-27)]
        [TestCase(-9)]
        [TestCase(-3)]
        [TestCase(3)]
        [TestCase(9)]
        [TestCase(27)]
        public void PlingPlangPlong_NumberHasAFactorOf3_ReturnsPling(int number)
        {
            var result = _sut.PlingPlangPlong(number);

            Assert.That(result, Is.EqualTo("Pling"));
        }

        [TestCase(-25)]
        [TestCase(-10)]
        [TestCase(-5)]
        [TestCase(5)]
        [TestCase(10)]
        [TestCase(25)]
        public void PlingPlangPlong_NumberHasAFactorOf5_ReturnsPlang(int number)
        {
            var result = _sut.PlingPlangPlong(number);

            Assert.That(result, Is.EqualTo("Plang"));
        }

        [TestCase(-28)]
        [TestCase(-14)]
        [TestCase(-7)]
        [TestCase(7)]
        [TestCase(14)]
        [TestCase(28)]
        public void PlingPlangPlong_NumberHasAFactorOf7_ReturnsPlong(int number)
        {
            var result = _sut.PlingPlangPlong(number);

            Assert.That(result, Is.EqualTo("Plong"));
        }

        [TestCase(-30)]
        [TestCase(-15)]
        [TestCase(15)]
        [TestCase(30)]
        public void PlingPlangPlong_NumberHasAFactorOf3And5_ReturnsPlingPlang(int number)
        {
            var result = _sut.PlingPlangPlong(number);

            Assert.That(result, Is.EqualTo("PlingPlang"));
        }

        [TestCase(-63)]
        [TestCase(-21)]
        [TestCase(21)]
        [TestCase(63)]
        public void PlingPlangPlong_NumberHasAFactorOf3And7_ReturnsPlingPlong(int number)
        {
            var result = _sut.PlingPlangPlong(number);

            Assert.That(result, Is.EqualTo("PlingPlong"));
        }

        [TestCase(-70)]
        [TestCase(-35)]
        [TestCase(35)]
        [TestCase(70)]
        public void PlingPlangPlong_NumberHasAFactorOf5And7_ReturnsPlangPlong(int number)
        {
            var result = _sut.PlingPlangPlong(number);

            Assert.That(result, Is.EqualTo("PlangPlong"));
        }

        [TestCase(-210)]
        [TestCase(-105)]
        [TestCase(105)]
        [TestCase(210)]
        public void PlingPlangPlong_NumberHasAFactorOf3And5And7_ReturnsPlingPlangPlong(int number)
        {
            var result = _sut.PlingPlangPlong(number);

            Assert.That(result, Is.EqualTo("PlingPlangPlong"));
        }

        [Test]
        public void PlingPlangPlong_NumberIsZero_ReturnsPlingPlangPlong()
        {
            var result = _sut.PlingPlangPlong(0);

            Assert.That(result, Is.EqualTo("PlingPlangPlong"));
        }
    }
}
