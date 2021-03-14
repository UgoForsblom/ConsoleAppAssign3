using System;
using System.Collections.Generic;
using System.Text;

namespace _3ConsoleApp.Test.modell
{
    class ToDo
    {
        private int ToDoId;
        private string description;
        private bool done;
        private string assignee;

        public int getTodId ()
        {
            return ToDoId;
        }

        public string getDescription ()
        {
            return description;
        }

        public void setDescription(string value)
        {
            description = value;

        }



        //Making a constructor
        //public ToDo()
        //ToDo int = 0;
        //string description = "Tall";
    }
}

