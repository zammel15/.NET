using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classse_et_stucrur
{
    class MyGenericClass<T>
    {
        private T genericMemberVariable;
        public MyGenericClass(T value)

     
        {
            genericMemberVariable = value; 


        }

        public T genericMethod(T genericParametre)
        {
            Console.WriteLine("Parameter type : {0} , value : {1}", typeof(T).ToString(), genericParametre);
            return genericMemberVariable; 

        }

        public T genericProperty { get; set;  } 

    }
}
