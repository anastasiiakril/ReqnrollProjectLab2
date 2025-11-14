using Lab2Tests.Base;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using Reqnroll;

namespace ReqnrollProjectLab2.Hooks
{
    [Binding]
    public sealed class Hooks1 : TestBase
    {

       
        
        [BeforeScenario("@tag1")]
        public void BeforeScenarioWithTag()
        {

            SetUp();
        }


        [AfterScenario]
        public void AfterScenario()
        {

            TearDown();
          
        }
    }
}