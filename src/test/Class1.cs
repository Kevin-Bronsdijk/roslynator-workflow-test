using System;

namespace test
{
    public class Class1
    {
        public void Main()
        {
            // code smells
            var x = 1; // not used
            
            if (x == x) // always true
                Console.WriteLine("..."); // RCS1007
        }
        
        public void Foo()
        {
            ; // RCS1038
        }
    }
}