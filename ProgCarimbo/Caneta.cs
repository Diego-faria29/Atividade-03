using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgCarimbo
{
    class Caneta : Interacao
    {
        private string cor;
        private string texto;
        private int tinta;

        /*Construtor*/
        public Caneta(string Ptexto)
        {
            trocarTexto(Ptexto);
        }


        /*Metodos GET SET*/
        private string Cor
        {
            get { return cor; }
            set { cor = value; }
        }

        private string Texto
        {
            get { return texto; }
            set { texto = value; }
        }

        private int Tinta
        {
            get { return tinta; }
            set { tinta = value; }
        }

        /*Metodos do contrato com interface*/
        public void usar()
        {
            if (Tinta >= 1)
            {
                if (!String.IsNullOrEmpty(Texto))
                {
                    if (!String.IsNullOrEmpty(Cor))
                    {
                        Console.WriteLine("(" + Texto + ") na cor " + Cor);
                        Tinta--;
                    }
                    else
                    {
                        Console.WriteLine(" Impossível Escrever - Caneta está sem Cor.");
                    }
                }
                else
                {
                    Console.WriteLine("Impossível Escrever -  não contem texto.");
                }
            }
            else
            {
                Console.WriteLine("Impossível Escrever - Caneta sem tinta!");
            }


        }
        public void carregar(string Pcor, int Ptinta)
        {
            trocarCor(Pcor);

            if ((Ptinta < 1 && Ptinta > 10) && ((Tinta + Ptinta) > 10))
            {
                Console.WriteLine("Nivel de tinta atual: " + Tinta + ", tinta deve ser entre 1 e 10");
            }
            else
            {
                Tinta = Ptinta;
            }
        }

        public void trocarCor(string Pcor)
        {
            if (Pcor == Cor)
            {
                Console.WriteLine("Carimbo já está com esta cor!");
            }
            else
            {
                Cor = Pcor;
            }
        }
        public void trocarTexto(string Ptexto)
        {
            if (Ptexto == this.Texto)
            {
                Console.WriteLine(" Este texto ja estava predefinido.");
            }
            else
            {
                this.Texto = Ptexto;
            }
        }
    }
}
