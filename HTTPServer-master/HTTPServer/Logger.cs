﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;


namespace HTTPServer
{
    class Logger
    {
        static StreamWriter sr = new StreamWriter("log.txt");
        public static void LogException(Exception ex)
        {


            LockManager.GetLock("log.txt", () =>
            {
                DateTime now = DateTime.Now;
                sr.WriteLine(now.ToString() + ": " + ex.Message);
                sr.Flush();
            });


        }


    }
}
