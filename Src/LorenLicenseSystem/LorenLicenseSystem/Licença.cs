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
    public partial class Licença : Form
    {
        public Licença()
        {
            Config.LoadDB();
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using SqlConnection connection = SQLjec.getInstance().Conn();
            SqlCommand command = connection.CreateCommand();
            connection.Open();
            command.Parameters.Add(new SqlParameter("@UserID", this.TextBoxUserID.Text));
            command.Parameters.Add(new SqlParameter("@ProductId", this.TextBoxproductID.Text));
            command.Parameters.Add(new SqlParameter("@Ip", this.TextBoxIP.Text));
            command.Parameters.Add(new SqlParameter("@HWID", this.textBoxHWID.Text));
            command.Parameters.Add(new SqlParameter("@Status", this.TextBoxStatus.Text));
            command.Parameters.Add(new SqlParameter("@Package", this.TextBoxPackage.Text));
            command.Parameters.Add(new SqlParameter("@Paln", this.TextBoxPlan.Text));
            command.Parameters.Add(new SqlParameter("@Expire", this.TextBoxExpire.Text));
            command.CommandText = "INSERT INTO [License] (UserID, ProductId, information1, information2, Status, PackageIndex, PlanIndex, Expire) VALUES (@UserID, @ProductId, @Ip, @HWID, @Status, @Package, @Paln, @Expire)";
            command.ExecuteNonQuery();
            command.Dispose();
            connection.Dispose();
            connection.Close();

            MessageBox.Show("Licença Gerada Com Sucesso!!");
        }

        private void Licença_Load(object sender, EventArgs e)
        {
            Config.LoadDB();
        }

        private void TextBoxproductID_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
