using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;

namespace Piano_Project
{
    public partial class FormDetailKey : Form
    {
        public FormDetailKey()
        {
            InitializeComponent();

            ConnectionDB con = new ConnectionDB();
            con.OpenCon();
            string query = "SELECT * FROM MusicT1";
            SQLiteCommand cmd = new SQLiteCommand(query, con.myCon);
            SQLiteDataAdapter adapter = new SQLiteDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);

            DetailKey_dataGridView.DataSource = dt;
        }

        private void DetailKey_dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            

        }
    }
}
