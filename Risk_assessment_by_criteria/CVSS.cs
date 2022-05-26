using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Risk_assessment_by_criteria
{
    public partial class CVSS : Form
    {
        public CVSS()
        {
            InitializeComponent();
            

        }

        private void button_calc_Click(object sender, EventArgs e)
        {
            labelRes.Text = "Базовая оценка (BS): " + calcCVSS().ToString();
            NewThreat main = this.Owner as NewThreat;
            if (main != null)
            {
                main.labelCVSS.Text = calcCVSS().ToString();
            }
            
        }
        private float calcCVSS()
        {
            float exploitability = 8.22f;
            float impact = 0;
            float iss = 0;
            float conf = 0, intg = 0, aval = 0;
            bool isScopeChanged = false;

            if (radioButtonSC.Checked)
                isScopeChanged = true;
            if (radioButtonSU.Checked)
                isScopeChanged = false;

            if (radioButtonAVN.Checked)
                exploitability *= (float)0.85;
            if (radioButtonAVA.Checked)
                exploitability *= (float)0.62;
            if (radioButtonAVL.Checked)
                exploitability *= (float)0.55;
            if (radioButtonAVP.Checked)
                exploitability *= (float)0.2;

            if (radioButtonACH.Checked)
                exploitability *= (float)0.44;
            if (radioButtonACL.Checked)
                exploitability *= (float)0.77;

            if (radioButtonPRH.Checked)
                if (isScopeChanged)
                    exploitability *= (float)0.5;
                else
                    exploitability *= (float)0.27;
            if (radioButtonPRL.Checked)
                if (isScopeChanged)
                    exploitability *= (float)0.68;
                else
                    exploitability *= (float)0.62;
            if (radioButtonPRN.Checked)
                exploitability *= (float)0.85;

            if (radioButtonUIN.Checked)
                exploitability *= (float)0.85;
            if (radioButtonUIR.Checked)
                exploitability *= (float)0.62;


            if (radioButtonCH.Checked)
                conf = 0.56f;
            if (radioButtonCL.Checked)
                conf = 0.22f;
            if (radioButtonCN.Checked)
                conf = 0;

            if (radioButtonIH.Checked)
                intg = 0.56f;
            if (radioButtonIL.Checked)
                intg = 0.22f;
            if (radioButtonIN.Checked)
                intg = 0;

            if (radioButtonAH.Checked)
                aval = 0.56f;
            if (radioButtonAL.Checked)
                aval = 0.22f;
            if (radioButtonAN.Checked)
                aval = 0;


            iss = 1 - ((1 - conf) * (1 - intg) * (1 - aval));
            if (isScopeChanged)
            {
                impact = (float)7.52 * (iss - (float)0.029) - (float)3.25 * (float)Math.Pow((iss - (float)0.02), 15);
                return (float)Math.Round(Math.Min((float)1.08 * (impact + exploitability), 10), 1);
            }
            else
            {
                impact = (float)6.42 * iss;
                return (float)Math.Round(Math.Min(impact + exploitability, 10), 1);
            }
        }

        private void button_ex_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
