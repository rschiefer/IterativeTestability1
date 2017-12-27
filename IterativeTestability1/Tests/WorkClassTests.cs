using Moq;
using NUnit.Framework;
using System;

namespace IterativeTestability1
{
    [TestFixture]
    public class WorkClassTests
    {
        private Mock<IHelper> _mockHelper;
        private Mock<IDateProvider> _mockDateProvider;
        private WorkClass _work;
        private string _result;

        [SetUp]
        public void SetUp()
        {
            _mockHelper = new Mock<IHelper>();
            _mockDateProvider = new Mock<IDateProvider>();
            _work = new WorkClass(_mockHelper.Object, _mockDateProvider.Object);
        }

        public void Because()
        {
            _result = _work.CreateGreeting("Robb");
            Console.WriteLine("Result is \"{0}\"", _result);
        }

        [Test]
        public void ShouldThrowException()
        {

            Assert.Throws(typeof(NullReferenceException), () => (new WorkClass()).CreateGreeting("Robb"));
        }
        [Test]
        public void ShouldThrowExceptionInOld()
        {

            Assert.Throws(typeof(NullReferenceException), () => (new WorkClass_OLD()).CreateGreeting("Robb"));
        }
        [Test]
        public void ShouldReturnGreeting()
        {
            Because();
            Assert.IsNotNull(_result);
        }
        [Test]
        public void ShouldGreetMorning()
        {
            _mockDateProvider.Setup(x => x.GetNow()).Returns(new System.DateTime(2012, 1, 1, 2, 1, 1));

            Because();
            Assert.IsTrue(_result.Contains("morning"));
        }
        [Test]
        public void ShouldGreetAfternoon()
        {
            _mockDateProvider.Setup(x => x.GetNow()).Returns(new System.DateTime(2012, 1, 1, 13, 1, 1));

            Because();
            Assert.IsTrue(_result.Contains("afternoon"));
        }
        [Test]
        public void ShouldGreetEvening()
        {
            _mockDateProvider.Setup(x => x.GetNow()).Returns(new System.DateTime(2012, 1, 1, 20, 1, 1));

            Because();
            Assert.IsTrue(_result.Contains("evening"));
        }
    }
}
