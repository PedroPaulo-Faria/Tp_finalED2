using System;
using System.Collections.Generic;
using System.Text;

namespace TP_FINAL
{
    class TipoEquip
    {
        private int id;
        private string nome;
        private List<Equipamento> itens;

        public TipoEquip()
        {
            id = 0;
            nome = "";
            itens = new List<Equipamento>();
        }

        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }

        public int Id
        {
            get { return id; }
            set { id = value; }
        }


        public List<Equipamento> Itens
        {
            get { return itens; }
            set { itens = value; }
        }

        public void Incluir(Equipamento eqp)
        {
            eqp.Id = itens.Count + 1;
            itens.Add(eqp);
        }

        public Equipamento Buscar(int id)
        {
            Equipamento ret = new Equipamento();
            foreach (Equipamento eqp in itens)
            {
                if (eqp.Id == id)
                {
                    ret = eqp;
                }
            }
            return ret;
        }

        public override bool Equals(object obj)
        {
            return (this.nome.Equals(((TipoEquip)obj).nome));
        }
    }
}
