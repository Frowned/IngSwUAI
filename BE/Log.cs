using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class Log
    {
        public int Id { get; set; }
        public string Message { get; set; } 
        public LogType Type { get; set; }
        public string User { get; set; }
        public DateTime CreatedAt { get; set; }
    }

    public enum LogType
    {
        Info,
        Warning,
        Error,
        Critical
    }
}
