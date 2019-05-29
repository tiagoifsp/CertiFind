﻿using DAL;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controller
{
    public static class CSugestao
    {
        public static void EnviarSugestao(MSugestao sugestao)
        {
            try
            {
                DSugestao.EnviarSugestao(sugestao);
            }
            catch
            {
                throw new Exception();
            }
        }
    }
}
