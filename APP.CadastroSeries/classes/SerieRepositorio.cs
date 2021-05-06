using System;
using System.Collections.Generic;
using APP.CadastroSeries.interfaces;

namespace APP.CadastroSeries.classes
{
    public class SerieRepositorio : IRepositorio<serie>
    {
        private List<serie> listaSerie = new List<serie>();
        public void Atualiza(int id, serie entidade)
        {
            listaSerie[id] = entidade;
        }

        public void Exclui(int id)
        {
            listaSerie[id].Excluir();
        }

        public void Insere(serie entidade)
        {
            listaSerie.Add(entidade);
        }

        public List<serie> Lista()
        {
            return listaSerie;
        }

        public int ProximoID()
        {
            return listaSerie.Count;
        }

        public serie RetornaPorId(int id)
        {
            return listaSerie[id];
        }
    }
}