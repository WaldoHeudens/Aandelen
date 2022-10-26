using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Les_8_3
{
    internal class Logger
    {
        delegate void LogDelegate(string bericht);

        //public void UpdateLog()
        //{
        //    LogDelegate del = new LogDelegate(Log);
        //    del("Laatste update: " + DateTime.Now.ToString());
        //}

        //void Log (string iets)
        //{
        //    File.AppendAllText(@"C:\Test.txt", iets + Environment.NewLine);
        //}

        // Dit is hetzelfde als:

        public void UpdateLog()
        {
            LogDelegate del = delegate (string bericht)
                                {
                                    File.AppendAllText(@"C:\Test.txt", bericht + Environment.NewLine);
                                };
            del("Laatste update: " + DateTime.Now.ToString());
        }


    }
}
