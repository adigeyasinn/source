using log4net.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdigeFramework.CrossCuttingConcerns.Logging.Log4Net
{
    public class SeriAlizableLogEvent
    {
        private LoggingEvent _loggingEvent;
        public SeriAlizableLogEvent(LoggingEvent loggingEvent)
        {
            _loggingEvent = loggingEvent;
        }
        public string UserName => _loggingEvent.UserName;
        public object MessageObject => _loggingEvent.MessageObject;
    }
}
