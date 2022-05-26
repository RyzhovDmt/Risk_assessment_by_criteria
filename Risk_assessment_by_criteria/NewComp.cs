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
    public partial class NewComp : Form
    {
        public NewComp()
        {
            InitializeComponent();
            //fillTable();
            fillComboboxLoc();
            //Component.readFromFile();
        }
        public void fillTable()
        {
            DataGridViewTextBoxColumn column2 = new DataGridViewTextBoxColumn();
            column2.Name = "Weakness";
            column2.HeaderText = "Уязвимость";

            DataGridViewTextBoxColumn column1 = new DataGridViewTextBoxColumn();
            column1.Name = "Thr_name";
            column1.HeaderText = "Название";

            DataGridViewCheckBoxColumn column0 = new DataGridViewCheckBoxColumn();
            column0.Name = "Is_exposed";
            column0.HeaderText = "Подвержен";

            DataGridViewTextBoxColumn column3 = new DataGridViewTextBoxColumn();
            column3.Name = "V";
            column3.HeaderText = "Априорная вероятность реализации";

            DataGridViewTextBoxColumn column4 = new DataGridViewTextBoxColumn();
            column4.Name = "S";
            column4.HeaderText = "Априорная величина ущерба";

            //dataGridView1.Columns.AddRange(column0, column1, column2, column3, column4);



            // --> current comp/thr list
            //List<comp> comp_list = new List<comp>();
            foreach (var c in Threat.getThrList())
            {
                DataGridViewCell is_exp0 = new DataGridViewCheckBoxCell();
                DataGridViewCell thr0 = new DataGridViewTextBoxCell();
                DataGridViewCell weak0 = new DataGridViewTextBoxCell();
                DataGridViewCell v0 = new DataGridViewTextBoxCell();
                DataGridViewCell s0 = new DataGridViewTextBoxCell();
                thr0.Value = c.title;
                weak0.Value = c.weakness;
                v0.Value = c.v;
                s0.Value = c.s;
                is_exp0.Value = false;
                DataGridViewRow row0 = new DataGridViewRow();
                row0.Cells.AddRange(is_exp0, thr0, weak0, v0, s0);
                //dataGridView1.Rows.Add(row0);
            }


            //DataGridViewCell is_exp0 = new DataGridViewCheckBoxCell();
            //DataGridViewCell thr0 = new DataGridViewTextBoxCell();
            //DataGridViewCell weak0 = new DataGridViewTextBoxCell();
            //DataGridViewCell v0 = new DataGridViewTextBoxCell();
            //DataGridViewCell s0 = new DataGridViewTextBoxCell();
            //s0.Value = "1";

            //dataGridView1.Rows.Add(row0);



        }


        private void button_add_Click(object sender, EventArgs e)
        {
            //List<string> threats = new List<string> ();
            if
             (Component.addToFile(textBox_name.Text, comboBox_area.SelectedItem.ToString()))
            {
                Component.isSuccAdd = true;
                MessageBox.Show("Компонент успешно создан", "Новый компонент", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                Component.isSuccAdd = false;
                MessageBox.Show("Компонент с таким именем уже существует", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }    
        }
        private void fillComboboxLoc()
        {
            //Loc.readFromFile();
            comboBox_loc.Items.AddRange(Loc.getLocList().ToArray());
        }
        private void fillComboboxArea()
        {
            //Loc.readFromFile();
            comboBox_area.Items.Clear();
            foreach (var a in Area.getArList().FindAll((p => p.location == comboBox_loc.SelectedItem.ToString())))
            {
                comboBox_area.Items.Add(a.title);
            }
        }

        private void comboBox_loc_SelectedIndexChanged(object sender, EventArgs e)
        {

            fillComboboxArea();
        }

        private void button_ex_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button_newloc_Click(object sender, EventArgs e)
        {
            Loc.addToFile(Loc.makeNewName());
            comboBox_loc.Items.Add(Loc.getLocList().Last());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            NewArea f1 = new NewArea();
            f1.ShowDialog();
        }
    }
}
