using Microsoft.VisualStudio.TestTools.UnitTesting;
using OrderTracker.Models;
using System.Collections.Generic;
using System;

namespace OrderTracker.Tests
{
  [TestClass]
  public class VendorTests : IDisposable
  {
    public void Dispose()
    {
      Vendor.ClearAll();
    }
    [TestMethod]
    public void VendorConstructor_CreatesInstanceOfVendor_Vendor()
    {
      Vendor newVendor = new Vendor("test vendor");
      Assert.AreEqual(typeof(Vendor), newVendor.GetType());
    }
    [TestMethod]
    public void GetVendorName_ReturnVendorName_String()
    {
      string vendorName = "Pierre's Bakery";
      Vendor testVendor = new Vendor(vendorName);
      string result = testVendor.VendorName;

      Assert.AreEqual(vendorName, result);
    }
    [TestMethod]
    public void GetId_ReturnsId_Int()
    {
        string vendor = "vendorname";
        Vendor vendorname = new Vendor(vendor);
        int id = vendorname.Id;
        Assert.AreEqual(1, id);
    }
    [TestMethod]
    public void GetAll_ReturnsAllVendorsObjects_VendorList()
    {
        string vendor01 = "Starbucks";
        string vendor02 = "Coffeshop";
        Vendor newVendor01 = new Vendor(vendor01);
        Vendor newVendor02 = new Vendor(vendor02);
        List<Vendor> newList = new List<Vendor> { newVendor01, newVendor02 };
        List<Vendor> result = Vendor.GetAll();
        CollectionAssert.AreEqual(newList, result);
    }

    }
}