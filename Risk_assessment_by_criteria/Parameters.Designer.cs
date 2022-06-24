
namespace Risk_assessment_by_criteria
{
    partial class Parameters
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
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.textBox_rcr = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.button_ex = new System.Windows.Forms.Button();
            this.button_save = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBoxType = new System.Windows.Forms.GroupBox();
            this.radioButtonIaaS = new System.Windows.Forms.RadioButton();
            this.radioButtonPaaS = new System.Windows.Forms.RadioButton();
            this.radioButtonSaaS = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButtonCust = new System.Windows.Forms.RadioButton();
            this.radioButtonBank = new System.Windows.Forms.RadioButton();
            this.radioButtonGost = new System.Windows.Forms.RadioButton();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.groupBoxType.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // trackBar1
            // 
            this.trackBar1.LargeChange = 1;
            this.trackBar1.Location = new System.Drawing.Point(280, 154);
            this.trackBar1.Maximum = 30;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(208, 56);
            this.trackBar1.TabIndex = 52;
            this.trackBar1.Value = 10;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // textBox_rcr
            // 
            this.textBox_rcr.Location = new System.Drawing.Point(543, 154);
            this.textBox_rcr.Name = "textBox_rcr";
            this.textBox_rcr.ReadOnly = true;
            this.textBox_rcr.Size = new System.Drawing.Size(95, 27);
            this.textBox_rcr.TabIndex = 51;
            this.textBox_rcr.Text = "0.1";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(48, 154);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(192, 20);
            this.label4.TabIndex = 50;
            this.label4.Text = "Критерий принятия риска";
            // 
            // button_ex
            // 
            this.button_ex.Location = new System.Drawing.Point(543, 484);
            this.button_ex.Name = "button_ex";
            this.button_ex.Size = new System.Drawing.Size(122, 39);
            this.button_ex.TabIndex = 47;
            this.button_ex.Text = "Закрыть";
            this.button_ex.UseVisualStyleBackColor = true;
            this.button_ex.Click += new System.EventHandler(this.button_ex_Click);
            // 
            // button_save
            // 
            this.button_save.Location = new System.Drawing.Point(44, 484);
            this.button_save.Name = "button_save";
            this.button_save.Size = new System.Drawing.Size(122, 39);
            this.button_save.TabIndex = 46;
            this.button_save.Text = "Сохранить";
            this.button_save.UseVisualStyleBackColor = true;
            this.button_save.Click += new System.EventHandler(this.button_save_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(46, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 25);
            this.label1.TabIndex = 42;
            this.label1.Text = "Параметры";
            // 
            // groupBoxType
            // 
            this.groupBoxType.Controls.Add(this.radioButtonIaaS);
            this.groupBoxType.Controls.Add(this.radioButtonPaaS);
            this.groupBoxType.Controls.Add(this.radioButtonSaaS);
            this.groupBoxType.Location = new System.Drawing.Point(44, 216);
            this.groupBoxType.Name = "groupBoxType";
            this.groupBoxType.Size = new System.Drawing.Size(283, 88);
            this.groupBoxType.TabIndex = 53;
            this.groupBoxType.TabStop = false;
            this.groupBoxType.Text = "Тип облачной инфраструктуры";
            // 
            // radioButtonIaaS
            // 
            this.radioButtonIaaS.AutoSize = true;
            this.radioButtonIaaS.Location = new System.Drawing.Point(201, 38);
            this.radioButtonIaaS.Name = "radioButtonIaaS";
            this.radioButtonIaaS.Size = new System.Drawing.Size(58, 24);
            this.radioButtonIaaS.TabIndex = 2;
            this.radioButtonIaaS.TabStop = true;
            this.radioButtonIaaS.Text = "IaaS";
            this.radioButtonIaaS.UseVisualStyleBackColor = true;
            // 
            // radioButtonPaaS
            // 
            this.radioButtonPaaS.AutoSize = true;
            this.radioButtonPaaS.Location = new System.Drawing.Point(111, 38);
            this.radioButtonPaaS.Name = "radioButtonPaaS";
            this.radioButtonPaaS.Size = new System.Drawing.Size(61, 24);
            this.radioButtonPaaS.TabIndex = 1;
            this.radioButtonPaaS.TabStop = true;
            this.radioButtonPaaS.Text = "PaaS";
            this.radioButtonPaaS.UseVisualStyleBackColor = true;
            // 
            // radioButtonSaaS
            // 
            this.radioButtonSaaS.AutoSize = true;
            this.radioButtonSaaS.Location = new System.Drawing.Point(21, 38);
            this.radioButtonSaaS.Name = "radioButtonSaaS";
            this.radioButtonSaaS.Size = new System.Drawing.Size(62, 24);
            this.radioButtonSaaS.TabIndex = 0;
            this.radioButtonSaaS.TabStop = true;
            this.radioButtonSaaS.Text = "SaaS";
            this.radioButtonSaaS.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButtonCust);
            this.groupBox1.Controls.Add(this.radioButtonBank);
            this.groupBox1.Controls.Add(this.radioButtonGost);
            this.groupBox1.Location = new System.Drawing.Point(48, 322);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(519, 134);
            this.groupBox1.TabIndex = 54;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Источник базы угроз";
            // 
            // radioButtonCust
            // 
            this.radioButtonCust.AutoSize = true;
            this.radioButtonCust.Location = new System.Drawing.Point(17, 90);
            this.radioButtonCust.Name = "radioButtonCust";
            this.radioButtonCust.Size = new System.Drawing.Size(160, 24);
            this.radioButtonCust.TabIndex = 2;
            this.radioButtonCust.Text = "Пользовательский";
            this.radioButtonCust.UseVisualStyleBackColor = true;
            // 
            // radioButtonBank
            // 
            this.radioButtonBank.AutoSize = true;
            this.radioButtonBank.Location = new System.Drawing.Point(17, 30);
            this.radioButtonBank.Name = "radioButtonBank";
            this.radioButtonBank.Size = new System.Drawing.Size(461, 24);
            this.radioButtonBank.TabIndex = 1;
            this.radioButtonBank.Text = "Банк данных угроз безопасности информации ФСТЭК России";
            this.radioButtonBank.UseVisualStyleBackColor = true;
            // 
            // radioButtonGost
            // 
            this.radioButtonGost.AutoSize = true;
            this.radioButtonGost.Checked = true;
            this.radioButtonGost.Location = new System.Drawing.Point(17, 60);
            this.radioButtonGost.Name = "radioButtonGost";
            this.radioButtonGost.Size = new System.Drawing.Size(193, 24);
            this.radioButtonGost.TabIndex = 0;
            this.radioButtonGost.TabStop = true;
            this.radioButtonGost.Text = "ГОСТ Р ИСО/МЭК 27005";
            this.radioButtonGost.UseVisualStyleBackColor = true;
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(292, 100);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(346, 27);
            this.textBoxName.TabIndex = 58;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(48, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(192, 20);
            this.label2.TabIndex = 57;
            this.label2.Text = "Название объекта оценки";
            // 
            // Parameters
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(708, 546);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBoxType);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.textBox_rcr);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button_ex);
            this.Controls.Add(this.button_save);
            this.Controls.Add(this.label1);
            this.Name = "Parameters";
            this.Text = "Параметры";
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.groupBoxType.ResumeLayout(false);
            this.groupBoxType.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.TrackBar trackBar1;
        public System.Windows.Forms.TextBox textBox_rcr;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button_ex;
        private System.Windows.Forms.Button button_save;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.GroupBox groupBoxType;
        public System.Windows.Forms.RadioButton radioButtonIaaS;
        public System.Windows.Forms.RadioButton radioButtonPaaS;
        public System.Windows.Forms.RadioButton radioButtonSaaS;
        public System.Windows.Forms.GroupBox groupBox1;
        public System.Windows.Forms.RadioButton radioButtonBank;
        public System.Windows.Forms.RadioButton radioButtonGost;
        public System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.RadioButton radioButtonCust;
    }
}