namespace Desafio1
{
    public partial class Principal : Form
    {

        Pacientes arbol = new Pacientes();
        Graphics area;

        public Principal()
        {
            InitializeComponent();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            if (txtPaciente.Text == " " || txtGenero.Text == "" || txtSangre.Text == "" || txtPresion.Text == "")
            {
                MessageBox.Show("¡Debe completar todos los datos!");
            }

            else
            {

                MessageBox.Show("¡Registrado con exito!");
                //limpiar();

                AVLNodo r;

                r = arbol.MostrarArbol(txtPaciente.Text, txtSangre.Text, txtGenero.Text, txtPresion.Text);
                arbol.TransversaPreO(r);


            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            area.Clear(Color.DarkSalmon);
            limpiar();
        }

        public void limpiar()
        {
            txtPaciente.Text = "";
            txtGenero.Text = "";
            txtSangre.Text = "";
            txtPresion.Text = "";

        }
        string Paciente;
        public int i = 0;


        public void DrawString()
        {
            System.Drawing.Graphics formGraphics = this.CreateGraphics();
            string drawString = Paciente;
            System.Drawing.Font drawFont = new System.Drawing.Font("Consolas", 10);
            System.Drawing.SolidBrush drawBrush = new System.Drawing.SolidBrush(System.Drawing.Color.Black);
            float x = 100.0F;
            float y = 200.0F;

            System.Drawing.StringFormat drawFormat = new System.Drawing.StringFormat();
            //formGraphics.DrawString(drawString, drawFont, drawBrush, 275, 100, drawFormat);

            formGraphics.DrawString("Pacientes", drawFont, drawBrush, 400, x, drawFormat);
            //Creando nivel 1 al 2
            formGraphics.DrawString("Genero", drawFont, drawBrush, 100, y, drawFormat);

            //linea de paciente a genero
            formGraphics.DrawLine(Pens.Black, 450, 125, 150, 200);

            //linea de paciente a tipo de sangre
            formGraphics.DrawLine(Pens.Black, 450, 125, 450, 200);

            //linea de paciente a presión
            formGraphics.DrawLine(Pens.Black, 450, 125, 740, 200);

            formGraphics.DrawString("Tipo de  \n Sangre", drawFont, drawBrush, 400, y, drawFormat);
            formGraphics.DrawString("presion", drawFont, drawBrush, 700, y, drawFormat);


            //tomando datos de las cajas de texto
            float y2 = 300.0F;
            string genero = txtGenero.Text;
            formGraphics.DrawString("Hombre", drawFont, drawBrush, 25, y2, drawFormat);
            formGraphics.DrawString("Mujer", drawFont, drawBrush, 150, y2, drawFormat);

            //linea de genero a hombre
            formGraphics.DrawLine(Pens.Black, 70, 300, 130, 225);

            //linea de genero a mujer
            formGraphics.DrawLine(Pens.Black, 180, 300, 140, 225);


            float y3 = 400.0F;
            Paciente = txtPaciente.Text;
            if (txtGenero.Text != "Femenino")
            {
                //linea de genero a mujer
                formGraphics.DrawLine(Pens.Black, 70, y3, 70, 325);
                formGraphics.DrawString(Paciente, drawFont, drawBrush, 25, y3, drawFormat);
                // lblResultado.Text = (" Se ha registrado el paciente  " + txtPaciente.Text + " de genero " + cmbGenero.Text + ", con tipo de sangre " + cmbsangre.Text + " y presion: " + cmbpresion.Text + ".");
            }
            else
            {
                //linea de genero a mujer
                formGraphics.DrawLine(Pens.Black, 180, y3, 180, 325);
                formGraphics.DrawString(Paciente, drawFont, drawBrush, 160, y3, drawFormat);
                // lblResultado.Text = (" Se ha registrado el paciente  " + txtPaciente.Text + " de genero " + cmbGenero.Text + ", con tipo de sangre " + cmbsangre.Text + " y presion: " + cmbpresion.Text + ".");
            }


            formGraphics.DrawString("A", drawFont, drawBrush, 250, y2, drawFormat);
            formGraphics.DrawLine(Pens.Black, 450, 250, 260, y2);
            formGraphics.DrawString("B", drawFont, drawBrush, 350, y2, drawFormat);
            formGraphics.DrawLine(Pens.Black, 450, 250, 360, y2);
            formGraphics.DrawString("AB", drawFont, drawBrush, 450, y2, drawFormat);
            formGraphics.DrawLine(Pens.Black, 450, 250, 460, y2);
            formGraphics.DrawString("O", drawFont, drawBrush, 550, y2, drawFormat);
            formGraphics.DrawLine(Pens.Black, 450, 250, 560, y2);


            formGraphics.DrawString("Alta", drawFont, drawBrush, 625, y2, drawFormat);
            formGraphics.DrawLine(Pens.Black, 650, y2, 740, 225);
            formGraphics.DrawString("Media", drawFont, drawBrush, 725, y2, drawFormat);
            formGraphics.DrawLine(Pens.Black, 750, y2, 740, 225);
            formGraphics.DrawString("Baja", drawFont, drawBrush, 825, y2, drawFormat);
            formGraphics.DrawLine(Pens.Black, 850, y2, 740, 225);

            if (txtSangre.Text == "A")
            { formGraphics.DrawString(Paciente, drawFont, drawBrush, 250, y3, drawFormat); formGraphics.DrawLine(Pens.Black, 260, y3, 260, 325); }
            else if (txtSangre.Text == "B")
            { formGraphics.DrawString(Paciente, drawFont, drawBrush, 350, y3, drawFormat); formGraphics.DrawLine(Pens.Black, 360, y3, 360, 325); }
            else if (txtSangre.Text == "AB")
            { formGraphics.DrawString(Paciente, drawFont, drawBrush, 450, y3, drawFormat); formGraphics.DrawLine(Pens.Black, 460, y3, 460, 325); }
            else if (txtSangre.Text == "O")
            { formGraphics.DrawString(Paciente, drawFont, drawBrush, 550, y3, drawFormat); formGraphics.DrawLine(Pens.Black, 560, y3, 560, 325); }


            if (txtPresion.Text == "Alta")
            { formGraphics.DrawString(Paciente, drawFont, drawBrush, 650, y3, drawFormat); formGraphics.DrawLine(Pens.Black, 650, y3, 650, 325); }
            else if (txtPresion.Text == "Baja")
            { formGraphics.DrawString(Paciente, drawFont, drawBrush, 850, y3, drawFormat); formGraphics.DrawLine(Pens.Black, 850, y3, 850, 325); }
            else if (txtPresion.Text == "Media")
            { formGraphics.DrawString(Paciente, drawFont, drawBrush, 750, y3, drawFormat); formGraphics.DrawLine(Pens.Black, 750, y3, 750, 325); }

        }

        private void btnPromedio_Click(object sender, EventArgs e)
        {

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (txtPaciente.Text == " ")
            {
                MessageBox.Show("¡Ingrese el nombre del paciente!");
            }

            else
            {

                MessageBox.Show("Buscando el paciente...");

            }
        }

        private void txtGenero_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}