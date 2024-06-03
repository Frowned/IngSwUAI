using BE.Base;

namespace BE.Entities
{
    public class Log : BaseEntity
    {
        public string Message { get; set; }
        public LogType Type { get; set; }

    }

    public enum LogType
    {
        Info,
        Warning,
        Error,
        Critical
    }
}
