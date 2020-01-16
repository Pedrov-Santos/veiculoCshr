using System;
using System.Collections.Generic;
using System.Text;

namespace br.com.gft.veiculo
{
    class Carro : Veiculo 
    {
        private String marca { set; get; }
        private int portas { set; get; }
        private int ano { set; get; }

        public Carro(string modelo, float velocidade, int passageiros, float combustivel, int totTanque,
            String marca, int portas, int ano) : base(modelo, velocidade, passageiros, combustivel, totTanque)
        {
        
            this.marca = marca;
            this.portas = portas;
            this.ano = ano;
        }
        public void status()
        {
            base.status();
            Console.WriteLine("Marca: " + this.marca +
                    "\nPortas: " + this.portas +
                    "\nAno: " + this.ano);
        }

    }
}
