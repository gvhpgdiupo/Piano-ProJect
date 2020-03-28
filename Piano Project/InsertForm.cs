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
    public partial class InsertForm : Form
    {
        
        public InsertForm()
        {
            InitializeComponent();
        }
        public void INSERT()
        {
            ConnectionDB con = new ConnectionDB();
            string insert = "INSERT INTO MusicT1(Name,Path) VALUES('" + Name_textBox.Text + "', '" + Path_textBox.Text + "' )";
            SQLiteCommand cmd = new SQLiteCommand(insert, con.myCon);
            con.OpenCon();
            cmd.ExecuteNonQuery();
            con.CloseCon();

        }
        private void ShowDetail_button_Click(object sender, EventArgs e)
        {
            FormDetailKey DK = new FormDetailKey();
            DK.Show();           
        }

        private void INSERTKEY_button_Click(object sender, EventArgs e)
        {            
            
            if (Name_textBox.Text == "" || Path_textBox.Text == "")
            {
                MessageBox.Show("Please fill information");
                return;
            }
            else
            {
                INSERT();
                MessageBox.Show("Success");
            }
            Name_textBox.Clear();
            Path_textBox.Clear();
        }

        private void InsertForm_Load(object sender, EventArgs e)
        {

        }

        private void InsertForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            FormPiano fp = new FormPiano();
            fp.Show();
            this.Hide();
        }
    }
}
