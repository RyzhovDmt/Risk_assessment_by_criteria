using Aspose.Pdf;
using Aspose.Pdf.Text;
using OxyPlot;
using OxyPlot.Axes;
using OxyPlot.Series;
using OxyPlot.WindowsForms;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace Risk_assessment_by_criteria
{
    public partial class Report : Form
    {
        float avgLoc = 0;
        List<float> avgs = new List<float>();
        public Report()
        {
            InitializeComponent();
            avgLoc = calcAvgs();
            fillTable();
            drawLocGraph(true);
            drawAreasGraph(Loc.getLocList()[0]);
            labelName.Text = "Объект: " + Component.objectName.ToString();
        }
 
        public void drawAreasGraph(string loc, bool saving = false)
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
                LabelPlacement = LabelPlacement.Inside,
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
                    barSeries.Items.Add(new BarItem { Value = Math.Round(sum, 2) , Color = defineAreaColor(sum , loc) });
                    categoryAxis.Labels.Add(a.title);
                }
            }
            model.Series.Add(barSeries);
            model.Axes.Add(categoryAxis);
            var valueAxis = new LinearAxis { Position = AxisPosition.Left, Key = "Value" };
            model.Axes.Add(valueAxis);
            this.plotViewAreas.Model = model;
            if (saving)
            {
                var pngExporter = new PngExporter { Width = 600, Height = 400 };
                pngExporter.ExportToFile(model, "graph2.jpg");
            }

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
        public void drawCompGraph(string ar, bool saving = false)
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
                    barSeries.Items.Add(new BarItem { Value = Math.Round(Component.riskForComponentByName(c.title, ar), 2), 
                        Color = defineCompColor(Component.riskForComponentByName(c.title, ar)) });
                    categoryAxis.Labels.Add(c.title);
                }
            }
            model.Series.Add(barSeries);
            model.Axes.Add(categoryAxis);
            var valueAxis = new LinearAxis { Position = AxisPosition.Left, Key = "Value" };
            model.Axes.Add(valueAxis);
            this.plotViewAreas.Model = model;
            if (saving)
            {
                var pngExporter = new PngExporter { Width = 600, Height = 400 };
                pngExporter.ExportToFile(model, "graph3.jpg");
            }

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
        public void drawLocGraph(bool saving = false)
        {
            var model = new PlotModel
            {
                Title = "Локации",
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
                    barSeries.Items.Add(new BarItem { Value = Math.Round(sum/ areasInLoc.Count, 2), Color = defineLocColor(sum / areasInLoc.Count, avgLoc) });
                    categoryAxis.Labels.Add(l);
                     
                } 
            }

            model.Series.Add(barSeries);
            model.Axes.Add(categoryAxis);
            var valueAxis = new LinearAxis { Position = AxisPosition.Left, Key = "Value" };
            model.Axes.Add(valueAxis);

            this.plotViewLoc.Model = model;

            //
            if (saving)
            {
                var pngExporter = new PngExporter { Width = 600, Height = 400 };
                pngExporter.ExportToFile(model, "graph.jpg");
            }


        }

        public float calcAvgs()
        {
            float avg = 0, max = 0;
            List<float> loc = new List<float>();
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
                if (sum / areasInLoc.Count >= loc.Max())
                {
                    labelLoc.Text = "Локация: " + l + " (" + Math.Round(sum / areasInLoc.Count, 2) + ")";
                    Dictionary<string, float> areaRisks = new Dictionary<string, float>();
                    foreach (var a in areasInLoc)
                    {
                        areaRisks.Add(a.title, Area.riskForArea(a.title));
                    }

                    string maxArea = areaRisks.FirstOrDefault(x => x.Value == areaRisks.Values.Max()).Key;
                    labelArea.Text = "Область: " + maxArea + " (" + Math.Round(areaRisks[maxArea], 2) + ")";
                    foreach (var c in Component.getCompList().FindAll(x => x.area == maxArea))
                    {
                        if (Component.riskForComponentByName(c.title, maxArea) > max)
                        {
                            max = Component.riskForComponentByName(c.title, maxArea);
                            labelComp.Text = "Компонент: " + c.title + " (" + Math.Round(max, 2) + ")";
                        }

                    }

                }
            }
            avg = loc.Average();

            labelRisk.Text = "Уровень риска системы: " + Math.Round(avg, 2).ToString();
            return avg;
        }

        public OxyColor defineLocColor(float riskVal, float avg)
        {

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
                    risk.Value = Math.Round(Area.riskForArea(t.title), 2);

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

        private void buttonSave_Click(object sender, EventArgs e)
        {

            Document doc = new Document();
            // Add page to pages collection of Document instance
            Page page = doc.Pages.Add();
            // Re-initialize TextFragment object with different contents
            TextFragment text = new TextFragment("Отчет \n\nпо оценке рисков информационной безопасности " +
                "на основе критериев существующих стандартов\n\n");
            // Set TextFragment as inline paragraph
            text.TextState.FontStyle = FontStyles.Bold;
            text.TextState.FontSize = 15;
            text.HorizontalAlignment = Aspose.Pdf.HorizontalAlignment.Center;
            // Add newly created TextFragment to paragraphs collection of page
            page.Paragraphs.Add(text);

            // Create TextFragmnet
            text = new TextFragment(
                "Объект оценки:  " + Component.objectName + "\n\n" +
                "Тип облачной инфраструктуры: " + Component.infrType + "\n\n" +
                "На основании угроз из " + Threat.sourceFile + "\n\n" +
                "Уровень принятия риска: " + Threat.riskCritValue + "\n\n" );
            // Add text fragment to paragraphs collection of Page object
            page.Paragraphs.Add(text);

           
            text = new TextFragment("Диаграмма показателей риска локалий: \n");
            text.HorizontalAlignment = Aspose.Pdf.HorizontalAlignment.Center;
            page.Paragraphs.Add(text);
            
            // Create an image instance
            Aspose.Pdf.Image image = new Aspose.Pdf.Image();
            // Set image as inline paragraph so that it appears right after
            // The previous paragraph object (TextFragment)

            // Specify image file path
            image.File = "graph.jpg";
            // Set image Height (optional)
            image.FixHeight = 250;
            // Set Image Width (optional)
            image.FixWidth = 400;
            // Add image to paragraphs collection of page object
            page.Paragraphs.Add(image);


            // Re-initialize TextFragment object with different contents
            text = new TextFragment("\n");
            // Set TextFragment as inline paragraph
            text = new TextFragment("\nТаблица рисков областей\n");
            // Add newly created TextFragment to paragraphs collection of page
            page.Paragraphs.Add(text);


            // Initializes a new instance of the Table
            Aspose.Pdf.Table table = new Aspose.Pdf.Table();
            // Set the table border color as LightGray
            //table.HorizontalAlignment = Aspose.Pdf.HorizontalAlignment.Center;
            table.Border = new Aspose.Pdf.BorderInfo(Aspose.Pdf.BorderSide.All, .5f, Aspose.Pdf.Color.FromRgb(System.Drawing.Color.LightGray));
            // Set the border for table cells

            table.DefaultCellBorder = new Aspose.Pdf.BorderInfo(Aspose.Pdf.BorderSide.All, .5f, Aspose.Pdf.Color.FromRgb(System.Drawing.Color.LightGray));
            Aspose.Pdf.Row row1 = table.Rows.Add();
            row1.Cells.Add("Локация");
            row1.Cells.Add("Область");
            row1.Cells.Add("Риск");
            foreach (var t in Area.getArList())
            {
                // Add row to table
                Aspose.Pdf.Row row = table.Rows.Add();
                // Add table cells
                row.Cells.Add(t.location);
                row.Cells.Add(t.title);
                row.Cells.Add(Math.Round(Area.riskForArea(t.title), 2).ToString());
            }

            // Add table object to first page of input document
            doc.Pages[1].Paragraphs.Add(table);

            text = new TextFragment(

                "\n\nЭлементы с наибольшем уровнем риска: " + "\n\n" +
                labelLoc.Text + "\n\n" +
                labelArea.Text + "\n\n" +
                labelComp.Text + "\n\n");
            page.Paragraphs.Add(text);


            // Create an image instance
            image = new Aspose.Pdf.Image();
            // Set image as inline paragraph so that it appears right after
            // The previous paragraph object (TextFragment)
            string[] words = labelLoc.Text.Split();
            drawAreasGraph(words[1], true);
            // Specify image file path
            image.File = "graph2.jpg";
            // Set image Height (optional)
            image.FixHeight = 250;
            // Set Image Width (optional)
            image.FixWidth = 400;
            // Add image to paragraphs collection of page object
            page.Paragraphs.Add(image);


            text = new TextFragment("\n\n");
            page.Paragraphs.Add(text);


            image = new Aspose.Pdf.Image();
            words = labelArea.Text.Split();
            drawCompGraph(words[1], true);
            // Specify image file path
            image.File = "graph3.jpg";
            // Set image Height (optional)
            image.FixHeight = 250;
            // Set Image Width (optional)
            image.FixWidth = 400;
            // Add image to paragraphs collection of page object
            page.Paragraphs.Add(image);


            string title = "Отчет " + DateTime.Now.ToString("dd_MM_yyyy_HH_mm") + ".pdf";
            // Save updated document containing table object
            doc.Save(title);

            var p = new Process();
            p.StartInfo = new ProcessStartInfo(title)
            {
                UseShellExecute = true
            };
            p.Start();

            FileInfo fileInf = new FileInfo("graph.jpg");
            if (fileInf.Exists)
                fileInf.Delete();
            fileInf = new FileInfo("graph2.jpg");
            if (fileInf.Exists)
                fileInf.Delete();
            fileInf = new FileInfo("graph3.jpg");
            if (fileInf.Exists)
                fileInf.Delete();

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            linkLabel1.LinkVisited = true;
            //Call the Process.Start method to open the default browser
            //with a URL:
            Process.Start(new ProcessStartInfo("https://elibrary.ru/item.asp?id=44611230") { UseShellExecute = true });

        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            linkLabel2.LinkVisited = true;
            Process.Start(new ProcessStartInfo("https://www.itweek.ru/infrastructure/jet/6/3/") { UseShellExecute = true });
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            linkLabel3.LinkVisited = true;
            Process.Start(new ProcessStartInfo("https://www.itweek.ru/security/article/detail.php?ID=208589") { UseShellExecute = true });
        }
    }
}
