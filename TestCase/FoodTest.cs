using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using QuanLyQuanCafe;
namespace TestCase
{
    [TestClass]
    public class FoodTest
    {
        fDoAnUong food = new fDoAnUong();
      
        /*
         80	Cafe late	55	17000	0		
         81	Cafe sua	55	17000	0		
         85	Cafe den	55	17000	0	
        */
        [TestMethod]
        public void addFoodFalse()
        {
            bool result1 = food.addFoodToDatabase(" ", "Không", 55, 15000, 0);// ten null
            Assert.AreEqual(result1, false);
            bool result2 = food.addFoodToDatabase("Cafe sua nong", "Không", 55, -1000, 0);// gia < 0
            Assert.AreEqual(result2, false);
            bool result3 = food.addFoodToDatabase("Cafe sua nong", "Không", 55, 15000, -1000); // giam gia < 0
            Assert.AreEqual(result3, false);
            bool result4 = food.addFoodToDatabase("Cafe den", "Không", 55, 15000, 0);// them trung ten
            Assert.AreEqual(result4, false);
        }
        [TestMethod]
        public void addFoodTrue()
        {
            bool result = food.addFoodToDatabase("Cafe sua nong", "Không", 55, 15000, 0); 
            Assert.AreEqual(result, true);
        }
        /*
        80	Cafe late	  55	17000	0		
        81	Cafe sua	  55	17000	0		
        85	Cafe den	  55	17000	0	
        90  Cafe sua nong 55    15000   0
        */
        [TestMethod]
        public void updateFoodFalse()
        {
            bool result1 = food.updateFoodInDatabase(90, " ", "Không", 55, 15000, 0); // ten null
            Assert.AreEqual(result1, false);
            bool result2 = food.updateFoodInDatabase(90, "Cafe sua nong", "Không", 55, -15000, 0); // gia < 0
            Assert.AreEqual(result2, false);
            bool result3 = food.updateFoodInDatabase(90, "Cafe sua nong", "Không", 55, 15000, -1000); // g gia < 0
            Assert.AreEqual(result3, false);
            bool result4 = food.updateFoodInDatabase(90, "Cafe den", "Không", 55, 15000, 0); // sua ten trung
            Assert.AreEqual(result4, false);
        }
        [TestMethod]
        public void updateFoodTrue()
        {
            bool result = food.updateFoodInDatabase(90, "Cafe sua nong", "Không", 55, 20000, 0); // sua ten trung
            Assert.AreEqual(result, true);
        }
        [TestMethod]
        public void deleteFood()
        {
            bool result = food.deleteFoodInDatabase(90); 
            Assert.AreEqual(result, true);
        }

        /*
           80	Cafe late	  55	17000	0		
           81	Cafe sua	  55	17000	0		
           85	Cafe den	  55	17000	0
         */
    }
}
