using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ComboList_Maker
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            MaximumSize = Size;
            MinimumSize = Size;
            tbOutput.Text = String.Format("{0}\\{1}.txt", Environment.CurrentDirectory, DateTime.Now.ToString("hhmmsstt MMddyyyy")); // Default output path
        }

        public String delimiter;
        public String lineBreak;
        public String outputPath;

        private void tbUsernames_DoubleClick(object sender, EventArgs e)
        {
            using (OpenFileDialog ofdUsers = new OpenFileDialog())
            {
                if (ofdUsers.ShowDialog() == DialogResult.OK)
                {
                    tbUsernames.Text = ofdUsers.FileName;
                }
            }
        }
    
        private void tbPasswords_DoubleClick(object sender, EventArgs e)
        {

            using (OpenFileDialog ofdPass = new OpenFileDialog())
            {
                if (ofdPass.ShowDialog() == DialogResult.OK)
                {
                    tbPasswords.Text = ofdPass.FileName;
                }
            }
        }

        private void tbOutput_DoubleClick(object sender, EventArgs e)
        {

            using (SaveFileDialog sfdOutput = new SaveFileDialog())
            {
                if (sfdOutput.ShowDialog() == DialogResult.OK)
                {
                    tbOutput.Text = sfdOutput.FileName;
                }
            }
        }

        private void btnCombine_Click(object sender, EventArgs e)
        {

            if (tbDelimiter.Text != "") { delimiter = tbDelimiter.Text; } else { delimiter = ":"; }

            if (tbLineBreak.Text != "System") { lineBreak = tbLineBreak.Text; } else { lineBreak = Environment.NewLine; }

            outputPath = tbOutput.Text;

            try
            {
                System.Threading.Thread thdCombine = new System.Threading.Thread(() => combineLists());
                thdCombine.IsBackground = true;
                thdCombine.Start();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        void combineLists()
        {
            if(InvokeRequired) { Invoke(new MethodInvoker(combineLists)); return; }

            pbCombine.Value = 0;

            String[] list1 = System.IO.File.ReadAllLines(tbUsernames.Text);
            String[] list2 = System.IO.File.ReadAllLines(tbPasswords.Text);
            
            pbCombine.Maximum = (list1.Count() * list2.Count()) + 1;
            
            foreach (String user in list1)
            {
                foreach (String pass in list2)
                {
                    System.IO.File.AppendAllText(outputPath, String.Format("{0}{1}{2}{3}", user, delimiter, pass, lineBreak));

                    pbCombine.Increment(1);
                }
            }

            pbCombine.Value = pbCombine.Maximum;

            MessageBox.Show("Success!");
        }

    }
}
