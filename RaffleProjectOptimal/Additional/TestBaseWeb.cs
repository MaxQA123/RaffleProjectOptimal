using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RaffleProjectOptimal.Additional
{
    public class TestBaseWeb : BaseWeb
    {
        [SetUp]
        public void Initialize()
        {
            Browser._Driver.Navigate().GoToUrl(EndPoints.homePage);
        }
    }
}
