using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Resources;
using System.Collections;

namespace Risk_assessment_by_criteria
{
    public partial class Parameters : Form
    {
        public Parameters()
        {
            InitializeComponent();


        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {

            textBox_rcr.Text = ((float)trackBar1.Value / 100).ToString();
        }

        private void button_save_Click(object sender, EventArgs e)
        {
            string type = "";
            Threat.riskCritValue = float.Parse(textBox_rcr.Text);
            Threat.isSuccEd = true;
            
            if (radioButtonSaaS.Checked)
            {
                Component.infrType = "SaaS";
            }
            if (radioButtonPaaS.Checked)
            {
                Component.infrType = "PaaS";
            }
            if (radioButtonIaaS.Checked)
            {
                Component.infrType = "IaaS";
            }
            if (radioButtonBank.Checked)
            {
                Threat.sourceFile = "ThreatsFSTEC.xml";
            }
            if (radioButtonGost.Checked)
            {
                Threat.sourceFile = "ThreatsISO27005.xml";
            }
            using (ResXResourceWriter resx = new ResXResourceWriter(@".\Params.resx"))
            {
                resx.AddResource("riskCritValue", Threat.riskCritValue);
                resx.AddResource("infrType", Component.infrType);
                resx.AddResource("sourceFile", Threat.sourceFile);
            }
        }

        private void button_ex_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
