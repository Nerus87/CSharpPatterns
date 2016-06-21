using System.Diagnostics;

namespace Base
{
    public class Virtual
    {
        public Virtual()
        {
            Debug.WriteLine("Virtual constructor");
        }

        public virtual void Test() => Debug.WriteLine("Virtual class");
    }

    public class VirtualClass : Virtual
    {
        public VirtualClass()
        {
            Debug.WriteLine("VirtualClass constructor");
        }

        public override void Test()
        {
           Debug.WriteLine("VirtualClass class");

           base.Test();
        }

        public virtual void VirtualMethod()
        {

        }
    }
}
