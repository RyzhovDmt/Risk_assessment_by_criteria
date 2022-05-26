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
    public partial class EditThreat : Form
    {
        public EditThreat()
        {
            InitializeComponent();
            fillTable();
        }


        public void fillTable()
        {
            DataGridViewTextBoxColumn column2 = new DataGridViewTextBoxColumn();
            column2.Name = "Loc";
            column2.HeaderText = "Локация";

            DataGridViewTextBoxColumn column1 = new DataGridViewTextBoxColumn();
            column1.Name = "Comp_name";
            column1.HeaderText = "Компонент";

            DataGridViewCheckBoxColumn column0 = new DataGridViewCheckBoxColumn();
            column0.Name = "Is_exposed";
            column0.HeaderText = "Подвержен";

            DataGridViewTextBoxColumn column3 = new DataGridViewTextBoxColumn();
            column3.Name = "Area";
            column3.HeaderText = "Область";

            // --> current comp/thr list
            //List<comp> comp_list = new List<comp>();
            dataGridView1.Columns.AddRange(column0, column1, column2, column3);
            var t = Threat.getThrList();
            var currThr = t.Find((p => p.title == Threat.currName));
            foreach (var c in Component.getCompList())
            {
                DataGridViewCell is_exp = new DataGridViewCheckBoxCell();
                DataGridViewCell comp = new DataGridViewTextBoxCell();
                DataGridViewCell loc = new DataGridViewTextBoxCell();
                DataGridViewCell area = new DataGridViewTextBoxCell();
                comp.Value = c.title;
                var currArea = Area.getArList().Find((p => p.title == c.area));
                loc.Value = currArea.location;
                area.Value = c.area;
                if (currThr.components.Exists(item => item == c.title))
                    is_exp.Value = true;
                else
                    is_exp.Value = false;
                //выбрать те что подвержены
                //if 

                DataGridViewRow row0 = new DataGridViewRow();
                row0.Cells.AddRange(is_exp, comp, loc, area);
                dataGridView1.Rows.Add(row0);
            }
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            textBox_v.Text = (((float)trackBar1.Value) / 20).ToString();
        }

        private void trackBar2_Scroll(object sender, EventArgs e)
        {
            textBox_s.Text = (trackBar2.Value).ToString();
        }

        private void button_ex_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button_add_Click(object sender, EventArgs e)
        {
            List<string> comp_list = new List<string>();


            //DataGridViewCheckBoxCell chk = (DataGridViewCheckBoxCell)dataGridView1.Rows[0].Cells[1];


            //foreach (DataGridViewRow dgvr in dataGridView1.Rows)
            for (int i = 0; i < dataGridView1.RowCount - 1; i++)
            {
                //DataGridViewCheckBoxCell chk = (DataGridViewCheckBoxCell)dgvr.Cells[1];
                bool is_checked = (bool)dataGridView1.Rows[i].Cells[0].Value;
                if (is_checked)
                {
                    comp_list.Add(dataGridView1.Rows[i].Cells[1].Value.ToString());
                }
            }
            if (Threat.changeThreat(textBox_name.Text, textBox_weakness.Text, float.Parse(textBox_v.Text), Convert.ToInt32(textBox_s.Text), comp_list))
            {
                Threat.isSuccEd = true;
                MessageBox.Show("Угроза успешно изменена", "Изменение угрозы", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}