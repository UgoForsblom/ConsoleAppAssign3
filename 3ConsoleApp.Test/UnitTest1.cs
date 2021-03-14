using System;
using Xunit;
using _3ConsoleApp.Test.modell;

namespace _3ConsoleApp.Test
{
    public class UnitTest1
    {
        
        [Fact]
        public void TestPersons()
        {

            //Arrange
         string firstName = "Findlay";
         string lastName = "forsblom";

            //Act
            Person person = new Person(firstName, lastName);

            //Assert
            Assert.Equal(firstName, person.Firstname);
            Assert.Equal("", person.LastName);

        }
        
           

       

    }




    //Act
//    Person person = new Person("Ugo", "Forsblom");


       

////Assert
//{
//    Assert.GetFullName("Ada");
//}

}
