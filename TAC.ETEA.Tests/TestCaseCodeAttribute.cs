using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using NUnit.Framework;

namespace TAC.ETEA.Tests
{
    [AttributeUsage(AttributeTargets.Method, AllowMultiple = false)]
    public class TestCaseCodeAttribute: PropertyAttribute
    {
        public TestCaseCodeAttribute(string code)
            : base(code)
        {
        }
    }
}
