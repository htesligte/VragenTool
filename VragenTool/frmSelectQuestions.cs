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
    public partial class frmSelectQuestions : Form
    {
        public frmSelectQuestions()
        {
            InitializeComponent();
            List<string> filenames = ApplicationHandler.Instance.getFileNames();
            listBoxFiles.Items.Clear();
            foreach (string f in filenames)
            {
                listBoxFiles.Items.Add(f);
            }
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            List<string> filenames = new List<string>();
            foreach (object item in listBoxFiles.CheckedItems)
            {
                filenames.Add(item.ToString());
            }
            ApplicationHandler.Instance.setFiles(filenames);
            frmAskQuestion frm = new frmAskQuestion();
            frm.initForm();
            frm.MainWindow = this;
            frm.Show();
            this.Hide();
        }
    }
}
