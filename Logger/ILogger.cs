using System;
namespace Logger
{
    public interface ILogger
    {
        void Debug(string _className, string _message);
        void Error(string _className, string _message);
    }
}