using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Xsl;

namespace MusicArtists
{
    public partial class MusicArtists : Form
    {
        string path = "C:\\OOP_2nd_course\\MusicArtists\\MusicArtists.xml";
        public MusicArtist musicArtist = null;
        public MusicArtists()
        {
            InitializeComponent();
        }


        private void SearchBtn_Click(object sender, EventArgs e)
        {
            Search();
        }
        
        private void Search()
        {
            resBox.Clear();
            musicArtist = new MusicArtist();
            IStrategy chosenStrategy;
            if (artistBox.Checked)
            {
                musicArtist.Name = artistCmbBox.Text;
            }
            if (genreBox.Checked)
            {
                musicArtist.Genre = genreCmbBox.Text;
            }
            if (countryBox.Checked)
            {
                musicArtist.Country = countryCmbBox.Text;
            }
            if (incomeBox.Checked)
            {
                musicArtist.IncomePerYear = incomeCmbBox.Text;
            }
            if (bandBox.Checked)
            {
                musicArtist.Band = bandCmbBox.Text;
            }
            if (activityBox.Checked)
            {
                musicArtist.Activity = activityCmbBox.Text;
            }

            if (domBtn.Checked)
            {
               chosenStrategy = new DOM();
                List<MusicArtist> resList = chosenStrategy.Search(musicArtist, path);
                ShowResults(resList);
            }
            if (saxBtn.Checked)
            {
                chosenStrategy = new SAX();
                List<MusicArtist> resList = chosenStrategy.Search(musicArtist, path);
                ShowResults(resList);
            }
            if (linqToXmlBtn.Checked)
            {
                chosenStrategy = new LINQtoXML();
                List<MusicArtist> resList = chosenStrategy.Search(musicArtist, path);
                ShowResults(resList);
            }
            
        }

        public void ShowResults(List<MusicArtist> mArtList)
        {
            for(int i = 0; i < mArtList.Count; i++)
            {
                resBox.AppendText(i + 1 + ".\n");
                resBox.AppendText("Name: " + mArtList[i].Name + "\n");
                resBox.AppendText("Genre: " + mArtList[i].Genre + "\n");
                resBox.AppendText("Country: " + mArtList[i].Country + "\n");
                resBox.AppendText("Income per year: " + mArtList[i].IncomePerYear + "\n");
                resBox.AppendText("Artist Band: " + mArtList[i].Band + "\n");
                resBox.AppendText("Music Activity: " + mArtList[i].Activity + "\n");
                resBox.AppendText("------------------------------------------\n");
            }
        }

        private void MusicArtists_Load(object sender, EventArgs e)
        {
            FillAll();
        }

        public void FillAll()
        {
            XmlDocument currentDoc = new XmlDocument();
            currentDoc.Load(path);
            XmlElement node = currentDoc.DocumentElement;
            XmlNodeList childNodes = node.SelectNodes("MusicArtist");

            foreach(XmlNode childNode in childNodes)
            {
                if (!artistCmbBox.Items.Contains(childNode.SelectSingleNode("@Name").Value))
                {
                    artistCmbBox.Items.Add(childNode.SelectSingleNode("@Name").Value);
                }
                if (!genreCmbBox.Items.Contains(childNode.SelectSingleNode("@MajorGenre").Value))
                {
                    genreCmbBox.Items.Add(childNode.SelectSingleNode("@MajorGenre").Value);
                }
                if (!countryCmbBox.Items.Contains(childNode.SelectSingleNode("@Country").Value))
                {
                    countryCmbBox.Items.Add(childNode.SelectSingleNode("@Country").Value);
                }
                if (!bandCmbBox.Items.Contains(childNode.SelectSingleNode("@ArtistBand").Value))
                {
                    bandCmbBox.Items.Add(childNode.SelectSingleNode("@ArtistBand").Value);
                }
                if (!incomeCmbBox.Items.Contains(childNode.SelectSingleNode("@IncomePerYear").Value))
                {
                    incomeCmbBox.Items.Add(childNode.SelectSingleNode("@IncomePerYear").Value);
                }
                if (!activityCmbBox.Items.Contains(childNode.SelectSingleNode("@MusicActivity").Value))
                {
                    activityCmbBox.Items.Add(childNode.SelectSingleNode("@MusicActivity").Value);
                }
            }
        }

        private void ClearBtn_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void Clear()
        {
            resBox.Clear();
            artistBox.Checked = false;
            artistCmbBox.Text = null;

            genreBox.Checked = false;
            genreCmbBox.Text = null;

            countryBox.Checked = false;
            countryCmbBox.Text = null;

            incomeBox.Checked = false;
            incomeCmbBox.Text = null;

            bandBox.Checked = false;
            bandCmbBox.Text = null;

            activityBox.Checked = false;
            activityCmbBox.Text = null;

            domBtn.Checked = false;
            saxBtn.Checked = false;
            linqToXmlBtn.Checked = false;
        }

        private void TransformBtn_Click(object sender, EventArgs e)
        {
            Transform();
        }

        private void Transform()
        {
            XslCompiledTransform xct = new XslCompiledTransform();
            xct.Load("C:\\OOP_2nd_course\\MusicArtists\\MusicArtists.xsl");
            string fXml = "C:\\OOP_2nd_course\\MusicArtists\\MusicArtists.xml";
            string fHtml = "C:/OOP_2nd_course/MusicArtists/bin/Debug/MusicArtists.html";
            xct.Transform(fXml, fHtml);
            MessageBox.Show("Done!");
        }
    }
}
