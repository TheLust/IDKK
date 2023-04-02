using ExempluConBazaDeDate.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExempluConBazaDeDate.Repository
{
    public class ArtistRepository
    {
        SongPlayerRepository SongPlayerRepository;

        
        public ArtistRepository(SongPlayerRepository songPlayerRepository)
        {
            SongPlayerRepository = songPlayerRepository;
        }

        public List<artist> GetAllArtists()
        {
            return SongPlayerRepository.artists.ToList();
        }

        public void AddArtist(artist artist)
        {
            SongPlayerRepository.artists.Add(artist);
            SongPlayerRepository.SaveChanges();
        }

        public void RemoveArtist(artist artist)
        {
            SongPlayerRepository.artists.Remove(artist);
            SongPlayerRepository.SaveChanges();
        }

        public void UpdateArtist(artist artist)
        {
            SongPlayerRepository.artists.Add(artist);
            SongPlayerRepository.SaveChanges();
        }
    }
}
