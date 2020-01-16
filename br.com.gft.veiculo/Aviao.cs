using System;
using System.Collections.Generic;
using System.Text;

namespace br.com.gft.veiculo
{
    class Aviao : Veiculo
    {
        private String tipo;
        private String uso;

        public Aviao(String modelo, float velocidade, int passageiros, float combustivel, int totTanque, String tipo, String uso) :
            base(modelo, velocidade, passageiros, combustivel, totTanque)
        {
            this.tipo = tipo;
            this.uso = uso;
        }

        public void abastecer(String lts)
        {
            base.abastecer(Convert.ToInt32(lts));
        }
        public void status()
        {
            base.status();
            Console.WriteLine("Tipo: "+ this.tipo+
                "\nUso: "+this.uso);
        }
    }

}
