using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio1
{
    internal class Pacientes
    {
        private AVLNodo raiz;
        private AVLNodo trabajo;
        public int i = 0;



        Graphics area;

        private const int Radio = 300;
        private const int DistanciaH = 400;
        private const int DistanciaV = 400;




        public Pacientes()
        {
            raiz = new AVLNodo();
        }

        //se generara el metodo insertar nodo
        public AVLNodo Insertar(string pDato, AVLNodo pNodo) //donde pDato es el dato a incertar y pNodo el nodo donde se desea insertar
        {

            if (pNodo == null)
            {
                raiz = new AVLNodo();
                raiz.Dato = pDato;

                //el primer nodo se ingresa como raíz si no hay hijo
                raiz.Izquierda = null;

                // de igual manera si no hay hermano y apunta a null no hay hermano
                raiz.Derecha = null;

                return raiz;
            }

            if (pNodo.Izquierda == null) //Se verifica si tiene hijos ,sino se inserta el dato como hijo
            {
                AVLNodo temp = new AVLNodo();
                temp.Dato = pDato;
                //conectando el nuevo nodo como hijo
                pNodo.Izquierda = temp;

                return temp;
            }
            else //ya tiene un hijo, le insertamos un hermano
            {
                trabajo = pNodo.Izquierda;

                // insertar el ultimo hermano
                while (trabajo.Derecha != null)
                {
                    trabajo = trabajo.Derecha;
                }


                //creamos nodo temporal 
                AVLNodo temp = new AVLNodo();
                temp.Dato = pDato;

                //uniendo el ultimo hermano
                trabajo.Derecha = temp;
                return temp;
            }
        }

        // para recorrer la esructura se realizara una transversa Pre Orden
        public void TransversaPreO(AVLNodo pNodo)
        {
            if (pNodo == null)

                return;

            //primer proceso
            for (int n = 0; n < i; n++) ;

            //rESPUESTA
            //MessageBox.Show(pNodo.Dato);
            //Console.WriteLine(pNodo.Dato);


            //procesamos a mi hijo
            if (pNodo.Izquierda != null)
            {
                i++;
                TransversaPreO(pNodo.Izquierda);
                i--;
            }
            // si tengo hermanos los proceso
            if (pNodo.Derecha != null)
                TransversaPreO(pNodo.Derecha);

        }

        //metodo para dibujar

        public void DibujarNodo(Graphics grafo, Font fuente, Brush Relleno, Brush RellenoFuente, Pen Lapiz, Brush encuentro)
        {

            grafo.FillEllipse(encuentro, new Rectangle(75, 40, 100, 25));
            grafo.FillEllipse(Relleno, new Rectangle(75, 40, 100, 25));
            grafo.DrawEllipse(Lapiz, new Rectangle(75, 40, 100, 25));

            StringFormat formato = new StringFormat();
            formato.Alignment = StringAlignment.Center;
            formato.LineAlignment = StringAlignment.Center;
            grafo.DrawString(raiz.ToString(), fuente, RellenoFuente, 75, 40, formato);

        }

        public AVLNodo MostrarArbol(string gen, string tip, string pre, string nom)
        {


            Pacientes arbol = new Pacientes();
            AVLNodo raiz = arbol.Insertar("Paciente", null);

            Principal mostrar = new Principal();

            AVLNodo n = arbol.Insertar("Genero", raiz);
            arbol.Insertar(gen, n);
            arbol.Insertar(nom, n);

            n = arbol.Insertar("T. Sangre", raiz);
            arbol.Insertar(tip, n);
            arbol.Insertar(nom, n);

            n = arbol.Insertar("Presion", raiz);
            arbol.Insertar(pre, n);
            arbol.Insertar(nom, n);

            return raiz;

        }

        public AVLNodo BuscarPaciente(string pDato, AVLNodo pNodo)
        {
            AVLNodo encontrado = null;

            if (pNodo == null)
                return encontrado;

            if (pNodo.Dato.CompareTo(pDato) == 0)
            {
                encontrado = raiz;
                return encontrado;
            }
            //Procesar nodos hijos
            if (raiz.Izquierda != null)
            {
                encontrado = BuscarPaciente(pDato, raiz.Izquierda);

                if (encontrado != null)
                    return encontrado;
            }
            //Si hay hermanos se procesan
            if (raiz.Derecha != null)
            {
                encontrado = BuscarPaciente(pDato, raiz.Derecha);

                if (encontrado != null)
                    return encontrado;
            }
            return encontrado;
        }
    }

}
