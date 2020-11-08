using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace MusicArtists
{
    public class DOM : IStrategy
    {
        public List<MusicArtist> Search(MusicArtist musicArtist, string path)
        {
            XmlDocument currentDoc = new XmlDocument();
            currentDoc.Load(path);
            List<List<MusicArtist>> resList = new List<List<MusicArtist>>();

            if (musicArtist.Name == String.Empty && musicArtist.Genre == String.Empty && musicArtist.Country == String.Empty
                && musicArtist.IncomePerYear == String.Empty && musicArtist.Band == String.Empty && musicArtist.Activity == String.Empty)
            {
                return CatchError(currentDoc);
            }

            if (musicArtist.Name != String.Empty) resList.Add(SearchByAttribute("MusicArtist", "Name", musicArtist.Name, currentDoc));
            if (musicArtist.Genre != String.Empty) resList.Add(SearchByAttribute("MusicArtist", "MajorGenre", musicArtist.Genre, currentDoc));
            if (musicArtist.Country != String.Empty) resList.Add(SearchByAttribute("MusicArtist", "Country", musicArtist.Country, currentDoc));
            if (musicArtist.IncomePerYear != String.Empty) resList.Add(SearchByAttribute("MusicArtist", "IncomePerYear", musicArtist.IncomePerYear, currentDoc));
            if (musicArtist.Band != String.Empty) resList.Add(SearchByAttribute("MusicArtist", "ArtistBand", musicArtist.Band, currentDoc));
            if (musicArtist.Activity != String.Empty) resList.Add(SearchByAttribute("MusicArtist", "MusicActivity", musicArtist.Activity, currentDoc));

            return FindCrossings(resList, musicArtist);
        }

        public List<MusicArtist> SearchByAttribute(string nodeName, string attribute, string template, XmlDocument doc)
        {
            List<MusicArtist> resList = new List<MusicArtist>();

            if(template != String.Empty)
            {
                XmlNodeList list = doc.SelectNodes("//" + nodeName + "[@" + attribute + "=\"" + template + "\"]");
                foreach(XmlNode node in list)
                {
                    resList.Add(GetInfo(node));
                }
            }
            return resList;
        }

        public List<MusicArtist> CatchError(XmlDocument doc)
        {
            List<MusicArtist> result = new List<MusicArtist>();
            XmlNodeList list = doc.SelectNodes("//" + "MusicArtist");
            foreach(XmlNode node in list)
            {
                result.Add(GetInfo(node));
            }
            return result;
        }

        public MusicArtist GetInfo(XmlNode node)
        {
            MusicArtist mA = new MusicArtist();
            mA.Name = node.Attributes.GetNamedItem("Name").Value;
            mA.Genre = node.Attributes.GetNamedItem("MajorGenre").Value;
            mA.Country = node.Attributes.GetNamedItem("Country").Value;
            mA.IncomePerYear = node.Attributes.GetNamedItem("IncomePerYear").Value;
            mA.Band = node.Attributes.GetNamedItem("ArtistBand").Value;
            mA.Activity = node.Attributes.GetNamedItem("MusicActivity").Value;

            return mA;
        }

        public List<MusicArtist> FindCrossings(List<List<MusicArtist>> artists, MusicArtist obj)
        {
            List<MusicArtist> resList = new List<MusicArtist>();
            List<MusicArtist> cleared = CheckNodes(artists, obj);
            foreach(MusicArtist temp in cleared)
            {
                bool isIn = false;
                foreach (MusicArtist mA in resList)
                {
                    if (mA.Compare(temp))
                    {
                        isIn = true;
                    }
                }
                if (!isIn)
                {
                    resList.Add(temp);
                }

            }
            return resList;
        }

        public List<MusicArtist> CheckNodes(List<List<MusicArtist>> artists, MusicArtist obj)
        {
            List<MusicArtist> newRes = new List<MusicArtist>();
            foreach(List<MusicArtist> artList in artists)
            {
                foreach(MusicArtist artist in artList)
                {
                    if ((obj.Name == artist.Name || obj.Name == String.Empty) &&
                        (obj.Genre == artist.Genre || obj.Genre == String.Empty) &&
                        (obj.Country == artist.Country || obj.Country == String.Empty) &&
                        (obj.IncomePerYear == artist.IncomePerYear || obj.IncomePerYear == String.Empty) &&
                        (obj.Band == artist.Band || obj.Band == String.Empty) &&
                        (obj.Activity == artist.Activity || obj.Activity == String.Empty))
                    {
                        newRes.Add(artist);
                    }
                }
            }
            return newRes;
        }
    }
}
