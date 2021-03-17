using System;
using System.Collections.Generic;
using System.Text;

namespace _3ConsoleAppAssign.Data
{
     public class PersonSequencer
    {
        //creating fields and methods
        private static int personId = 0;

       public static int getPersonId ()
        {
            return personId;
        }

        public static int nextPersonId()
        {
            
            personId++; 
            
            return personId;

        }


        public static void reset()

        {
            personId = 0;

        }

        
       

        
   

     //    



        }
        
    
}
