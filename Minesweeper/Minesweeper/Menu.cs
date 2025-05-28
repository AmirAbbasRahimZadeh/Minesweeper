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
using System.IO;
using AxWMPLib;

namespace Minesweeper
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        string music_Path = Path.Combine(Application.StartupPath, "Assets", "Music.mp3");
        
        private void takers_enabled(bool enable)
        {
            tb_rowtaker.Enabled = enable;
            tb_colstaker.Enabled = enable;
            tb_minestaker.Enabled = enable;
        }
        private void tb_takers_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true; 
            }
        }


        private void Menu_Load(object sender, EventArgs e)
        {
            if (!File.Exists(global.HistoryPath))
            {
                File.WriteAllText(global.HistoryPath, ""); 
            }

            if (global.islight)
            {
                global.changetheme(this, global.light);
            }
            else
            {
                global.changetheme(this, global.dark);
            }

            takers_enabled(false);

            if (global.issoundon)
            {
                pb_soundisoff.Visible = false;
                pb_soundison.Visible = true;
            }
            else
            {
                pb_soundisoff.Visible = true;
                pb_soundison.Visible = false;
            }

            Music.Visible = false;
            Music.URL = music_Path;
            Music.settings.setMode("loop", true);
            Music.Ctlcontrols.play();
            if (global.issoundon)
            {
                Music.settings.volume = 100;
            }
            else
            {
                Music.settings.volume = 0;
            }
        }

        private async void btn_start_Click(object sender, EventArgs e)
        {
            global.Setting.rows = Convert.ToInt16('0' + tb_rowtaker.Text);
            global.Setting.cols = Convert.ToInt16('0' + tb_colstaker.Text);
            global.Setting.mins = Convert.ToInt16('0' + tb_minestaker.Text);

            if ((global.Setting.rows < 25 && global.Setting.rows > 0) &&
                (global.Setting.cols < 44 && global.Setting.cols > 0) &&
                 global.Setting.mins < global.Setting.rows * global.Setting.cols && global.Setting.mins > 0)
            {
                Button btn = sender as Button;

                if (btn == btn_multiplayer)
                    global.Setting.gamemode = "Multiplayer";
                else if (btn == btn_uh)
                    global.Setting.gamemode = "Unlimited Hints";
                else if (btn == btn_lh)
                    global.Setting.gamemode = "Limited Hints";
                else if (btn == btn_nh)
                    global.Setting.gamemode = "Strict";

                Form newgame = new game();
                newgame.Show();
                this.Hide();
                if(global.issoundon)
                {
                    while (Music.settings.volume > 1)
                    {
                        Music.settings.volume--;
                        await Task.Delay(1);
                    }
                }
                Music.Ctlcontrols.stop();
            }
            else
            {
                MessageBox.Show("Invalid amounts!");
            }
        }


        private void rb_easy_CheckedChanged(object sender, EventArgs e)
        {
            tb_rowtaker.Text = "9";
            tb_colstaker.Text = "9";
            tb_minestaker.Text = "10";
            takers_enabled(false);
        }

        private void rb_medium_CheckedChanged(object sender, EventArgs e)
        {
            tb_rowtaker.Text = "16";
            tb_colstaker.Text = "16";
            tb_minestaker.Text = "40";
            takers_enabled(false);
        }

        private void rb_hard_CheckedChanged(object sender, EventArgs e)
        {
            tb_rowtaker.Text = "16";
            tb_colstaker.Text = "30";
            tb_minestaker.Text = "99";
            takers_enabled(false);
        }

        private void rb_costum_CheckedChanged(object sender, EventArgs e)
        {
            takers_enabled(true);
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to exit?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btn_light_Click(object sender, EventArgs e)
        {
            if (!global.islight)
            {
                global.islight = true;
                global.changetheme(this, global.light);
            }
        }

        private void btn_dark_Click(object sender, EventArgs e)
        {
            if (global.islight)
            {
                global.islight = false;
                global.changetheme(this, global.dark);
            }
        }

        private void bt_singlestart_Click(object sender, EventArgs e)
        {
            panelmodes.Visible = !panelmodes.Visible;
        }

        private void btn_theme_Click(object sender, EventArgs e)
        {
            ph_theme.Visible = !ph_theme.Visible;
        }

        private void pb_soundisoff_Click(object sender, EventArgs e)
        {
            pb_soundisoff.Visible = false;
            pb_soundison.Visible = true;
            global.issoundon = true;
            Music.settings.volume = 100;
        }

        private void pb_soundison_Click(object sender, EventArgs e)
        {
            pb_soundisoff.Visible = true;
            pb_soundison.Visible = false;
            global.issoundon = false;
            Music.settings.volume = 0;
        }

        private void btn_history_Click(object sender, EventArgs e)
        {
            Form newhistory = new History();
            newhistory.ShowDialog();
        }

    }
}
