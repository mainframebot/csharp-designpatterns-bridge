using BridgePatternLesson;
using NUnit.Framework;

namespace BridgePatternTests
{
    [TestFixture]
    public class Class1
    {
        [Test]
        public void Testing()
        {
            var test1 = new Abstraction(new ImplementationA()).Operation();
            var test2 = new Abstraction(new ImplementationB()).Operation();
        }
    }
}
