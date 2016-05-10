using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework.Internal;
using NUnit.Framework;

namespace Daisy
{
    public class Program
    {
        static void Main(string[] args)
        {
        }

        public int Add(int a, int b)
        {
            return a + b;
            //return 9;
        }

        [TestFixture]
        public class ProgramTest  //Detta ska egentligen ligga i helt separata projekt
        {
            [Test]
            public void AddRight()
            {
                //arrange
                var prog = new Program();

                //act
                var actual = prog.Add(3, 4);
                var expected = 7;

                //assert
                Assert.That(actual, Is.EqualTo(expected));
            }

            [Test]
            public void AddWrong()
            {
                //arrange
                var prog = new Program();

                //act
                var actual = prog.Add(5, 4);
                var expected = 7;

                //assert
                Assert.That(actual, Is.Not.EqualTo(expected));

            }
        }
    }
}
