using System;
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
        public static string EmailVazio = "O campo E-mail não pode estar vazio. ";
        public static string SenhaVazio = "O campo Senha não pode estar vazio. ";
        public static string EmailInvalido = "O campo E-mail não é válido. ";
        public static string NomeInvalido = "Nome esta vazio ou não é válido.";
        public static string DatasInvalidas = "Data de término não pode ser anterior a data de inicio.";
    }
}
