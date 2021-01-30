using System;
using System.Collections.Generic;
using System.Text;

namespace TP_FINAL
{
    class Locações
    {
        
        private List<Locação> contratos;

              public Locações()
            {
                contratos = new List<Locação>();
            }

            public List<Locação> Contratos
            {
                get { return contratos; }
                set { contratos = value; }
            }

            public void Incluir(Locação locação)
            {
                locação.Id = contratos.Count + 1;
                contratos.Add(locação);
            }
        }
}
