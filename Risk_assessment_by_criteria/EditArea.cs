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
    public partial class EditArea : Form
    {
        public EditArea()
        {
            InitializeComponent();
            fillLocCombobox();
            fillRespCombobox();
        }
        private void fillLocCombobox()
        {
            comboBox_loc.Items.AddRange(Loc.getLocList().ToArray());
        }
        private void fillRespCombobox()
        {
            string[] marks = { "Приложения + БД", "Базы данных", "Другая" };
            comboBox_resp.Items.AddRange(marks);
        }
        private void comboBox_loc_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBox_name.Text = Area.makeNewName(comboBox_loc.Text);
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            textBox_k.Text = (trackBar1.Value).ToString();
        }

        private void button_save_Click(object sender, EventArgs e)
        {
            if (Area.changeArea(textBox_name.Text.ToString(), float.Parse(textBox_k.Text), comboBox_loc.SelectedItem.ToString()))
            {
                Area.isSuccEd = true;
                MessageBox.Show("Область успешно изменена", "Изменение области", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void button_ex_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
