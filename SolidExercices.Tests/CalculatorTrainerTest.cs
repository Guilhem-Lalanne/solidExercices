using NFluent;
using NUnit.Framework;

namespace SolidExercices.Tests
{
    class CalculatorTrainerTest
    {
        [Test]
        public void TestTrainer()
        {
            var calculatorTrainer = new CalculatorTrainer();
            calculatorTrainer.Run();
        }
    }
}
