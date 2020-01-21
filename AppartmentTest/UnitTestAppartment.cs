using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Apartment;
using System.Collections.Generic;

namespace Apartment
{
    [TestClass]
    public class UnitTestAppartment
    {

        public static Tenant pers1 = new Tenant("Dima", "I");
        public static Tenant pers2 = new Tenant("Serg", "Z");
        public static Tenant pers3 = new Tenant("Sasha", "B");
        public static Tenant pers4 = new Tenant("Serg", "RZ");
        public static Tenant pers5 = new Tenant("Yulya", "G");
        public static Tenant pers6 = new Tenant("Olena", "K");
        public static Tenant pers7 = new Tenant("Ruslan", "M");
        public static Tenant pers8 = new Tenant("Tanya", "N");

        public static Flat flat1 = new Flat(new List<Tenant>() { pers1, pers2 }, 46);
        public static Flat flat2 = new Flat(new List<Tenant>() { pers4, pers3 }, 60);
        public static Flat flat3 = new Flat(new List<Tenant>() { pers5, pers6, pers7 }, 33);
        public static Flat flat4 = new Flat(new List<Tenant>() { pers8 }, 90);

        public static HomeFabrica homeFabrica;
        public static Home home;
        [TestInitialize]
        public void TestInit()
        { 
            homeFabrica = new HomeFabrica();
            home = homeFabrica.CreateHome(new List<Flat>() { flat1, flat2, flat3, flat4 });
        }
        [TestMethod]
        public void TestCalculateElectricity1Tenant()
        {
            Assert.AreEqual(Expenses.CalculateElectricity(flat4), 100); 
        }

        [TestCleanup]
        public void TestClean()
        {
            homeFabrica = null;
            home = null;
        }
        [TestMethod]
        public void TestCalculateElectricity3Tenant()
        {
            Assert.AreEqual(Expenses.CalculateElectricity(flat3), 300);
        }
        [TestMethod]
        public void TestCalculateElectricity1TenantWrong()
        {
            Assert.AreNotEqual(Expenses.CalculateElectricity(flat4), 101);
        }

        [TestMethod]
        public void TestCalculateWater1Tenant()
        {
            Assert.AreEqual(Expenses.CalculateWater(flat4), 400);
        }

        [TestMethod]
        public void TestCalculateWater3Tenant()
        {
            Assert.AreEqual(Expenses.CalculateWater(flat3), 1200);
        }
        [TestMethod]
        public void TestCalculateWater1TenantWrong()
        {
            Assert.AreNotEqual(Expenses.CalculateWater(flat4), 101);
        }

        [TestMethod]
        public void TestCalculateSupportBigFlat()
        {
            Assert.AreEqual(Expenses.CalculateSupport(flat4), 1350);
        }

        [TestMethod]
        public void TestCalculateSupportSmallFlat()
        {
            Assert.AreEqual(Expenses.CalculateSupport(flat3), 495);
        }

        [TestMethod]
        public void TestCalculateSupportWrong()
        {
            Assert.AreNotEqual(Expenses.CalculateSupport(flat4), 101);
        }

        [TestMethod]
        public void TestCalculateAllBigFlat()
        {
            Assert.AreEqual(Expenses.CalculateAll(flat4), 1850);
        }

        [TestMethod]
        public void TestCalculateAllSmallFlat()
        {
            Assert.AreEqual(Expenses.CalculateAll(flat3), 1995);
        }

        [TestMethod]
        public void TestCalculateAllWrong()
        {
            Assert.AreNotEqual(Expenses.CalculateAll(flat4), 101);
        }

        [TestMethod]
        public void TestCalculateAllHome()
        {
            Assert.AreEqual(Expenses.CalculateAll(home.Flats), 7435);
        }

        [TestMethod]
        public void TestCalculateAllHomeWrong()
        {
            Assert.AreNotEqual(Expenses.CalculateAll(home.Flats), 101);
        }

        [TestMethod]
        public void TestHomeFlatsAreSameToList()
        {
            CollectionAssert.AreEqual(new List<Flat>() { flat1, flat2, flat3, flat4 }, home.Flats);
            
        }

        [TestMethod]
        public void TestHomeFlatsAreNotSameToList()
        {
            CollectionAssert.AreNotEqual(new List<Flat>() { flat2, flat1, flat3, flat4 }, home.Flats);
        }

        [TestMethod]
        public void TestThrowedException()
        {
            Exception expectedException = new DivideByZeroException();
            Exception realException = null;
            try
            {
                Expenses.ThrowException();
            }
            catch (Exception ex)
            {

                realException = ex;
            }
            Assert.IsNotNull(realException);
            Assert.IsInstanceOfType(realException, typeof(DivideByZeroException));
            //Assert.ThrowsException<DivideByZeroException>(()=>Expenses.ThrowException());
        }


    }
}
