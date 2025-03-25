using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio1
{
    class AVLNodo
    {

            private string dato;
            private AVLNodo izquierda;
            private AVLNodo derecha;

            public string Dato { get => dato; set => dato = value; }
            public AVLNodo Izquierda { get => izquierda; set => izquierda = value; }
            public AVLNodo Derecha { get => derecha; set => derecha = value; }

            public AVLNodo()
            {
                dato = "";
                Izquierda = null;
                Derecha = null;

            }
        
    }
}
