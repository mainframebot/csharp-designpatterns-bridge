using BridgePatternLesson.Interfaces;

namespace BridgePatternLesson
{
    public class Abstraction
    {
        private IBridge _bridge;

        public Abstraction(IBridge bridge)
        {
            _bridge = bridge;
        }

        public string Operation()
        {
            return "Via Bridge: " + _bridge.OperationImp();
        }
    }
}
