
using Lab2Tests.Pages;
using OpenQA.Selenium;
using System;
using Reqnroll;
using Lab2Tests.Base;


namespace ReqnrollProjectLab2.StepDefinitions
{
    [Binding]
    public class RemoveItemFromCartOrInventoryStepDefinitions : TestBase
    {
        
        private LoginPage loginPage;
        private InventoryPage inventoryPage;
        private CartPage cartPage;


        [Given("user is logged in as {string} with password {string}")]
        public void GivenUserIsLoggedInAsWithPassword(string username, string password)
        {
            
            loginPage = new LoginPage(TestBase.driver);
            loginPage.LoginWithNameAndPassword(username, password);
            inventoryPage = new InventoryPage(TestBase.driver);

        }

        [When("user adds an item")]
        public void WhenUserAddsAnItem()
        {
            inventoryPage.AddAnItem();
        }

        [When("user removes the item from the inventory")]
        public void WhenUserRemovesTheItemFromTheInventory()
        {
            inventoryPage.RemoveAnItem();
        }

        [Then("the item should be removed from the inventory")]
        public void ThenTheItemShouldBeRemovedFromTheInventory()
        {
            inventoryPage.CheckThatItemIsRemoved();
           
        }

        [When("navigates to the cart page")]
        public void WhenNavigatesToTheCartPage()
        {
            inventoryPage.NavigateToCartPage();
            cartPage = new CartPage(TestBase.driver);
        }

        [When("user removes the item from the cart")]
        public void WhenUserRemovesTheItemFromTheCart()
        {
            cartPage.RemoveAnItem();
        }

        [Then("the item should be removed from the cart")]
        public void ThenTheItemShouldBeRemovedFromTheCart()
        {
            cartPage.CheckThatItemIsRemoved();

        }
    }
}
