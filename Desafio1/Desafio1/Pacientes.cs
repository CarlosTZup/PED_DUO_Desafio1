using System;
using System.Collections.Generic;
using System.Data;
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

        public string[,] Records = new string[100,4];
        public int RLength;

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

        public AVLNodo MostrarArbol(string nombre, string genero, string sangre, string presion)
        {


            Pacientes arbol = new Pacientes();
            AVLNodo raiz = arbol.Insertar("Paciente", null);
            int size = 0;
            Principal mostrar = new Principal();
            if (RLength != null)
                size = RLength;
             else RLength = 0;

            AVLNodo n = arbol.Insertar("Genero", raiz);
            arbol.Insertar(genero, n);
            arbol.Insertar(nombre, n);

            n = arbol.Insertar("T. Sangre", raiz);
            arbol.Insertar(sangre, n);
            arbol.Insertar(nombre, n);
            
            n = arbol.Insertar("Presion", raiz);
            arbol.Insertar(presion, n);
            arbol.Insertar(nombre, n);

            Records[size,3] = presion;
            Records[size,0] = nombre;
            Records[size,1] = genero;
            Records[size,2] = sangre;
            RLength++;
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

        public string Promediar()
        {
            string text= "";
            double Sangre_A = 0, Sangre_B = 0, Sangre_AB = 0, Sangre_O = 0, Total = 0;
            double PSangre_A, PSangre_B, PSangre_AB, PSangre_O;
            if (RLength > 0)
            {
                
                for (int i = 0; RLength != i; i++)
                {
                    switch (Records[i,2]) {

                        case "A":
                            Sangre_A ++;
                            Total++;
                            break;

                        case "B":
                            Sangre_B++;
                            Total++;
                            break;

                        case "AB":
                            Sangre_AB++;
                            Total++;
                            break;

                        case "O":
                            Sangre_O++;
                            Total++;
                            break;
                        default:
                            break;
                    }
                }

                text = "En la poblacion de El salvador hay: "+ Total+" Personas Registradas. De las cuales los tipos de sangre que hay son: \n";

                if (Sangre_A > 0)
                {
                    PSangre_A = (Sangre_A / Total)*100;
                    text += "\n Sangre Tipo A: " + PSangre_A+"%";

                }
                if (Sangre_B > 0)
                {
                    PSangre_B = (Sangre_B / Total)*100;
                    text += "\n Sangre Tipo B: " + PSangre_B + "%";

                }
                if (Sangre_AB > 0)
                {
                    PSangre_AB = (Sangre_AB / Total)*100;
                    text += "\n Sangre Tipo AB: " + PSangre_AB + "%";

                }
                if (Sangre_O > 0)
                {
                    PSangre_O = (Sangre_O / Total) * 100;
                    text += "\n Sangre Tipo O: " + PSangre_O + "%";

                }



            }
            else
            {
                text = "No hay valores registrados";
            }
            return text;
        }

        public bool Checkpaciente(string nombre, string genero, string sangre, string presion)
        {
            bool val = false;
            for (int i = 0; RLength != i; i++)
            {
                if (Records[i, 0]== nombre )
                {
                    if (Records[i, 1] == genero)
                    {
                        if (Records[i, 2] == sangre)
                        {

                            if (Records[i, 3] == presion)
                            {
                                val = true;
                                return val;
                            }
                        }

                    }

                }

            }
            return val;
        }

        public bool Clears(string nombre, string genero, string sangre, string presion)
        {
            bool val = false;
            int shift = 0;
            for (int i = 0; RLength != i; i++)
            {
                if (Records[i, 0] == nombre)
                {
                    if (Records[i, 1] == genero)
                    {
                        if (Records[i, 2] == sangre)
                        {

                            if (Records[i, 3] == presion)
                            {
                                val = true;
                                
                                shift ++;
                            }
                        }

                    }

                }
                if (val)
                {
                    if (i == 0)
                    {
                        Records[i, 0] = null;
                        Records[i, 1] = null;
                        Records[i, 2] = null;
                        Records[i, 3] = null;
                    }
                    else
                    {
                        Records[i - shift, 0] = Records[i, 0];
                        Records[i - shift, 1] = Records[i, 1];
                        Records[i - shift, 2] = Records[i, 2];
                        Records[i - shift, 3] = Records[i, 3];
                        Records[i, 0] = null;
                        Records[i, 1] = null;
                        Records[i, 2] = null;
                        Records[i, 3] = null;
                    }
                }
            }
            RLength -= shift;
            return val;
        }
    }

}
