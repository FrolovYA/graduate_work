using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TehnoStory
{

    public partial class catalog : Form
    {
        Panel[] pn = new Panel[10];
        Panel[] pan = new Panel[10];
        Label[] lb = new Label[10];

        int x = 240;
        int y = 200;

        int fractional;
        int whole;

        int DO = 10;

        int proverka;
        int number = 1;

        int zdolbaliperemennie;

        int dolbanieper;

        static string connectionString = @"server=127.0.0.1;port=3306;uid=root;password=;database=tehnostorydb;";

        MySqlConnection DBconnect = new MySqlConnection(connectionString);              //Подключение к базе данных








        public catalog()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;

            collection();

        }


        private void Main_menu_Click(object sender, EventArgs e)                        //Открытие главного меню
        {
            this.Hide();
            TehnoStory tehnostory = new TehnoStory();
            tehnostory.Show();
        }

        private void button_physical_addresses_Click(object sender, EventArgs e)        //Открытие "Магазины и пункты выдачи"
        {
            this.Hide();
            PickUpPoints picuppoints = new PickUpPoints();
            picuppoints.Show();
        }

        private void Exit_Click(object sender, EventArgs e)                             //Кнопка закрытия приложения
        {
            Application.Exit();
        }

        private void Button_game_Click(object sender, EventArgs e)                      //Кнопка закрытия игры
        {
            this.Hide();
            Game gmae = new Game();
            gmae.Show();
        }

        private void button_about_us_Click(object sender, EventArgs e)                  //Кнопка открытия "О нас"
        {
            this.Hide();
            AboutUs abus = new AboutUs();
            abus.Show();
        }

        private void collection()                                                       //Создание каталога: панелей
        {
            DBconnect.Open();                                                           //Открытие подключения







            MySqlCommand coom = new MySqlCommand("SELECT COUNT(id) FROM `product`", DBconnect);

            string col = coom.ExecuteScalar().ToString();
            int colvo = Convert.ToInt32(col);

            whole = colvo / 10;

            fractional = colvo % 10;

            button2.Text = Convert.ToString(number);

            CreateCatalog();



        }

        public void CreateCatalog()
        {
            for (int i = 0; i < 10; i++)
            {

                if (zdolbaliperemennie != 0 && i == (fractional))
                {
                    break;
                }

                pn[i] = new Panel();
                pn[i].Visible = true;
                pn[i].BorderStyle = BorderStyle.FixedSingle;
                pn[i].ForeColor = DefaultForeColor;
                pn[i].BackColor = DefaultBackColor;
                pn[i].Size = new Size(250, 290);
                pn[i].Location = new Point(x, y);
                this.Controls.Add(pn[i]);
                x += 300;
                if (i == 4)
                {
                    x = 240;
                    y = 600;
                }

                CreatePanelInPanel(i);
                CreateLable(i);
                

            }
        }

        public void CreatePanelInPanel(int i)
        {

            if(dolbanieper == 1)
            {
                i -= proverka;
            }
            pan[i] = new Panel();
            pan[i].BringToFront();
            pan[i].BackgroundImageLayout = ImageLayout.Zoom;
            pan[i].Visible = true;
            pan[i].BorderStyle = BorderStyle.FixedSingle;
            pan[i].ForeColor = DefaultForeColor;
            pan[i].BackColor = DefaultBackColor;
            pan[i].Size = new Size(250, 216);
            pan[i].Location = new Point(0, 0);
          
            pn[i].Controls.Add(pan[i]);
            if (dolbanieper == 1)
            {
                i += proverka;
            }
            picture(i);
        }

        public void CreateLable(int i)
        {
            lb[i] = new Label();
            lb[i].AutoSize = false;
            lb[i].Location = new Point(20, 200);
            lb[i].Font = new Font("Palatino Linotype", 14);
            lb[i].AutoSize = false;
            lb[i].Size = new Size(210, 80);
            lb[i].TextAlign = ContentAlignment.MiddleCenter;
            lb[i].Dock = DockStyle.Bottom;
            lb[i].BringToFront();


            SQL_WQ(i);                                                              //Вызов функции выбирающей текст из базы данных

            pn[i].Controls.Add(lb[i]);
        }

        public void picture(int Y)                                                     //Функция которая ставит картинку в PictureBox
        {

            Y++;
            Y += proverka;
            MySqlCommand cmd = new MySqlCommand("SELECT picture FROM `product` WHERE id = @id", DBconnect);
            cmd.Parameters.Add("@id", MySqlDbType.Int32).Value = Y;

            byte[] img = (byte[])cmd.ExecuteScalar();
            Y -= proverka;
            Y--;

            if (dolbanieper == 1)
            {
                Y -= proverka;
            }
            pan[Y].BackgroundImage = ByteArrayToImage(img);
            if (dolbanieper == 1)
            {
                Y += proverka;
            }
        }

        public Image ByteArrayToImage(byte[] inputArray)                                //Функция преобразующая битное значение в картинку
        {
            var memoryStream = new MemoryStream(inputArray);
            return Image.FromStream(memoryStream);
        }



        public void SQL_WQ(int X)                                                      //Функция которая задаёт текст Label, элементом из базы данных
        {

            X++;
            if(proverka != 0)
            {
                X += proverka;
            }
            
            MySqlCommand cmd1 = new MySqlCommand("SELECT name_product FROM `product` WHERE id = @id", DBconnect);
            cmd1.Parameters.Add("@id", MySqlDbType.Int32).Value = X;
            if (proverka != 0)
            {
                X -= proverka;
            }
              
            X--;

            lb[X].Text = cmd1.ExecuteScalar().ToString();


        }
        private void catalog_FormClosing(object sender, FormClosingEventArgs e)         //Хз вроде то что происходит при выключении формы, но тут ничего не написал
        {
            DBconnect.Close();                                                          //Закрытие подключения
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (proverka < 0 && proverka >= 10)
            {

                proverka -= 10;
                DO -= 10;
                Otchistka();
                Zapolnenie(proverka, DO);


            }
            else if (zdolbaliperemennie > 0)
            {
                zdolbaliperemennie = 0;
                proverka -= 10;
                Otchistka();
                Zapolnenie(proverka, DO);

            }
            else
            {

            }
        }
        private void button3_Click(object sender, EventArgs e)
        {
            if (proverka != whole)
            {
                proverka += 10;
                DO += 10;
                Otchistka();
                Zapolnenie(proverka, DO);
            }
            else if (proverka == (whole*10) && fractional != 0)
            {
                proverka += 10;
                zdolbaliperemennie += 1;
                Otchistka();
                Zapolnenie(proverka,fractional); // нужно не создавать каталог а менять данные в панелях и лейблах.
            }
            else
            {

            }


        }

        private void Zapolnenie(int O,int D)
        {
            for (int i = O; i < D;i++)
            {
                dolbanieper += 1;
                CreatePanelInPanel(i);
                CreateLable(i);
                dolbanieper -= 1;

            }
        }

        private void Otchistka()
        {
            for (int i = 0; i < 10; i++)
            {
                pn[i].Controls.Clear();
                pan[i] = null;
                lb[i] = null;
            }
        }

      
    }
}
