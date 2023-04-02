using ExempluConBazaDeDate.Data;
using ExempluConBazaDeDate.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExempluConBazaDeDate.Service
{
    public class ArtistService
    {
        ArtistRepository ArtistRepository;

        public ArtistService(ArtistRepository artistRepository)
        {
            ArtistRepository = artistRepository;
        }

        public List<artist> GetAllArtists()
        {
            return ArtistRepository.GetAllArtists();
        }

        public void AddArtist(artist artist)
        {
            if (string.IsNullOrWhiteSpace(artist.name))
            {
                throw new ArgumentNullException("Numele nu poate fi gol!");
            }

            if (string.IsNullOrWhiteSpace(artist.country))
            {
                throw new ArgumentNullException("Tara nu poate fi goala!");
            }

            ArtistRepository.AddArtist(artist);
        }

        public void RemoveArtist(artist artist)
        {
            ArtistRepository.RemoveArtist(artist);
        }

        public void UpdateArtist(artist artist)
        {
            ArtistRepository.UpdateArtist(artist);
        }
    }
}
