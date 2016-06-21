using System;

namespace Base
{
    public abstract class Abstract
    {
        public Abstract()
        {
            
        }

        public abstract void Test();     
    }

    class TestAbstract : Abstract
    {
        public TestAbstract()
        {

        }

        public override void Test()
        {
            throw new NotImplementedException();
        }
    }
}
