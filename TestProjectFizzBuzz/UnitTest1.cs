using System.Runtime.CompilerServices;
using ConsoleAppTDDFizzBuzz2;

namespace TestProjectFizzBuzz
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Given_Number_When_FizzBuzzPourUnNombre_Then_Return_Nombre_In_String()
        {
            //Arrange 
            int nombre = 1;
            string retour ;
            //Act
            retour = ConsoleAppTDDFizzBuzz2.Program.FizzBuzzPourUnNombre(nombre);
            //Assert
            Assert.AreEqual("1", retour);
        }

        [TestMethod]
        public void Given_Number_3_When_FizzBuzzPourUnNombre_Then_Return_Fizz()
        {
            //Arrange 
            int nombre = 3;
            string retour ;
            //Act
            retour = ConsoleAppTDDFizzBuzz2.Program.FizzBuzzPourUnNombre(nombre);
            //Assert
            Assert.AreEqual("Fizz", retour);
        }

        [TestMethod]
        public void Given_Number_6_When_FizzBuzzPourUnNombre_Then_Return_Fizz()
        {
            //Arrange 
            int nombre = 6;
            string retour ;
            //Act
            retour = ConsoleAppTDDFizzBuzz2.Program.FizzBuzzPourUnNombre(nombre);
            //Assert
            Assert.AreEqual("Fizz", retour);
        }

        [TestMethod]
        public void Given_Number_5_When_FizzBuzzPourUnNombre_Then_Return_Buzz()
        {
            //Arrange 
            int nombre = 5;
            string retour ;
            //Act
            retour = ConsoleAppTDDFizzBuzz2.Program.FizzBuzzPourUnNombre(nombre);
            //Assert
            Assert.AreEqual("Buzz", retour);
        }

        [TestMethod]
        public void Given_Number_10_When_FizzBuzzPourUnNombre_Then_Return_Buzz()
        {
            //Arrange 
            int nombre = 10;
            string retour ;
            //Act
            retour = ConsoleAppTDDFizzBuzz2.Program.FizzBuzzPourUnNombre(nombre);
            //Assert
            Assert.AreEqual("Buzz", retour);
        }

        [TestMethod]
        public void Given_Number_15_When_FizzBuzzPourUnNombre_Then_Return_FizzBuzz()
        {
            //Arrange 
            int nombre = 15;
            string retour ;
            //Act
            retour = ConsoleAppTDDFizzBuzz2.Program.FizzBuzzPourUnNombre(nombre);
            //Assert
            Assert.AreEqual("FizzBuzz", retour);
        }

        [TestMethod]
        public void Given_Number_30_When_FizzBuzzPourUnNombre_Then_Return_FizzBuzz()
        {
            //Arrange 
            int nombre = 30;
            string retour ;
            //Act
            retour = ConsoleAppTDDFizzBuzz2.Program.FizzBuzzPourUnNombre(nombre);
            //Assert
            Assert.AreEqual("FizzBuzz", retour);
        }

        [TestMethod]
        public void Given_Number_0_When_FizzBuzzPourUnNombre_Then_Return_FizzBuzz()
        {
            //Arrange 
            int nombre = 0;
            string retour ;
            //Act
            retour = ConsoleAppTDDFizzBuzz2.Program.FizzBuzzPourUnNombre(nombre);
            //Assert
            Assert.AreEqual("0", retour);
        }
    }
}