namespace Cedula
{
    public partial class Form1 : Form
    {
        public class Civil
        {
            public string Nombres { get; set; }
            public string Apellidos { get; set; }
            public string LugardeNacimiento { get; set; } 
            public string FechadeNacimiento { get; set; }
            public string Nacionalidad { get; set; }
            public string Sexo { get; set; }
            public string Sangre { get; set; }
            public string EstadoCivil { get; set; }
            public string FechadeExpiracion { get; set; }
            
            
            
        }
        List<Civil> Civiles = new List<Civil>();
        public Form1()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            foreach (Control c in panel1.Controls)
            {
                if(c is TextBox)
                {
                    c.Text =String.Empty;
                }
            } 
        }

        private void button2_Click(object sender, EventArgs e)
        {
            save();
        }
        private void save()
        {
            var civil = new Civil()
            {
                Apellidos = Apellidos.Text,
                Nombres = Nombres.Text,
                LugardeNacimiento = LugardeNacimiento.Text,
                FechadeNacimiento = FechadeNacimiento.Text,
                Nacionalidad = Nacionalidad.Text,
                Sexo = Sexo.Text,
                Sangre = Sangre.Text,
                EstadoCivil = EstadoCivil.Text,
                FechadeExpiracion = FechadeExpiracion.Text,
               
            };
            Civiles.Add(civil);
            MessageBox.Show("credenciales guardados");

            dataGridView1.Enabled = true;
            buttinguardar.Enabled = true;
            button1.Enabled = true;

            GuardarCiviles();
            
        }

        private void GuardarCiviles()
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = Civiles;
        }

    }
}