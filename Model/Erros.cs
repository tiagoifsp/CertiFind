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
    }
}
