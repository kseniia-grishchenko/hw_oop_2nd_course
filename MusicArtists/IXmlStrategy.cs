using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicArtists
{
    public interface IStrategy
    {
        List<MusicArtist> Search(MusicArtist artist, string path);
    }
}
