using MyBlog.Business.Abstract;
using NLog;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyBlog.Business.Concrete
{
    public class NlogAdapter : INlogAdapter
    {
        public void Logla(string mesaj)
        {
            var log=LogManager.GetLogger("Logger");
            log.Log(LogLevel.Error, mesaj);
        }
    }
}
