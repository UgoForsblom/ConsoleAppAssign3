using System;
using System.Collections.Generic;
using System.Text;

namespace _3ConsoleApp.Test.modell
{
    public class ToDo
    {
        private int todoId;
        private string description;
        private bool done;
        private Person assignee;

        public int getTodId()
        {
            return todoId;
        }

        public string getDescription()
        {
            return description;
        }

        public void setDescription(string value)

        {
            description = value;

        }



        //Making a constructor

        public ToDo(int todoId, string description)
        {
            this.todoId = todoId;
            this.description = description;

        }
        public string getDescription(string value)
        {
            return description;
        }
        public string GettodoId(int value)
        {
            return $"{description} {todoId}";


        }

    }

}
