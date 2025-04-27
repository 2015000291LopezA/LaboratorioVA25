using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace LaboratorioVA25
{
    public partial class crud : Form
    {
        public crud()
        {
            InitializeComponent();
        }

        private void crud_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string nombre = textBox1.Text;
            string grado = textBox2.Text;
            string seccion = textBox3.Text;
            string telefono = textBox4.Text;
            string matricula = textBox5.Text;
            string ciclo = textBox6.Text;
            string edad = textBox7.Text;
            string comision = textBox8.Text;
            string talla = textBox9.Text;
            string altura = textBox10.Text;
            string año = textBox11.Text;

            //Obtiene el texto que el usuario escribió en cada caja de texto

            string[] fila = {nombre, grado, seccion, telefono, matricula, ciclo,
                edad, comision, talla, altura, año};

            //Crea un arreglo de strings con todos esos valores

            dataGridView1.Rows.Add(fila);

            //grega una nueva fila al dataGridView1, usando los datos del arreglo

            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();
            textBox7.Clear();
            textBox8.Clear();
            textBox9.Clear();
            textBox10.Clear();
            textBox11.Clear();
            //Limpia todas las cajas de texto para que puedas escribir datos nuevos

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                dataGridView1.CurrentRow.Cells[0].Value = textBox1.Text;
                dataGridView1.CurrentRow.Cells[1].Value = textBox2.Text;
                dataGridView1.CurrentRow.Cells[2].Value = textBox3.Text;
                dataGridView1.CurrentRow.Cells[3].Value = textBox4.Text;
                dataGridView1.CurrentRow.Cells[4].Value = textBox5.Text;
                dataGridView1.CurrentRow.Cells[5].Value = textBox6.Text;
                dataGridView1.CurrentRow.Cells[6].Value = textBox7.Text;
                dataGridView1.CurrentRow.Cells[7].Value = textBox8.Text;
                dataGridView1.CurrentRow.Cells[8].Value = textBox9.Text;
                dataGridView1.CurrentRow.Cells[9].Value = textBox10.Text;
                dataGridView1.CurrentRow.Cells[10].Value = textBox11.Text;

                //Si hay una fila seleccionada en la tabla
                //Actualiza cada celda de esa fila con los nuevos valores escritos en las textBox

                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
                textBox4.Clear();
                textBox5.Clear();
                textBox6.Clear();
                textBox7.Clear();
                textBox8.Clear();
                textBox9.Clear();
                textBox10.Clear();
                textBox11.Clear();

                //Luego de actualizar, limpia todas las cajas de texto otra vez
            }


        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow fila = dataGridView1.Rows[e.RowIndex];
                textBox1.Text = fila.Cells[0].Value.ToString();
                textBox2.Text = fila.Cells[1].Value.ToString();
                textBox3.Text = fila.Cells[2].Value.ToString();
                textBox4.Text = fila.Cells[3].Value.ToString();
                textBox5.Text = fila.Cells[4].Value.ToString();
                textBox6.Text = fila.Cells[5].Value.ToString();
                textBox7.Text = fila.Cells[6].Value.ToString();
                textBox8.Text = fila.Cells[7].Value.ToString();
                textBox9.Text = fila.Cells[8].Value.ToString();
                textBox10.Text = fila.Cells[9].Value.ToString();
                textBox11.Text = fila.Cells[10].Value.ToString();

                //Cuando haces clic en cualquier celda de la tabla

                //Carga los datos de esa fila en las textBox

                //Así puedo verlos y luego modificarlos o eliminarlos
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                dataGridView1.Rows.Remove(dataGridView1.CurrentRow);

                //Si hay una fila seleccionada, elimina esa fila de la tabla

                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
                textBox4.Clear();
                textBox5.Clear();
                textBox6.Clear();
                textBox7.Clear();
                textBox8.Clear();
                textBox9.Clear();
                textBox10.Clear();
                textBox11.Clear();
                //Limpia las cajas de texto después de eliminar
            }
            else
            {
                MessageBox.Show("Seleciona para eliminar");

                //Si no seleccione nada me muestra un mensaje de advertencia
            }
        }

        private void aUTORToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cred v2 = new cred();
            v2.Show();    

            //muestra ventana
        }
    }
}
