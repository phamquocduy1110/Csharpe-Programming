using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTest_Exercise1.Test
{
    [TestClass]
    public class PriceTest
    {
        /// <summary>
        /// TC1: Check Tapes input whith 11 elements and Customer is True. The Result is 124
        /// </summary>
        [TestMethod]
        public void CheckPrice_WithTapes11Elements_CutomerIsTrue()
        {
            // Arrange
            PriceTest Price = new PriceTest();
            string[] tapes = new string[11];
            tapes[0] = "10";
            tapes[1] = "15";
            tapes[2] = "5";
            tapes[3] = "10";
            tapes[4] = "5";
            tapes[5] = "20";
            tapes[6] = "15";
            tapes[7] = "25";
            tapes[8] = "30";
            tapes[9] = "15";
            tapes[10] = "5";
            string expectedResult = "124";

            // Action
            string actualResult = Price.CheckPrice(tapes);

            // Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        /// <summary>
        /// TC2: Check Tapes input whith 3 elements and Customer is False. The Result is 27
        /// </summary>
        [TestMethod]
        public void CheckPrice_WithTapes3Elements_CutomerIsFalse()
        {
            // Arrange
            PriceTest Price = new PriceTest();
            string[] tapes = new string[3];
            tapes[0] = "10";
            tapes[1] = "15";
            tapes[2] = "5";
            string expectedResult = "27";

            // Action
            string actualResult = Price.CheckPrice(tapes);

            // Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        /// <summary>
        /// TC3: Check Tapes input whith 6 elements and Customer is True. The Result is 58.5
        /// </summary>
        [TestMethod]
        public void CheckPrice_WithTapes6Elements_CutomerIsTrue()
        {
            // Arrange
            PriceTest Price = new PriceTest();
            string[] tapes = new string[6];
            tapes[0] = "10";
            tapes[1] = "15";
            tapes[2] = "5";
            tapes[3] = "10";
            tapes[4] = "5";
            tapes[5] = "20";
            string expectedResult = "58.5";

            // Action
            string actualResult = Price.CheckPrice(tapes);

            // Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        /// <summary>
        /// TC4: Check Tapes input whith 4 elements and Customer is True. The Result is 40
        /// </summary>
        [TestMethod]
        public void CheckPrice_WithTapes4Elements_CutomerIsTrue()
        {
            // Arrange
            PriceTest Price = new PriceTest();
            string[] tapes = new string[4];
            tapes[0] = "10";
            tapes[1] = "15";
            tapes[2] = "5";
            tapes[3] = "10";
            string expectedResult = "40";

            // Action
            string actualResult = Price.CheckPrice(tapes);

            // Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        /// <summary>
        /// TC5: Check Tapes input whith zero elements and Customer is False. The Result is 0
        /// </summary>
        [TestMethod]
        public void CheckPrice_WithTapesZeroElements_CutomerIsFalse()
        {
            // Arrange
            PriceTest Price = new PriceTest();
            string[] tapes = new string[0];
            string expectedResult = "0";

            // Action
            string actualResult = Price.CheckPrice(tapes);

            // Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        /// <summary>
        /// TC6: Check Tapes input whith 1 elements and Customer is True. The Result is 9
        /// </summary>
        [TestMethod]
        public void CheckPrice_WithTapes1Elements_CutomerIsTrue()
        {
            // Arrange
            PriceTest Price = new PriceTest();
            string[] tapes = new string[1];
            tapes[0] = "10";
            string expectedResult = "9";

            // Action
            string actualResult = Price.CheckPrice(tapes);

            // Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        /// <summary>
        /// TC7: Check Tapes input whith 2 elements and Customer is False. The Result is 22.5
        /// </summary>
        [TestMethod]
        public void CheckPrice_WithTapes2Elements_CutomerIsTrue()
        {
            // Arrange
            PriceTest Price = new PriceTest();
            string[] tapes = new string[2];
            tapes[0] = "10";
            tapes[1] = "15";
            string expectedResult = "22.5";

            // Action
            string actualResult = Price.CheckPrice(tapes);

            // Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        /// <summary>
        /// TC8: Check Tapes input whith 10 elements and Customer is False. The Result is 135
        /// </summary>
        [TestMethod]
        public void CheckPrice_WithTapes10Elements_CutomerIsTrue()
        {
            // Arrange
            PriceTest Price = new PriceTest();
            string[] tapes = new string[10];
            tapes[0] = "10";
            tapes[1] = "15";
            tapes[2] = "5";
            tapes[3] = "10";
            tapes[4] = "5";
            tapes[5] = "20";
            tapes[6] = "15";
            tapes[7] = "25";
            tapes[8] = "30";
            tapes[9] = "15";
            string expectedResult = "135";

            // Action
            string actualResult = Price.CheckPrice(tapes);

            // Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        /// <summary>
        /// TC9: Check Tapes input whith 9 elements and Customer is False. The Result is 121.5
        /// </summary>
        [TestMethod]
        public void CheckPrice_WithTapes9Elements_CutomerIsTrue()
        {
            // Arrange
            PriceTest Price = new PriceTest();
            string[] tapes = new string[9];
            tapes[0] = "10";
            tapes[1] = "15";
            tapes[2] = "5";
            tapes[3] = "10";
            tapes[4] = "5";
            tapes[5] = "20";
            tapes[6] = "15";
            tapes[7] = "25";
            tapes[8] = "30";
            string expectedResult = "121.5";

            // Action
            string actualResult = Price.CheckPrice(tapes);

            // Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        /// <summary>
        /// TC10: Check Tapes input whith 5 elements and Customer is False. The Result is 40.5
        /// </summary>
        [TestMethod]
        public void CheckPrice_WithTapes5Elements_CutomerIsTrue()
        {
            // Arrange
            PriceTest Price = new PriceTest();
            string[] tapes = new string[5];
            tapes[0] = "10";
            tapes[1] = "15";
            tapes[2] = "5";
            tapes[3] = "10";
            tapes[4] = "5";
            string expectedResult = "40.5";

            // Action
            string actualResult = Price.CheckPrice(tapes);

            // Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        /// <summary>
        /// TC11: Check Tapes input whith null elements and Customer is False. The Result is Error Message
        /// </summary>
        [TestMethod]
        public void CheckPrice_WithTapesNullElements_CutomerIsFalse()
        {
            // Arrange
            PriceTest Price = new PriceTest();
            string[] tapes = new string[0];
            tapes[0] = "null";
            string expectedResult = "Error! The array must a integer number";

            // Action
            string actualResult = Price.CheckPrice(tapes);

            // Assert
            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}
