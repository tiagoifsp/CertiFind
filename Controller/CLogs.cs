﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Controller
{
    public static class CLogs
    {
        public static void Log(Exception ex)
        {    
            StreamWriter file = File.AppendText(@"E:\arquivo");

            file.WriteLine("\n");
            file.WriteLine(DateTime.Now);
            file.WriteLine(ex.Message.ToString());
            file.WriteLine(ex.TargetSite.ToString());
            file.WriteLine(ex.HResult.ToString());

            file.Close();
        }
    }
}