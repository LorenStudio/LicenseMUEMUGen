////////////////////////////////////////////////
//             LORENSTUDIO                     /
//          By Rodrigo(Lucifer)                /
//          Whats: (22)98186-8617              /
//        Email: suporte@lorenstudio.com       /
////////////////////////////////////////////////
using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;
          // IGNORAR COMPLETAMENTE ESSA CLASSE, ELA SÓ SERVE PARA TESTAR A CONEXÃO.
namespace LorenLicenseSystem
{
    class Login
    {
        public static void Load()
        {
            try
            {
                using (SqlConnection connection = LorenLicenseSystem.SQLjec.getInstance().Conn())
                {
                    ConnectionState state = connection.State;
                    if (state == ConnectionState.Open)
                    {

                    }
                    else
                    {
                        connection.Open();
                     MessageBox.Show("conexão com o banco de dados foi estabelecida.");

                    }
                }
            }
            catch (Exception ex)
            {
             MessageBox.Show("Erro: " + ex.ToString());
            }
        }
    }
}
