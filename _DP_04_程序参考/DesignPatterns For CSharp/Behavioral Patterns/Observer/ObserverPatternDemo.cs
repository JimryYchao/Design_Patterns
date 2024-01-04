using System;

namespace DesignPatterns_For_CSharp.Behavioral_Patterns.Observer
{
    public class ObserverPatternDemo
    {
        public static void Enter()
        {
            string name = string.Empty;
            string password = string.Empty;
        label_1:
            Console.WriteLine("Whether or not registered？Input Y/N");
            string YN = Console.ReadLine();
            if (YN == "Y")
            {
            label_2:
                Console.WriteLine("Please input your Account name");
                name = Console.ReadLine();
                if (name == string.Empty || name == null)
                {
                    Console.WriteLine("Input name ERROR");
                    goto label_2;
                }
            label_3:
                Console.WriteLine("Please input your password");
                password = Console.ReadLine();
                if (password == string.Empty || password == null)
                {
                    Console.WriteLine("Input password ERROR");
                    goto label_3;
                }
                Subject.Instance.RegisterAccount(name, password);
                Subject.Instance.Notify();
                goto label_1;
            }
            else if (YN == "N")
            {
            label_4:
                Console.WriteLine("Please input your Account name");
                name = Console.ReadLine();
                if (name == string.Empty || name == null)
                {
                    Console.WriteLine("Input name ERROR");
                    goto label_4;
                }
            label_5:
                Console.WriteLine("Please input your password");
                password = Console.ReadLine();
                if (password == String.Empty || password == null)
                {
                    Console.WriteLine("Input password ERROR");
                    goto label_5;
                }
                Subject.Instance.LoginAccount(name, password);
                Subject.Instance.Notify();
            }
            else
            {
                Console.WriteLine("Input ERROR");
                goto label_1;
            }
        }
    }
}