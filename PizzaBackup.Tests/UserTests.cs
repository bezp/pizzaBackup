using PizzaBackup.Library.Models;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace PizzaBackup.Tests
{
    public class UserTests
    {
        //        must have a registered account.
        //must be able to view all completed orders.
        /*
         * ID
         * email
         * name
         * list? Orders
         * */
        /*
         * placeOrder()
         * cancelOrder()
         * viewHistory()
         * */

        //
        private User sut;

        public UserTests()
        {
            sut = new User();
        }


        [Fact]
        public void Test_User_Id()
        {
            int expected = 1;

            Assert.IsType<int>(sut.Id);
            Assert.True(expected == sut.Id);
        }
        [Fact]
        public void Test_User_Email()
        {
            Assert.IsType<string>(sut.Email);
        }
        [Fact]
        public void Test_User_Name()
        {
            Assert.IsType<string>(sut.Name);
        }
        [Fact]
        public void Test_User_OrdersList()
        {

        }

        /*
         * cancelOrder()
         * viewHistory()
         * placeOrder()
         * */

        [Fact]
        public void Test_User_PlaceOrder()
        {
            sut.PlaceOrder();

            Assert.True(sut.PlaceOrder());
            Assert.True(1 <= sut.Orders.Count);
        }
        [Fact]
        public void Test_User_CancelOrder()
        {
            sut.PlaceOrder();
            sut.CancelOrder();

            Assert.True(0 == sut.ViewHistory().Count());
            //Assert.True(1 > sut.Orders.Count);
        }
        [Fact]
        public void Test_User_ViewHistory()
        {
            sut.PlaceOrder();
            sut.PlaceOrder();
            Assert.True(2 == sut.ViewHistory().Count());
        }
    }
}
