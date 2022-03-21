using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TehnoStory
{
    public partial class Game : Form
    {


        Panel Tod = new Panel();

        Random rnd = new Random();
        int s = 0;
        int m = 0;
        int points = 0;



        public Game()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;

            game_but.Visible = false;
        }

               
        private void StartAgain_Click(object sender, EventArgs e)
        {
            game_manu.Visible = false;
            Time.Enabled = true;
            game_timer.Enabled = true;
        }

        private void bu_out_Click(object sender, EventArgs e)
        {
            this.Hide();
            TehnoStory tehnostory = new TehnoStory();
            tehnostory.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            game_timer.Enabled = false;
            game_manu.Visible = true;
            Time.Enabled = false;
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Time_Tick(object sender, EventArgs e)
        {

            if (s < 59)
            {
                s++;
                if (s<10)
                {
                    Sec.Text = "0" + s.ToString();
                }
                else
                {
                    Sec.Text = s.ToString();
                }
            }
            else
            {
                if (m < 59)
                {
                    m++;
                    if (m<10)
                    {
                        Min.Text = "0" + m.ToString();
                    }
                    else
                    {
                        Min.Text = m.ToString();
                        s = 0;
                        Sec.Text = "00";
                    }
                }
                else
                {
                    m = 0;
                    Min.Text = "00";
                }
            }
            

        }

        private void Start_Click(object sender, EventArgs e)
        {
            game_timer.Enabled = false;
            Start.Visible = false;
            Time.Enabled = true;
            game_but.Visible = true;
            game_timer.Enabled = true;
        }

        private void game_but_Click(object sender, EventArgs e)
        {
            
            
        }

        private void game_timer_Tick(object sender, EventArgs e)
        {
            game_but.Location = new Point(rnd.Next(1900), rnd.Next(1030));
        }



        private void game_but_MouseEnter(object sender, EventArgs e)
        {
            points++;
            game_but.Location = new Point(rnd.Next(1900), rnd.Next(1030));
            points_yes.Text = Convert.ToString(points);
            game_timer.Stop();
            game_timer.Start();
            if (points == 10)
            {
                Tod = new Panel();
                Tod.Size = new Size(770, 700);
                Tod.Location = new Point(550, 20);
                Tod.BackgroundImage = Image.FromFile(@"C:\Users\stale\Pictures\Проэктная фигня\техно истории\TOD.jpg");
                Tod.BackgroundImageLayout = ImageLayout.Zoom;
                Tod.BringToFront();

                playing_field.Controls.Add(Tod);
                game_timer.Enabled = false;
                Time.Enabled = false;



                TodTimer.Enabled = true;
            }
        }

        private void TodTimer_Tick(object sender, EventArgs e)
        {
            playing_field.Controls.Remove(Tod);
            game_timer.Enabled = true;
            Time.Enabled = true;
            TodTimer.Enabled = false;
        }
    }
}
