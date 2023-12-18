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
    }
}