namespace Minesweeper
{
    partial class game
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(game));
            this.bt_Hint = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lb_mines = new System.Windows.Forms.Label();
            this.lb_timer = new System.Windows.Forms.Label();
            this.btn_menu = new System.Windows.Forms.Button();
            this.btn_theme = new System.Windows.Forms.Button();
            this.btn_exit = new System.Windows.Forms.Button();
            this.lb_sound = new System.Windows.Forms.Label();
            this.ph_theme = new System.Windows.Forms.Panel();
            this.btn_dark = new System.Windows.Forms.Button();
            this.btn_light = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pb_soundison = new System.Windows.Forms.PictureBox();
            this.pb_soundisoff = new System.Windows.Forms.PictureBox();
            this.lb_p1timer = new System.Windows.Forms.Label();
            this.lb_p2timer = new System.Windows.Forms.Label();
            this.ph_theme.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_soundison)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_soundisoff)).BeginInit();
            this.SuspendLayout();
            // 
            // bt_Hint
            // 
            this.bt_Hint.Location = new System.Drawing.Point(126, 160);
            this.bt_Hint.Name = "bt_Hint";
            this.bt_Hint.Size = new System.Drawing.Size(75, 23);
            this.bt_Hint.TabIndex = 0;
            this.bt_Hint.Text = "Hint";
            this.bt_Hint.UseVisualStyleBackColor = true;
            this.bt_Hint.Click += new System.EventHandler(this.bt_Hint_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(142, 144);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(145, 128);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "label2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(183, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "label3";
            // 
            // lb_mines
            // 
            this.lb_mines.AutoSize = true;
            this.lb_mines.BackColor = System.Drawing.Color.Transparent;
            this.lb_mines.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_mines.ForeColor = System.Drawing.Color.Red;
            this.lb_mines.Location = new System.Drawing.Point(149, 87);
            this.lb_mines.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_mines.Name = "lb_mines";
            this.lb_mines.Size = new System.Drawing.Size(67, 25);
            this.lb_mines.TabIndex = 34;
            this.lb_mines.Text = "Mines:";
            // 
            // lb_timer
            // 
            this.lb_timer.AutoSize = true;
            this.lb_timer.BackColor = System.Drawing.Color.Transparent;
            this.lb_timer.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_timer.ForeColor = System.Drawing.Color.Red;
            this.lb_timer.Location = new System.Drawing.Point(261, 87);
            this.lb_timer.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_timer.Name = "lb_timer";
            this.lb_timer.Size = new System.Drawing.Size(54, 30);
            this.lb_timer.TabIndex = 33;
            this.lb_timer.Text = "0 : 0";
            // 
            // btn_menu
            // 
            this.btn_menu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_menu.Location = new System.Drawing.Point(9, 11);
            this.btn_menu.Name = "btn_menu";
            this.btn_menu.Size = new System.Drawing.Size(64, 31);
            this.btn_menu.TabIndex = 32;
            this.btn_menu.Text = "Menu";
            this.btn_menu.UseVisualStyleBackColor = true;
            this.btn_menu.Click += new System.EventHandler(this.btn_menu_Click);
            // 
            // btn_theme
            // 
            this.btn_theme.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_theme.Location = new System.Drawing.Point(355, 11);
            this.btn_theme.Name = "btn_theme";
            this.btn_theme.Size = new System.Drawing.Size(84, 31);
            this.btn_theme.TabIndex = 30;
            this.btn_theme.Text = "Theme";
            this.btn_theme.UseVisualStyleBackColor = true;
            this.btn_theme.Click += new System.EventHandler(this.btn_theme_Click);
            // 
            // btn_exit
            // 
            this.btn_exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_exit.Location = new System.Drawing.Point(9, 48);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(64, 31);
            this.btn_exit.TabIndex = 26;
            this.btn_exit.Text = "Exit";
            this.btn_exit.UseVisualStyleBackColor = true;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // lb_sound
            // 
            this.lb_sound.AutoSize = true;
            this.lb_sound.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_sound.ForeColor = System.Drawing.Color.MediumOrchid;
            this.lb_sound.Location = new System.Drawing.Point(352, 58);
            this.lb_sound.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_sound.Name = "lb_sound";
            this.lb_sound.Size = new System.Drawing.Size(49, 17);
            this.lb_sound.TabIndex = 46;
            this.lb_sound.Text = "Sound";
            // 
            // ph_theme
            // 
            this.ph_theme.Controls.Add(this.btn_dark);
            this.ph_theme.Controls.Add(this.btn_light);
            this.ph_theme.Location = new System.Drawing.Point(355, 39);
            this.ph_theme.Margin = new System.Windows.Forms.Padding(2);
            this.ph_theme.Name = "ph_theme";
            this.ph_theme.Size = new System.Drawing.Size(85, 78);
            this.ph_theme.TabIndex = 48;
            this.ph_theme.Visible = false;
            // 
            // btn_dark
            // 
            this.btn_dark.Location = new System.Drawing.Point(9, 38);
            this.btn_dark.Margin = new System.Windows.Forms.Padding(2);
            this.btn_dark.Name = "btn_dark";
            this.btn_dark.Size = new System.Drawing.Size(66, 26);
            this.btn_dark.TabIndex = 1;
            this.btn_dark.Text = "Dark";
            this.btn_dark.UseVisualStyleBackColor = true;
            this.btn_dark.Click += new System.EventHandler(this.btn_dark_Click);
            // 
            // btn_light
            // 
            this.btn_light.Location = new System.Drawing.Point(9, 7);
            this.btn_light.Margin = new System.Windows.Forms.Padding(2);
            this.btn_light.Name = "btn_light";
            this.btn_light.Size = new System.Drawing.Size(66, 26);
            this.btn_light.TabIndex = 0;
            this.btn_light.Text = "Light";
            this.btn_light.UseVisualStyleBackColor = true;
            this.btn_light.Click += new System.EventHandler(this.btn_light_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Controls.Add(this.btn_exit);
            this.panel2.Controls.Add(this.btn_theme);
            this.panel2.Controls.Add(this.ph_theme);
            this.panel2.Controls.Add(this.btn_menu);
            this.panel2.Controls.Add(this.pb_soundison);
            this.panel2.Controls.Add(this.lb_timer);
            this.panel2.Controls.Add(this.lb_sound);
            this.panel2.Controls.Add(this.lb_mines);
            this.panel2.Controls.Add(this.pb_soundisoff);
            this.panel2.Location = new System.Drawing.Point(1, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(450, 125);
            this.panel2.TabIndex = 51;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Minesweeper.Properties.Resources.mine1;
            this.pictureBox1.Location = new System.Drawing.Point(142, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(165, 67);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 49;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Minesweeper.Properties.Resources.Bomb_Icon;
            this.pictureBox2.Location = new System.Drawing.Point(124, 83);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(30, 30);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 50;
            this.pictureBox2.TabStop = false;
            // 
            // pb_soundison
            // 
            this.pb_soundison.Image = ((System.Drawing.Image)(resources.GetObject("pb_soundison.Image")));
            this.pb_soundison.Location = new System.Drawing.Point(405, 58);
            this.pb_soundison.Name = "pb_soundison";
            this.pb_soundison.Size = new System.Drawing.Size(34, 19);
            this.pb_soundison.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_soundison.TabIndex = 47;
            this.pb_soundison.TabStop = false;
            this.pb_soundison.Click += new System.EventHandler(this.pb_soundison_Click);
            // 
            // pb_soundisoff
            // 
            this.pb_soundisoff.Image = global::Minesweeper.Properties.Resources.bbbb;
            this.pb_soundisoff.Location = new System.Drawing.Point(405, 58);
            this.pb_soundisoff.Margin = new System.Windows.Forms.Padding(2);
            this.pb_soundisoff.Name = "pb_soundisoff";
            this.pb_soundisoff.Size = new System.Drawing.Size(34, 19);
            this.pb_soundisoff.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_soundisoff.TabIndex = 45;
            this.pb_soundisoff.TabStop = false;
            this.pb_soundisoff.Click += new System.EventHandler(this.pb_soundisoff_Click);
            // 
            // lb_p1timer
            // 
            this.lb_p1timer.AutoSize = true;
            this.lb_p1timer.Location = new System.Drawing.Point(84, 131);
            this.lb_p1timer.Name = "lb_p1timer";
            this.lb_p1timer.Size = new System.Drawing.Size(41, 13);
            this.lb_p1timer.TabIndex = 52;
            this.lb_p1timer.Text = "p1timer";
            // 
            // lb_p2timer
            // 
            this.lb_p2timer.AutoSize = true;
            this.lb_p2timer.Location = new System.Drawing.Point(30, 160);
            this.lb_p2timer.Name = "lb_p2timer";
            this.lb_p2timer.Size = new System.Drawing.Size(41, 13);
            this.lb_p2timer.TabIndex = 53;
            this.lb_p2timer.Text = "p2timer";
            // 
            // game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(450, 194);
            this.ControlBox = false;
            this.Controls.Add(this.lb_p2timer);
            this.Controls.Add(this.lb_p1timer);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bt_Hint);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "game";
            this.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultBounds;
            this.Text = "Minesweeper";
            this.Load += new System.EventHandler(this.game_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.game_MouseDown);
            this.ph_theme.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_soundison)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_soundisoff)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button bt_Hint;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lb_mines;
        private System.Windows.Forms.Label lb_timer;
        private System.Windows.Forms.Button btn_menu;
        private System.Windows.Forms.Button btn_theme;
        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.PictureBox pb_soundison;
        private System.Windows.Forms.Label lb_sound;
        private System.Windows.Forms.PictureBox pb_soundisoff;
        private System.Windows.Forms.Panel ph_theme;
        private System.Windows.Forms.Button btn_dark;
        private System.Windows.Forms.Button btn_light;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lb_p1timer;
        private System.Windows.Forms.Label lb_p2timer;




    }
}

