using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;

namespace MusicArtists
{
    public class LINQtoXML : IStrategy
    {
        private List<MusicArtist> resList = null;
        XDocument currentDoc = new XDocument();
        public List<MusicArtist> Search(MusicArtist musicArtist, string path)
        {
            currentDoc = XDocument.Load(@path);
            resList = new List<MusicArtist>();

            List<XElement> matches = (from value in currentDoc.Descendants("MusicArtist")
                                      where ((musicArtist.Name == String.Empty || musicArtist.Name == value.Attribute("Name").Value) &&
                                      (musicArtist.Genre == String.Empty || musicArtist.Genre == value.Attribute("MajorGenre").Value) &&
                                      (musicArtist.IncomePerYear == String.Empty || musicArtist.IncomePerYear == value.Attribute("IncomePerYear").Value) &&
                                      (musicArtist.Country == String.Empty || musicArtist.Country == value.Attribute("Country").Value) &&
                                      (musicArtist.Band == String.Empty || musicArtist.Band == value.Attribute("ArtistBand").Value) &&
                                      (musicArtist.Activity == String.Empty || musicArtist.Activity == value.Attribute("MusicActivity").Value))
                                      select value).ToList();
            foreach(XElement match in matches)
            {
                MusicArtist artist = new MusicArtist();
                artist.Name = match.Attribute("Name").Value;
                artist.Genre = match.Attribute("MajorGenre").Value;
                artist.Country = match.Attribute("Country").Value;
                artist.IncomePerYear = match.Attribute("IncomePerYear").Value;
                artist.Band = match.Attribute("ArtistBand").Value;
                artist.Activity = match.Attribute("MusicActivity").Value;
                resList.Add(artist);
            }
            return resList;
        }
    }
}
