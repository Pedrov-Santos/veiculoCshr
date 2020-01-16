using System;

namespace br.com.gft.veiculo
{
    public abstract class Veiculo
    {
        protected String modelo { set; get; }
        protected float velocidade { set; get; }
        protected int passageiros { set; get; }
        protected float combustivel { set; get; }
        protected Boolean isLigado { set; get; }
        protected int totTanque { set; get; }
        public Veiculo(String modelo, float velocidade, int passageiros, float combustivel, int totTanque)
        {

            this.modelo = modelo;
            this.velocidade = velocidade;
            this.passageiros = passageiros;
            this.combustivel = combustivel;
            this.isLigado = false;
            this.totTanque = totTanque;
        }

        public void ligar()
        {
            if(this.isLigado == true)
            {
                Console.WriteLine("O "+ this.modelo +" já está ligado.");
            }
            else
            {
                this.isLigado = true;
                Console.WriteLine("O "+ this.modelo +" foi ligado.");
            }
        }
        public void desligar()
        {
            if(this.isLigado == true)
            {
                this.isLigado = false;
                Console.WriteLine("O "+ this.modelo +" foi desligado.");
            }
            else
            {
                Console.WriteLine("O " + this.modelo +" já está desligado");
            }
        }
        public void abastecer(int lts)
        {
            if (lts <= this.totTanque)
            {
                this.combustivel += lts;
                Console.WriteLine("O " + this.modelo +" foi abastecido com: " + lts+"L");
            }
            else
            {
                Console.WriteLine("Não é possivel abastecer mais que á capacidade do tanque de 200L combustivel atual: " + this.combustivel + "L");
            }
        }

        public void acelerar(float acl)
        {
            acl =Convert.ToSingle(acl);
            if (this.isLigado == true && this.combustivel > acl/10)
            {
                this.velocidade += acl;
                this.combustivel -= acl/10;
            }
            else
            {
                Console.WriteLine("Não é possivel acelerar com o " + this.modelo +" desligado ou sem gasolina.");
            }
        }

        public void status()
        {
            Console.WriteLine("Modelo: " + this.modelo +
                    "\nVelocidade Atual: " + this.velocidade + "Km/h" +
                    "\nPassageiros: " + this.passageiros +
                    "\nCombustivel Atual: " + this.combustivel + "L");
        }
    }
}
