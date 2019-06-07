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
        public static string ErroFalhaConexaoSGBD = "Falha na conexão com o SGBD.";

        //Tipo de dado
        public static string TipoDadoNull = "Campo(s) inválido(s)";
        public static string TipoDadoNome = "Campo nome inválido";
        public static string TipoDadoDescricao = "Campo descrição inválido";
        public static string TipoDadoNomeDuplicado = "Campo nome já existe";
        public static string TipoDadoChaveEstrangeira = "Impossível excluir. Tipo de dando sendo usado no cadastro de Campo";

        //Campo
        public static string CampoNull = "Campo(s) inválido(s)";
        public static string CampoNome = "Campo nome inválido";
        public static string CampoTipoDado = "Campo tipo de dado inválido";
        public static string CampoNomeDuplicado = "Campo nome já existe";

        //Tipo Atividade Campo
        public static string AtividadeCampoCampo = "Campo campo inválido";
        public static string AtividadeCampoTipoAtividade = "Campo tipo de atividade inválido";
        public static string AtividadeCampoTamanho = "Campo tamanho inválido";
        public static string AtividadeCampoValorInicial = "Campo valor inicial inválido";
        public static string AtividadeCampoValorFinal = "Campo valor final inválido";

    }
}
