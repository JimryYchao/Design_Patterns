using System;

namespace DesignPatterns_For_CSharp.Behavioral_Patterns.ChainOfResponsibility
{
    public class ChainOfResponsibilityPatternDemo
    {
        public static void Enter()
        {
            LoggerHandler Logger = new Client().GetLoggers();
            Console.WriteLine(Logger.Level);
            Logger.Log(2, "This is a warning log");
        }
    }
}