//In the code given below, The class Complex is a part of internalAccessModifier namespace and is accessible throughout it.
// C# Program to show use of 
// internal access modifier 
// Inside the file Program.cs 

namespace internalAccessModifier
{
    // Driver Class
    static class Program
    {
        // Main Method 
        static void Main(string[] args)
        {
            // Instantiate the class Complex 
            // in separate class but within  
            // the same assembly 
            Complex c = new Complex();

            // Accessible in class Program 
            c.setData(2, 1);
            c.displayData();
        }
    }
}
