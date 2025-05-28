namespace Minesweeper
{
    partial class Menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            this.tb_rowtaker = new System.Windows.Forms.TextBox();
            this.tb_colstaker = new System.Windows.Forms.TextBox();
            this.tb_minestaker = new System.Windows.Forms.TextBox();
            this.bt_singlestart = new System.Windows.Forms.Button();
            this.rb_easy = new System.Windows.Forms.RadioButton();
            this.rb_medium = new System.Windows.Forms.RadioButton();
            this.rb_hard = new System.Windows.Forms.RadioButton();
            this.rb_costum = new System.Windows.Forms.RadioButton();
            this.btn_exit = new System.Windows.Forms.Button();
            this.btn_theme = new System.Windows.Forms.Button();
            this.btn_light = new System.Windows.Forms.Button();
            this.btn_dark = new System.Windows.Forms.Button();
            this.ph_theme = new System.Windows.Forms.Panel();
            this.pb_soundisoff = new System.Windows.Forms.PictureBox();
            this.pb_soundon = new System.Windows.Forms.PictureBox();
            this.lb_sound = new System.Windows.Forms.Label();
            this.lb_rows = new System.Windows.Forms.Label();
            this.lb_bombs = new System.Windows.Forms.Label();
            this.btn_multiplayer = new System.Windows.Forms.Button();
            this.lb_columns = new System.Windows.Forms.Label();
            this.lb_difficulty = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_nh = new System.Windows.Forms.Button();
            this.btn_lh = new System.Windows.Forms.Button();
            this.btn_uh = new System.Windows.Forms.Button();
            this.panelmodes = new System.Windows.Forms.Panel();
            this.pb_soundison = new System.Windows.Forms.PictureBox();
            this.lb_rowlimit = new System.Windows.Forms.Label();
            this.lb_collimit = new System.Windows.Forms.Label();
            this.Music = new AxWMPLib.AxWindowsMediaPlayer();
            this.btn_history = new System.Windows.Forms.Button();
            this.ph_theme.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_soundisoff)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_soundon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelmodes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_soundison)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Music)).BeginInit();
            this.SuspendLayout();
            // 
            // tb_rowtaker
            // 
            this.tb_rowtaker.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_rowtaker.Location = new System.Drawing.Point(246, 134);
            this.tb_rowtaker.Name = "tb_rowtaker";
            this.tb_rowtaker.Size = new System.Drawing.Size(51, 24);
            this.tb_rowtaker.TabIndex = 23;
            this.tb_rowtaker.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tb_rowtaker.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_takers_KeyPress);
            // 
            // tb_colstaker
            // 
            this.tb_colstaker.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_colstaker.Location = new System.Drawing.Point(246, 164);
            this.tb_colstaker.Name = "tb_colstaker";
            this.tb_colstaker.Size = new System.Drawing.Size(50, 24);
            this.tb_colstaker.TabIndex = 24;
            this.tb_colstaker.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tb_colstaker.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_takers_KeyPress);
            // 
            // tb_minestaker
            // 
            this.tb_minestaker.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_minestaker.Location = new System.Drawing.Point(246, 193);
            this.tb_minestaker.Name = "tb_minestaker";
            this.tb_minestaker.Size = new System.Drawing.Size(50, 24);
            this.tb_minestaker.TabIndex = 25;
            this.tb_minestaker.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tb_minestaker.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_takers_KeyPress);
            // 
            // bt_singlestart
            // 
            this.bt_singlestart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_singlestart.Location = new System.Drawing.Point(107, 221);
            this.bt_singlestart.Name = "bt_singlestart";
            this.bt_singlestart.Size = new System.Drawing.Size(122, 31);
            this.bt_singlestart.TabIndex = 26;
            this.bt_singlestart.Text = "Single Player";
            this.bt_singlestart.UseVisualStyleBackColor = true;
            this.bt_singlestart.Click += new System.EventHandler(this.bt_singlestart_Click);
            // 
            // rb_easy
            // 
            this.rb_easy.AutoSize = true;
            this.rb_easy.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_easy.ForeColor = System.Drawing.Color.MediumOrchid;
            this.rb_easy.Location = new System.Drawing.Point(59, 118);
            this.rb_easy.Margin = new System.Windows.Forms.Padding(2);
            this.rb_easy.Name = "rb_easy";
            this.rb_easy.Size = new System.Drawing.Size(83, 20);
            this.rb_easy.TabIndex = 28;
            this.rb_easy.Text = "9 × 9  -  10";
            this.rb_easy.UseVisualStyleBackColor = true;
            this.rb_easy.Click += new System.EventHandler(this.rb_easy_CheckedChanged);
            // 
            // rb_medium
            // 
            this.rb_medium.AutoSize = true;
            this.rb_medium.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_medium.ForeColor = System.Drawing.Color.MediumOrchid;
            this.rb_medium.Location = new System.Drawing.Point(59, 143);
            this.rb_medium.Margin = new System.Windows.Forms.Padding(2);
            this.rb_medium.Name = "rb_medium";
            this.rb_medium.Size = new System.Drawing.Size(97, 20);
            this.rb_medium.TabIndex = 29;
            this.rb_medium.Text = "16 × 16  -  40";
            this.rb_medium.UseVisualStyleBackColor = true;
            this.rb_medium.Click += new System.EventHandler(this.rb_medium_CheckedChanged);
            // 
            // rb_hard
            // 
            this.rb_hard.AutoSize = true;
            this.rb_hard.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_hard.ForeColor = System.Drawing.Color.MediumOrchid;
            this.rb_hard.Location = new System.Drawing.Point(59, 167);
            this.rb_hard.Margin = new System.Windows.Forms.Padding(2);
            this.rb_hard.Name = "rb_hard";
            this.rb_hard.Size = new System.Drawing.Size(97, 20);
            this.rb_hard.TabIndex = 30;
            this.rb_hard.Text = "16 × 30  -  99";
            this.rb_hard.UseVisualStyleBackColor = true;
            this.rb_hard.Click += new System.EventHandler(this.rb_hard_CheckedChanged);
            // 
            // rb_costum
            // 
            this.rb_costum.AutoSize = true;
            this.rb_costum.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_costum.ForeColor = System.Drawing.Color.MediumOrchid;
            this.rb_costum.Location = new System.Drawing.Point(60, 191);
            this.rb_costum.Margin = new System.Windows.Forms.Padding(2);
            this.rb_costum.Name = "rb_costum";
            this.rb_costum.Size = new System.Drawing.Size(71, 20);
            this.rb_costum.TabIndex = 31;
            this.rb_costum.TabStop = true;
            this.rb_costum.Text = "Costum";
            this.rb_costum.UseVisualStyleBackColor = true;
            this.rb_costum.Click += new System.EventHandler(this.rb_costum_CheckedChanged);
            // 
            // btn_exit
            // 
            this.btn_exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_exit.Location = new System.Drawing.Point(137, 360);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(64, 31);
            this.btn_exit.TabIndex = 32;
            this.btn_exit.Text = "Exit";
            this.btn_exit.UseVisualStyleBackColor = true;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // btn_theme
            // 
            this.btn_theme.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_theme.Location = new System.Drawing.Point(255, 12);
            this.btn_theme.Name = "btn_theme";
            this.btn_theme.Size = new System.Drawing.Size(84, 31);
            this.btn_theme.TabIndex = 33;
            this.btn_theme.Text = "Theme";
            this.btn_theme.UseVisualStyleBackColor = true;
            this.btn_theme.Click += new System.EventHandler(this.btn_theme_Click);
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
            // ph_theme
            // 
            this.ph_theme.Controls.Add(this.btn_dark);
            this.ph_theme.Controls.Add(this.btn_light);
            this.ph_theme.Location = new System.Drawing.Point(255, 38);
            this.ph_theme.Margin = new System.Windows.Forms.Padding(2);
            this.ph_theme.Name = "ph_theme";
            this.ph_theme.Size = new System.Drawing.Size(85, 78);
            this.ph_theme.TabIndex = 34;
            this.ph_theme.Visible = false;
            // 
            // pb_soundisoff
            // 
            this.pb_soundisoff.Image = global::Minesweeper.Properties.Resources.bbbb;
            this.pb_soundisoff.Location = new System.Drawing.Point(185, 18);
            this.pb_soundisoff.Margin = new System.Windows.Forms.Padding(2);
            this.pb_soundisoff.Name = "pb_soundisoff";
            this.pb_soundisoff.Size = new System.Drawing.Size(47, 19);
            this.pb_soundisoff.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_soundisoff.TabIndex = 35;
            this.pb_soundisoff.TabStop = false;
            this.pb_soundisoff.Click += new System.EventHandler(this.pb_soundisoff_Click);
            // 
            // pb_soundon
            // 
            this.pb_soundon.Location = new System.Drawing.Point(-2, -2);
            this.pb_soundon.Margin = new System.Windows.Forms.Padding(2);
            this.pb_soundon.Name = "pb_soundon";
            this.pb_soundon.Size = new System.Drawing.Size(75, 41);
            this.pb_soundon.TabIndex = 43;
            this.pb_soundon.TabStop = false;
            // 
            // lb_sound
            // 
            this.lb_sound.AutoSize = true;
            this.lb_sound.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_sound.ForeColor = System.Drawing.Color.MediumOrchid;
            this.lb_sound.Location = new System.Drawing.Point(139, 18);
            this.lb_sound.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_sound.Name = "lb_sound";
            this.lb_sound.Size = new System.Drawing.Size(47, 16);
            this.lb_sound.TabIndex = 36;
            this.lb_sound.Text = "Sound";
            // 
            // lb_rows
            // 
            this.lb_rows.AutoSize = true;
            this.lb_rows.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_rows.ForeColor = System.Drawing.Color.MediumOrchid;
            this.lb_rows.Location = new System.Drawing.Point(199, 134);
            this.lb_rows.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_rows.Name = "lb_rows";
            this.lb_rows.Size = new System.Drawing.Size(47, 16);
            this.lb_rows.TabIndex = 37;
            this.lb_rows.Text = "Height";
            // 
            // lb_bombs
            // 
            this.lb_bombs.AutoSize = true;
            this.lb_bombs.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_bombs.ForeColor = System.Drawing.Color.MediumOrchid;
            this.lb_bombs.Location = new System.Drawing.Point(199, 193);
            this.lb_bombs.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_bombs.Name = "lb_bombs";
            this.lb_bombs.Size = new System.Drawing.Size(44, 16);
            this.lb_bombs.TabIndex = 38;
            this.lb_bombs.Text = "Mines";
            // 
            // btn_multiplayer
            // 
            this.btn_multiplayer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_multiplayer.Location = new System.Drawing.Point(107, 258);
            this.btn_multiplayer.Name = "btn_multiplayer";
            this.btn_multiplayer.Size = new System.Drawing.Size(122, 31);
            this.btn_multiplayer.TabIndex = 27;
            this.btn_multiplayer.Text = "Multi Player";
            this.btn_multiplayer.UseVisualStyleBackColor = true;
            this.btn_multiplayer.Click += new System.EventHandler(this.btn_start_Click);
            // 
            // lb_columns
            // 
            this.lb_columns.AutoSize = true;
            this.lb_columns.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_columns.ForeColor = System.Drawing.Color.MediumOrchid;
            this.lb_columns.Location = new System.Drawing.Point(199, 164);
            this.lb_columns.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_columns.Name = "lb_columns";
            this.lb_columns.Size = new System.Drawing.Size(42, 16);
            this.lb_columns.TabIndex = 39;
            this.lb_columns.Text = "Width";
            // 
            // lb_difficulty
            // 
            this.lb_difficulty.AutoSize = true;
            this.lb_difficulty.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_difficulty.ForeColor = System.Drawing.Color.MediumOrchid;
            this.lb_difficulty.Location = new System.Drawing.Point(56, 100);
            this.lb_difficulty.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_difficulty.Name = "lb_difficulty";
            this.lb_difficulty.Size = new System.Drawing.Size(46, 16);
            this.lb_difficulty.TabIndex = 40;
            this.lb_difficulty.Text = "Setup:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Minesweeper.Properties.Resources.mine2;
            this.pictureBox1.Location = new System.Drawing.Point(-16, -5);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(157, 102);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 41;
            this.pictureBox1.TabStop = false;
            // 
            // btn_nh
            // 
            this.btn_nh.Location = new System.Drawing.Point(15, 6);
            this.btn_nh.Margin = new System.Windows.Forms.Padding(2);
            this.btn_nh.Name = "btn_nh";
            this.btn_nh.Size = new System.Drawing.Size(93, 26);
            this.btn_nh.TabIndex = 0;
            this.btn_nh.Text = "No Hint";
            this.btn_nh.UseVisualStyleBackColor = true;
            this.btn_nh.Click += new System.EventHandler(this.btn_start_Click);
            // 
            // btn_lh
            // 
            this.btn_lh.Location = new System.Drawing.Point(15, 37);
            this.btn_lh.Margin = new System.Windows.Forms.Padding(2);
            this.btn_lh.Name = "btn_lh";
            this.btn_lh.Size = new System.Drawing.Size(93, 26);
            this.btn_lh.TabIndex = 1;
            this.btn_lh.Text = "Limited Hints";
            this.btn_lh.UseVisualStyleBackColor = true;
            this.btn_lh.Click += new System.EventHandler(this.btn_start_Click);
            // 
            // btn_uh
            // 
            this.btn_uh.Location = new System.Drawing.Point(15, 68);
            this.btn_uh.Margin = new System.Windows.Forms.Padding(2);
            this.btn_uh.Name = "btn_uh";
            this.btn_uh.Size = new System.Drawing.Size(93, 26);
            this.btn_uh.TabIndex = 2;
            this.btn_uh.Text = "Unlimited Hints";
            this.btn_uh.UseVisualStyleBackColor = true;
            this.btn_uh.Click += new System.EventHandler(this.btn_start_Click);
            // 
            // panelmodes
            // 
            this.panelmodes.Controls.Add(this.btn_uh);
            this.panelmodes.Controls.Add(this.btn_lh);
            this.panelmodes.Controls.Add(this.btn_nh);
            this.panelmodes.Location = new System.Drawing.Point(107, 251);
            this.panelmodes.Margin = new System.Windows.Forms.Padding(2);
            this.panelmodes.Name = "panelmodes";
            this.panelmodes.Size = new System.Drawing.Size(122, 104);
            this.panelmodes.TabIndex = 42;
            this.panelmodes.Visible = false;
            // 
            // pb_soundison
            // 
            this.pb_soundison.Image = ((System.Drawing.Image)(resources.GetObject("pb_soundison.Image")));
            this.pb_soundison.Location = new System.Drawing.Point(185, 18);
            this.pb_soundison.Name = "pb_soundison";
            this.pb_soundison.Size = new System.Drawing.Size(47, 19);
            this.pb_soundison.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_soundison.TabIndex = 44;
            this.pb_soundison.TabStop = false;
            this.pb_soundison.Click += new System.EventHandler(this.pb_soundison_Click);
            // 
            // lb_rowlimit
            // 
            this.lb_rowlimit.AutoSize = true;
            this.lb_rowlimit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_rowlimit.ForeColor = System.Drawing.Color.MediumOrchid;
            this.lb_rowlimit.Location = new System.Drawing.Point(298, 134);
            this.lb_rowlimit.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_rowlimit.Name = "lb_rowlimit";
            this.lb_rowlimit.Size = new System.Drawing.Size(41, 16);
            this.lb_rowlimit.TabIndex = 45;
            this.lb_rowlimit.Text = "(1-24)";
            // 
            // lb_collimit
            // 
            this.lb_collimit.AutoSize = true;
            this.lb_collimit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_collimit.ForeColor = System.Drawing.Color.MediumOrchid;
            this.lb_collimit.Location = new System.Drawing.Point(298, 164);
            this.lb_collimit.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_collimit.Name = "lb_collimit";
            this.lb_collimit.Size = new System.Drawing.Size(41, 16);
            this.lb_collimit.TabIndex = 47;
            this.lb_collimit.Text = "(1-43)";
            // 
            // Music
            // 
            this.Music.Enabled = true;
            this.Music.Location = new System.Drawing.Point(-2, 368);
            this.Music.Name = "Music";
            this.Music.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("Music.OcxState")));
            this.Music.Size = new System.Drawing.Size(75, 23);
            this.Music.TabIndex = 48;
            // 
            // btn_history
            // 
            this.btn_history.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_history.Location = new System.Drawing.Point(107, 295);
            this.btn_history.Name = "btn_history";
            this.btn_history.Size = new System.Drawing.Size(122, 31);
            this.btn_history.TabIndex = 49;
            this.btn_history.Text = "History";
            this.btn_history.UseVisualStyleBackColor = true;
            this.btn_history.Click += new System.EventHandler(this.btn_history_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(351, 397);
            this.ControlBox = false;
            this.Controls.Add(this.btn_theme);
            this.Controls.Add(this.bt_singlestart);
            this.Controls.Add(this.panelmodes);
            this.Controls.Add(this.btn_history);
            this.Controls.Add(this.Music);
            this.Controls.Add(this.lb_collimit);
            this.Controls.Add(this.lb_rowlimit);
            this.Controls.Add(this.pb_soundison);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lb_difficulty);
            this.Controls.Add(this.lb_columns);
            this.Controls.Add(this.btn_multiplayer);
            this.Controls.Add(this.lb_bombs);
            this.Controls.Add(this.lb_rows);
            this.Controls.Add(this.lb_sound);
            this.Controls.Add(this.pb_soundon);
            this.Controls.Add(this.pb_soundisoff);
            this.Controls.Add(this.ph_theme);
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.rb_costum);
            this.Controls.Add(this.rb_hard);
            this.Controls.Add(this.rb_medium);
            this.Controls.Add(this.rb_easy);
            this.Controls.Add(this.tb_minestaker);
            this.Controls.Add(this.tb_colstaker);
            this.Controls.Add(this.tb_rowtaker);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.Menu_Load);
            this.ph_theme.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pb_soundisoff)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_soundon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelmodes.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pb_soundison)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Music)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_rowtaker;
        private System.Windows.Forms.TextBox tb_colstaker;
        private System.Windows.Forms.TextBox tb_minestaker;
        private System.Windows.Forms.Button bt_singlestart;
        private System.Windows.Forms.RadioButton rb_easy;
        private System.Windows.Forms.RadioButton rb_medium;
        private System.Windows.Forms.RadioButton rb_hard;
        private System.Windows.Forms.RadioButton rb_costum;
        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.Button btn_theme;
        private System.Windows.Forms.Button btn_light;
        private System.Windows.Forms.Button btn_dark;
        private System.Windows.Forms.Panel ph_theme;
        private System.Windows.Forms.PictureBox pb_soundisoff;
        private System.Windows.Forms.PictureBox pb_soundon;
        private System.Windows.Forms.Label lb_sound;
        private System.Windows.Forms.Label lb_rows;
        private System.Windows.Forms.Label lb_bombs;
        private System.Windows.Forms.Button btn_multiplayer;
        private System.Windows.Forms.Label lb_columns;
        private System.Windows.Forms.Label lb_difficulty;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btn_nh;
        private System.Windows.Forms.Button btn_lh;
        private System.Windows.Forms.Button btn_uh;
        private System.Windows.Forms.Panel panelmodes;
        private System.Windows.Forms.PictureBox pb_soundison;
        private System.Windows.Forms.Label lb_rowlimit;
        private System.Windows.Forms.Label lb_collimit;
        private AxWMPLib.AxWindowsMediaPlayer Music;
        private System.Windows.Forms.Button btn_history;



    }
}