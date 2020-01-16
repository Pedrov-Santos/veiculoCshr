using System;
using System.Collections.Generic;
using System.Text;

namespace br.com.gft.veiculo
{
    class main
    {
        public static void Main(String[] args)
        {

            Carro c1 = new Carro("SUV", 0.00f, 4, 0.00f, 150, "sssss", 3, 2015);
           
            c1.ligar();
            c1.acelerar(15);
            c1.abastecer(150);
            c1.acelerar(15.5f);
            c1.status();
        }
    }
}
