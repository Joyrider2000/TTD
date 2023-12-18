namespace TTD.Tests {
    public class Tests {

        StringCalculator calculator;

        [SetUp]
        public void Setup() {
            calculator = new StringCalculator();
        }

        [Test]
        public void Add_EmptyString_ReturnsZero() {
            int result = calculator.Add("");
            Assert.That(result, Is.EqualTo(0));
        }

        [Test]
        [TestCase("0", 0)]
        [TestCase("1", 1)]
        [TestCase("2", 2)]
        public void Add_OneNumber_ReturnsNumber(string stringNumber, int expectedResult) {
            int result = calculator.Add(stringNumber);
        }

        [Test]
        [TestCase("1,2", 3)]
        [TestCase("0,2", 2)]
        [TestCase("0,1", 1)]
        public void Add_TwoNumbers_ReturnsNumber(string stringNumber, int expectedResult) {
            int result = calculator.Add(stringNumber);
            Assert.That(result, Is.EqualTo(expectedResult));
        }
    }
}