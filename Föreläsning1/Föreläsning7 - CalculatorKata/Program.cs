using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;


namespace Föreläsning7___CalculatorKata
{
    public class Program
    {
        static void Main(string[] args)
        {
        }

        public int Add(string numbers)
        {

            if (numbers.Length > 3)
            {
                var numbersInString = numbers.Split(',');
                var sum = 0;
                for (int i = 0; i < numbersInString.Length; i++)
                {
                    sum += int.Parse(numbersInString[i]);
                }
                return sum;
            }

            return Result(numbers);
        }

        private static int Result(string numbers)
        {
            if (numbers.Length >= 0 && numbers.Length <= 3)
            {
                if (string.IsNullOrEmpty(numbers))
                {
                    return 0;
                }
                else if (numbers.Length == 1)
                {
                    return int.Parse(numbers);
                }
                else if (numbers.Length == 3)
                {
                    var numbersInString = numbers.Split(','); //"1,2" > "1", "2" 
                    int result = int.Parse(numbersInString[0]) + int.Parse(numbersInString[1]);
                    return result;
                }
            }
            throw new Exception("You can only input numbers between 0 and 2");
        }

        [TestFixture]
        public class CalcualtorTest
        {
            [Test]
            public void CorrectNumber()
            {
                //Arrange
                Program correctNumber = new Program();

                //Act
                var actual = correctNumber.Add("1");
                var expected = 1;

                //Assert
                Assert.That(actual, Is.EqualTo(expected));
            }

            [Test]
            public void IncorrectNumber()
            {
                //Arrange
                Program incorrectNumber = new Program();

                //Act
                var actual = incorrectNumber.Add("1,2");
                var expected = 3;

                //Assert
                Assert.That(actual, Is.EqualTo(expected));
            }

            [Test]
            public void NullNumber()
            {
                //Arrange
                Program nullNumber = new Program();

                //Act
                var actual = nullNumber.Add("0");
                var expected = "";

                //Assert
                Assert.That(actual, Is.EqualTo(expected));
            }

            [Test]
            public void NumbersMoreThanThree()
            {
                //Arrange
                Program numberMoreThanThree = new Program();

                //Act
                var actual = numberMoreThanThree.Add("1,2,3");
                var expected = "4";

                //Assert
                Assert.That(actual, Is.EqualTo(expected));
            }
        }
    }
}
