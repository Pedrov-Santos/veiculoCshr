using System;
using System.Collections.Generic;
using System.Text;

namespace br.com.gft.veiculo
{
    class Caminhao : Veiculo
    {
        private int rodas { set; get; }
        private int eixo { set; get; }

        public Caminhao(String modelo, float velocidade, int passageiros, float combustivel, int totTanque, int rodas, int eixo):
            base(modelo, velocidade, passageiros, combustivel, totTanque)
        {
            this.rodas = rodas;
            this.eixo = eixo;
        }
        public void abastecer(float lts)
        {
            base.abastecer((int)Math.Ceiling(lts));
        }

        
        public void status()
        {
            base.status();
            Console.WriteLine("Total de rodas: " + this.rodas +
                "\nTotal de eixos: "+ this.eixo);
        }

    }
}
