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

namespace Minesweeper
{
    public partial class game : Form
    {
        

        public game()
        {
            InitializeComponent();
        }

        private Button[,] buttonGrid;
        private Panel gamepanel;

        Random rnd = new Random();

        int rows;
        int cols;
        int mins;
        string gamemode;

        bool turn;
        int p1score;
        int p2score;
        int multiwinbombs;

        int singlewinbombs;
        int correctClicks;
        int hints; 

        bool isfinished;

        Image Bomb;
        Image Flag;
        Image Explode;

        SoundPlayer FLAG;
        SoundPlayer FLAG_R;
        SoundPlayer MIN;
        SoundPlayer OPEN;
        SoundPlayer HINT;
        SoundPlayer WIN;
        SoundPlayer MIN2;
        //SoundPlayer START is not here, just playing when game loads

        int second;
        int p1second;
        int p2second;

        int de; //delay amount

        private void game_Load(object sender, EventArgs e)
        {
            if (global.issoundon)
            {
                new SoundPlayer(Properties.Resources.START).Play();
            }

            this.ClientSize = new Size(450, 200);
            this.StartPosition = FormStartPosition.Manual;

            rows = global.Setting.rows;
            cols = global.Setting.cols;
            mins = global.Setting.mins;
            lb_mines.Text = Convert.ToString(mins);
            isfinished = false;
            int buttonsize;
            if (rows < 17)
            {
                buttonsize = 30;
            }
            else if (rows < 20)
            {
                buttonsize = 25;
            }
            else
            {
                buttonsize = 20;
            }

            Flag = new Bitmap(Properties.Resources.Flag_Icon, new Size(buttonsize, buttonsize));
            Bomb = new Bitmap(Properties.Resources.Bomb_Icon, new Size(buttonsize-5, buttonsize-5));
            Explode = new Bitmap(Properties.Resources.Explode_Icon, new Size(buttonsize - 5, buttonsize - 5));

            FLAG = new SoundPlayer(Properties.Resources.FLAG);
            FLAG_R = new SoundPlayer(Properties.Resources.FLAG_R);
            MIN = new SoundPlayer(Properties.Resources.MIN);
            OPEN = new SoundPlayer(Properties.Resources.OPEN);
            HINT = new SoundPlayer(Properties.Resources.HINT);
            WIN = new SoundPlayer(Properties.Resources.WIN);
            MIN2 = new SoundPlayer(Properties.Resources.MIN2);

            gamemode = global.Setting.gamemode;
            gamepanel = new Panel();
            gamepanel.Size = new Size(cols * buttonsize, rows * buttonsize); 
            
            if (cols * buttonsize >= this.ClientSize.Width)
            {
                this.ClientSize = new Size((cols + 2) * buttonsize, this.ClientSize.Height + gamepanel.Height);
                gamepanel.Location = new Point(buttonsize, 125);
            }
            else
            {
                this.ClientSize = new Size(this.ClientSize.Width, this.ClientSize.Height + gamepanel.Height);
                gamepanel.Location = new Point((this.Width - gamepanel.Width) / 2, 125);
            }

            this.Location = new Point((Screen.PrimaryScreen.Bounds.Width - this.Width) / 2, (Screen.PrimaryScreen.Bounds.Height - this.Height) / 2);

            if (global.islight) 
            {
                global.changetheme(this, global.light);
                global.changetheme(panel2, global.light);
            }
            else
            {
                global.changetheme(this, global.dark);
                global.changetheme(panel2, global.dark);
            }

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

            this.Controls.Add(gamepanel);
            buttonGrid = global.CreateTable(gamepanel, rows, cols, buttonsize, ButtonClicked, Button_RightClick);

            //placing bombs and numbers
            if (mins > rows * cols * 0.6) //bombs are too much
            {
                foreach (Control c in gamepanel.Controls)
                    {
                        Button bt = c as Button;
                        if (bt != null)
                        {
                            global.btn_att info = (global.btn_att)bt.Tag;
                            if ((info.row == 0 || info.row == rows - 1) && (info.col == 0 || info.col == cols -1))
                            {
                                info.back_status = '3';
                            }
                            else if (info.row == 0 || info.row == rows - 1 || info.col == 0 || info.col == cols - 1)
                                info.back_status = '5';
                            else
                            {
                                info.back_status = '8';
                            }
                        }
                    }
                for (int i = 0; i < rows*cols - mins; i++)
                {
                    int r = rnd.Next(0, rows);
                    int c = rnd.Next(0, cols);
                    global.btn_att info = (global.btn_att)buttonGrid[r, c].Tag;
                    if (info.not_bomb)
                    {
                        i--;
                        continue;
                    }
                    else
                    {
                        info.not_bomb = true;
                        for (int i2 = r - 1; i2 <= r + 1; i2++)
                        {
                            for (int j2 = c - 1; j2 <= c + 1; j2++)
                            {
                                if ((i2 != r || j2 != c) && i2 < rows && j2 < cols && i2 >= 0 && j2 >= 0)
                                {
                                    global.btn_att info2 = (global.btn_att)buttonGrid[i2, j2].Tag;
                                        info2.back_status--;
                                }
                            }
                        }
                    }
                }
                foreach (Control c in gamepanel.Controls)
                {
                    Button bt = c as Button;
                    if (bt != null)
                    {
                        global.btn_att info = (global.btn_att)bt.Tag;
                        if (!info.not_bomb)
                        {
                            info.back_status = 'm';
                        }
                    }
                }
            }
            else //bombs are less than 60%
            {
                for (int i = 0; i < mins; i++) 
                {
                    int r = rnd.Next(0, rows);
                    int c = rnd.Next(0, cols);
                    global.btn_att info = (global.btn_att)buttonGrid[r, c].Tag;
                    if (info.back_status == 'm')
                    {
                        i--;
                        continue;
                    }
                    else
                    {
                        info.back_status = 'm';
                        for (int i2 = r - 1; i2 <= r + 1; i2++)
                        {
                            for (int j2 = c - 1; j2 <= c + 1; j2++)
                            {
                                if ((i2 != r || j2 != c) && i2 < rows && j2 < cols && i2 >= 0 && j2 >= 0)
                                {
                                    global.btn_att info2 = (global.btn_att)buttonGrid[i2, j2].Tag;
                                    if (info2.back_status != 'm')
                                    {
                                        info2.back_status++;
                                    }
                                }
                            }
                        }
                    }
                }
            }

            //placing numbers(we did it with bombs)
            //for (int i = 0; i < rows; i++)
            //{
            //    for (int j = 0; j < cols; j++)
            //    {
            //        global.btn_att info = (global.btn_att)buttonGrid[i, j].Tag;
            //        if (info.back_status != 'm')
            //        {
            //            int mines = 0;
            //            for (int i2 = i - 1; i2 <= i + 1; i2++)
            //            {
            //                for (int j2 = j - 1; j2 <= j + 1; j2++)
            //                {
            //                    if ((i2 != i || j2 != j) && i2 < rows && j2 < cols && i2 >=0 && j2 >= 0)
            //                    {
            //                        global.btn_att info2 = (global.btn_att)buttonGrid[i2, j2].Tag;
            //                        if (info2.back_status == 'm')
            //                        {
            //                            mines++;
            //                        }
            //                    }
            //                }
            //            }
            //            info.back_status = Convert.ToChar('0' + mines);
            //        }
            //    }
            //}

            panel2.Location = new Point((this.ClientSize.Width - panel2.Width) / 2, 0);

            if (gamemode == "Multiplayer")
            {
                p1score = 0;
                p2score = 0;
                p1second = 0;
                p2second = 0;
                turn = true;
                multiwinbombs = mins/2 + 1;
                this.Controls.Remove(bt_Hint);
                bt_Hint.Dispose();
                label1.ForeColor = Color.Blue;
                label2.ForeColor = Color.Red;
                label1.BackColor = Color.LightBlue;
                lb_p1timer.ForeColor = Color.Blue;
                lb_p2timer.ForeColor = Color.Red;
                label3.ForeColor = Color.FromArgb(186, 85, 211);
                label1.Text = "Player1:  ";
                label2.Text = "Player2:  ";
                lb_p1timer.Text = "";
                lb_p2timer.Text = "";
                label3.Text = "Find " + Convert.ToString(multiwinbombs) + " mines to win";
                label1.Location = new Point((this.ClientSize.Width - label1.Width) / 2, this.ClientSize.Height - 60);
                lb_p1timer.Location = new Point(label1.Location.X - 25, this.ClientSize.Height - 60);
                label2.Location = new Point((this.ClientSize.Width - label2.Width) / 2, this.ClientSize.Height - 45);
                lb_p2timer.Location = new Point(label2.Location.X - 25, this.ClientSize.Height - 45);
                label3.Location = new Point((this.ClientSize.Width - label3.Width) / 2, this.ClientSize.Height - 30);
            }
            else
            {
                this.Controls.Remove(label2);
                label2.Dispose();
                this.Controls.Remove(label3);
                label3.Dispose();
                this.Controls.Remove(lb_p1timer);
                lb_p1timer.Dispose();
                this.Controls.Remove(lb_p2timer);
                lb_p2timer.Dispose();


                if (gamemode == "Strict")
                {
                    hints = 0;
                }
                else if (gamemode == "Unlimited Hints")
                {
                    hints = -1;
                }
                else
                {
                    hints = (rows * cols - mins) / 15 + 1;
                }

                bt_Hint.Location = new Point((this.ClientSize.Width - bt_Hint.Width) / 2, this.ClientSize.Height - 45);
                if (hints == -1)
                {
                    label1.Text = "you have unlimited hints";
                }
                else
                {
                    label1.Text = "you have " + hints + " hints";
                }
                label1.ForeColor = Color.FromArgb(186, 85, 211);
                label1.Location = new Point((this.ClientSize.Width - label1.Width) / 2, this.ClientSize.Height - 60);
                singlewinbombs = rows * cols - mins;
                correctClicks = 0;
            }
            second = 0;
            timer1.Interval = 1000;  // 1000 ms
            de = 300;
        }

        private void opening(Button btn)
        {
            global.btn_att info = (global.btn_att)btn.Tag;
            char mines = info.back_status;
            int i = info.row;
            int j = info.col;
            if (mines != 'm' && info.status == 'c')
            {
                if (gamemode != "Multiplayer" && !isfinished)
                {
                    correctClicks++;
                }
                info.status = 'o';
                if (global.islight)
                {
                    btn.BackColor = global.light.color1;
                }
                else
                {
                    btn.BackColor = global.dark.color1;
                }
                switch (mines)
                {
                    case '0':
                        for (int i2 = i - 1; i2 <= i + 1; i2++)
                        {
                            for (int j2 = j - 1; j2 <= j + 1; j2++)
                            {
                                if ((i2 != i || j2 != j) && i2 < rows && j2 < cols && i2 >= 0 && j2 >= 0)
                                {
                                    opening(buttonGrid[i2, j2]);
                                }
                            }
                        }
                        break;
                    case '1':
                        btn.ForeColor = Color.Blue;
                        break;
                    case '2':
                        btn.ForeColor = Color.Green;
                        break;
                    case '3':
                        btn.ForeColor = Color.Red;
                        break;
                    case '4':
                        btn.ForeColor = Color.Navy;
                        break;
                    case '5':
                        btn.ForeColor = Color.Maroon;
                        break;
                    case '6':
                        btn.ForeColor = Color.Teal;
                        break;
                    case '7':
                        btn.ForeColor = Color.Black;
                        break;
                    case '8':
                        btn.ForeColor = Color.Gray;
                        break;
                }
                if (mines != '0')
                {
                    btn.Text = Convert.ToString(mines);
                }
            }
        }

        private async void ButtonClicked(object sender, EventArgs e) 
        {
            if (!timer1.Enabled)
            {
                timer1.Start();
            }
            Button btn = sender as Button;
            global.btn_att info = (global.btn_att)btn.Tag;
            if (info.status == 'c')
            {
                if (global.islight)
                {
                    btn.BackColor = global.light.color1;
                }
                else
                {
                    btn.BackColor = global.dark.color1;
                }

                if (info.back_status == '0')
                {
                    if (global.issoundon)
                    {
                        OPEN.Play();
                    }
                }

                if (info.back_status == 'm')
                {
                    if (gamemode == "Multiplayer")
                    {
                        mins--;
                        lb_mines.Text = Convert.ToString(mins);
                        if (turn)
                        {
                            btn.ForeColor = Color.Blue;
                            btn.Text = "🔴";
                            if (global.issoundon)
                            {
                                MIN2.Play();
                            }
                            p1score += 1;
                            label1.Text = "Player1: " + Convert.ToString(p1score);
                            if (p1score == multiwinbombs)
                            {
                                isfinished = true;
                                if (global.issoundon)
                                {
                                    WIN.Play();
                                }
                                global.endgame_text = "player1 won!\n\nTimes:\n    Total:    " + Convert.ToString(second) +
                                    "s\n    Player1:    " + Convert.ToString(p1second) + "s\n    Player2:    " + Convert.ToString(p2second) +
                                    "s\n\nScores:\n    Player1:    " + Convert.ToString(p1score) + "\n    Player2:    " + Convert.ToString(p2score) +
                                    "\n\nMap:\n    Height:    " + Convert.ToString(rows) + "\n    Width:    " + Convert.ToString(cols) + "\n    Mines:    " + Convert.ToString(global.Setting.mins);
                            }
                        }
                        else
                        {
                            btn.ForeColor = Color.Red;
                            btn.Text = "🔴";
                            if (global.issoundon)
                            {
                                MIN2.Play();
                            }
                            p2score += 1;
                            label2.Text = "Player2: " + Convert.ToString(p2score);
                            if (p2score == multiwinbombs)
                            {
                                isfinished = true;
                                if (global.issoundon)
                                {
                                    WIN.Play();
                                }
                                global.endgame_text = "player2 won!\n\nTimes:\n    Total:    " + Convert.ToString(second) +
                                    "s\n    Player1:    " + Convert.ToString(p1second) + "s\n    Player2:    " + Convert.ToString(p2second) +
                                    "s\n\nScores:\n    Player1:    " + Convert.ToString(p1score) + "\n    Player2:    " + Convert.ToString(p2score) +
                                    "\n\nMap:\n    Height:    " + Convert.ToString(rows) + "\n    Width:    " + Convert.ToString(cols) + "\n    Mines:    " + Convert.ToString(global.Setting.mins);
                            }
                        }
                        if (mins == 0 && !isfinished)
                        {
                            isfinished = true;
                            if (global.issoundon)
                            {
                                WIN.Play();
                            }
                            global.endgame_text = "Draw!\n\nTimes:\n    Total:    " + Convert.ToString(second) +
                                    "s\n    Player1:    " + Convert.ToString(p1second) + "s\n    Player2:    " + Convert.ToString(p2second) +
                                    "s\n\nScores:\n    Player1:    " + Convert.ToString(p1score) + "\n    Player2:    " + Convert.ToString(p2score) +
                                    "\n\nMap:\n    Height:    " + Convert.ToString(rows) + "\n    Width:    " + Convert.ToString(cols) + "\n    Mines:    " + Convert.ToString(global.Setting.mins);
                        }
                    }
                    else
                    {
                        isfinished = true;
                        btn.Image = Bomb;
                        btn.BackColor = Color.Salmon;
                        await Task.Delay(de);
                        btn.Image = Explode;
                        if (global.issoundon)
                        {
                            MIN.Play();
                        }
                        label1.Text = "Click on the empty space to stop animation";
                        label1.Location = new Point((this.ClientSize.Width - label1.Width) / 2, this.ClientSize.Height - 60);
                        label1.ForeColor = Color.Red;
                        global.endgame_text = "You lost!\n\nType:   " + Convert.ToString(gamemode) + "\n\nTime:    " + Convert.ToString(second) +
                                    "s\n\nMap:\n    Height:   " + Convert.ToString(rows) + "\n    Width:    " + Convert.ToString(cols) + "\n    Mines:    " + Convert.ToString(global.Setting.mins) +
                                    "\n\nYou opened " + Convert.ToString(correctClicks * 100 / singlewinbombs) + "% of empty map!" +
                                    "\nYou opened " + Convert.ToString(correctClicks * 100 / (rows * cols)) + "% of whole map!";
                    }
                }
                else
                {
                    opening(btn);
                    if (gamemode == "Multiplayer")
                    {
                        turn = !turn;
                        if (turn)
                        {
                            label1.BackColor = Color.LightBlue;
                            label2.BackColor = Color.Transparent;
                        }
                        else
                        {
                            label1.BackColor = Color.Transparent;
                            label2.BackColor = Color.Salmon;
                        }
                    }
                    else
                    {
                        if (correctClicks == singlewinbombs)
                        {
                            isfinished = true;
                            if (global.issoundon)
                            {
                                WIN.Play();
                            }
                            global.endgame_text = "You won!\n\nType:    " + Convert.ToString(gamemode) + "\n\nTime:    " + Convert.ToString(second) +
                                    "s\n\nMap:\n    Height:   " + Convert.ToString(rows) + "\n    Width:    " + Convert.ToString(cols) + "\n    Mines:    " + Convert.ToString(global.Setting.mins);
                        }
                    }
                }
                info.status = 'o';
                if (isfinished)
                {
                    timer1.Stop();
                    foreach (Control c in gamepanel.Controls)
                    {
                        Button bt = c as Button;
                        if (bt != null)
                        {
                            global.btn_att info2 = (global.btn_att)bt.Tag;
                            opening(bt);
                            if(info2.status == 'c') //so it's bomb
                            {
                                bt.Image = Bomb;
                                bt.BackColor = this.BackColor;                              
                            }
                            else if (info2.status == 'f')
                            {
                                bt.BackColor = this.BackColor;
                                if (info2.back_status == 'm')
                                {
                                    bt.ForeColor = global.light.color3;
                                    bt.Text = "✔️";
                                }
                                else
                                {
                                    bt.ForeColor = Color.Red;
                                    bt.Text = "❌";
                                }
                            }
                            bt.Click -= ButtonClicked;
                            bt.MouseDown -= Button_RightClick;
                        }
                    }

                    if (gamemode != "Multiplayer" && correctClicks != singlewinbombs) //explode animation
                    {
                        bool loop = true;
                        int i = info.row - 1;  //info is related to clicked btn
                        int j = info.col - 1;
                        int k = 2;

                        while (loop)
                        {
                            loop = false;

                            int limit = j + k;
                            for (; j < limit; j++) //in the upper row we go right
                            {
                                if(j < cols && j > -1 && i > -1) //i < rows is already passed because we went up
                                {
                                    loop = true;
                                    if(buttonGrid[i,j].Image==Bomb)
                                    {
                                        if (de > 30)
                                        {
                                            de = de * 98 / 100;
                                        }
                                        await Task.Delay(de);
                                        buttonGrid[i, j].Image = Explode;
                                        if (global.issoundon)
                                        {
                                            MIN.Play();
                                        }
                                    }
                                }
                            }

                            limit = i + k;
                            for (; i < limit; i++) //in the right col we go down
                            {
                                if (i < rows && j < cols && i > -1) //j > -1 is already passed because we went right
                                {
                                    loop = true;
                                    if (buttonGrid[i, j].Image == Bomb)
                                    {
                                        if (de > 30)
                                        {
                                            de = de * 98 / 100;
                                        }
                                        await Task.Delay(de);
                                        buttonGrid[i, j].Image = Explode;
                                        if (global.issoundon)
                                        {
                                            MIN.Play();
                                        }
                                    }
                                }
                            }

                            limit = j - k;
                            for (; j > limit; j--) //in the bottom row we go left
                            {
                                if (i < rows && j < cols && j > -1) //i > -1 is already passed because we went down
                                {
                                    loop = true;
                                    if (buttonGrid[i, j].Image == Bomb)
                                    {
                                        if (de > 30)
                                        {
                                            de = de * 98 / 100;
                                        }
                                        await Task.Delay(de);
                                        buttonGrid[i, j].Image = Explode;
                                        if (global.issoundon)
                                        {
                                            MIN.Play();
                                        }
                                    }
                                }
                            }

                            limit = i - k;
                            for (; i > limit; i--) //in the bottom row we go left
                            {
                                if (i < rows && i > -1 && j > -1) //j < cols is already passed because we went left
                                {
                                    loop = true;
                                    if (buttonGrid[i, j].Image == Bomb)
                                    {
                                        if (de > 30)
                                        {
                                            de = de * 98 / 100;
                                        }
                                        await Task.Delay(de);
                                        buttonGrid[i, j].Image = Explode;
                                        if (global.issoundon)
                                        {
                                            MIN.Play();
                                        }
                                    }
                                }
                            }

                            i--; //for new start position
                            j--; //for new start position
                            k += 2; //for new start position
                        }
                    }
                    global.gameform_loc = this.Location;
                    global.gametable_loc = gamepanel.Location;
                    global.gametable_size = (Point)gamepanel.ClientSize;
                    Form new_endgame = new Endgame();
                    new_endgame.ShowDialog(); //when we use show dialog this form will wait for our new form to end
                    if (!global.stayopen)
                    {
                        this.Close();
                    }
                }
            }
            
            

        }
        private void Button_RightClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right && gamemode != "Multiplayer")
            {
                Button btn = sender as Button;
                global.btn_att info = (global.btn_att)btn.Tag;
                if (info.status == 'c')
                {
                    mins--;
                    lb_mines.Text = Convert.ToString(mins);
                    info.status = 'f';
                    btn.Image = Flag;
                    if (global.issoundon)
                    {
                        FLAG.Play();
                    }
                }
                else if (info.status == 'f')
                {
                    mins++;
                    lb_mines.Text = Convert.ToString(mins);
                    info.status = 'c';
                    btn.Image = null;
                    if (global.issoundon)
                    {
                        FLAG_R.Play();
                    }
                }
            }
            
        }

        private void bt_Hint_Click(object sender, EventArgs e)
        {
            if (hints != 0 && !isfinished)
            {
                if (hints != -1)
                {
                    hints--;
                    label1.Text = "you have " + hints + " hints";
                }

                while (true)
                {
                    int r = rnd.Next(0, rows);
                    int c = rnd.Next(0, cols);
                    global.btn_att info = (global.btn_att)buttonGrid[r, c].Tag;
                    if (info.back_status != 'm' && info.status != 'o')
                    {
                        buttonGrid[r, c].BackColor = Color.FromArgb(186, 85, 211);
                        buttonGrid[r, c].FlatAppearance.BorderColor = Color.FromArgb(128, 0, 128);
                        break;
                    }
                }

                if (global.issoundon)
                {
                    HINT.Play();
                }
            }
        }

        private async void btn_menu_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Your current game will be lost. Are you sure?", "return to menu", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                if (isfinished)
                {
                    de = 0;
                    if (global.issoundon)
                    {
                        global.issoundon = false;
                        await Task.Delay(200);
                        global.issoundon = true;
                    }
                }
                Form backToMenu = new Menu();
                backToMenu.Show();
                this.Close();
            }
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to exit? Your current game will be lost.", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
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
        }

        private void pb_soundison_Click(object sender, EventArgs e)
        {
            pb_soundisoff.Visible = true;
            pb_soundison.Visible = false;
            global.issoundon = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            second++;
            int min = second / 60;
            int sec = second % 60;
            lb_timer.Text = Convert.ToString(min) + " : " + Convert.ToString(sec);
            if (gamemode == "Multiplayer")
            {
                if (turn)
                {
                    p1second++;
                    if (p1second < 1000)
                    {
                        lb_p1timer.Text = Convert.ToString(p1second);
                    }
                }
                else
                {
                    p2second++;
                    if (p2second < 1000)
                    {
                        lb_p2timer.Text = Convert.ToString(p2second);
                    }
                }
            }
        }

        private void btn_light_Click(object sender, EventArgs e)
        {
            if (!global.islight)
            {
                global.islight = true;
                global.changetheme(this, global.light);
                global.changetheme(panel2, global.light);

                foreach (Control c in gamepanel.Controls)
                {
                    Button bt = c as Button;
                    if (bt != null)
                    {
                        if (bt.BackColor == global.dark.color3)
                        {
                            bt.BackColor = global.light.color3;
                        }
                        if (bt.BackColor == global.dark.color1)
                        {
                            bt.BackColor = global.light.color1;
                        }
                    }
                }
            }
        }

        private void btn_dark_Click(object sender, EventArgs e)
        {
            if (global.islight)
            {
                global.islight = false;
                global.changetheme(this, global.dark);
                global.changetheme(panel2, global.dark);

                foreach (Control c in gamepanel.Controls)
                {
                    Button bt = c as Button;
                    if (bt != null)
                    {
                        if (bt.BackColor == global.light.color3)
                        {
                            bt.BackColor = global.dark.color3;
                        }
                        if (bt.BackColor == global.light.color1)
                        {
                            bt.BackColor = global.dark.color1;
                        }
                    }
                }
            }
        }

        private async void game_MouseDown(object sender, MouseEventArgs e)
        {
            if (isfinished)
            {
                de = 0;
                if (global.issoundon)
                {
                    global.issoundon = false;
                    await Task.Delay(200);
                    global.issoundon = true;
                }
            }

        }

        




    }
}
