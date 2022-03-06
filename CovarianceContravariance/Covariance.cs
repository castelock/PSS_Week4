using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CovarianceContravariance
{
    public class First { }
    public class Second : First { }
    public delegate First SampleDelegate(Second a);
    public class Covariance
    {
        // Matching signature.  
        public static First ASecondRFirst(Second second)
        { return new First(); }

        // The return type is more derived.  
        public static Second ASecondRSecond(Second second)
        { return new Second(); }

        // The argument type is less derived.  
        public static First AFirstRFirst(First first)
        { return new First(); }

        // The return type is more derived
        // and the argument type is less derived.  
        public static Second AFirstRSecond(First first)
        { return new Second(); }
    }
}
