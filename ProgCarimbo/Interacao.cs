using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgCarimbo
{
    interface Interacao
    {
        void usar();
        void carregar(string Pcor, int Pcarga);
        void trocarCor(string Pcor);
        void trocarTexto(string Ptexto);
    }
}
