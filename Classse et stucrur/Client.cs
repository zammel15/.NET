using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Classse_et_stucrur
{
    class Client
    {

        private static  int nbClient = 0 ; 
      public   int id;
        public String name;
        
            

        public Client( String name = "inconue")
        {
            id = ++nbClient;
            this.name = name; 
        }
        
        public Client()
        {
            id = ++nbClient;
            name = "inconue"; 
        }
        public void print()
        {

            Console.WriteLine("id = {0} name = {1}", id, name);
        }

        ~Client()
        {

            Console.WriteLine("afficher "); 
        }
        
       public void CalculClient()
          {
            Console.WriteLine("id = {0} name = {1}", id, name);
          }

    }
}
