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
using System.Xml.Serialization;
using System.IO;

namespace VragenTool
{
    public partial class frmEditQuestions : Form
    {
        Dictionary<int, Vraag> Vragen;
        int CurrentIndex;
        Vraag CurrentVraag;

        public frmEditQuestions()
        {
            InitializeComponent();
            Vragen = new Dictionary<int, Vraag>();
            CurrentIndex = 0;
            CurrentVraag = new Vraag();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            CurrentVraag.txtVraag = txtVraag.Text;
            CurrentVraag.txtAntwoord = txtAntwoord.Text;

            if (Vragen.ContainsKey(CurrentIndex))
            {
                Vragen[CurrentIndex] = CurrentVraag;
            }
            else
            {
                Vragen.Add(CurrentIndex, CurrentVraag);
            }
            
            TextWriter Writer = new StreamWriter(@"c:\users\henk\Documents\vragen\noooo.xml");
            XmlSerializer Serializer = new XmlSerializer(typeof(List<Vraag>));
            List<Vraag> lstVragen = new List<Vraag>();
            foreach (KeyValuePair<int, Vraag> entry in Vragen)
            {
                lstVragen.Add(entry.Value);
            }

            Serializer.Serialize(Writer, lstVragen);
            Writer.Close();

            CurrentIndex++;

            if (Vragen.ContainsKey(CurrentIndex))
                CurrentVraag = Vragen[CurrentIndex];
            else
            {
                CurrentVraag = new Vraag();
                CurrentVraag.txtVraag = "";
                CurrentVraag.txtAntwoord = "";
            }
                
            txtVraag.Text = CurrentVraag.txtVraag;
            txtAntwoord.Text = CurrentVraag.txtAntwoord;
            txtVraag.Focus();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnPrev_Click(object sender, EventArgs e)
        {
            if (CurrentIndex > 0)
            {
                if (Vragen.ContainsKey(CurrentIndex - 1))
                {
                    CurrentVraag = Vragen[CurrentIndex - 1];
                    CurrentIndex--;
                }
                else
                {
                    int y = 120;
                    MessageBox.Show("Geen vorige vraag gevonden (?)");

                }



                   

                txtVraag.Text = CurrentVraag.txtVraag;
                txtAntwoord.Text = CurrentVraag.txtAntwoord;
            }
        }
    }
}
