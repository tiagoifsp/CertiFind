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

        public static string EmailVazio = "O campo E-mail não pode estar vazio.";
        public static string SenhaVazio = "O campo Senha não pode estar vazio.";
        public static string EmailInvalido = "O campo E-mail excedeu o limite máximo permitido de 100 (cem) caracteres..";
        public static string UsuarioInexistente = "Usuário Inválido.";
        public static string NomeInvalido = "O nome do usuário excedeu o limite máximo permitido de 100 (cem) caracteres.";
        public static string NomeVazio = "O campo nome não pode estar vazio.";
        public static string SituacaoInvalida = "Nenhum valor de Situação selecionado.";
        public static string TipodeUsuarioInvalido = "Nenhum valor de Tipo de Usuário selecionado.";
        public static string DescricaoVazia = " O Campo Descrição esta vazio!";


        public static string DatasInvalidas = "Data de término não pode ser anterior a data de inicio.";

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

        public static string CampoNomeDuplicado = "Campo nome já existe.";

        //Backup
        public static string CaminhoBackupNoaExiste = "O caminho para a pasta do Backup não existe.";


        public static string CampoNomeDuplicado2 = "Campo nome já existe";
        public static string CampoChaveEstrangeira = "Impossível excluir. Campo sendo usado no cadastro de Relacionamento";

        //Atividade
        public static string AtividadeNull = "Campo(s) inválido(s)";
        public static string AtividadeNome = "Campo nome inválido";
        public static string AtividadeNomeDuplicado = "Campo nome já existe";
        public static string AtividadeChaveEstrangeira = "Impossível excluir. Tipo de atividade sendo usado no cadastro de Relacionamento";

        //Tipo Atividade Campo
        public static string AtividadeCampoNull = "Campo(s) inválido(s)";
        public static string AtividadeCampoCampo = "Campo campo inválido";
        public static string AtividadeCampoTipoAtividade = "Campo tipo de atividade inválido";
        public static string AtividadeCampoTamanho = "Campo tamanho inválido";
        public static string AtividadeCampoValorInicial = "Campo valor inicial inválido";
        public static string AtividadeCampoValorFinal = "Campo valor final inválido";
        public static string AtividadeCampoDuplicado = "Campos duplicados";

        //Cerificado
        public static string CertificadoCampoNull = "Campo(s) inválido(s)";
        public static string CertificadoCampoTipoAtividade = "Campo tipo de atividade inválido";
        public static string CertificadoCampoUsuario = "Campo usuário inválido";



    }
}
