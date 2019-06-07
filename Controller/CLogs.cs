using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;

namespace Controller
{
    public static class CLogs
    {
        public static void Log(Exception ex, MUsuario usuario)
        {    
            StreamWriter file = File.AppendText(@"E:\LogsCertifind");

            file.WriteLine("\n");

            if(usuario != null)
                file.WriteLine(usuario.Nome + " (" + usuario.ID + ")");
            else
                file.WriteLine("Sem usuário");
            file.WriteLine(DateTime.Now);
            file.WriteLine(ex.Message.ToString());
            file.WriteLine(ex.TargetSite.ToString());
            file.WriteLine(ex.HResult.ToString());

            file.WriteLine(ex.StackTrace.ToString());
            file.WriteLine(ex.GetType().FullName.ToString());
            file = ExpectionRecursiva(ex, file);

            file.Close();
        }

        private static StreamWriter ExpectionRecursiva(Exception ex, StreamWriter file)
        {
            if (ex.InnerException != null)
            {
                file.WriteLine(ex.InnerException.ToString());
                file = ExpectionRecursiva(ex, file);
            }

            return file;
        }
    }
}
