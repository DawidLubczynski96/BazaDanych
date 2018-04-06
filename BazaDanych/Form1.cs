using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;


namespace BazaDanych
{
    public partial class okno1 : Form
    {
        public okno1()
        {
            InitializeComponent();
        }

        private void logowanieBTN_Click(object sender, EventArgs e)
        {
           
            //pobieram dane logowania
            string mojePolaczenie =
                "SERVER=" + nazwaSerweraTB.Text + ";" +
                "PORT=" + 3306 + ";" +
                "DATABASE=" + bazaDanychTB.Text + ";" +
                "UID=" + loginTB.Text + ";" +
                "PASSWORD=" + hasloTB.Text + ";";
            
            //pobieram tabele dla sprawdzenia
            string sql = "SELECT * FROM producent";

            MySqlConnection polaczenie = new MySqlConnection(mojePolaczenie);

            try
            {
                polaczenie.Open();

                MessageBox.Show("Połączono z bazą danych MySQL.", "Informacja");

                using (MySqlCommand cmdSel = new MySqlCommand(sql, polaczenie))
                {
                    DataTable dt = new DataTable();

                    MySqlDataAdapter da = new MySqlDataAdapter(cmdSel);
                    da.Fill(dt);

                    dataGridView1.DataSource = dt.DefaultView;
                }
            }

            catch (MySql.Data.MySqlClient.MySqlException ex)
            {
                MessageBox.Show("Błąd logowania do bazy danych MySQL.", "Błąd");
            }

            polaczenie.Close();
        }

    }
}
