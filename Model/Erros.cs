﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    /// <summary>
    /// Classe contendo as possíveis mensagens de erro do sistema
    /// </summary>
    public static class Erros
    {
        public static string ErroGeral = "O sistema se comportou de maneira inesperada.";
        public static string ErroFalhaConexaoSGBD = "Falha na conexão com o SGBD.";
        public static string ErroTipoDeDado = "Tipo de dados inválido";
    }
}
