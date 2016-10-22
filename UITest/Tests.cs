using System;
using System.IO;
using System.Linq;
using NUnit.Framework;
using Xamarin.UITest;
using Xamarin.UITest.Queries;

namespace UITest
{
    [TestFixture(Platform.Android)]
    //[TestFixture(Platform.iOS)]
    public class Tests
    {
        IApp app;
        Platform platform;

        public Tests(Platform platform)
        {
            this.platform = platform;
        }

        [SetUp]
        public void BeforeEachTest()
        {
            app = AppInitializer.StartApp(platform);
        }

        [Test]
        public void AppLaunches()
        {
            app.Screenshot("First screen.");
        }

        [Test]
        public void PressHelloButton()
        {
            app.Tap(b => b.Marked("btnHello"));
            var lblText = app.Query(l => l.Marked("lblHello")).Single().Text;
            Assert.AreEqual(lblText, "HelloMoto");
            app.Screenshot("Hello From Moto");
        }

        [Test]
        public void PressHelloButton2()
        {
            app.Tap(b => b.Marked("btnHello"));
            var lblText = app.Query(l => l.Marked("lblHello")).Single().Text;
            Assert.AreEqual(lblText, "HelloMoto2");
            app.Screenshot("Hello From Moto");
        }
    }
}

