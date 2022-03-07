using Microsoft.VisualStudio.TestTools.UnitTesting;
using opg1obl;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace opg1obl.Tests
{
    [TestClass()]
    public class CarTests
    {
        private Car car;
        private Car car2;
        [TestInitialize]
        public void Init()
        {
            car = new Car("Toyota 5i", 40000, "af52919");
            car2 = new Car("Tesla", 11, "fu38319");
        }

        [TestMethod()]
        public void ConstructorTest()
        {
            Assert.AreEqual("Toyota 5i", car.Model);
            Assert.AreEqual(40000, car.Price);
            Assert.AreEqual("af52919", car.LicensePlate);
        }

        [TestMethod()]
        public void IdTest()
        {
            Assert.AreNotEqual(0, car.Id);
            
            
            //hvis man kører den igennem som enkelt test går det godt. Hvis du kører alle testene igennem giver den her fejl. Ved ikke helt hvorfor at id ændrer sig, men det er nok noget med init at gøre.
            Assert.AreEqual(2, car2.Id);
        }

        [TestMethod()]
        public void ModelTest()
        {
            
            Assert.AreNotEqual(car.Model, car2.Model);
            Assert.AreNotEqual("T", car2.Model);
            Assert.AreEqual("Tesla", car2.Model);
            

        }

        [TestMethod()]
        public void ModelTest2()
        {
            Assert.ThrowsException<ArgumentException>(() => car2.Model = car2.Model = " ");
            Assert.ThrowsException<ArgumentNullException>(() => car2.Model = car2.Model = "           ");

        }

        [TestMethod()]
        public void LicenseTest()
        {
            Assert.ThrowsException<ArgumentException>(() => car.LicensePlate = car.LicensePlate = " ");
            Assert.ThrowsException<ArgumentException>(() => car.LicensePlate = car.LicensePlate = "af250909809580");
            Assert.ThrowsException<ArgumentNullException>(() => car.LicensePlate = car.LicensePlate = "      ");

        }

        //[TestMethod()]
        //public void ToStringTest()
        //{
        //    Assert.Fail();
        //}
    }
}