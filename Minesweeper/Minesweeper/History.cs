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
    public partial class History : Form
    {
        public History()
        {
            InitializeComponent();
        }

        private void History_Load(object sender, EventArgs e)
        {
            if (global.islight)
            {
                global.changetheme(this, global.light);
            }
            else
            {
                global.changetheme(this, global.dark);
            }

            if (File.Exists(global.HistoryPath))
            {        
                lb_history.Text = File.ReadAllText(global.HistoryPath);
            }
            else
            {
                lb_history.Text = "";
            }
        }

        private void btn_reset_Click(object sender, EventArgs e)
        {
            lb_history.Text = "";
            File.SetAttributes(global.HistoryPath, FileAttributes.Normal);
            File.WriteAllText(global.HistoryPath, "");
            File.SetAttributes(global.HistoryPath, FileAttributes.Hidden);
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
