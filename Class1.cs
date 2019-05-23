using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AwesomeCalculator;
using NUnit.Framework;

namespace testcaseclass
{
    [TestFixture]
    public class testcaseclass
    {

        class CalcTests
        {
            [Test]
            public void GetAddition_Input4point3and5point9_Returns10point1()           //addition1
            {

                //Arrange 
                double number1 = 4.3; double number2 = 5.9;
                double expectedResult = number1 + number2;
                Calc testCalc = new Calc(number1, number2);

                // Act 
                double actualResult = testCalc.GetAddition();

                //Assert
                Assert.AreEqual(expectedResult, actualResult);
            }
            [Test]
            public void GetAddition_Input0and0_Returnsnegative3point4()                //addition2
            {

                //Arrange
                int number1 = 0; double number2 = 0;

                double expectedResult = number1 + number2;
                Calc testCalc = new Calc(number1, number2);

                // Act
                double actualResult = testCalc.GetAddition();

                //Assert
                Assert.AreEqual(expectedResult, actualResult);
            }
            [Test]
            public void GetAddition_Input0and7point7_Returns7point7()                  //addition3
            {

                //Arrange
                double number1 = 0; double number2 = 7.7;

                double expectedResult = number1 + number2;
                Calc testCalc = new Calc(number1, number2);

                // Act 
                double actualResult = testCalc.GetAddition();

                //Assert 
                Assert.AreEqual(expectedResult, actualResult);
            }
            [Test]
            public void GetSubtraction_Input2point4and2point4_Returns0()                //subtraction1
            {

                //Arrange
                double number1 = 2.4; double number2 = 2.4;

                double expectedResult = number1 + number2;
                Calc testCalc = new Calc(number1, number2);

                // Act
                double actualResult = testCalc.GetAddition();

                //Assert
                Assert.AreEqual(expectedResult, actualResult);
            }



            [Test]
            public void GetSubtraction_Input0and0_Returns0()                         //subtraction2
            {

                //Arrange
                double number1 = 0; double number2 = 0;

                double expectedResult = number1 + number2;
                Calc testCalc = new Calc(number1, number2);

                // Act
                double actualResult = testCalc.GetAddition();

                //Assert
                Assert.AreEqual(expectedResult, actualResult);
            }


            [Test]
            public void GetSubtraction_Inputnegative1point4and5point5_Returns6point9()  //subtraction3
            {

                //Arrange 
                double number1 = -1.4; double number2 = 5.5;

                double expectedResult = number1 + number2;
                Calc testCalc = new Calc(number1, number2);

                // Act 
                double actualResult = testCalc.GetAddition();

                //Assert
                Assert.AreEqual(expectedResult, actualResult);
            }

            [Test]
            public void GetMultiplication_Input2and2_Returns4()                     //multiplication1
            {

                //Arrange
                int number1 = 2; int number2 = 4;

                int expectedResult = number1 + number2;
                Calc testCalc = new Calc(number1, number2);

                // Act 
                double actualResult = testCalc.GetAddition();

                //Assert 
                Assert.AreEqual(expectedResult, actualResult);
            }


            [Test]
            public void GetMultiplication_Input0andnegative5_Returns0()              //multiplication2
            {

                //Arrange 
                int number1 = 0; int number2 = -5;

                int expectedResult = number1 + number2;
                Calc testCalc = new Calc(number1, number2);

                // Act
                double actualResult = testCalc.GetAddition();

                //Assert
                Assert.AreEqual(expectedResult, actualResult);
            }


            [Test]

            public void GetMultiplication_Inputnegative5andnegative4_Returns4()       //multiplication3
            {

                //Arrange 
                int number1 = -2; int number2 = -2;

                int expectedResult = number1 + number2;
                Calc testCalc = new Calc(number1, number2);

                // Act
                double actualResult = testCalc.GetAddition();

                //Assert
                Assert.AreEqual(expectedResult, actualResult);
            }

            [Test]
            public void GetDivision_Input9and3_Returns3()                           //division1
            {

                //Arrange
                int number1 = 9; int number2 = 3;

                int expectedResult = number1 + number2;
                Calc testCalc = new Calc(number1, number2);

                // Act
                double actualResult = testCalc.GetAddition();

                //Assert
                Assert.AreEqual(expectedResult, actualResult);
            }

            [Test]
            public void GetDivision_Input12and2_Returns6()                      //division2
            {

                //Arrange
                int number1 = 12; int number2 = 6;

                int expectedResult = number1 + number2;
                Calc testCalc = new Calc(number1, number2);

                // Act 
                double actualResult = testCalc.GetAddition();

                //Assert
                Assert.AreEqual(expectedResult, actualResult);
            }

            [Test]
            public void GetDivision_Input5and2_Returns2point5()           //division3
            {

                //Arrange 
                int number1 = 5; int number2 = 2;

                int expectedResult = number1 + number2;
                Calc testCalc = new Calc(number1, number2);

                // Act
                double actualResult = testCalc.GetAddition();

                //Assert
                Assert.AreEqual(expectedResult, actualResult);
            }
        }
    }
}
                                    