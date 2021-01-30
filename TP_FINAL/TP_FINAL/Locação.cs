using System;
using System.Collections.Generic;
using System.Text;

namespace TP_FINAL
{
    class Locação
    {
        private int id;
        private bool liberado = false;
        private DateTime data_saida;
        private DateTime data_retorno;
        private Stack<TipoEquip> itens;

        public Locação()
        {
            id = 0;
            liberado = false;
            data_retorno = new DateTime();
            data_saida = new DateTime();
            itens = new Stack<TipoEquip>();
        }

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public bool Liberado
        {
            get { return liberado; }
            set { liberado = value; }
        }

        public DateTime Data_saida
        {
            get { return data_saida; }
            set { data_saida = value; }
        }

        public DateTime Data_retorno
        {
            get { return data_retorno; }
            set { data_retorno = value; }
        }

        public Stack<TipoEquip> Itens
        {
            get { return itens; }
            set { itens = value; }
        }


        public TipoEquip Buscar(string nome)
        {
            TipoEquip ret = new TipoEquip();
            foreach (TipoEquip teqp in itens)
            {
                if (teqp.Nome == nome)
                {
                    ret = teqp;
                }
            }
            return ret;
        }

        public void Incluir(TipoEquip eqpTipo)
        {
            eqpTipo.Id = itens.Count + 1;
            itens.Push(eqpTipo);
        }
        public override bool Equals(object obj)
        {
            return this.id.Equals(((Locação)obj).id);
        }
    }
}
