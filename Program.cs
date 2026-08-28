using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Assignment01AdvancedC_
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Q1 

            //A generic class is a class that uses type parameters to work with different data types. ---- Generics provide code reusability, type safety, and reduce the need for casting

            #endregion

            #region Q2

            //Container<int> C1 = new Container<int>();
            //C1.Add(1);
            //Console.WriteLine(C1.Get());

            //Container<string> C1 = new Container<string>();
            //C1.Add("Ahmed");
            //Console.WriteLine(C1.Get());

            #endregion

            #region Q3

            // Generic Class Can Have More Than One Type Parameter

            //Pair<int, string> pair = new Pair<int, string>(1, "Ahmed");

            //Console.WriteLine(pair.Value);
            //Console.WriteLine(pair.Key);

            #endregion

        }
    }
}
