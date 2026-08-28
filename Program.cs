using Assignment01AdvancedC_.GenericConstraints;
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

            #region Q4

            //int a = 1;
            //int b = 2;
            //Swapp.Swap(ref  a, ref  b);
            //Console.WriteLine(a);
            //Console.WriteLine(b);

            #endregion

            #region Q5

            //int S1 = Swapp.FindMax(20, 10);
            //Console.WriteLine(S1);

            #endregion

            #region Q6

            //IRepository<User> R1 = new UserRepository();
            //R1.Add(new User(2 , "Ahmed"));
            //Console.WriteLine(R1.Get(2));

            #endregion

            #region Q7

            //Accessible Bec this value type Only
            //Person<int>  P1 = new Person<int>(2);
            //Console.WriteLine(P1.Value);

            //Person<double>  P2 = new Person<double>(3.14);
            //Console.WriteLine(P2.Value);

            #endregion

            #region Q8

            // Accessible reference type only
            //Inventory<string> I1 = new Inventory<string>("Ahmed");
            //Console.WriteLine(I1.Value);

            #endregion

            #region Q9

            //Factory<Student> factory = new Factory<Student>();

            //Student s = factory.GetValue();

            //Console.WriteLine(s.Name);

            #endregion

        }
    }
}
