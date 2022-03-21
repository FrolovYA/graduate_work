namespace TehnoStory
{
    partial class catalog
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(catalog));
            this.Exit = new System.Windows.Forms.Button();
            this.Lb3 = new System.Windows.Forms.Label();
            this.panel_PUP = new System.Windows.Forms.Panel();
            this.button4 = new System.Windows.Forms.Button();
            this.button_physical_addresses = new System.Windows.Forms.Button();
            this.button_about_us = new System.Windows.Forms.Button();
            this.button_catalog = new System.Windows.Forms.Button();
            this.Button_game = new System.Windows.Forms.Button();
            this.Main_menu = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel_PUP.SuspendLayout();
            this.SuspendLayout();
            // 
            // Exit
            // 
            this.Exit.BackColor = System.Drawing.Color.Transparent;
            this.Exit.BackgroundImage = global::TehnoStory.Properties.Resources.close_window_removebg_preview;
            this.Exit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Exit.Location = new System.Drawing.Point(1889, -1);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(35, 35);
            this.Exit.TabIndex = 8;
            this.Exit.UseVisualStyleBackColor = false;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // Lb3
            // 
            this.Lb3.AutoSize = true;
            this.Lb3.BackColor = System.Drawing.Color.Transparent;
            this.Lb3.Font = new System.Drawing.Font("Perpetua Titling MT", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lb3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Lb3.Location = new System.Drawing.Point(833, 46);
            this.Lb3.Name = "Lb3";
            this.Lb3.Size = new System.Drawing.Size(304, 58);
            this.Lb3.TabIndex = 7;
            this.Lb3.Text = "Cataloge";
            this.Lb3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel_PUP
            // 
            this.panel_PUP.BackColor = System.Drawing.Color.Transparent;
            this.panel_PUP.BackgroundImage = global::TehnoStory.Properties.Resources.button_bacground;
            this.panel_PUP.Controls.Add(this.button4);
            this.panel_PUP.Controls.Add(this.button_physical_addresses);
            this.panel_PUP.Controls.Add(this.button_about_us);
            this.panel_PUP.Controls.Add(this.button_catalog);
            this.panel_PUP.Controls.Add(this.Button_game);
            this.panel_PUP.Controls.Add(this.Main_menu);
            this.panel_PUP.Location = new System.Drawing.Point(12, 116);
            this.panel_PUP.Name = "panel_PUP";
            this.panel_PUP.Size = new System.Drawing.Size(1896, 45);
            this.panel_PUP.TabIndex = 6;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Transparent;
            this.button4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button4.Location = new System.Drawing.Point(2008, 3);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(288, 38);
            this.button4.TabIndex = 6;
            this.button4.Text = "Корзина";
            this.button4.UseVisualStyleBackColor = false;
            // 
            // button_physical_addresses
            // 
            this.button_physical_addresses.BackColor = System.Drawing.Color.Transparent;
            this.button_physical_addresses.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.button_physical_addresses.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_physical_addresses.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_physical_addresses.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button_physical_addresses.Location = new System.Drawing.Point(600, 3);
            this.button_physical_addresses.Name = "button_physical_addresses";
            this.button_physical_addresses.Size = new System.Drawing.Size(288, 38);
            this.button_physical_addresses.TabIndex = 4;
            this.button_physical_addresses.Text = "Магазины и пункты выдачи";
            this.button_physical_addresses.UseVisualStyleBackColor = false;
            this.button_physical_addresses.Click += new System.EventHandler(this.button_physical_addresses_Click);
            // 
            // button_about_us
            // 
            this.button_about_us.BackColor = System.Drawing.Color.Transparent;
            this.button_about_us.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_about_us.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_about_us.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button_about_us.Location = new System.Drawing.Point(1302, 3);
            this.button_about_us.Name = "button_about_us";
            this.button_about_us.Size = new System.Drawing.Size(288, 38);
            this.button_about_us.TabIndex = 3;
            this.button_about_us.Text = "О нас";
            this.button_about_us.UseVisualStyleBackColor = false;
            this.button_about_us.Click += new System.EventHandler(this.button_about_us_Click);
            // 
            // button_catalog
            // 
            this.button_catalog.BackColor = System.Drawing.Color.Transparent;
            this.button_catalog.Cursor = System.Windows.Forms.Cursors.No;
            this.button_catalog.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_catalog.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_catalog.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button_catalog.Location = new System.Drawing.Point(306, 3);
            this.button_catalog.Name = "button_catalog";
            this.button_catalog.Size = new System.Drawing.Size(288, 38);
            this.button_catalog.TabIndex = 2;
            this.button_catalog.Text = "Каталог";
            this.button_catalog.UseVisualStyleBackColor = false;
            // 
            // Button_game
            // 
            this.Button_game.BackColor = System.Drawing.Color.Transparent;
            this.Button_game.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Button_game.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button_game.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Button_game.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Button_game.Location = new System.Drawing.Point(1596, 3);
            this.Button_game.Name = "Button_game";
            this.Button_game.Size = new System.Drawing.Size(288, 38);
            this.Button_game.TabIndex = 1;
            this.Button_game.Text = "Мини игра";
            this.Button_game.UseVisualStyleBackColor = false;
            this.Button_game.Click += new System.EventHandler(this.Button_game_Click);
            // 
            // Main_menu
            // 
            this.Main_menu.BackColor = System.Drawing.Color.Transparent;
            this.Main_menu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Main_menu.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Main_menu.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Main_menu.Location = new System.Drawing.Point(12, 3);
            this.Main_menu.Name = "Main_menu";
            this.Main_menu.Size = new System.Drawing.Size(288, 38);
            this.Main_menu.TabIndex = 0;
            this.Main_menu.Text = "Главное меню";
            this.Main_menu.UseVisualStyleBackColor = false;
            this.Main_menu.Click += new System.EventHandler(this.Main_menu_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(878, 950);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(50, 50);
            this.button1.TabIndex = 11;
            this.button1.Text = "<";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(948, 950);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(50, 50);
            this.button2.TabIndex = 12;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button3.Location = new System.Drawing.Point(1018, 950);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(50, 50);
            this.button3.TabIndex = 13;
            this.button3.Text = ">";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(60, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "label1";
            // 
            // catalog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::TehnoStory.Properties.Resources.city_bacground;
            this.ClientSize = new System.Drawing.Size(1924, 1061);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.Lb3);
            this.Controls.Add(this.panel_PUP);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "catalog";
            this.Text = "catalog";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.catalog_FormClosing);
            this.panel_PUP.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.Label Lb3;
        private System.Windows.Forms.Panel panel_PUP;
        private System.Windows.Forms.Button button_physical_addresses;
        private System.Windows.Forms.Button button_about_us;
        private System.Windows.Forms.Button button_catalog;
        private System.Windows.Forms.Button Button_game;
        private System.Windows.Forms.Button Main_menu;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label1;
    }
}