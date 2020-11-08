using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace MusicArtists
{
    public class SAX : IStrategy
    {
        private List<MusicArtist> lastRes = null;
        public List<MusicArtist> Search(MusicArtist musicArtist, string path)
        {
            List<MusicArtist> resList = new List<MusicArtist>();
            XmlReader reader = XmlReader.Create(path);

            MusicArtist found = null;
            while (reader.Read())
            {
                switch (reader.NodeType)
                {
                    case XmlNodeType.Element:
                        if (reader.Name == "MusicArtist")
                        {
                            found = new MusicArtist();
                            while (reader.MoveToNextAttribute())
                            {
                                if (reader.Name == "Name")
                                {
                                    found.Name = reader.Value;
                                }
                                if (reader.Name == "MajorGenre")
                                {
                                    found.Genre = reader.Value;
                                }
                                if (reader.Name == "Country")
                                {
                                    found.Country = reader.Value;
                                }
                                if (reader.Name == "IncomePerYear")
                                {
                                    found.IncomePerYear = reader.Value;
                                }
                                if (reader.Name == "ArtistBand")
                                {
                                    found.Band = reader.Value;
                                }
                                if (reader.Name == "MusicActivity")
                                {
                                    found.Activity = reader.Value;
                                }
                            }
                            resList.Add(found);
                        }
                        break;
                }
            }
            lastRes = Filter(resList, musicArtist);
            return lastRes;
        }
        
        private List<MusicArtist> Filter(List<MusicArtist> resList, MusicArtist temp)
        {
            List<MusicArtist> newRes = new List<MusicArtist>();
            if(resList != null)
            {
                foreach(MusicArtist artist in resList)
                {
                    if ((temp.Name == artist.Name || temp.Name == String.Empty) &&
                       (temp.Genre == artist.Genre || temp.Genre == String.Empty) &&
                       (temp.Country == artist.Country || temp.Country == String.Empty) &&
                       (temp.IncomePerYear == artist.IncomePerYear || temp.IncomePerYear == String.Empty) &&
                       (temp.Band == artist.Band || temp.Band == String.Empty) &&
                       (temp.Activity == artist.Activity || temp.Activity == String.Empty))
                    {
                        newRes.Add(artist);
                    }
                }
            }
            return newRes;
        }
    }
}

