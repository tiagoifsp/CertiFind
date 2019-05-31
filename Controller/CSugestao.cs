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
        public static List<MSugestao> Pesquisar()
        {
            return DSugestao.Pesquisar();
        }
        /// <summary>
        /// Realiza uma pesquisa que retorna uma lista de sugestões baseado em uma data final ou inicial
        /// </summary>
        /// <param name="opcao"></param>
        /// Parametro que define qual data utilizar
        /// <param name="date"></param>
        /// Parametro de data
        /// <returns></returns>
        public static List<MSugestao> Pesquisar(bool opcao, DateTime date)
        {
            return DSugestao.Pesquisar();
        }
        /// <summary>
        /// Realiza uma pesquisa que retorna uma lista de sugestões baseado em duas datas
        /// </summary>
        /// <param name="datainicial"></param>
        /// Parametro data inicial
        /// <param name="datafinal"></param>
        /// Parametro data final
        /// <returns></returns>
        public static List<MSugestao> Pesquisar(DateTime datainicial, DateTime datafinal)
        {
            return DSugestao.Pesquisar();
        }
    }
}
