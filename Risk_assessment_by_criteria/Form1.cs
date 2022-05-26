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


namespace Risk_assessment_by_criteria
{
    public partial class Form1 : Form
    {
        //public static Component mdl = new Component();
        //Threat threat = new Threat();
        //Component component = new Component();
        //Area area = new Area();
        //Location location = new Location();
        public Form1()
        {
            InitializeComponent();
            loadRes();
            Threat.readFromFile();
            Component.readFromFile();
            Area.readFromFile();
            Loc.readFromFile();
            fillTable();
            fillThreatTable();
            fillAreaTable();
            refreshListBox();
            
        }
        public void loadRes()
        {
            using (ResXResourceSet resxSet = new ResXResourceSet(@".\Params.resx"))
            {
                // Retrieve the string resource for the title.
                Threat.riskCritValue = (float)resxSet.GetObject("riskCritValue");
                Component.infrType = resxSet.GetString("infrType");
                Threat.sourceFile = resxSet.GetString("sourceFile");
            }
        }
        public void fillTable1()
        {
            dataGridView1.Columns.Clear();
            dataGridView1.Rows.Clear();
            DataGridViewTextBoxColumn column0 = new DataGridViewTextBoxColumn();
            column0.Name = "Loc";
            column0.HeaderText = "Локация";

            DataGridViewTextBoxColumn column1 = new DataGridViewTextBoxColumn();
            column1.Name = "Area";
            column1.HeaderText = "Область";

            DataGridViewTextBoxColumn column2 = new DataGridViewTextBoxColumn();
            column2.Name = "Threats";
            column2.HeaderText = "Угроза";

            DataGridViewTextBoxColumn column3 = new DataGridViewTextBoxColumn();
            column3.Name = "Weakness";
            column3.HeaderText = "Уязвимость";

            DataGridViewTextBoxColumn column4 = new DataGridViewTextBoxColumn();
            column4.Name = "Comp_name";
            column4.HeaderText = "Компонент";

            DataGridViewTextBoxColumn column5 = new DataGridViewTextBoxColumn();
            column5.Name = "V";
            column5.HeaderText = "Априорная вероятность реализации";

            DataGridViewTextBoxColumn column6 = new DataGridViewTextBoxColumn();
            column6.Name = "S";
            column6.HeaderText = "Априорная величина ущерба";

            DataGridViewTextBoxColumn column7 = new DataGridViewTextBoxColumn();
            column7.Name = "R";
            column7.HeaderText = "Риск";

            // --> current comp/thr list
            //List<comp> comp_list = new List<comp>();
            dataGridView1.Columns.AddRange(column0, column1, column2, column3, column4, column5, column6, column7);
            foreach (var t in Threat.getThrList())
            {

                foreach (var x in t.components)
                {
                    DataGridViewCell com = new DataGridViewTextBoxCell();
                    DataGridViewCell loc = new DataGridViewTextBoxCell();
                    DataGridViewCell area = new DataGridViewTextBoxCell();
                    DataGridViewCell th = new DataGridViewTextBoxCell();
                    DataGridViewCell weak = new DataGridViewTextBoxCell();
                    DataGridViewCell v = new DataGridViewTextBoxCell();
                    DataGridViewCell s = new DataGridViewTextBoxCell();
                    DataGridViewCell risk = new DataGridViewTextBoxCell();

                    //loc.Value = c.location;
                    //area.Value = c.area;
                    th.Value = t.title;
                    weak.Value = t.weakness;
                    com.Value = x;
                    v.Value = t.v;
                    s.Value = t.s;
                    var c = Component.getCompList();
                    var currComp = c.Find((p => p.title == x));
                    area.Value = currComp.area;
                    var currArea = Area.getArList().Find((p => p.title == currComp.area));
                    loc.Value = currArea.location;
                    //risk calculation
                    risk.Value = Threat.riskForComponent(t.s, t.v);
                    //
                    risk.Style.BackColor = Threat.defineRiskColor(risk.Value);
                    DataGridViewRow row0 = new DataGridViewRow();
                    row0.Cells.AddRange(loc, area, th, weak, com, v, s, risk);
                    dataGridView1.Rows.Add(row0);
                    //dataGridView1.Rows.Add();
                    //dataGridView1.Rows[i].Cells[0].Value = i.ToString();


                }
                //loc.Value = c.location;
                //area.Value = c.area;
                //is_exp.Value = false;

            }


            //DataGridViewCell is_exp0 = new DataGridViewCheckBoxCell();
            //DataGridViewCell thr0 = new DataGridViewTextBoxCell();
            //DataGridViewCell weak0 = new DataGridViewTextBoxCell();
            //DataGridViewCell v0 = new DataGridViewTextBoxCell();
            //DataGridViewCell s0 = new DataGridViewTextBoxCell();
            //s0.Value = "1";

            //dataGridView1.Rows.Add(row0);



        }
        public void fillTable()
        {
            dataGridView1.Columns.Clear();
            dataGridView1.Rows.Clear();
            DataGridViewTextBoxColumn column0 = new DataGridViewTextBoxColumn();
            column0.Name = "Loc";
            column0.HeaderText = "Локация";

            DataGridViewTextBoxColumn column1 = new DataGridViewTextBoxColumn();
            column1.Name = "Area";
            column1.HeaderText = "Область";

            DataGridViewTextBoxColumn column2 = new DataGridViewTextBoxColumn();
            column2.Name = "Threats";
            column2.HeaderText = "Угроза";

            DataGridViewTextBoxColumn column3 = new DataGridViewTextBoxColumn();
            column3.Name = "Weakness";
            column3.HeaderText = "Уязвимость";

            DataGridViewTextBoxColumn column4 = new DataGridViewTextBoxColumn();
            column4.Name = "Comp_name";
            column4.HeaderText = "Компонент";

            DataGridViewTextBoxColumn column5 = new DataGridViewTextBoxColumn();
            column5.Name = "V";
            column5.HeaderText = "Априорная вероятность реализации";

            DataGridViewTextBoxColumn column6 = new DataGridViewTextBoxColumn();
            column6.Name = "S";
            column6.HeaderText = "Априорная величина ущерба";

            DataGridViewTextBoxColumn column7 = new DataGridViewTextBoxColumn();
            column7.Name = "R";
            column7.HeaderText = "Риск";

            // --> current comp/thr list
            //List<comp> comp_list = new List<comp>();
            dataGridView1.Columns.AddRange(column0, column1, column2, column3, column4, column5, column6, column7);
            foreach (var a in Area.getArList())
            {
                var compsInArea = Component.getCompList().FindAll((p => p.area == a.title));
                foreach (var comp in compsInArea)
                {
                    var thrsForComp = Threat.getThrList().FindAll(p => p.components.Exists(x => x == comp.title));
                    foreach (var t in thrsForComp)
                    {
                        DataGridViewCell com = new DataGridViewTextBoxCell();
                        DataGridViewCell loc = new DataGridViewTextBoxCell();
                        DataGridViewCell area = new DataGridViewTextBoxCell();
                        DataGridViewCell th = new DataGridViewTextBoxCell();
                        DataGridViewCell weak = new DataGridViewTextBoxCell();
                        DataGridViewCell v = new DataGridViewTextBoxCell();
                        DataGridViewCell s = new DataGridViewTextBoxCell();
                        DataGridViewCell risk = new DataGridViewTextBoxCell();

                        //loc.Value = c.location;
                        //area.Value = c.area;
                        th.Value = t.title;
                        weak.Value = t.weakness;
                        com.Value = comp.title;
                        v.Value = t.v;
                        s.Value = t.s;

                        area.Value = a.title;
                       
                        loc.Value = a.location;
                        //risk calculation
                        risk.Value = Threat.riskForComponent(t.s, t.v);
                        //
                        risk.Style.BackColor = Threat.defineRiskColor(risk.Value);
                        DataGridViewRow row0 = new DataGridViewRow();
                        row0.Cells.AddRange(loc, area, th, weak, com, v, s, risk);
                        dataGridView1.Rows.Add(row0);
                    }
                    


                }
 

            }




        }
        public void fillThreatTable()
        {
            dataGridView2.Columns.Clear();
            dataGridView2.Rows.Clear();
            DataGridViewTextBoxColumn column1 = new DataGridViewTextBoxColumn();
            column1.Name = "Weakness";
            column1.HeaderText = "Уязвимость";

            DataGridViewTextBoxColumn column0 = new DataGridViewTextBoxColumn();
            column0.Name = "Thr_name";
            column0.HeaderText = "Название";

            DataGridViewTextBoxColumn column2 = new DataGridViewTextBoxColumn();
            column2.Name = "V";
            column2.HeaderText = "Априорная вероятность реализации";

            DataGridViewTextBoxColumn column3 = new DataGridViewTextBoxColumn();
            column3.Name = "S";
            column3.HeaderText = "Априорная величина ущерба";

            dataGridView2.Columns.AddRange(column0, column1, column2, column3);
            foreach (var t in Threat.getThrList())
            {

                DataGridViewCell th = new DataGridViewTextBoxCell();
                DataGridViewCell weak = new DataGridViewTextBoxCell();
                DataGridViewCell v = new DataGridViewTextBoxCell();
                DataGridViewCell s = new DataGridViewTextBoxCell();


                //loc.Value = c.location;
                //area.Value = c.area;
                th.Value = t.title;
                weak.Value = t.weakness;
                v.Value = t.v;
                s.Value = t.s;

                DataGridViewRow row0 = new DataGridViewRow();
                row0.Cells.AddRange(th, weak, v, s);
                dataGridView2.Rows.Add(row0);
                //dataGridView1.Rows.Add();
                //dataGridView1.Rows[i].Cells[0].Value = i.ToString();


                //loc.Value = c.location;
                //area.Value = c.area;
                //is_exp.Value = false;

            }
        }

        public void fillAreaTable()
        {
            dataGridView3.Columns.Clear();
            dataGridView3.Rows.Clear();
            DataGridViewTextBoxColumn column0 = new DataGridViewTextBoxColumn();
            column0.Name = "Ar_name";
            column0.HeaderText = "Область";

            DataGridViewTextBoxColumn column1 = new DataGridViewTextBoxColumn();
            column1.Name = "Loc";
            column1.HeaderText = "Локация";

            DataGridViewTextBoxColumn column2 = new DataGridViewTextBoxColumn();
            column2.Name = "Risk crit";
            column2.HeaderText = "Критерий риска";

            DataGridViewTextBoxColumn column3 = new DataGridViewTextBoxColumn();
            column3.Name = "Resp zone";
            column3.HeaderText = "Зона ответственности";

            dataGridView3.Columns.AddRange(column0, column1, column2, column3);


            foreach (var t in Area.getArList())
            {

                DataGridViewCell area = new DataGridViewTextBoxCell();
                DataGridViewCell loc = new DataGridViewTextBoxCell();
                DataGridViewCell risk = new DataGridViewTextBoxCell();
                DataGridViewCell resp = new DataGridViewTextBoxCell();
                var c = Component.getCompList();
                var compAreaList = c.FindAll((p => p.area == t.title));
                //loc.Value = c.location;
                //area.Value = c.area;
                area.Value = t.title;
                loc.Value = t.location;
                risk.Value = t.riskCr;
                resp.Value = t.resp;
                DataGridViewRow row = new DataGridViewRow();
                row.Cells.AddRange(area, loc, risk, resp);
                dataGridView3.Rows.Add(row);
                //dataGridView1.Rows.Add();
                //dataGridView1.Rows[i].Cells[0].Value = i.ToString();


                //loc.Value = c.location;
                //area.Value = c.area;
                //is_exp.Value = false;

            }
        }

        private void refreshListBox()
        {
            foreach (string name in Loc.getLocList())
            {
                listBox1.Items.Add(name);
            }
        }


        private void button_newcomp_Click(object sender, EventArgs e)
        {
            NewComp f1 = new NewComp();
            f1.ShowDialog();
            //mdl.add_to_file();
        }

        private void button_addthr_Click(object sender, EventArgs e)
        {
            NewThreat f1 = new NewThreat();
            f1.ShowDialog();
        }

        private void button_addloc_Click(object sender, EventArgs e)
        {
            Loc.addToFile(Loc.makeNewName());
            addLocToListBox();
        }

        public void addLocToListBox()
        {
            listBox1.Items.Add(Loc.getLocList().Last());
        }

        private void button_addarea_Click(object sender, EventArgs e)
        {
            NewArea f1 = new NewArea();
            f1.ShowDialog();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem != null)
            {
                var pe = Loc.getLocList();
                listView1.Items.Clear();
                var arList = Area.getArList().FindAll((p => p.location == listBox1.SelectedItem.ToString()));
                foreach (var ar in arList)
                {
                    listView1.Items.Add(ar.title.ToString());
                }

            }
        }

        private void Form1_Activated(object sender, EventArgs e)
        {
            if (Area.isSuccAdd)
                addNewArea();
            if (Component.isSuccAdd || Component.isSuccEd)
                fillTable();
            if (Threat.isSuccAdd)
                { 
                    addNewThr();
                    addNewComp();
                }
            if (Area.isSuccEd || Area.isSuccDel)
                fillAreaTable();
            if (Threat.isSuccEd || Threat.isSuccDel )
            {
                fillThreatTable();
                fillTable();
            }
            if (Component.isSuccDel)
            {
                fillTable();
                fillThreatTable();
            }

        }

        private void addNewThr()
        {
            var newElem = Threat.getThrList().Last();
            DataGridViewCell th = new DataGridViewTextBoxCell();
            DataGridViewCell weak = new DataGridViewTextBoxCell();
            DataGridViewCell v = new DataGridViewTextBoxCell();
            DataGridViewCell s = new DataGridViewTextBoxCell();


            //loc.Value = c.location;
            //area.Value = c.area;
            th.Value = newElem.title;
            weak.Value = newElem.weakness;
            v.Value = newElem.v;
            s.Value = newElem.s;

            DataGridViewRow row0 = new DataGridViewRow();
            row0.Cells.AddRange(th, weak, v, s);
            dataGridView2.Rows.Add(row0);
        }

        private void addNewComp()
        {
            var newElem = Threat.getThrList().Last();
            foreach (var x in newElem.components)
            {

                DataGridViewCell com = new DataGridViewTextBoxCell();
                DataGridViewCell loc = new DataGridViewTextBoxCell();
                DataGridViewCell area = new DataGridViewTextBoxCell();
                DataGridViewCell th = new DataGridViewTextBoxCell();
                DataGridViewCell weak = new DataGridViewTextBoxCell();
                DataGridViewCell v = new DataGridViewTextBoxCell();
                DataGridViewCell s = new DataGridViewTextBoxCell();
                DataGridViewCell risk = new DataGridViewTextBoxCell();
                //loc.Value = c.location;
                //area.Value = c.area;
                th.Value = newElem.title;
                weak.Value = newElem.weakness;
                com.Value = x;
                v.Value = newElem.v;
                s.Value = newElem.s;
                var c = Component.getCompList();
                var currComp = c.Find((p => p.title == x));
                area.Value = currComp.area;
                var currArea = Area.getArList().Find((p => p.title == currComp.area));
                loc.Value = currArea.location;
                risk.Value = Threat.riskForComponent(newElem.s, newElem.v);
                DataGridViewRow row0 = new DataGridViewRow();
                row0.Cells.AddRange(loc, area, th, weak, com, v, s, risk);
                dataGridView1.Rows.Add(row0);
            }
        }

        private void addNewArea()
        {
            var newElem = Area.getArList().Last();
            DataGridViewCell area = new DataGridViewTextBoxCell();
            DataGridViewCell loc = new DataGridViewTextBoxCell();
            DataGridViewCell risk = new DataGridViewTextBoxCell();
            DataGridViewCell resp = new DataGridViewTextBoxCell();

            var c = Component.getCompList();
            var compAreaList = c.FindAll((p => p.area == newElem.title));
            //loc.Value = c.location;
            //area.Value = c.area;
            area.Value = newElem.title;
            loc.Value = newElem.location;
            risk.Value = newElem.riskCr;
            resp.Value = newElem.resp;

            DataGridViewRow row = new DataGridViewRow();
            row.Cells.AddRange(area, loc, risk, resp);
            dataGridView3.Rows.Add(row);
            //dataGridView1.Rows.Add();
            //dataGridView1.Rows[i].Cells[0].Value = i.ToString();


            //loc.Value = c.location;
            //area.Value = c.area;
            //is_exp.Value = false;


        }

        private void button_chAr_Click(object sender, EventArgs e)
        {
            if (dataGridView3.SelectedRows.Count != 0)
            {
                EditArea f = new EditArea();
                Area.isSuccEd = false;
                Area.currName = dataGridView3.SelectedRows[0].Cells[0].Value.ToString();
                f.textBox_name.Text = Area.currName;
                var c = Area.getArList();
                var chAr = c.Find((p => p.title == Area.currName));
                f.textBox_k.Text = chAr.riskCr.ToString();
                f.trackBar1.Value = Convert.ToInt32(chAr.riskCr);
                f.comboBox_loc.SelectedItem = chAr.location;
                f.comboBox_resp.SelectedItem = chAr.resp;
                f.ShowDialog();
            }
            else
                MessageBox.Show("Необходимо выбрать строку изменяемой области", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button_chComp_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count != 0)
            {
                EditComp f = new EditComp();
                Component.isSuccEd = false;
                Component.currName = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
                f.textBox_name.Text = Component.currName;
                var c = Component.getCompList();
                var chCom = c.Find((p => p.title == Component.currName));
                var chArea = Area.getArList().Find((p => p.title == chCom.area));
                f.comboBox_loc.SelectedItem = chArea.location;
                f.comboBox_area.SelectedItem = chCom.area;
                f.ShowDialog();
            }
            else
                MessageBox.Show("Необходимо выбрать строку изменяемого компонента", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void buttonchThr_Click(object sender, EventArgs e)
        {
            if (dataGridView2.SelectedRows.Count != 0)
            {
                Threat.currName = dataGridView2.SelectedRows[0].Cells[0].Value.ToString();
                Threat.isSuccEd = false;
                EditThreat f = new EditThreat();
                var c = Threat.getThrList();
                var chThr = c.Find((p => p.title == Threat.currName));
                f.textBox_name.Text = Threat.currName;
                f.textBox_weakness.Text = chThr.weakness;
                f.textBox_v.Text = chThr.v.ToString();
                f.trackBar1.Value = Convert.ToInt32(chThr.v * 20);
                f.textBox_s.Text = chThr.s.ToString();
                f.trackBar2.Value = Convert.ToInt32(chThr.s);
                f.ShowDialog();
            }
            else
                MessageBox.Show("Необходимо выбрать строку изменяемой угрозы", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void button_delcomp_Click(object sender, EventArgs e)
        {
            if (Component.deleteComponent(dataGridView1.SelectedRows[0].Cells[4].Value.ToString()))
            {
                Component.isSuccDel = true;
                MessageBox.Show("Компонент удален", "Удаление компонента", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                Component.isSuccDel = false;
                MessageBox.Show("Необходимо выбрать имя компонента", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void button_delthr_Click(object sender, EventArgs e)
        {
            if (Threat.deleteThreat(dataGridView2.SelectedRows[0].Cells[0].Value.ToString()))
            {
                Threat.isSuccDel = true;
                MessageBox.Show("Угроза удалена", "Удаление угрозы", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                Threat.isSuccDel = false;
                MessageBox.Show("Необходимо выбрать имя угрозы", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void button_locDel_Click(object sender, EventArgs e)
        {
            if (Loc.deleteLoc(listBox1.SelectedItem.ToString()))
            {
                Loc.isSuccDel = true;
                MessageBox.Show("Локация удалена", "Удаление локации", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                Loc.isSuccDel = false;
                MessageBox.Show("Необходимо выбрать локацию", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void button_arDel_Click(object sender, EventArgs e)
        {
            if (Area.deleteArea(dataGridView3.SelectedRows[0].Cells[0].Value.ToString()))
            {
                Area.isSuccDel = true;
                MessageBox.Show("Область удалена", "Удаление области", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                Area.isSuccDel = false;
                MessageBox.Show("Необходимо выбрать область", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }



        private void dataGridView3_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGridView3.CurrentRow.Selected = true;
            
            if (dataGridView3.Rows[e.RowIndex].Cells[0].Value != null)
            {
                listViewComps.Items.Clear();
                var arList = Component.getCompList().FindAll((p => p.area == dataGridView3.Rows[e.RowIndex].Cells[0].Value.ToString()));
                foreach (var ar in arList)
                {
                    listViewComps.Items.Add(ar.title.ToString());
                }

            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGridView1.CurrentRow.Selected = true;

        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGridView2.CurrentRow.Selected = true;
        }

        private void параметрыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Parameters f1 = new Parameters();
            f1.textBox_rcr.Text = Threat.riskCritValue.ToString();
            f1.trackBar1.Value = Convert.ToInt32(Threat.riskCritValue*100);
            switch (Component.infrType)
            {
                case "SaaS":
                    f1.radioButtonSaaS.Checked = true;
                    break;
                case "PaaS":
                    f1.radioButtonPaaS.Checked = true;
                    break;
                case "IaaS":
                    f1.radioButtonIaaS.Checked = true;
                    break;
            }
            switch (Threat.sourceFile)
            {
                case "ThreatsFSTEC.xml":
                    f1.radioButtonBank.Checked = true;
                    break;
                case "ThreatsISO27005.xml":
                    f1.radioButtonGost.Checked = true;
                    break;

            }

            f1.ShowDialog();
        }

        private void button_rep_Click(object sender, EventArgs e)
        {
            Report f1 = new Report();
            f1.ShowDialog();
        }
    }
}
