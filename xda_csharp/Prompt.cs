using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MTwExample
{
    public partial class Prompt : Form
    {
        public static readonly string appPath = Path.Combine(new string[] { Path.GetDirectoryName(Application.ExecutablePath) });
        public static readonly string resourcesPath1 = Path.Combine(new string[] { appPath, "resources1" });
        public static readonly string resourcesPath = Path.Combine(new string[] { appPath, "resources" });
        public static readonly string resultsDir = Path.Combine(new string[] { appPath, "results" });

        Logger subjLogger;

        private string[] PromptHeader = new string[] { "ID", "Gender", "Age", "BirthDate", "Hand" };

        public Prompt()
        {
            InitializeComponent();
            //string id;
        }

        private void Prompt_Load(object sender, EventArgs e)
        {

        }

        private void comBoxHand_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DateTime startBtnClickTime = DateTime.Now;
            Logger.SetCommonPath(appPath, "results", txtBoxID.Text, _time: startBtnClickTime);
            subjLogger = new Logger(destinationFolder: txtBoxID.Text, extension: "subjinfo", keepStream: false);
            subjLogger.CreateFolder();

            Task mkHdr = Task.Run(()=>subjLogger.SetHeader(PromptHeader));
            mkHdr.Wait();
            //string id= txtBoxID.Text;

            subjLogger.UpdateValue("Hand", comBoxHand.Text);
            subjLogger.UpdateValue("Gender", txtBoxGnr.Text);
            subjLogger.UpdateValue("Age", txtBoxAge.Text);
            subjLogger.UpdateValue("BirthDate", txtBoxBirDate.Text);
            subjLogger.UpdateValue("ID", txtBoxID.Text);

            subjLogger.LogData();

            Form1 form1 = new Form1(txtBoxID.Text, startBtnClickTime);
            form1.ShowDialog();
           // form1.ID = id;
           // MessageBox.Show(form1.ID);
            this.Close();

        }

        private void txtBoxGnr_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtBoxAge_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtBoxBirDate_TextChanged(object sender, EventArgs e)
        {
            
            
        }

        private void txtBoxID_TextChanged(object sender, EventArgs e)
        {
            

        }
    }
}
