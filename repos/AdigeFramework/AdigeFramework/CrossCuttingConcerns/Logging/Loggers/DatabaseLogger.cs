﻿using AdigeFramework.CrossCuttingConcerns.Logging.Log4Net;
using log4net;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdigeFramework.CrossCuttingConcerns.Logging.Loggers
{
   public class DatabaseLogger:LoggerService
    {
        public DatabaseLogger():base(LogManager.GetLogger("DatabaseLogger"))
        {

        }
    }
}
