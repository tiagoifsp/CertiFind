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

        //Tipo dado
        public static string ErroTipoDadoNull = "Campo(s) inválido(s)";
        public static string ErroTipoDadoNome = "Campo nome inválido";
        public static string ErroTipoDadoDescricao = "Campo descrição inválido";
    }
}
