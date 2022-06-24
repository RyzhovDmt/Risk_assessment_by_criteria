
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
            this.labelName = new System.Windows.Forms.Label();
            this.labelRisk = new System.Windows.Forms.Label();
            this.labelLoc = new System.Windows.Forms.Label();
            this.labelArea = new System.Windows.Forms.Label();
            this.labelComp = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.labelRec = new System.Windows.Forms.Label();
            this.buttonSave = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            this.linkLabel3 = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(53, 581);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(410, 191);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // button_ex
            // 
            this.button_ex.Location = new System.Drawing.Point(845, 733);
            this.button_ex.Name = "button_ex";
            this.button_ex.Size = new System.Drawing.Size(122, 39);
            this.button_ex.TabIndex = 37;
            this.button_ex.Text = "Закрыть";
            this.button_ex.UseVisualStyleBackColor = true;
            this.button_ex.Click += new System.EventHandler(this.button_ex_Click);
            // 
            // plotViewLoc
            // 
            this.plotViewLoc.Location = new System.Drawing.Point(53, 323);
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
            this.plotViewAreas.Location = new System.Drawing.Point(543, 33);
            this.plotViewAreas.Name = "plotViewAreas";
            this.plotViewAreas.PanCursor = System.Windows.Forms.Cursors.Hand;
            this.plotViewAreas.Size = new System.Drawing.Size(394, 496);
            this.plotViewAreas.TabIndex = 39;
            this.plotViewAreas.Text = "plotView2";
            this.plotViewAreas.ZoomHorizontalCursor = System.Windows.Forms.Cursors.SizeWE;
            this.plotViewAreas.ZoomRectangleCursor = System.Windows.Forms.Cursors.SizeNWSE;
            this.plotViewAreas.ZoomVerticalCursor = System.Windows.Forms.Cursors.SizeNS;
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelName.Location = new System.Drawing.Point(53, 33);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(59, 23);
            this.labelName.TabIndex = 41;
            this.labelName.Text = "label1";
            // 
            // labelRisk
            // 
            this.labelRisk.AutoSize = true;
            this.labelRisk.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelRisk.Location = new System.Drawing.Point(53, 80);
            this.labelRisk.Name = "labelRisk";
            this.labelRisk.Size = new System.Drawing.Size(55, 23);
            this.labelRisk.TabIndex = 42;
            this.labelRisk.Text = "label1";
            // 
            // labelLoc
            // 
            this.labelLoc.AutoSize = true;
            this.labelLoc.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelLoc.Location = new System.Drawing.Point(53, 180);
            this.labelLoc.Name = "labelLoc";
            this.labelLoc.Size = new System.Drawing.Size(55, 23);
            this.labelLoc.TabIndex = 43;
            this.labelLoc.Text = "label1";
            // 
            // labelArea
            // 
            this.labelArea.AutoSize = true;
            this.labelArea.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelArea.Location = new System.Drawing.Point(53, 230);
            this.labelArea.Name = "labelArea";
            this.labelArea.Size = new System.Drawing.Size(55, 23);
            this.labelArea.TabIndex = 44;
            this.labelArea.Text = "label1";
            // 
            // labelComp
            // 
            this.labelComp.AutoSize = true;
            this.labelComp.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelComp.Location = new System.Drawing.Point(53, 280);
            this.labelComp.Name = "labelComp";
            this.labelComp.Size = new System.Drawing.Size(55, 23);
            this.labelComp.TabIndex = 45;
            this.labelComp.Text = "label1";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(559, 614);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(279, 20);
            this.linkLabel1.TabIndex = 46;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "https://elibrary.ru/item.asp?id=44611230";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // labelRec
            // 
            this.labelRec.AutoSize = true;
            this.labelRec.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelRec.Location = new System.Drawing.Point(559, 553);
            this.labelRec.Name = "labelRec";
            this.labelRec.Size = new System.Drawing.Size(364, 46);
            this.labelRec.TabIndex = 47;
            this.labelRec.Text = "Для снижения уровня риска воспользуйтесь\r\nрекоммендациями из источников:";
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(543, 733);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(122, 39);
            this.buttonSave.TabIndex = 48;
            this.buttonSave.Text = "Сохранить";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(53, 130);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(341, 23);
            this.label1.TabIndex = 49;
            this.label1.Text = "Элементы с наибольшим уровнем риска";
            // 
            // linkLabel2
            // 
            this.linkLabel2.AutoSize = true;
            this.linkLabel2.Location = new System.Drawing.Point(559, 644);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(302, 20);
            this.linkLabel2.TabIndex = 50;
            this.linkLabel2.TabStop = true;
            this.linkLabel2.Text = "https://www.itweek.ru/infrastructure/jet/6/3/";
            this.linkLabel2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel2_LinkClicked);
            // 
            // linkLabel3
            // 
            this.linkLabel3.AutoSize = true;
            this.linkLabel3.Location = new System.Drawing.Point(559, 674);
            this.linkLabel3.Name = "linkLabel3";
            this.linkLabel3.Size = new System.Drawing.Size(408, 20);
            this.linkLabel3.TabIndex = 51;
            this.linkLabel3.TabStop = true;
            this.linkLabel3.Text = "https://www.itweek.ru/security/article/detail.php?ID=208589";
            this.linkLabel3.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel3_LinkClicked);
            // 
            // Report
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1003, 794);
            this.Controls.Add(this.linkLabel3);
            this.Controls.Add(this.linkLabel2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.labelRec);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.labelComp);
            this.Controls.Add(this.labelArea);
            this.Controls.Add(this.labelLoc);
            this.Controls.Add(this.labelRisk);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.plotViewAreas);
            this.Controls.Add(this.plotViewLoc);
            this.Controls.Add(this.button_ex);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Report";
            this.Text = "Отчет";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button_ex;
        private OxyPlot.WindowsForms.PlotView plotViewLoc;
        private OxyPlot.WindowsForms.PlotView plotViewAreas;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelRisk;
        private System.Windows.Forms.Label labelLoc;
        private System.Windows.Forms.Label labelArea;
        private System.Windows.Forms.Label labelComp;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Label labelRec;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel linkLabel2;
        private System.Windows.Forms.LinkLabel linkLabel3;
    }
}