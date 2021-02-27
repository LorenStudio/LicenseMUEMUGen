////////////////////////////////////////////////
//             LORENSTUDIO                     /
//          By Rodrigo(Lucifer)                /
//          Whats: (22)98186-8617              /
//        Email: suporte@lorenstudio.com       /
////////////////////////////////////////////////
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;


namespace LorenLicenseSystem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            Config.LoadDB();
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Config.LoadDB();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        { 
            Licença frm2 = new Licença();
            frm2.Show();
        }

        private void sobreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            About frm12 = new About();
            frm12.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            using SqlConnection connection = SQLjec.getInstance().Conn();
            SqlCommand command = connection.CreateCommand();
            connection.Open();
            command.Parameters.Add(new SqlParameter("@Name", this.TextBoxName.Text));
            command.Parameters.Add(new SqlParameter("@Mail", this.TextBoxMail.Text));
            command.Parameters.Add(new SqlParameter("@ClientName", this.textBox1.Text));
            command.Parameters.Add(new SqlParameter("@Password", this.TextBoxPassword.Text));
            command.Parameters.Add(new SqlParameter("@Nivel", this.Nivel.Text));
            command.Parameters.Add(new SqlParameter("@status", this.TextBoxStatus.Text));
            command.CommandText = "INSERT INTO [User] (Name, Mail, ClientName, Password, Nivel, Status) VALUES (@Name, @Mail, @ClientName, @Password, @Nivel, @Status)";
            command.ExecuteNonQuery();
            // command.BeginExecuteNonQuery();
            command.Dispose();
            connection.Dispose();
            connection.Close();

            MessageBox.Show("Usuario Gerado Com Sucesso!!");
        }
    }
}

