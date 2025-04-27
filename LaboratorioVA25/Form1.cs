namespace LaboratorioVA25
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(textBox1.Text == "1234")
            {
                crud v1= new crud();
                v1.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Contraseña incorrecta");
            }

            //Cambio de ventana al crud
        }
    }
}
