using Microsoft.VisualStudio.TestTools.UnitTesting;
using OrderTracker.Models;
using System.Collections.Generic;
using System;

namespace OrderTracker.Tests
{
  [TestClass]
  public class OrderTests : IDisposable
  {
        int vendorId = 1;
    public void Dispose()
    {
      Order.ClearAll();
    }
    [TestMethod]
    public void OrderConstructor_CreatesInstanceOfOrder_Order()
    {
      int price01 = 1;
      Order newOrder = new Order(vendorId, "test vendor", price01);
      Assert.AreEqual(typeof(Order), newOrder.GetType());
    }

    [TestMethod]
    public void OrderDescription_ReturnDescription_String()
    {
      string description = "brownie";
      int price01 = 1;
      Order testOrder = new Order(vendorId, description, price01);
      string result = testOrder.Description;

      Assert.AreEqual(description, result);
    }

    [TestMethod]
    public void SetDescription_SetDescription_String()
    {
      string description = "cookies";
      int price01 = 1;
      Order newOrder = new Order(vendorId, description, price01);
      string updatedDescription = "cake";
      newOrder.Description = updatedDescription;
      string result = newOrder.Description;
      Assert.AreEqual(updatedDescription, result);
    }
    [TestMethod]
    public void GetAll_ReturnsEmptyList_OrderList()
    {
      List<Order> newList = new List<Order> { };
      List<Order> result = Order.GetAll();
      CollectionAssert.AreEqual(newList, result);
    }
    [TestMethod]
    public void GetAll_ReturnsOrders_OrderList()
    {
      string description01 = "brownies";
      string description02 = "cookies";
      int price01 = 1;
      int price02 = 2;
      Order newOrder01 = new Order(vendorId, description01, price01);
      Order newOrder02 = new Order(vendorId, description02, price02);
      List<Order> newList = new List<Order> { newOrder01, newOrder02 };
      List<Order> result = Order.GetAll();
      CollectionAssert.AreEqual(newList, result);
    }
  }
}