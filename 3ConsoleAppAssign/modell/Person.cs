using System;
using System.Collections.Generic;
using System.Text;

namespace _3ConsoleApp.Test.modell
{
    public class Person
    {//creating person fields
        private int personId;
        private string firstName;

        public string Firstname
        {
            get { return firstName; }   // get method
            set
            {
                if (value != null && value.Length > 0)
                {
                    firstName = value;
                }
            }
        }
        private string lastName;

        public string LastName
        {
            get { return lastName; }   // get method
            set { if (value != null && value.Length > 0 ) {
                    lastName = value;
                } } 
        }
        public int height;//default assigned 0
        public int weight;
        private string colour;
        public string status;



        //Making a Constructor
        public Person(string firsName, string lastNam1e)
        {
             firstName = firsName;
             lastName = lastNam1e;
        }

        public string getLastName ()
        {
            return lastName;
        }
        public string GetFullName()
        {
            return $"{firstName} {lastName}"; 
        }
       
            
           
        }


    }
    enum status
    {
        married,
        single,
        divorcec,
        seperated,
    }


    





    

