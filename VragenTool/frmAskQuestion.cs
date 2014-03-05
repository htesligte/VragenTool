using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VragenTool
{
    public partial class frmAskQuestion : Form
    {
        public frmSelectQuestions MainWindow { get; set; }
        int totalGood = 0;
        int totalWrong = 0;
        int totalSkipped = 0;
        bool tryAgain;
        bool showPeek = false;
        bool closeApp = true;
        Vraag CurrentVraag;

        public frmAskQuestion()
        {
            InitializeComponent();
            this.KeyPreview = true;
            setNextQuestion();
        }

        public void initForm()
        {
            toolStripAmountTotal.Text = ApplicationHandler.Instance.getTotalQuestions().ToString();
            toolStripAmountGood.Text = "0";
            toolStripAmountWrong.Text = "0";
            toolstripAmountHad.Text = "0";
            tryAgain = false;
        }

        public void setNextQuestion()
        {
            if (ApplicationHandler.Instance.isFinished())
            {
                closeApp = false;
                MainWindow.Show();
                this.Close();
                return;
            }
            toolstripAmountHad.Text = (totalGood + totalWrong + totalSkipped).ToString();
            tryAgain = false;
            CurrentVraag = ApplicationHandler.Instance.getNextQuestion();
            txtVraag.Text = CurrentVraag.txtVraag;
            txtAntwoord.Text = "";
            txtAntwoord.Focus();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            frmCheckAnswer frm = new frmCheckAnswer();
            frm.txtGood.Text = CurrentVraag.txtAntwoord;
            frm.txtYour.Text = txtAntwoord.Text;
            DialogResult result = frm.ShowDialog(this);
            if (result == DialogResult.Yes)
            {
                if (!tryAgain)
                {
                    totalGood++;
                    toolStripAmountGood.Text = totalGood.ToString();
                }
                setNextQuestion();
            }
            else if( result == DialogResult.No )
            {
                if (!tryAgain)
                {
                    totalWrong++;
                    toolStripAmountWrong.Text = totalWrong.ToString();
                    tryAgain = true;
                }
                txtAntwoord.Text = "";
                toolStripAmountWrong.Text = totalWrong.ToString();
            }
        }

        private void frmAskQuestion_FormClosed(object sender, FormClosedEventArgs e)
        {
            if( closeApp ) 
                Application.Exit();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (!tryAgain)
                totalSkipped++;

            setNextQuestion();
        }

        private void frmAskQuestion_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.F1)
            {
                if (!showPeek)
                {
                    if (!tryAgain)
                    {
                        totalWrong++;
                        tryAgain = true;
                        toolStripAmountWrong.Text = totalWrong.ToString();
                    }

                    txtAntwoord.Text = CurrentVraag.txtAntwoord;
                    txtAntwoord.ReadOnly = true;
                    btnOK.Enabled = false;
                    showPeek = true;
                }
                else
                {
                    showPeek = false;
                    txtAntwoord.Text = "";
                    txtAntwoord.ReadOnly = false;
                    btnOK.Enabled = true;
                }
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            MainWindow.Show();
            closeApp = false;
            this.Close();
        }
    }
}
