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
        public static string ErroFalhaConexaoSGBD = "Falha na conexão com o SGBD.";

        //Tipo dado
        public static string ErroTipoDadoNull = "Campo(s) inválido(s)";
        public static string ErroTipoDadoNome = "Campo nome inválido";
        public static string ErroTipoDadoDescricao = "Campo descrição inválido";
        public static string ErroTipoDadoNomeDuplicado = "Campo nome já existe.";
        public static string ErroTipoDadoChaveEstrangeira = "Impossível excluir. Tipo de dando sendo usado no cadastro de Campo.";

        //Campo
        public static string ErroCampoNull = "Campo(s) inválido(s)";
        public static string ErroCampoNome = "Campo nome inválido";
        public static string ErroCampoTipoDado = "Campo tipo de dado inválido";
        public static string ErroCampoNomeDuplicado = "Campo nome já existe.";
    }
}
