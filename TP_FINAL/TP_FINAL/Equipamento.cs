using System;
using System.Collections.Generic;
using System.Text;

namespace TP_FINAL
{
    class Equipamento
    {
        private int id;
        private bool avrd;
        private bool lcd;

        public Equipamento()
        {
            id = 0;
            avrd = false;
            lcd = false;
        }

        public bool Avrd
        {
            get { return avrd; }
            set { avrd = value; }
        }

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public bool Lcd
        {
            get { return lcd; }
            set { lcd = value; }
        }

        public override bool Equals(object obj)
        {
            return this.id.Equals(((Equipamento)obj).id);
        }
    }
}
