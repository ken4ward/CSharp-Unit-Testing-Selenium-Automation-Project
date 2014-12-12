using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SampleTestingProjectAppZone.TestUtils.TestThreads
{
    [TestClass]
    public class TimingSettings
    {
        [TestMethod]
        public static void WaitTime()
        {
            System.Threading.Thread.Sleep(500);
        }
    }
}
