
namespace Risk_assessment_by_criteria
{
    partial class Report
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button_ex = new System.Windows.Forms.Button();
            this.plotViewLoc = new OxyPlot.WindowsForms.PlotView();
            this.plotViewAreas = new OxyPlot.WindowsForms.PlotView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(53, 294);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(410, 191);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // button_ex
            // 
            this.button_ex.Location = new System.Drawing.Point(776, 458);
            this.button_ex.Name = "button_ex";
            this.button_ex.Size = new System.Drawing.Size(122, 39);
            this.button_ex.TabIndex = 37;
            this.button_ex.Text = "Закрыть";
            this.button_ex.UseVisualStyleBackColor = true;
            this.button_ex.Click += new System.EventHandler(this.button_ex_Click);
            // 
            // plotViewLoc
            // 
            this.plotViewLoc.Location = new System.Drawing.Point(53, 33);
            this.plotViewLoc.Name = "plotViewLoc";
            this.plotViewLoc.PanCursor = System.Windows.Forms.Cursors.Hand;
            this.plotViewLoc.Size = new System.Drawing.Size(410, 222);
            this.plotViewLoc.TabIndex = 38;
            this.plotViewLoc.Text = "plotView1";
            this.plotViewLoc.ZoomHorizontalCursor = System.Windows.Forms.Cursors.SizeWE;
            this.plotViewLoc.ZoomRectangleCursor = System.Windows.Forms.Cursors.SizeNWSE;
            this.plotViewLoc.ZoomVerticalCursor = System.Windows.Forms.Cursors.SizeNS;
            // 
            // plotViewAreas
            // 
            this.plotViewAreas.Location = new System.Drawing.Point(504, 33);
            this.plotViewAreas.Name = "plotViewAreas";
            this.plotViewAreas.PanCursor = System.Windows.Forms.Cursors.Hand;
            this.plotViewAreas.Size = new System.Drawing.Size(394, 364);
            this.plotViewAreas.TabIndex = 39;
            this.plotViewAreas.Text = "plotView2";
            this.plotViewAreas.ZoomHorizontalCursor = System.Windows.Forms.Cursors.SizeWE;
            this.plotViewAreas.ZoomRectangleCursor = System.Windows.Forms.Cursors.SizeNWSE;
            this.plotViewAreas.ZoomVerticalCursor = System.Windows.Forms.Cursors.SizeNS;
            // 
            // Report
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(927, 520);
            this.Controls.Add(this.plotViewAreas);
            this.Controls.Add(this.plotViewLoc);
            this.Controls.Add(this.button_ex);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Report";
            this.Text = "Report";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button_ex;
        private OxyPlot.WindowsForms.PlotView plotViewLoc;
        private OxyPlot.WindowsForms.PlotView plotViewAreas;
    }
}