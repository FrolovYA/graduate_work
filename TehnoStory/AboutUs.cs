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
    public partial class AboutUs : Form
    {
        public AboutUs()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Button_game_Click(object sender, EventArgs e)
        {
            this.Hide();
            Game gmae = new Game();
            gmae.Show();
        }

        private void button_about_us_Click(object sender, EventArgs e)
        {

        }

        private void button_physical_addresses_Click(object sender, EventArgs e)
        {
            this.Hide();
            PickUpPoints picuppoints = new PickUpPoints();
            picuppoints.Show();
        }

        private void button_catalog_Click(object sender, EventArgs e)
        {
            this.Hide();
            catalog Catalog = new catalog();
            Catalog.Show();
        }

        private void Main_menu_Click(object sender, EventArgs e)
        {
            this.Hide();
            TehnoStory tehnostory = new TehnoStory();
            tehnostory.Show();
        }

        
    }
}
