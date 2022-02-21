namespace DesignPatterns_For_CSharp.Behavioral_Patterns.ChainOfResponsibility
{
    public class Client
    {
        public LoggerHandler GetLoggers()
        {
            LoggerHandler logger = new ConsoleLogger(1).SetSupHandler(new WarningLogger(2)).SetSupHandler(new ErrorLogger(3));
            return logger;
        }
    }
}
