using System;
using Xunit;
using COMP2084_Assignment1.Controllers;
using Microsoft.AspNetCore.Mvc;

namespace XUnitTestProject1
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            var homecontroll = new HomeController();
            var result = homecontroll.Index();
            Assert.NotNull(result);
        }

        [Fact]
        public void Test2()
        {
            var homecontroll = new HomeController();
            var result = homecontroll.About();
            Assert.NotNull(result);
        }

        [Fact]
        public void Test3()
        {
            var homecontroll = new HomeController();
            var result = homecontroll.Contact();
            Assert.NotNull(result);
        }


        [Fact]
        public void Test4()
        {
            var homecontroll = new HomeController();
            var result = homecontroll.Privacy();
            Assert.NotNull(result);
        }

      

    }
}
