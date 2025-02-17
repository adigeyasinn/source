﻿using log4net.Core;
using log4net.Layout;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdigeFramework.CrossCuttingConcerns.Logging.Log4Net.Layout
{
    public class JsonLayout : LayoutSkeleton
    {
        public override void ActivateOptions()
        {
        }

        public override void Format(TextWriter writer, LoggingEvent loggingEvent)
        {
            var logEvent = new SeriAlizableLogEvent(loggingEvent);
            var json = JsonConvert.SerializeObject(logEvent,Formatting.Indented);
            writer.WriteLine(json);

            //Burada Log eventini Jsona çevirdik ve writera yazmış olduk
        }

    }
}
