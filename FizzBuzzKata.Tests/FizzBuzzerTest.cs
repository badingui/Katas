using System;
using FizzBuzz;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FizzBuzzKata.Tests
{
    [TestClass]
    public class FizzBuzzerTest
    {
        [TestMethod]
        public void Converter_When_Input_1_Return_1()
        {
            //  Arrange
            var fizzBuzzer = new FizzBuzzer();

            //  Act
            var result = fizzBuzzer.Converter(1);

            //  Assert
            Assert.AreEqual(result, "1");
        }

        [TestMethod]
        public void Converter_When_Input_2_Return_2()
        {
            //  Arrange
            var fizzBuzzer = new FizzBuzzer();

            //  Act
            var result = fizzBuzzer.Converter(2);

            //  Assert
            Assert.AreEqual(result, "2");
        }

        [TestMethod]
        public void Converter_When_Input_3_Return_Fizz()
        {
            //  Arrange
            var fizzBuzzer = new FizzBuzzer();

            //  Act
            var result = fizzBuzzer.Converter(3);

            //  Assert
            Assert.AreEqual(result, "Fizz");
        }

        [TestMethod]
        public void Converter_When_Input_6_Return_Fizz()
        {
            //  Arrange
            var fizzBuzzer = new FizzBuzzer();

            //  Act
            var result = fizzBuzzer.Converter(6);

            //  Assert
            Assert.AreEqual(result, "Fizz");
        }

        [TestMethod]
        public void Converter_When_Input_27_Return_Fizz()
        {
            //  Arrange
            var fizzBuzzer = new FizzBuzzer();

            //  Act
            var result = fizzBuzzer.Converter(27);

            //  Assert
            Assert.AreEqual(result, "Fizz");
        }

        [TestMethod]
        public void Converter_When_Input_5_Return_Buzz()
        {
            //  Arrange
            var fizzBuzzer = new FizzBuzzer();

            //  Act
            var result = fizzBuzzer.Converter(5);

            //  Assert
            Assert.AreEqual(result, "Buzz");
        }

        [TestMethod]
        public void Converter_When_Input_25_Return_Buzz()
        {
            //  Arrange
            var fizzBuzzer = new FizzBuzzer();

            //  Act
            var result = fizzBuzzer.Converter(25);

            //  Assert
            Assert.AreEqual(result, "Buzz");
        }

        [TestMethod]
        public void Converter_When_Input_15_Return_FizzBuzz()
        {
            //  Arrange
            var fizzBuzzer = new FizzBuzzer();

            //  Act
            var result = fizzBuzzer.Converter(15);

            //  Assert
            Assert.AreEqual(result, "FizzBuzz");
        }

        [TestMethod]
        public void Converter_When_Input_31_Return_Fizz()
        {
            //  Arrange
            var fizzBuzzer = new FizzBuzzer();

            //  Act
            var result = fizzBuzzer.Converter(31);

            //  Assert
            Assert.AreEqual(result, "Fizz");
        }

        [TestMethod]
        public void Converter_When_Input_51_Return_FizzBuzz()
        {
            //  Arrange
            var fizzBuzzer = new FizzBuzzer();

            //  Act
            var result = fizzBuzzer.Converter(51);

            //  Assert
            Assert.AreEqual(result, "FizzBuzz");
        }

        [TestMethod]
        public void Converter_When_Input_53_Return_Buzz()
        {
            //  Arrange
            var fizzBuzzer = new FizzBuzzer();

            //  Act
            var result = fizzBuzzer.Converter(53);

            //  Assert
            Assert.AreEqual(result, "FizzBuzz");
        }
    }
}
