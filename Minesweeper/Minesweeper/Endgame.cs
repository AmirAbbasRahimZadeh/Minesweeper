using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Minesweeper
{
    public partial class Endgame : Form
    {
        public Endgame()
        {
            InitializeComponent();
        }

        bool issaved;

        private async void Endgame_Load(object sender, EventArgs e)
        {
            if (global.islight)
            {
                global.changetheme(this, global.light);
                global.changetheme(pnl_details, global.light);
            }
            else
            {
                global.changetheme(this, global.dark);
                global.changetheme(pnl_details, global.dark);
            }
            //size is 450*260 at first
            int xloc = global.gameform_loc.X;
            if (this.Height < global.gametable_size.Y)
            {
                this.Height = global.gametable_size.Y;
            }
            if (this.Width < global.gametable_size.X)
            {
                xloc += global.gametable_loc.X;
                this.Width = global.gametable_size.X;
            }
            this.Location = new Point(xloc, global.gametable_loc.Y + global.gameform_loc.Y);
            pnl_details.Location = new Point((this.ClientSize.Width - pnl_details.Width) / 2, (this.ClientSize.Height - pnl_details.Height) / 2);
            lb_endgame.Text = global.endgame_text;

            if (global.issoundon)
            {
                global.issoundon = false;
                await Task.Delay(200);
                global.issoundon = true;
            }
            
            global.stayopen = false;

            issaved = false;
        }

        private void btn_again_Click(object sender, EventArgs e)
        {
            Form newgame = new game();
            newgame.Show();
            this.Close();
        }

        private void btn_menu_Click(object sender, EventArgs e)
        {
            Form backToMenu = new Menu();
            backToMenu.Show();
            this.Close();
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to exit?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            global.stayopen = true;
            this.Close();
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            if (issaved)
            {
                MessageBox.Show("This game is already saved!");
            }
            else
            {
                issaved = true;
                File.SetAttributes(global.HistoryPath, FileAttributes.Normal);
                File.AppendAllText(global.HistoryPath, '\n' + global.endgame_text + '\n' + new string('-', 60)); 
                File.SetAttributes(global.HistoryPath, FileAttributes.Hidden);
            }
        }
    }
}
