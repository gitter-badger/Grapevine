﻿using System;
using System.Net;

namespace Grapevine.Util
{
    public interface IGrapevineLogger
    {
        void Trace(object obj);
        void Trace(string message);
        void Trace(string message, Exception ex);

        void Debug(object obj);
        void Debug(string message);
        void Debug(string message, Exception ex);

        void Info(object obj);
        void Info(string message);
        void Info(string message, Exception ex);

        void Warn(object obj);
        void Warn(string message);
        void Warn(string message, Exception ex);

        void Error(object obj);
        void Error(string message);
        void Error(string message, Exception ex);

        void Fatal(object obj);
        void Fatal(string message);
        void Fatal(string message, Exception ex);
    }

    public class ConsoleLogger : IGrapevineLogger
    {
        private readonly LogLevel _level;

        private static string RightNow => DateTime.Now.ToString(@"M/d/yyyy hh:mm:ss tt");

        public ConsoleLogger(LogLevel level = LogLevel.Debug)
        {
            _level = level;
        }

        public void Trace(object obj)
        {
            Trace(obj.ToString());
        }

        public void Trace(string message)
        {
            if (LogLevel.Trace > _level) return;
            Console.WriteLine($"{RightNow}\tTRACE\t{message}");
        }

        public void Trace(string message, Exception ex)
        {
            Trace($"{message}:{ex.Message}\r\n{ex.StackTrace}");
        }

        public void Debug(object obj)
        {
            Debug(obj.ToString());
        }

        public void Debug(string message)
        {
            if (LogLevel.Debug > _level) return;
            Console.WriteLine($"{RightNow}\tDEBUG\t{message}");
        }

        public void Debug(string message, Exception ex)
        {
            Debug($"{message}:{ex.Message}\r\n{ex.StackTrace}");
        }

        public void Info(object obj)
        {
            Info(obj.ToString());
        }

        public void Info(string message)
        {
            if (LogLevel.Info > _level) return;
            Console.WriteLine($"{RightNow}\tINFO\t{message}");
        }

        public void Info(string message, Exception ex)
        {
            Info($"{message}:{ex.Message}\r\n{ex.StackTrace}");
        }

        public void Warn(object obj)
        {
            Warn(obj.ToString());
        }

        public void Warn(string message)
        {
            if (LogLevel.Warn > _level) return;
            Console.WriteLine($"{RightNow}\tWARN\t{message}");
        }

        public void Warn(string message, Exception ex)
        {
            Warn($"{message}:{ex.Message}\r\n{ex.StackTrace}");
        }

        public void Error(object obj)
        {
            Error(obj.ToString());
        }

        public void Error(string message)
        {
            if (LogLevel.Error > _level) return;
            Console.WriteLine($"{RightNow}\tERROR\t{message}");
        }

        public void Error(string message, Exception ex)
        {
            Error($"{message}:{ex.Message}\r\n{ex.StackTrace}");
        }

        public void Fatal(object obj)
        {
            Fatal(obj.ToString());
        }

        public void Fatal(string message)
        {
            if (LogLevel.Fatal > _level) return;
            Console.WriteLine($"{RightNow}\tFATAL\t{message}");
        }

        public void Fatal(string message, Exception ex)
        {
            Fatal($"{message}:{ex.Message}\r\n{ex.StackTrace}");
        }
    }

    public enum LogLevel
    {
        Trace = 5,
        Debug = 4,
        Info = 3,
        Warn = 2,
        Error = 1,
        Fatal = 0
    }
}
