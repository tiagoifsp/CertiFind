using DAL;
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
                throw new ExcecaoPadrao("Falha no envio");
            }
        }

        /// <summary>
        /// Realiza uma pesquisa que retorna uma lista de sugestões
        /// </summary>
        /// <returns></returns>
        public static List<MSugestao> Pesquisar(int tipo)
        {
            return DSugestao.Pesquisar(tipo);
        }
        /// <summary>
        /// Realiza uma pesquisa que retorna uma lista de sugestões baseado em uma data final ou inicial
        /// </summary>
        /// <param name="opcao"></param>
        /// Parametro que define qual data utilizar, true para data inicial e false para data final
        /// <param name="date"></param>
        /// Parametro de data
        /// <returns></returns>
        public static List<MSugestao> Pesquisar(int tipo, bool opcao, DateTime date)
        {
            return DSugestao.Pesquisar(tipo);
        }
        /// <summary>
        /// Realiza uma pesquisa que retorna uma lista de sugestões baseado em duas datas
        /// </summary>
        /// <param name="datainicial"></param>
        /// Parametro data inicial
        /// <param name="datafinal"></param>
        /// Parametro data final
        /// <returns></returns>
        public static List<MSugestao> Pesquisar(int tipo, String datainicial, String datafinal)
        {
            return DSugestao.Pesquisar(tipo, datainicial, datafinal);
        }

        public static string Obter(int id)
        {
            return DSugestao.Obter(id);
        }
    }
}
