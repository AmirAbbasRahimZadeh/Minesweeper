namespace Minesweeper
{
    partial class Endgame
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Endgame));
            this.lb_endgame = new System.Windows.Forms.Label();
            this.pnl_details = new System.Windows.Forms.Panel();
            this.btn_menu = new System.Windows.Forms.Button();
            this.btn_close = new System.Windows.Forms.Button();
            this.btn_again = new System.Windows.Forms.Button();
            this.btn_exit = new System.Windows.Forms.Button();
            this.btn_save = new System.Windows.Forms.Button();
            this.pnl_details.SuspendLayout();
            this.SuspendLayout();
            // 
            // lb_endgame
            // 
            this.lb_endgame.AutoSize = true;
            this.lb_endgame.Font = new System.Drawing.Font("Segoe UI", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_endgame.ForeColor = System.Drawing.Color.MediumOrchid;
            this.lb_endgame.Location = new System.Drawing.Point(23, 24);
            this.lb_endgame.Name = "lb_endgame";
            this.lb_endgame.Size = new System.Drawing.Size(42, 15);
            this.lb_endgame.TabIndex = 0;
            this.lb_endgame.Text = "label1";
            // 
            // pnl_details
            // 
            this.pnl_details.Controls.Add(this.btn_save);
            this.pnl_details.Controls.Add(this.btn_menu);
            this.pnl_details.Controls.Add(this.btn_close);
            this.pnl_details.Controls.Add(this.btn_again);
            this.pnl_details.Controls.Add(this.btn_exit);
            this.pnl_details.Controls.Add(this.lb_endgame);
            this.pnl_details.Location = new System.Drawing.Point(12, 12);
            this.pnl_details.Name = "pnl_details";
            this.pnl_details.Size = new System.Drawing.Size(272, 236);
            this.pnl_details.TabIndex = 37;
            // 
            // btn_menu
            // 
            this.btn_menu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_menu.Location = new System.Drawing.Point(171, 85);
            this.btn_menu.Name = "btn_menu";
            this.btn_menu.Size = new System.Drawing.Size(78, 28);
            this.btn_menu.TabIndex = 38;
            this.btn_menu.Text = "Menu";
            this.btn_menu.UseVisualStyleBackColor = true;
            this.btn_menu.Click += new System.EventHandler(this.btn_menu_Click);
            // 
            // btn_close
            // 
            this.btn_close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_close.Location = new System.Drawing.Point(171, 119);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(78, 28);
            this.btn_close.TabIndex = 39;
            this.btn_close.Text = "Close";
            this.btn_close.UseVisualStyleBackColor = true;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // btn_again
            // 
            this.btn_again.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_again.Location = new System.Drawing.Point(171, 17);
            this.btn_again.Name = "btn_again";
            this.btn_again.Size = new System.Drawing.Size(78, 28);
            this.btn_again.TabIndex = 40;
            this.btn_again.Text = "Play again";
            this.btn_again.UseVisualStyleBackColor = true;
            this.btn_again.Click += new System.EventHandler(this.btn_again_Click);
            // 
            // btn_exit
            // 
            this.btn_exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_exit.Location = new System.Drawing.Point(171, 153);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(78, 28);
            this.btn_exit.TabIndex = 37;
            this.btn_exit.Text = "Exit";
            this.btn_exit.UseVisualStyleBackColor = true;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // btn_save
            // 
            this.btn_save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_save.Location = new System.Drawing.Point(171, 51);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(78, 28);
            this.btn_save.TabIndex = 41;
            this.btn_save.Text = "Save";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // Endgame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(450, 260);
            this.Controls.Add(this.pnl_details);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Endgame";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Endgame";
            this.Load += new System.EventHandler(this.Endgame_Load);
            this.pnl_details.ResumeLayout(false);
            this.pnl_details.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lb_endgame;
        private System.Windows.Forms.Panel pnl_details;
        private System.Windows.Forms.Button btn_menu;
        private System.Windows.Forms.Button btn_close;
        private System.Windows.Forms.Button btn_again;
        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.Button btn_save;
    }
}