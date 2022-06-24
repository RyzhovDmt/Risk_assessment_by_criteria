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
using System.Xml;
using System.IO;

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
            Component.objectName = textBoxName.Text;
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
            if (radioButtonCust.Checked)
            {
                Threat.sourceFile = "Custom.xml";
                if (System.IO.File.Exists("Custom.xml"))
                    System.IO.File.Delete("Custom.xml");
                using (System.IO.FileStream fs = File.Create("Custom.xml")) ;

                    //создание главного объекта документа
                XmlDocument xmlDoc = new XmlDocument();

                /*<?xml version="1.0" encoding="utf-8" ?> */
                //создание объявления (декларации) документа
                XmlDeclaration xmlDec = xmlDoc.CreateXmlDeclaration("1.0", "utf-8", null);
                //добавляем в документ
                xmlDoc.AppendChild(xmlDec);
                /*<database name="abc"></database>*/
                //создание корневого элемента 
                XmlElement newEl = xmlDoc.CreateElement("threats");

                //добавляем в документ
                xmlDoc.AppendChild(newEl);
                xmlDoc.Save("Custom.xml");
            }
            using (ResXResourceWriter resx = new ResXResourceWriter(@".\Params.resx"))
            {
                resx.AddResource("riskCritValue", Threat.riskCritValue);
                resx.AddResource("infrType", Component.infrType);
                resx.AddResource("sourceFile", Threat.sourceFile);
                resx.AddResource("objectName", Component.objectName);
            }
            Threat.isSuccEd = true;
            Threat.readFromFile();
            MessageBox.Show("Изменения сохранены", "Параметры", MessageBoxButtons.OK, MessageBoxIcon.Information);
            
        }

        private void button_ex_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
