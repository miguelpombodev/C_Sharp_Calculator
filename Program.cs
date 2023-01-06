using System;

namespace Name
{
    class Program {
        static void Main(string[] args) {
            MenuApp();
        }

        static void MenuApp() {
            try
            {
                short option;

                Console.Clear();
                Console.WriteLine("Be welcomed!");
                Console.WriteLine("What is your request?");
                Console.WriteLine("1 - Addition");
                Console.WriteLine("2 - Subtraction");
                Console.WriteLine("3 - Division");
                Console.WriteLine("4 - Multiplication");
                Console.WriteLine("5 - Exit Calculator");

                Console.WriteLine("------------------------");
                Console.WriteLine("Selection your option");

                option = short.Parse(Console.ReadLine());  

                switch(option) {
                    case 1: Add(); break;
                    case 2: Subtraction(); break;
                    case 3: Division(); break;
                    case 4: Multiplication(); break;
                    case 5: System.Environment.Exit(0); break;
                    default: MenuApp(); break;
                } 

            }
            catch (System.Exception)
            {                
                MenuApp();
            }
        }

        static void Add(){
            List<float> valuesList = _getValues();
            float result = 0;

            Console.WriteLine("");

            foreach(float value in valuesList) {
                result += value;
            }

            Console.WriteLine($"The result is {result}");            
        }

        static void Subtraction() {
            List<float> valuesList = _getValues();
            float result = 0;

            Console.WriteLine("");

            foreach(float value in valuesList) {
                result -= value;
            }

            Console.WriteLine($"The result is {result}");            
        }

        static void Division() {
            try
            {
                List<float> valuesList = _getValues();
                float? result = null;

                Console.WriteLine("");

                foreach(float value in valuesList) {
                    if(result == null) {
                        result = value;
                    } else {
                        result /= value;
                    }
                }

                if (result == float.NaN) {
                    throw new Exception("Value cannot be divided by zero or has unexpected value");
                }

                Console.WriteLine($"The result is {result}");    
            }
            catch (System.Exception e)
            {
                
                throw e;
            }
            
        }

        static void Multiplication() {
            List<float> valuesList = _getValues();
            float? result = null;

            Console.WriteLine("");

            foreach(float value in valuesList) {
                if(result == null) {
                    result = value;
                } else {
                    result *= value;
                }
            }

            Console.WriteLine($"The result is {result}");      
        }

        static private List<float> _getValues() {
            float value1;
            float value2;
            List<float> list = new List<float>();

            Console.Clear();
            Console.WriteLine("First value: ");

            value1 = float.Parse(Console.ReadLine());

            list.Add(value1);

            Console.WriteLine("Second value: ");
            value2 = float.Parse(Console.ReadLine());

            list.Add(value2);

            return list;
        }
    }    
}