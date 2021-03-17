using System;
using Xunit;
using _3ConsoleApp.Test.modell;

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
        


        

        
           

       

    }




  

}
