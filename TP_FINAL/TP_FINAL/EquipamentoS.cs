using System;
using System.Collections.Generic;
using System.Text;

namespace TP_FINAL
{
    class EquipamentoS
    {
        private List<TipoEquip> estoque;

        public EquipamentoS()
        {
            estoque = new List<TipoEquip>();
        }

        public List<TipoEquip> Estoque
        {
            get { return estoque; }
            set { estoque = value; }
        }

        public void Incluir(TipoEquip eqpTipo)
        {
            eqpTipo.Id = estoque.Count + 1;
            estoque.Add(eqpTipo);
        }

        public TipoEquip Buscar(string nome)
        {
            TipoEquip ret = new TipoEquip();
            foreach (TipoEquip teqp in estoque)
            {
                if (teqp.Nome == nome)
                {
                    ret = teqp;
                }
            }
            return ret;
        }

    }
}
