using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
using System.Data.SQLite;


namespace Piano_Project
{
    public partial class FormPiano : Form
    {
        Boolean stop;
        public FormPiano()
        {
            InitializeComponent();            
        }

       /* public void INSERT() 
        {
            ConnectionDB con = new ConnectionDB();    
            string insert = "INSERT INTO MusicT1(Name,Path) VALUES('"+Name_textBox.Text+"', '"+Path_textBox.Text+"' )";
            SQLiteCommand cmd = new SQLiteCommand(insert,con.myCon);
            con.OpenCon();
            cmd.ExecuteNonQuery();
            con.CloseCon();  
            
        }*/
        public void SelectSoundPlay(string Select) 
        {
            ConnectionDB con = new ConnectionDB();
            con.OpenCon();
            string query = Select;
            SQLiteCommand cmd = new SQLiteCommand(query, con.myCon);
            SQLiteDataReader dr = cmd.ExecuteReader();
            dr.Read();

            SoundPlayer p = new SoundPlayer(dr["Path"].ToString());
            p.Play();
            dr.Close();
            con.CloseCon();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            Fur_Eilse_button.Enabled = false;
            Marryhad_button.Enabled = false;
        }

        private async void C_button_Click(object sender, EventArgs e)
        {

            SelectSoundPlay("SELECT Path FROM MusicT1 WHERE Name = 'C'");
            C_button.BackColor = SystemColors.GrayText;
            await Task.Delay(TimeSpan.FromSeconds(0.4));
            C_button.BackColor = Color.White;

        }

        private void INSERTKEY_button_Click(object sender, EventArgs e)
        {
            InsertForm isf = new InsertForm();
            isf.Show();
            this.Hide();              
        }

        private async void D_button_Click(object sender, EventArgs e)
        {
            SelectSoundPlay("SELECT Path FROM MusicT1 WHERE Name = 'D'");
            D_button.BackColor = SystemColors.GrayText;
            await Task.Delay(TimeSpan.FromSeconds(0.4));
            D_button.BackColor = Color.White;
        }

        private async void E_button_Click(object sender, EventArgs e)
        {
            SelectSoundPlay("SELECT Path FROM MusicT1 WHERE Name = 'E'");
            E_button.BackColor = SystemColors.GrayText;
            await Task.Delay(TimeSpan.FromSeconds(0.4));
            E_button.BackColor = Color.White;
        }

        private async void F_button_Click(object sender, EventArgs e)
        {
            SelectSoundPlay("SELECT Path FROM MusicT1 WHERE Name = 'F'");
            F_button.BackColor = SystemColors.GrayText;
            await Task.Delay(TimeSpan.FromSeconds(0.4));
            F_button.BackColor = Color.White;
        }

        private async void G_button_Click(object sender, EventArgs e)
        {
            SelectSoundPlay("SELECT Path FROM MusicT1 WHERE Name = 'G'");
            G_button.BackColor = SystemColors.GrayText;
            await Task.Delay(TimeSpan.FromSeconds(0.4));
            G_button.BackColor = Color.White;
        }

        private async void A_button_Click(object sender, EventArgs e)
        {
            SelectSoundPlay("SELECT Path FROM MusicT1 WHERE Name = 'A'");
            A_button.BackColor = SystemColors.GrayText;
            await Task.Delay(TimeSpan.FromSeconds(0.4));
            A_button.BackColor = Color.White;
        }

        private async void B_button_Click(object sender, EventArgs e)
        {
            SelectSoundPlay("SELECT Path FROM MusicT1 WHERE Name = 'B'");
            B_button.BackColor = SystemColors.GrayText;
            await Task.Delay(TimeSpan.FromSeconds(0.4));
            B_button.BackColor = Color.White;
        }

        private async void C1_button_Click(object sender, EventArgs e)
        {
            SelectSoundPlay("SELECT Path FROM MusicT1 WHERE Name = 'C1'");
            C1_button.BackColor = SystemColors.GrayText;
            await Task.Delay(TimeSpan.FromSeconds(0.4));
            C1_button.BackColor = Color.White;
        }

        private async void D1_button_Click(object sender, EventArgs e)
        {
            SelectSoundPlay("SELECT Path FROM MusicT1 WHERE Name = 'D1'");
            D1_button.BackColor = SystemColors.GrayText;
            await Task.Delay(TimeSpan.FromSeconds(0.4));
            D1_button.BackColor = Color.White;
        }

        private async void E1_button_Click(object sender, EventArgs e)
        {
            SelectSoundPlay("SELECT Path FROM MusicT1 WHERE Name = 'E1'");
            E1_button.BackColor = SystemColors.GrayText;
            await Task.Delay(TimeSpan.FromSeconds(0.4));
            E1_button.BackColor = Color.White;
        }

        private async void F1_button_Click(object sender, EventArgs e)
        {
            SelectSoundPlay("SELECT Path FROM MusicT1 WHERE Name = 'F1'");
            F1_button.BackColor = SystemColors.GrayText;
            await Task.Delay(TimeSpan.FromSeconds(0.4));
            F1_button.BackColor = Color.White;
        }

        private async void C_S_button_Click(object sender, EventArgs e)
        {
            SelectSoundPlay("SELECT Path FROM MusicT1 WHERE Name = 'C#'");
            C_S_button.BackColor = SystemColors.GrayText;
            await Task.Delay(TimeSpan.FromSeconds(0.4));
            C_S_button.BackColor = Color.Black;
        }

        private async void D_S_button_Click(object sender, EventArgs e)
        {
            SelectSoundPlay("SELECT Path FROM MusicT1 WHERE Name = 'D#'");
            D_S_button.BackColor = SystemColors.GrayText;
            await Task.Delay(TimeSpan.FromSeconds(0.4));
            D_S_button.BackColor = Color.Black;
        }

        private async void F_S_button_Click(object sender, EventArgs e)
        {
            SelectSoundPlay("SELECT Path FROM MusicT1 WHERE Name = 'F#'");
            
            F_S_button.BackColor = SystemColors.GrayText;
            await Task.Delay(TimeSpan.FromSeconds(0.4));
            F_S_button.BackColor = Color.Black;
        }

        private async void G_S_button_Click(object sender, EventArgs e)
        {
            SelectSoundPlay("SELECT Path FROM MusicT1 WHERE Name = 'G#'");
            
            G_S_button.BackColor = SystemColors.GrayText;
            await Task.Delay(TimeSpan.FromSeconds(0.4));
            G_S_button.BackColor = Color.Black;
        }

        private async void Bb_button_Click(object sender, EventArgs e)
        {
            SelectSoundPlay("SELECT Path FROM MusicT1 WHERE Name = 'Bb'");
            
            Bb_button.BackColor = SystemColors.GrayText;
            await Task.Delay(TimeSpan.FromSeconds(0.4));
            Bb_button.BackColor = Color.Black;
        }

        private async void C_S1_button_Click(object sender, EventArgs e)
        {
            SelectSoundPlay("SELECT Path FROM MusicT1 WHERE Name = 'C#1'");
            
            C_S1_button.BackColor = SystemColors.GrayText;
            await Task.Delay(TimeSpan.FromSeconds(0.4));
            C_S1_button.BackColor = Color.Black;
        }

        private async void D_S1_button_Click(object sender, EventArgs e)
        {
            SelectSoundPlay("SELECT Path FROM MusicT1 WHERE Name = 'D#1'");
            
            D_S1_button.BackColor = SystemColors.GrayText;
            await Task.Delay(TimeSpan.FromSeconds(0.4));
            D_S1_button.BackColor = Color.Black;
        }

        private async void Fur_Eilse_button_Click(object sender, EventArgs e)
        {           
            stop = false;
            for(int i = 1; i<=17;i++) 
            {
                if (stop == false)
                {
                    switch (i)
                    {
                        case 1:
                            SelectSoundPlay("SELECT Path FROM MusicT1 WHERE Name = 'E1'");
                            E1_button.BackColor = SystemColors.GrayText;
                            await Task.Delay(TimeSpan.FromSeconds(0.6));
                            E1_button.BackColor = Color.White;
                            break;
                        case 2:
                            SelectSoundPlay("SELECT Path FROM MusicT1 WHERE Name = 'D#1'");
                            D_S1_button.BackColor = SystemColors.GrayText;
                            await Task.Delay(TimeSpan.FromSeconds(0.6));
                            D_S1_button.BackColor = Color.Black;
                            break;
                        case 3:
                            SelectSoundPlay("SELECT Path FROM MusicT1 WHERE Name = 'E1'");
                            E1_button.BackColor = SystemColors.GrayText;
                            await Task.Delay(TimeSpan.FromSeconds(0.6));
                            E1_button.BackColor = Color.White;
                            break;
                        case 4:
                            SelectSoundPlay("SELECT Path FROM MusicT1 WHERE Name = 'D#1'");
                            D_S1_button.BackColor = SystemColors.GrayText;
                            await Task.Delay(TimeSpan.FromSeconds(0.6));
                            D_S1_button.BackColor = Color.Black;
                            break;
                        case 5:
                            SelectSoundPlay("SELECT Path FROM MusicT1 WHERE Name = 'E1'");
                            E1_button.BackColor = SystemColors.GrayText;
                            await Task.Delay(TimeSpan.FromSeconds(0.6));
                            E1_button.BackColor = Color.White;
                            break;
                        case 6:
                            SelectSoundPlay("SELECT Path FROM MusicT1 WHERE Name = 'B'");
                            B_button.BackColor = SystemColors.GrayText;
                            await Task.Delay(TimeSpan.FromSeconds(0.6));
                            B_button.BackColor = Color.White;
                            break;
                        case 7:
                            SelectSoundPlay("SELECT Path FROM MusicT1 WHERE Name = 'D1'");
                            D1_button.BackColor = SystemColors.GrayText;
                            await Task.Delay(TimeSpan.FromSeconds(0.6));
                            D1_button.BackColor = Color.White;
                            break;
                        case 8:
                            SelectSoundPlay("SELECT Path FROM MusicT1 WHERE Name = 'C1'");
                            C1_button.BackColor = SystemColors.GrayText;
                            await Task.Delay(TimeSpan.FromSeconds(0.6));
                            C1_button.BackColor = Color.White;
                            break;
                        case 9:
                            SelectSoundPlay("SELECT Path FROM MusicT1 WHERE Name = 'A'");
                            A_button.BackColor = SystemColors.GrayText;
                            await Task.Delay(TimeSpan.FromSeconds(1.1));
                            A_button.BackColor = Color.White;
                            break;
                        case 10:
                            SelectSoundPlay("SELECT Path FROM MusicT1 WHERE Name = 'C'");
                            C_button.BackColor = SystemColors.GrayText;
                            await Task.Delay(TimeSpan.FromSeconds(0.7));
                            C_button.BackColor = Color.White;
                            break;
                        case 11:
                            SelectSoundPlay("SELECT Path FROM MusicT1 WHERE Name = 'E'");
                            E_button.BackColor = SystemColors.GrayText;
                            await Task.Delay(TimeSpan.FromSeconds(0.7));
                            E_button.BackColor = Color.White;
                            break;
                        case 12:
                            SelectSoundPlay("SELECT Path FROM MusicT1 WHERE Name = 'A'");
                            A_button.BackColor = SystemColors.GrayText;
                            await Task.Delay(TimeSpan.FromSeconds(0.7));
                            A_button.BackColor = Color.White;
                            break;
                        case 13:
                            SelectSoundPlay("SELECT Path FROM MusicT1 WHERE Name = 'B'");
                            B_button.BackColor = SystemColors.GrayText;
                            await Task.Delay(TimeSpan.FromSeconds(1.0));
                            B_button.BackColor = Color.White;
                            break;
                        case 14:
                            SelectSoundPlay("SELECT Path FROM MusicT1 WHERE Name = 'E'");
                            E_button.BackColor = SystemColors.GrayText;
                            await Task.Delay(TimeSpan.FromSeconds(0.7));
                            E_button.BackColor = Color.White;
                            break;
                        case 15:
                            SelectSoundPlay("SELECT Path FROM MusicT1 WHERE Name = 'G#'");
                            G_S_button.BackColor = SystemColors.GrayText;
                            await Task.Delay(TimeSpan.FromSeconds(0.7));
                            G_S_button.BackColor = Color.Black;
                            break;
                        case 16:
                            SelectSoundPlay("SELECT Path FROM MusicT1 WHERE Name = 'B'");
                            B_button.BackColor = SystemColors.GrayText;
                            await Task.Delay(TimeSpan.FromSeconds(0.7));
                            B_button.BackColor = Color.White;
                            break;
                        case 17:
                            SelectSoundPlay("SELECT Path FROM MusicT1 WHERE Name = 'C1'");
                            C1_button.BackColor = SystemColors.GrayText;
                            await Task.Delay(TimeSpan.FromSeconds(0.7));
                            C1_button.BackColor = Color.White;
                            break;

                    }
                }
            }
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Sample_radioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (Sample_radioButton.Checked == true)
            {
                Fur_Eilse_button.Enabled = true;
                Marryhad_button.Enabled = true;
            }
            else 
            {
                Fur_Eilse_button.Enabled = false;
                Marryhad_button.Enabled = false;
            }
        }

        private void Music_radioButton_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void Stop_button_Click(object sender, EventArgs e)
        {
            stop = true;
        }

        private async void Marryhad_button_ClickAsync(object sender, EventArgs e)
        {
            stop = false;
            for (int i = 1; i <= 25; i++)
            {
                if (stop == false)
                {
                    switch (i)
                    {
                        case 1:
                            SelectSoundPlay("SELECT Path FROM MusicT1 WHERE Name = 'E'");
                            E_button.BackColor = SystemColors.GrayText;
                            await Task.Delay(TimeSpan.FromSeconds(0.8));
                            E_button.BackColor = Color.White;
                            break;
                        case 2:
                            SelectSoundPlay("SELECT Path FROM MusicT1 WHERE Name = 'D'");
                            D_button.BackColor = SystemColors.GrayText;
                            await Task.Delay(TimeSpan.FromSeconds(0.8));
                            D_button.BackColor = Color.White;
                            break;
                        case 3:
                            SelectSoundPlay("SELECT Path FROM MusicT1 WHERE Name = 'C'");
                            C_button.BackColor = SystemColors.GrayText;
                            await Task.Delay(TimeSpan.FromSeconds(0.8));
                            C_button.BackColor = Color.White;
                            break;
                        case 4:
                            SelectSoundPlay("SELECT Path FROM MusicT1 WHERE Name = 'D'");
                            D_button.BackColor = SystemColors.GrayText;
                            await Task.Delay(TimeSpan.FromSeconds(0.8));
                            D_button.BackColor = Color.White;
                            break;
                        case 5:
                            SelectSoundPlay("SELECT Path FROM MusicT1 WHERE Name = 'E'");
                            E_button.BackColor = SystemColors.GrayText;
                            await Task.Delay(TimeSpan.FromSeconds(0.7));
                            E_button.BackColor = Color.White;
                            break;
                        case 6:
                            SelectSoundPlay("SELECT Path FROM MusicT1 WHERE Name = 'E'");
                            E_button.BackColor = SystemColors.GrayText;
                            await Task.Delay(TimeSpan.FromSeconds(0.7));
                            E_button.BackColor = Color.White;
                            break;
                        case 7:
                            SelectSoundPlay("SELECT Path FROM MusicT1 WHERE Name = 'E'");
                            E_button.BackColor = SystemColors.GrayText;
                            await Task.Delay(TimeSpan.FromSeconds(0.8));
                            E_button.BackColor = Color.White;
                            break;
                        case 8:
                            SelectSoundPlay("SELECT Path FROM MusicT1 WHERE Name = 'D'");
                            D_button.BackColor = SystemColors.GrayText;
                            await Task.Delay(TimeSpan.FromSeconds(0.7));
                            D_button.BackColor = Color.White;
                            break;
                        case 9:
                            SelectSoundPlay("SELECT Path FROM MusicT1 WHERE Name = 'D'");
                            D_button.BackColor = SystemColors.GrayText;
                            await Task.Delay(TimeSpan.FromSeconds(0.7));
                            D_button.BackColor = Color.White;
                            break;
                        case 10:
                            SelectSoundPlay("SELECT Path FROM MusicT1 WHERE Name = 'D'");
                            D_button.BackColor = SystemColors.GrayText;
                            await Task.Delay(TimeSpan.FromSeconds(0.8));
                            D_button.BackColor = Color.White;
                            break;
                        case 11:
                            SelectSoundPlay("SELECT Path FROM MusicT1 WHERE Name = 'E'");
                            E_button.BackColor = SystemColors.GrayText;
                            await Task.Delay(TimeSpan.FromSeconds(0.7));
                            E_button.BackColor = Color.White;
                            break;
                        case 12:
                            SelectSoundPlay("SELECT Path FROM MusicT1 WHERE Name = 'E'");
                            E_button.BackColor = SystemColors.GrayText;
                            await Task.Delay(TimeSpan.FromSeconds(0.7));
                            E_button.BackColor = Color.White;
                            break;
                        case 13:
                            SelectSoundPlay("SELECT Path FROM MusicT1 WHERE Name = 'E'");
                            E_button.BackColor = SystemColors.GrayText;
                            await Task.Delay(TimeSpan.FromSeconds(1));
                            E_button.BackColor = Color.White;
                            break;
                        case 14:
                            SelectSoundPlay("SELECT Path FROM MusicT1 WHERE Name = 'E'");
                            E_button.BackColor = SystemColors.GrayText;
                            await Task.Delay(TimeSpan.FromSeconds(0.8));
                            E_button.BackColor = Color.White;
                            break;
                        case 15:
                            SelectSoundPlay("SELECT Path FROM MusicT1 WHERE Name = 'D'");
                            D_button.BackColor = SystemColors.GrayText;
                            await Task.Delay(TimeSpan.FromSeconds(0.8));
                            D_button.BackColor = Color.White;
                            break;
                        case 16:
                            SelectSoundPlay("SELECT Path FROM MusicT1 WHERE Name = 'C'");
                            C_button.BackColor = SystemColors.GrayText;
                            await Task.Delay(TimeSpan.FromSeconds(0.8));
                            C_button.BackColor = Color.White;
                            break;
                        case 17:
                            SelectSoundPlay("SELECT Path FROM MusicT1 WHERE Name = 'D'");
                            D_button.BackColor = SystemColors.GrayText;
                            await Task.Delay(TimeSpan.FromSeconds(0.8));
                            D_button.BackColor = Color.White;
                            break;
                        case 18:
                            SelectSoundPlay("SELECT Path FROM MusicT1 WHERE Name = 'E'");
                            E_button.BackColor = SystemColors.GrayText;
                            await Task.Delay(TimeSpan.FromSeconds(0.7));
                            E_button.BackColor = Color.White;
                            break;
                        case 19:
                            SelectSoundPlay("SELECT Path FROM MusicT1 WHERE Name = 'E'");
                            E_button.BackColor = SystemColors.GrayText;
                            await Task.Delay(TimeSpan.FromSeconds(0.7));
                            E_button.BackColor = Color.White;
                            break;
                        case 20:
                            SelectSoundPlay("SELECT Path FROM MusicT1 WHERE Name = 'E'");
                            E_button.BackColor = SystemColors.GrayText;
                            await Task.Delay(TimeSpan.FromSeconds(0.8));
                            E_button.BackColor = Color.White;
                            break;
                        case 21:
                            SelectSoundPlay("SELECT Path FROM MusicT1 WHERE Name = 'D'");
                            D_button.BackColor = SystemColors.GrayText;
                            await Task.Delay(TimeSpan.FromSeconds(0.7));
                            D_button.BackColor = Color.White;
                            break;
                        case 22:
                            SelectSoundPlay("SELECT Path FROM MusicT1 WHERE Name = 'D'");
                            D_button.BackColor = SystemColors.GrayText;
                            await Task.Delay(TimeSpan.FromSeconds(0.7));
                            D_button.BackColor = Color.White;
                            break;
                        case 23:
                            SelectSoundPlay("SELECT Path FROM MusicT1 WHERE Name = 'E'");
                            E_button.BackColor = SystemColors.GrayText;
                            await Task.Delay(TimeSpan.FromSeconds(0.7));
                            E_button.BackColor = Color.White;
                            break;
                        case 24:
                            SelectSoundPlay("SELECT Path FROM MusicT1 WHERE Name = 'D'");
                            D_button.BackColor = SystemColors.GrayText;
                            await Task.Delay(TimeSpan.FromSeconds(0.7));
                            D_button.BackColor = Color.White;
                            break;
                        case 25:
                            SelectSoundPlay("SELECT Path FROM MusicT1 WHERE Name = 'C'");
                            C_button.BackColor = SystemColors.GrayText;
                            await Task.Delay(TimeSpan.FromSeconds(0.8));
                            C_button.BackColor = Color.White;
                            break;
                        
                    }
                }
            }
        }

        private void ShowDetail_button_Click(object sender, EventArgs e)
        {
           
        }
    }
}
