using ReizTechAssignment;

namespace TestReizTechAssignment
{
    public class Tests
    {
        Validation validation;
        Calculations calculations;

        [SetUp]
        public void Setup()
        {
            validation = new Validation();
            calculations = new Calculations();
        }

        [Test]
        [TestCase("1:00")]
        [TestCase("01:0")]
        [TestCase("0A:00")]
        [TestCase("01:A0")]
        [TestCase("13:00")]
        [TestCase("01:60")]
        public void TestValidation_ValidateData_AllSortsOfNotValidDataSent_ReturnsFalse(string input)
        {
            bool desiredResult = false;
            bool actualresult = validation.ValidateData(input);
            Assert.AreEqual(desiredResult, actualresult);
        }
        [Test]
        [TestCase("00:00")]
        [TestCase("12:59")]
        public void TestValidation_ValidateData_AllSortsOfValidDataSent_ReturnsTrue(string input)
        {
            bool desiredResult = true;            
            bool actualResult = validation.ValidateData(input);
            Assert.AreEqual(desiredResult, actualResult);
        }
        [Test]
        [TestCase("01:00", 30)]
        [TestCase("03:00", 90)]
        [TestCase("06:00", 180)]
        [TestCase("09:00", 90)]
        [TestCase("00:30", 165)]
        public void TestCalculations_CalculateAngle_DataSent_ReturnsProperlyCalculatedAngles(string input, double desiredResult)
        {
            double actualResult = calculations.CalculateAngle(input);
            Assert.AreEqual(desiredResult, actualResult);
        }
    }
}