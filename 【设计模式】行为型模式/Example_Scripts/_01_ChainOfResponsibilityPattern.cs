/*
 *  设计模式行为型————责任链模式
 * 
 *  意图：{ 使多个对象都有机会处理请求，从而避免请求的发送者和接收者之间的耦合
 *          关系。将这些对象连成一条链，并沿着这条链传递请求，直到有一个对象处
 *          理它为止。}
 *         
 *  动机：{ 1. 在软件构建过程中，一个请求可能被多个对象处理，但是每个请求在运
 *          行时只能有一个接受者，如果显式指定，将必不可少地带来请求发送者与
 *          接受者的紧耦合。
 *         
 *         2. 如何使请求的发送者不需要指定具体的接受者? 让请求的接受者自己在运
 *         行时决定来处理请求，从而使两者解耦。 }
 */

using System;
using System.Collections.Generic;

namespace Ychao.Learn.DesignPatterns.BehaviouralPatterns
{
    class ChainOfResponsibilityPattern
    {
        //-----------------------------------------Logger
        public abstract class AbstractLogger
        {
            public static int INFO = 1;
            public static int DEBUG = 2;
            public static int ERROR = 3;

            protected int level;

            //责任链中的下一个元素
            protected AbstractLogger nextLogger;

            public void setNextLogger(AbstractLogger nextLogger)
            {
                this.nextLogger = nextLogger;
            }
            public void logMessage(int level, string message)
            {
                if (this.level <= level) { write(message); }
                if (nextLogger != null) { nextLogger.logMessage(level, message); }
            }
            abstract protected void write(string message);
        }
        public class ConsoleLogger : AbstractLogger
        {
            public ConsoleLogger(int level)
            {
                this.level = level;
            }
            protected override void write(string message)
            {
                Console.WriteLine("Standard Console::Logger: " + message);
            }
        }
        public class ErrorLogger : AbstractLogger
        {
            public ErrorLogger(int level)
            {
                this.level = level;
            }
            protected override void write(string message)
            {
                Console.WriteLine("Error Console::Logger: " + message);
            }
        }
        public class FileLogger : AbstractLogger
        {

            public FileLogger(int level)
            {
                this.level = level;
            }
            protected override void write(string message)
            {
                Console.WriteLine("File::Logger: " + message);
            }
        }
        //----------------------------------------------ChainOfResponsibilityDemo
        public class ChainOfResponsibilityPatternDemo
        {
            private static AbstractLogger getChainOfLoggers()
            {
                AbstractLogger errorLogger = new ErrorLogger(AbstractLogger.ERROR);
                AbstractLogger fileLogger = new FileLogger(AbstractLogger.DEBUG);
                AbstractLogger consoleLogger = new ConsoleLogger(AbstractLogger.INFO);

                errorLogger.setNextLogger(fileLogger);
                fileLogger.setNextLogger(consoleLogger);

                return errorLogger;
            }
            static void Main(string[] args)
            {
                AbstractLogger loggerChain = getChainOfLoggers();

                loggerChain.logMessage(AbstractLogger.INFO,
                   "This is an information.");

                loggerChain.logMessage(AbstractLogger.DEBUG,
                   "This is an debug level information.");

                loggerChain.logMessage(AbstractLogger.ERROR,
                   "This is an error information.");
            }
        }
    }
}
