using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace News.MyUtilities
{
    public interface ILogger
    {
        void Init();
        void LogEvent(LogItem item);
        void LogError(LogItem item);
        void LogException(LogItem item);
        void LogCheckHouseKeeping();
    }

}
