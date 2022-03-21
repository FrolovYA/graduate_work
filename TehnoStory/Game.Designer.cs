namespace TehnoStory
{
    partial class Game
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
            this.Exit = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Time = new System.Windows.Forms.Timer(this.components);
            this.playing_field = new System.Windows.Forms.Panel();
            this.time_game = new System.Windows.Forms.Panel();
            this.lab = new System.Windows.Forms.Label();
            this.Sec = new System.Windows.Forms.Label();
            this.Min = new System.Windows.Forms.Label();
            this.game_timer = new System.Windows.Forms.Timer(this.components);
            this.points_yes = new System.Windows.Forms.Label();
            this.TodTimer = new System.Windows.Forms.Timer(this.components);
            this.Start = new System.Windows.Forms.Button();
            this.game_manu = new System.Windows.Forms.Panel();
            this.bu_setings = new System.Windows.Forms.Button();
            this.StartAgain = new System.Windows.Forms.Button();
            this.bu_out = new System.Windows.Forms.Button();
            this.game_but = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.playing_field.SuspendLayout();
            this.time_game.SuspendLayout();
            this.game_manu.SuspendLayout();
            this.SuspendLayout();
            // 
            // Exit
            // 
            this.Exit.BackColor = System.Drawing.Color.Transparent;
            this.Exit.BackgroundImage = global::TehnoStory.Properties.Resources.close_window_removebg_preview;
            this.Exit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Exit.Location = new System.Drawing.Point(1885, 0);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(35, 35);
            this.Exit.TabIndex = 6;
            this.Exit.UseVisualStyleBackColor = false;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = global::TehnoStory.Properties.Resources.settings_removebg_preview;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(50, 50);
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Time
            // 
            this.Time.Interval = 1000;
            this.Time.Tick += new System.EventHandler(this.Time_Tick);
            // 
            // playing_field
            // 
            this.playing_field.BackColor = System.Drawing.Color.Transparent;
            this.playing_field.Controls.Add(this.game_but);
            this.playing_field.Controls.Add(this.game_manu);
            this.playing_field.Controls.Add(this.Start);
            this.playing_field.Location = new System.Drawing.Point(9, 59);
            this.playing_field.Name = "playing_field";
            this.playing_field.Size = new System.Drawing.Size(1900, 1030);
            this.playing_field.TabIndex = 9;
            // 
            // time_game
            // 
            this.time_game.BackColor = System.Drawing.Color.Transparent;
            this.time_game.Controls.Add(this.lab);
            this.time_game.Controls.Add(this.Sec);
            this.time_game.Controls.Add(this.Min);
            this.time_game.Location = new System.Drawing.Point(878, 7);
            this.time_game.Name = "time_game";
            this.time_game.Size = new System.Drawing.Size(124, 46);
            this.time_game.TabIndex = 10;
            // 
            // lab
            // 
            this.lab.AutoSize = true;
            this.lab.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lab.Location = new System.Drawing.Point(57, 6);
            this.lab.Name = "lab";
            this.lab.Size = new System.Drawing.Size(19, 29);
            this.lab.TabIndex = 2;
            this.lab.Text = ":";
            // 
            // Sec
            // 
            this.Sec.AutoSize = true;
            this.Sec.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Sec.ForeColor = System.Drawing.Color.White;
            this.Sec.Location = new System.Drawing.Point(71, 7);
            this.Sec.Name = "Sec";
            this.Sec.Size = new System.Drawing.Size(39, 29);
            this.Sec.TabIndex = 1;
            this.Sec.Text = "00";
            this.Sec.UseMnemonic = false;
            // 
            // Min
            // 
            this.Min.AutoSize = true;
            this.Min.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Min.ForeColor = System.Drawing.Color.White;
            this.Min.Location = new System.Drawing.Point(22, 7);
            this.Min.Name = "Min";
            this.Min.Size = new System.Drawing.Size(39, 29);
            this.Min.TabIndex = 0;
            this.Min.Text = "00";
            this.Min.UseMnemonic = false;
            // 
            // game_timer
            // 
            this.game_timer.Interval = 800;
            this.game_timer.Tick += new System.EventHandler(this.game_timer_Tick);
            // 
            // points_yes
            // 
            this.points_yes.AutoSize = true;
            this.points_yes.BackColor = System.Drawing.Color.Transparent;
            this.points_yes.Font = new System.Drawing.Font("Microsoft YaHei UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.points_yes.ForeColor = System.Drawing.Color.White;
            this.points_yes.Location = new System.Drawing.Point(830, 12);
            this.points_yes.Name = "points_yes";
            this.points_yes.Size = new System.Drawing.Size(31, 35);
            this.points_yes.TabIndex = 11;
            this.points_yes.Text = "0";
            // 
            // TodTimer
            // 
            this.TodTimer.Interval = 7000;
            this.TodTimer.Tick += new System.EventHandler(this.TodTimer_Tick);
            // 
            // Start
            // 
            this.Start.Font = new System.Drawing.Font("Showcard Gothic", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Start.Location = new System.Drawing.Point(720, 215);
            this.Start.Name = "Start";
            this.Start.Size = new System.Drawing.Size(430, 350);
            this.Start.TabIndex = 8;
            this.Start.Text = "START";
            this.Start.UseVisualStyleBackColor = true;
            this.Start.Click += new System.EventHandler(this.Start_Click);
            // 
            // game_manu
            // 
            this.game_manu.BackgroundImage = global::TehnoStory.Properties.Resources.button_bacground;
            this.game_manu.Controls.Add(this.bu_out);
            this.game_manu.Controls.Add(this.StartAgain);
            this.game_manu.Controls.Add(this.bu_setings);
            this.game_manu.Location = new System.Drawing.Point(761, 251);
            this.game_manu.Name = "game_manu";
            this.game_manu.Size = new System.Drawing.Size(347, 274);
            this.game_manu.TabIndex = 0;
            this.game_manu.Visible = false;
            // 
            // bu_setings
            // 
            this.bu_setings.BackColor = System.Drawing.Color.DarkSlateGray;
            this.bu_setings.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bu_setings.Font = new System.Drawing.Font("Elephant", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bu_setings.ForeColor = System.Drawing.Color.White;
            this.bu_setings.Location = new System.Drawing.Point(42, 115);
            this.bu_setings.Name = "bu_setings";
            this.bu_setings.Size = new System.Drawing.Size(262, 36);
            this.bu_setings.TabIndex = 1;
            this.bu_setings.Text = "Настройки";
            this.bu_setings.UseVisualStyleBackColor = false;
            // 
            // StartAgain
            // 
            this.StartAgain.BackColor = System.Drawing.Color.DarkSlateGray;
            this.StartAgain.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.StartAgain.Font = new System.Drawing.Font("Elephant", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StartAgain.ForeColor = System.Drawing.Color.White;
            this.StartAgain.Location = new System.Drawing.Point(42, 29);
            this.StartAgain.Name = "StartAgain";
            this.StartAgain.Size = new System.Drawing.Size(262, 36);
            this.StartAgain.TabIndex = 0;
            this.StartAgain.Text = "Продолжить";
            this.StartAgain.UseVisualStyleBackColor = false;
            this.StartAgain.Click += new System.EventHandler(this.StartAgain_Click);
            // 
            // bu_out
            // 
            this.bu_out.BackColor = System.Drawing.Color.DarkSlateGray;
            this.bu_out.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bu_out.Font = new System.Drawing.Font("Elephant", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bu_out.ForeColor = System.Drawing.Color.White;
            this.bu_out.Location = new System.Drawing.Point(42, 205);
            this.bu_out.Name = "bu_out";
            this.bu_out.Size = new System.Drawing.Size(262, 36);
            this.bu_out.TabIndex = 2;
            this.bu_out.Text = "Главное меню";
            this.bu_out.UseVisualStyleBackColor = false;
            this.bu_out.Click += new System.EventHandler(this.bu_out_Click);
            // 
            // game_but
            // 
            this.game_but.Location = new System.Drawing.Point(909, 156);
            this.game_but.Name = "game_but";
            this.game_but.Size = new System.Drawing.Size(40, 40);
            this.game_but.TabIndex = 3;
            this.game_but.UseVisualStyleBackColor = true;
            this.game_but.Click += new System.EventHandler(this.game_but_Click);
            this.game_but.MouseEnter += new System.EventHandler(this.game_but_MouseEnter);
            // 
            // Game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::TehnoStory.Properties.Resources.one;
            this.ClientSize = new System.Drawing.Size(1940, 1100);
            this.Controls.Add(this.points_yes);
            this.Controls.Add(this.time_game);
            this.Controls.Add(this.playing_field);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Exit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Game";
            this.Text = "Game";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.playing_field.ResumeLayout(false);
            this.time_game.ResumeLayout(false);
            this.time_game.PerformLayout();
            this.game_manu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Timer Time;
        private System.Windows.Forms.Panel playing_field;
        private System.Windows.Forms.Panel time_game;
        private System.Windows.Forms.Label lab;
        private System.Windows.Forms.Label Sec;
        private System.Windows.Forms.Label Min;
        private System.Windows.Forms.Timer game_timer;
        private System.Windows.Forms.Label points_yes;
        private System.Windows.Forms.Timer TodTimer;
        private System.Windows.Forms.Button game_but;
        private System.Windows.Forms.Panel game_manu;
        private System.Windows.Forms.Button bu_out;
        private System.Windows.Forms.Button StartAgain;
        private System.Windows.Forms.Button bu_setings;
        private System.Windows.Forms.Button Start;
    }
}