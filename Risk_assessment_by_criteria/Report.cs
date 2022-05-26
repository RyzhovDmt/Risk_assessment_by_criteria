using OxyPlot;
using OxyPlot.Axes;
using OxyPlot.Series;
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
    public partial class Report : Form
    {
        public Report()
        {
            InitializeComponent();
            fillTable();
            drawLocGraph();
        }
 
        public void drawAreasGraph(string loc)
        {
            var model = new PlotModel
            {
                Title =  loc + ": области"
            };
            var barSeries = new BarSeries
            {
                XAxisKey = "Value",
                YAxisKey = "Category",
                StrokeThickness = 1,
                //LabelPlacement = LabelPlacement.Inside,
            };
            var categoryAxis = new CategoryAxis { Position = AxisPosition.Bottom, Key = "Category" };
            bool isComponent = false;
            var areasInLoc = Area.getArList().FindAll(x => x.location == loc);
            foreach (var a in areasInLoc)
            {
                float sum = 0;
                if (double.IsNaN(Area.riskForArea(a.title)))
                    continue;
                else
                {
                    sum += Area.riskForArea(a.title);
                    isComponent = true;
                }
                if (isComponent)
                {
                    barSeries.Items.Add(new BarItem { Value = sum , Color = defineAreaColor(sum , loc) });
                    categoryAxis.Labels.Add(a.title);
                }
            }
            model.Series.Add(barSeries);
            model.Axes.Add(categoryAxis);
            var valueAxis = new LinearAxis { Position = AxisPosition.Left, Key = "Value" };
            model.Axes.Add(valueAxis);
            this.plotViewAreas.Model = model;
        }
        public OxyColor defineAreaColor(float riskVal, string loc)
        {
            float avg = 0;
            
            bool isComponent = false;
            List<float> ar = new List<float>();
            var areasInLoc = Area.getArList().FindAll(x => x.location == loc);
            foreach (var a in areasInLoc)
            {
                float sum = 0;
                if (double.IsNaN(Area.riskForArea(a.title)))
                    continue;
                else
                {
                    sum += Area.riskForArea(a.title);
                    isComponent = true;
                }
                if (isComponent)
                {
                    ar.Add(sum);
                }
            }
            avg = ar.Average();
            if (riskVal >= 0.85 * avg && riskVal <= 1.15 * avg)
                return OxyColors.Yellow;
            if (riskVal > 1.15 * avg && riskVal <= 1.3 * avg)
                return OxyColors.Orange;
            if (riskVal > 1.3 * avg)
                return OxyColors.OrangeRed;
            if (riskVal >= 0.7 * avg && riskVal < 0.85 * avg)
                return OxyColors.YellowGreen;
            if (riskVal < 0.7 * avg)
                return OxyColors.GreenYellow;
            return OxyColors.Blue;
        }
        public void drawCompGraph(string ar)
        {
            var model = new PlotModel
            {
                Title = ar + ": компоненты"
            };
            var barSeries = new BarSeries
            {
                XAxisKey = "Value",
                YAxisKey = "Category",
                StrokeThickness = 1,
                //LabelPlacement = LabelPlacement.Inside,
            };
            var categoryAxis = new CategoryAxis { Position = AxisPosition.Bottom, Key = "Category", Angle = 90 };
            bool isComponent = false;
            var compsInArea = Component.getCompList().FindAll(x => x.area == ar);
            float sum = 0;
            foreach (var c in compsInArea)
            {
                if (double.IsNaN(Component.riskForComponentByName(c.title, ar)))
                    continue;
                else
                {
                    sum += Area.riskForArea(c.title);
                    isComponent = true;
                }
                if (isComponent)
                {
                    barSeries.Items.Add(new BarItem { Value = Component.riskForComponentByName(c.title, ar), 
                        Color = defineCompColor(Component.riskForComponentByName(c.title, ar)) });
                    categoryAxis.Labels.Add(c.title);
                }
            }
            model.Series.Add(barSeries);
            model.Axes.Add(categoryAxis);
            var valueAxis = new LinearAxis { Position = AxisPosition.Left, Key = "Value" };
            model.Axes.Add(valueAxis);
            this.plotViewAreas.Model = model;
        }
        public OxyColor defineCompColor(float riskVal)
        {
            if (riskVal <= 1.2 * Threat.riskCritValue)
                return OxyColors.YellowGreen;
            if (riskVal > 1.2 * Threat.riskCritValue && riskVal <= 1.4 * Threat.riskCritValue)
                return OxyColors.Orange;
            if (riskVal > 1.4 * Threat.riskCritValue)
                return OxyColors.OrangeRed;
            return OxyColors.Blue;
        }
        public void drawLocGraph()
        {
            var model = new PlotModel
            {
                Title = "BarSeries",
            };
            var barSeries = new BarSeries
            {
                XAxisKey = "Value",
                YAxisKey = "Category",
                StrokeThickness = 1,
                //LabelPlacement = LabelPlacement.Inside,
            };
            var categoryAxis = new CategoryAxis { Position = AxisPosition.Bottom, Key = "Category" };
            foreach (var l in Loc.getLocList())
            {
                bool isComponent = false;
                var areasInLoc = Area.getArList().FindAll(x => x.location == l);
                float sum = 0;
                foreach (var a in areasInLoc)
                {

                    if (double.IsNaN(Area.riskForArea(a.title)))
                        continue;
                    else
                    {
                        sum += Area.riskForArea(a.title);
                        
                        isComponent = true;
                    }
                }

                if (isComponent)
                {
                    barSeries.Items.Add(new BarItem { Value = sum/ areasInLoc.Count, Color = defineLocColor(sum / areasInLoc.Count) });
                    categoryAxis.Labels.Add(l);
                     
                } 
            }

            model.Series.Add(barSeries);
            model.Axes.Add(categoryAxis);
            var valueAxis = new LinearAxis { Position = AxisPosition.Left, Key = "Value" };
            model.Axes.Add(valueAxis);

            this.plotViewLoc.Model = model;
        }
        public OxyColor defineLocColor(float riskVal)
        {
            float avg = 0;
            List <float> loc = new List<float>();
            foreach (var l in Loc.getLocList())
            {
                bool isComponent = false;
                var areasInLoc = Area.getArList().FindAll(x => x.location == l);
                float sum = 0;
                foreach (var a in areasInLoc)
                {

                    if (double.IsNaN(Area.riskForArea(a.title)))
                        continue;
                    else
                    {
                        sum += Area.riskForArea(a.title);
                        isComponent = true;
                    }
                }
                if (isComponent)
                {
                    loc.Add(sum / areasInLoc.Count);
                }
            }
            avg = loc.Average();
            if (riskVal >= 0.85 * avg && riskVal <= 1.15 * avg)
                return OxyColors.Yellow;
            if (riskVal > 1.15 * avg && riskVal <= 1.3 * avg)
                return OxyColors.Orange;
            if (riskVal > 1.3 * avg)
                return OxyColors.OrangeRed;
            if (riskVal >= 0.7 * avg && riskVal < 0.85 * avg)
                return OxyColors.YellowGreen;
            if (riskVal < 0.7 * avg)
                return OxyColors.GreenYellow;
            return OxyColors.Blue;
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
            column2.Name = "R";
            column2.HeaderText = "Риск";

            // --> current comp/thr list
            //List<comp> comp_list = new List<comp>();
            dataGridView1.Columns.AddRange(column0, column1, column2);
            foreach (var t in Area.getArList())
            {

                DataGridViewCell loc = new DataGridViewTextBoxCell();
                DataGridViewCell area = new DataGridViewTextBoxCell();
                DataGridViewCell risk = new DataGridViewTextBoxCell();

                //loc.Value = c.location;
                //area.Value = c.area;
                area.Value = t.title;
                loc.Value = t.location;
                if (double.IsNaN(Area.riskForArea(t.title)))
                    risk.Value = "Компоненты отсутствуют";
                else
                    risk.Value = Area.riskForArea(t.title);

                //risk.Style.BackColor = Threat.defineRiskColor(risk.Value);
                DataGridViewRow row0 = new DataGridViewRow();
                row0.Cells.AddRange(loc, area, risk);
                dataGridView1.Rows.Add(row0);

            }

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex] == null ||
                dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value == null)
            { }
            else
            {
                if (e.ColumnIndex == 0)
                    drawAreasGraph(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
                if (e.ColumnIndex == 1)
                    drawCompGraph(dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString());
            }
        }

        private void button_ex_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
