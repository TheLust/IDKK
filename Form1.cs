using ExempluConBazaDeDate.Data;
using ExempluConBazaDeDate.Repository;
using ExempluConBazaDeDate.Service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExempluConBazaDeDate
{
    public partial class Form1 : Form
    {
        ArtistService ArtistService = new ArtistService(new ArtistRepository(new SongPlayerRepository()));

        public Form1()
        {
            InitializeComponent();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            try
            {
                artist Artist = new artist()
                {
                    name = nameTextBox.Text,
                    country = countryTextBox.Text
                };
                ArtistService.AddArtist(Artist);
            }
            catch (Exception ex)
            {
                MessageBox.Show(Convert.ToString(ex));
            }

            dataGridView1.DataSource = ArtistService.GetAllArtists();
        }
    }
}
