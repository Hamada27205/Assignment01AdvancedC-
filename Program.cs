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

            #region Q10

            //Printer<Student> printer = new Printer<Student>();
            //printer.Printt(new Student());

            //Printer<Article> printer2 = new Printer<Article>();
            //printer2.Printt(new Article());

            #endregion

            #region Q11

            //Baseclass b = new Baseclass();

            //b.Name = "Ahmed";

            //Cclass<Baseclass> C1 = new Cclass<Baseclass>();

            //C1.Add(b);

            #endregion

            #region Q12

            // Multiple constraints can be applied to a generic type by separating them with commas after the where keyword.
            // And I create a `MyClass` object to see how it works


            #endregion

            #region Q13

            // The `default` keyword returns the default value of the generic type T
            //Test<int> test1 = new Test<int>();

            //Console.WriteLine(test1.GetDefault());

            #endregion

            #region Q14

            //SafeList<int> list = new SafeList<int>();
            //list.Add(10);
            //list.Add(20);
            //list.Add(30);
            //list.Add(40);

            //Console.WriteLine(list.Get(0));  
            //Console.WriteLine(list.Get(5));  

            #endregion

            #region Q15

            // Covariance allows you to use a more derived type where a base type is expected

            //IProducer<Dog> dogProducer = new DogProduce();

            //Dog dog = dogProducer.Get();

            //Console.WriteLine(dog.Name);

            //IProducer<Dog> dogProducer = new DogProduce();

            //IProducer<Animal> animalProducer = dogProducer;

            //Animal animal = animalProducer.Get();

            //Console.WriteLine(animal.Name);

            #endregion

            #region Q16

            //A generic type with a base type can be assigned to a generic type with a derived type
            //IConsumer<Animal> animalConsumer = new AnimalConsumer();

            //IConsumer<Dog> dogConsumer = animalConsumer;

            //Dog dog = new Dog();
            //dog.Name = "Buddy";

            //dogConsumer.Consume(dog);

            #endregion

            #region Q17

            //Covariance uses the out keyword and allows a generic type with a derived type to be assigned to a generic type with a base type

            //Contravariance uses the in keyword and allows a generic type with a base type to be assigned to a generic type with a derived type



            #endregion

            #region Q18

            // Static members in generic types are shared for the same type, but each different type has its own static member
            //Counter<int> c1 = new Counter<int>();
            //Counter<int> c2 = new Counter<int>();

            //Console.WriteLine(Counter<int>.Count);

            #endregion

            #region Q19

            // A class can inherit from a generic class by specifying the type argument or by keeping the derived class generic

            //Child child = new Child();

            //child.Value = 10;

            //Console.WriteLine(child.Value);

            #endregion

        }
    }
}
