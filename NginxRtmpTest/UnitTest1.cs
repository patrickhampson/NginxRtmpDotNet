using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NginxRtmp;

namespace NginxRtmpTest
{
    [TestClass]
    public class NginxRtmpClientTests
    {
        [TestMethod]
        public void TestMethod1()
        {
            NginxRtmpClient c = new NginxRtmpClient("https://output.pa.4stream.tv/stat");
            var ret = c.pollNginxRtmp();

            Assert.IsNotNull(ret);
        }
    }
}
