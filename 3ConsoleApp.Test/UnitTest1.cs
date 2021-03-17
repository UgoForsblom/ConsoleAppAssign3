using System;
using Xunit;
using _3ConsoleApp.Test.modell;
using _3ConsoleAppAssign.Data;

namespace _3ConsoleApp.Test
{
    public class UnitTest1
    {

        [Fact]
        public void TestToDo()
        {

            //Arrange
            string description = "Tall";
            int todoId= 0;

            //Act
            ToDo todo= new ToDo(todoId, description);

            //Assert
            Assert.Equal(description, todo.getDescription());
            Assert.Equal(todoId, todo.getTodId());

        }
        [Fact]
        public void TestPersonSequencer()
        {
            //Arrange
            int expectedNesxpersonId = 1;

            Assert.Equal(expectedNesxpersonId, PersonSequencer.nextPersonId());
            PersonSequencer.reset();
            Assert.Equal(0, PersonSequencer.getPersonId());

            //Assert



        }



    }






}
