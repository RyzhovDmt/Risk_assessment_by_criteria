
namespace Risk_assessment_by_criteria
{
    partial class CVSS
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
            this.groupBoxAV = new System.Windows.Forms.GroupBox();
            this.radioButtonAVP = new System.Windows.Forms.RadioButton();
            this.radioButtonAVL = new System.Windows.Forms.RadioButton();
            this.radioButtonAVA = new System.Windows.Forms.RadioButton();
            this.radioButtonAVN = new System.Windows.Forms.RadioButton();
            this.button_ex = new System.Windows.Forms.Button();
            this.button_calc = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButtonACL = new System.Windows.Forms.RadioButton();
            this.radioButtonACH = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.radioButtonPRL = new System.Windows.Forms.RadioButton();
            this.radioButtonPRH = new System.Windows.Forms.RadioButton();
            this.radioButtonPRN = new System.Windows.Forms.RadioButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.radioButtonUIN = new System.Windows.Forms.RadioButton();
            this.radioButtonUIR = new System.Windows.Forms.RadioButton();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.radioButtonSU = new System.Windows.Forms.RadioButton();
            this.radioButtonSC = new System.Windows.Forms.RadioButton();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.radioButtonCL = new System.Windows.Forms.RadioButton();
            this.radioButtonCH = new System.Windows.Forms.RadioButton();
            this.radioButtonCN = new System.Windows.Forms.RadioButton();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.radioButtonIL = new System.Windows.Forms.RadioButton();
            this.radioButtonIH = new System.Windows.Forms.RadioButton();
            this.radioButtonIN = new System.Windows.Forms.RadioButton();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.radioButtonAL = new System.Windows.Forms.RadioButton();
            this.radioButtonAH = new System.Windows.Forms.RadioButton();
            this.radioButtonAN = new System.Windows.Forms.RadioButton();
            this.labelRes = new System.Windows.Forms.Label();
            this.groupBoxAV.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxAV
            // 
            this.groupBoxAV.Controls.Add(this.radioButtonAVP);
            this.groupBoxAV.Controls.Add(this.radioButtonAVL);
            this.groupBoxAV.Controls.Add(this.radioButtonAVA);
            this.groupBoxAV.Controls.Add(this.radioButtonAVN);
            this.groupBoxAV.Location = new System.Drawing.Point(55, 104);
            this.groupBoxAV.Name = "groupBoxAV";
            this.groupBoxAV.Size = new System.Drawing.Size(219, 166);
            this.groupBoxAV.TabIndex = 60;
            this.groupBoxAV.TabStop = false;
            this.groupBoxAV.Text = "Вектор атаки (AV)";
            // 
            // radioButtonAVP
            // 
            this.radioButtonAVP.AutoSize = true;
            this.radioButtonAVP.Location = new System.Drawing.Point(21, 128);
            this.radioButtonAVP.Name = "radioButtonAVP";
            this.radioButtonAVP.Size = new System.Drawing.Size(136, 24);
            this.radioButtonAVP.TabIndex = 3;
            this.radioButtonAVP.Text = "Физический (P)";
            this.radioButtonAVP.UseVisualStyleBackColor = true;
            // 
            // radioButtonAVL
            // 
            this.radioButtonAVL.AutoSize = true;
            this.radioButtonAVL.Location = new System.Drawing.Point(21, 98);
            this.radioButtonAVL.Name = "radioButtonAVL";
            this.radioButtonAVL.Size = new System.Drawing.Size(130, 24);
            this.radioButtonAVL.TabIndex = 2;
            this.radioButtonAVL.Text = "Локальный (L)";
            this.radioButtonAVL.UseVisualStyleBackColor = true;
            // 
            // radioButtonAVA
            // 
            this.radioButtonAVA.AutoSize = true;
            this.radioButtonAVA.Location = new System.Drawing.Point(21, 68);
            this.radioButtonAVA.Name = "radioButtonAVA";
            this.radioButtonAVA.Size = new System.Drawing.Size(151, 24);
            this.radioButtonAVA.TabIndex = 1;
            this.radioButtonAVA.Text = "Смежная сеть (A)";
            this.radioButtonAVA.UseVisualStyleBackColor = true;
            // 
            // radioButtonAVN
            // 
            this.radioButtonAVN.AutoSize = true;
            this.radioButtonAVN.Checked = true;
            this.radioButtonAVN.Location = new System.Drawing.Point(21, 38);
            this.radioButtonAVN.Name = "radioButtonAVN";
            this.radioButtonAVN.Size = new System.Drawing.Size(112, 24);
            this.radioButtonAVN.TabIndex = 0;
            this.radioButtonAVN.TabStop = true;
            this.radioButtonAVN.Text = "Сетевой (N)";
            this.radioButtonAVN.UseVisualStyleBackColor = true;
            // 
            // button_ex
            // 
            this.button_ex.Location = new System.Drawing.Point(637, 626);
            this.button_ex.Name = "button_ex";
            this.button_ex.Size = new System.Drawing.Size(122, 39);
            this.button_ex.TabIndex = 56;
            this.button_ex.Text = "Закрыть";
            this.button_ex.UseVisualStyleBackColor = true;
            this.button_ex.Click += new System.EventHandler(this.button_ex_Click);
            // 
            // button_calc
            // 
            this.button_calc.Location = new System.Drawing.Point(55, 626);
            this.button_calc.Name = "button_calc";
            this.button_calc.Size = new System.Drawing.Size(122, 39);
            this.button_calc.TabIndex = 55;
            this.button_calc.Text = "Вычислить";
            this.button_calc.UseVisualStyleBackColor = true;
            this.button_calc.Click += new System.EventHandler(this.button_calc_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(48, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(290, 25);
            this.label1.TabIndex = 54;
            this.label1.Text = "Оценка уязвимостей CVSS 3.1";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButtonACL);
            this.groupBox1.Controls.Add(this.radioButtonACH);
            this.groupBox1.Location = new System.Drawing.Point(311, 104);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(188, 166);
            this.groupBox1.TabIndex = 61;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Сложность атаки (AC)";
            // 
            // radioButtonACL
            // 
            this.radioButtonACL.AutoSize = true;
            this.radioButtonACL.Location = new System.Drawing.Point(21, 68);
            this.radioButtonACL.Name = "radioButtonACL";
            this.radioButtonACL.Size = new System.Drawing.Size(101, 24);
            this.radioButtonACL.TabIndex = 1;
            this.radioButtonACL.Text = "Низкая (L)";
            this.radioButtonACL.UseVisualStyleBackColor = true;
            // 
            // radioButtonACH
            // 
            this.radioButtonACH.AutoSize = true;
            this.radioButtonACH.Checked = true;
            this.radioButtonACH.Location = new System.Drawing.Point(21, 38);
            this.radioButtonACH.Name = "radioButtonACH";
            this.radioButtonACH.Size = new System.Drawing.Size(114, 24);
            this.radioButtonACH.TabIndex = 0;
            this.radioButtonACH.TabStop = true;
            this.radioButtonACH.Text = "Высокая (H)";
            this.radioButtonACH.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.radioButtonPRL);
            this.groupBox2.Controls.Add(this.radioButtonPRH);
            this.groupBox2.Controls.Add(this.radioButtonPRN);
            this.groupBox2.Location = new System.Drawing.Point(525, 104);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(221, 166);
            this.groupBox2.TabIndex = 61;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Уровень привилегий (PR)";
            // 
            // radioButtonPRL
            // 
            this.radioButtonPRL.AutoSize = true;
            this.radioButtonPRL.Location = new System.Drawing.Point(21, 68);
            this.radioButtonPRL.Name = "radioButtonPRL";
            this.radioButtonPRL.Size = new System.Drawing.Size(103, 24);
            this.radioButtonPRL.TabIndex = 2;
            this.radioButtonPRL.Text = "Низкий (L)";
            this.radioButtonPRL.UseVisualStyleBackColor = true;
            // 
            // radioButtonPRH
            // 
            this.radioButtonPRH.AutoSize = true;
            this.radioButtonPRH.Checked = true;
            this.radioButtonPRH.Location = new System.Drawing.Point(21, 38);
            this.radioButtonPRH.Name = "radioButtonPRH";
            this.radioButtonPRH.Size = new System.Drawing.Size(116, 24);
            this.radioButtonPRH.TabIndex = 2;
            this.radioButtonPRH.TabStop = true;
            this.radioButtonPRH.Text = "Высокий (H)";
            this.radioButtonPRH.UseVisualStyleBackColor = true;
            // 
            // radioButtonPRN
            // 
            this.radioButtonPRN.AutoSize = true;
            this.radioButtonPRN.Location = new System.Drawing.Point(21, 98);
            this.radioButtonPRN.Name = "radioButtonPRN";
            this.radioButtonPRN.Size = new System.Drawing.Size(146, 24);
            this.radioButtonPRN.TabIndex = 3;
            this.radioButtonPRN.Text = "Не требуется (N)";
            this.radioButtonPRN.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.radioButtonUIN);
            this.groupBox3.Controls.Add(this.radioButtonUIR);
            this.groupBox3.Location = new System.Drawing.Point(55, 290);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(333, 110);
            this.groupBox3.TabIndex = 61;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Взаимодействие с пользователем (UI)";
            // 
            // radioButtonUIN
            // 
            this.radioButtonUIN.AutoSize = true;
            this.radioButtonUIN.Location = new System.Drawing.Point(21, 68);
            this.radioButtonUIN.Name = "radioButtonUIN";
            this.radioButtonUIN.Size = new System.Drawing.Size(146, 24);
            this.radioButtonUIN.TabIndex = 1;
            this.radioButtonUIN.Text = "Не требуется (N)";
            this.radioButtonUIN.UseVisualStyleBackColor = true;
            // 
            // radioButtonUIR
            // 
            this.radioButtonUIR.AutoSize = true;
            this.radioButtonUIR.Checked = true;
            this.radioButtonUIR.Location = new System.Drawing.Point(21, 38);
            this.radioButtonUIR.Name = "radioButtonUIR";
            this.radioButtonUIR.Size = new System.Drawing.Size(123, 24);
            this.radioButtonUIR.TabIndex = 0;
            this.radioButtonUIR.TabStop = true;
            this.radioButtonUIR.Text = "Требуется (R)";
            this.radioButtonUIR.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.radioButtonSU);
            this.groupBox4.Controls.Add(this.radioButtonSC);
            this.groupBox4.Location = new System.Drawing.Point(416, 290);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(343, 110);
            this.groupBox4.TabIndex = 62;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Влияние на другие компоненты системы (S)";
            // 
            // radioButtonSU
            // 
            this.radioButtonSU.AutoSize = true;
            this.radioButtonSU.Location = new System.Drawing.Point(21, 68);
            this.radioButtonSU.Name = "radioButtonSU";
            this.radioButtonSU.Size = new System.Drawing.Size(149, 24);
            this.radioButtonSU.TabIndex = 1;
            this.radioButtonSU.Text = "Не оказывает (U)";
            this.radioButtonSU.UseVisualStyleBackColor = true;
            // 
            // radioButtonSC
            // 
            this.radioButtonSC.AutoSize = true;
            this.radioButtonSC.Checked = true;
            this.radioButtonSC.Location = new System.Drawing.Point(21, 38);
            this.radioButtonSC.Name = "radioButtonSC";
            this.radioButtonSC.Size = new System.Drawing.Size(127, 24);
            this.radioButtonSC.TabIndex = 0;
            this.radioButtonSC.TabStop = true;
            this.radioButtonSC.Text = "Оказывает (C)";
            this.radioButtonSC.UseVisualStyleBackColor = true;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.radioButtonCL);
            this.groupBox5.Controls.Add(this.radioButtonCH);
            this.groupBox5.Controls.Add(this.radioButtonCN);
            this.groupBox5.Location = new System.Drawing.Point(55, 423);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(206, 166);
            this.groupBox5.TabIndex = 62;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Влияние на конфиденциальность (С)";
            // 
            // radioButtonCL
            // 
            this.radioButtonCL.AutoSize = true;
            this.radioButtonCL.Location = new System.Drawing.Point(17, 82);
            this.radioButtonCL.Name = "radioButtonCL";
            this.radioButtonCL.Size = new System.Drawing.Size(102, 24);
            this.radioButtonCL.TabIndex = 2;
            this.radioButtonCL.Text = "Низкое (L)";
            this.radioButtonCL.UseVisualStyleBackColor = true;
            // 
            // radioButtonCH
            // 
            this.radioButtonCH.AutoSize = true;
            this.radioButtonCH.Checked = true;
            this.radioButtonCH.Location = new System.Drawing.Point(17, 52);
            this.radioButtonCH.Name = "radioButtonCH";
            this.radioButtonCH.Size = new System.Drawing.Size(115, 24);
            this.radioButtonCH.TabIndex = 2;
            this.radioButtonCH.TabStop = true;
            this.radioButtonCH.Text = "Высокое (H)";
            this.radioButtonCH.UseVisualStyleBackColor = true;
            // 
            // radioButtonCN
            // 
            this.radioButtonCN.AutoSize = true;
            this.radioButtonCN.Location = new System.Drawing.Point(17, 112);
            this.radioButtonCN.Name = "radioButtonCN";
            this.radioButtonCN.Size = new System.Drawing.Size(165, 24);
            this.radioButtonCN.TabIndex = 3;
            this.radioButtonCN.Text = "Не оказывается (N)";
            this.radioButtonCN.UseVisualStyleBackColor = true;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.radioButtonIL);
            this.groupBox6.Controls.Add(this.radioButtonIH);
            this.groupBox6.Controls.Add(this.radioButtonIN);
            this.groupBox6.Location = new System.Drawing.Point(293, 423);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(215, 166);
            this.groupBox6.TabIndex = 63;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Влияние на целостность (I)";
            // 
            // radioButtonIL
            // 
            this.radioButtonIL.AutoSize = true;
            this.radioButtonIL.Location = new System.Drawing.Point(21, 68);
            this.radioButtonIL.Name = "radioButtonIL";
            this.radioButtonIL.Size = new System.Drawing.Size(102, 24);
            this.radioButtonIL.TabIndex = 2;
            this.radioButtonIL.Text = "Низкое (L)";
            this.radioButtonIL.UseVisualStyleBackColor = true;
            // 
            // radioButtonIH
            // 
            this.radioButtonIH.AutoSize = true;
            this.radioButtonIH.Checked = true;
            this.radioButtonIH.Location = new System.Drawing.Point(21, 38);
            this.radioButtonIH.Name = "radioButtonIH";
            this.radioButtonIH.Size = new System.Drawing.Size(115, 24);
            this.radioButtonIH.TabIndex = 2;
            this.radioButtonIH.TabStop = true;
            this.radioButtonIH.Text = "Высокое (H)";
            this.radioButtonIH.UseVisualStyleBackColor = true;
            // 
            // radioButtonIN
            // 
            this.radioButtonIN.AutoSize = true;
            this.radioButtonIN.Location = new System.Drawing.Point(21, 98);
            this.radioButtonIN.Name = "radioButtonIN";
            this.radioButtonIN.Size = new System.Drawing.Size(165, 24);
            this.radioButtonIN.TabIndex = 3;
            this.radioButtonIN.Text = "Не оказывается (N)";
            this.radioButtonIN.UseVisualStyleBackColor = true;
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.radioButtonAL);
            this.groupBox7.Controls.Add(this.radioButtonAH);
            this.groupBox7.Controls.Add(this.radioButtonAN);
            this.groupBox7.Location = new System.Drawing.Point(540, 423);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(219, 166);
            this.groupBox7.TabIndex = 64;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Влияние на доступность (A)";
            // 
            // radioButtonAL
            // 
            this.radioButtonAL.AutoSize = true;
            this.radioButtonAL.Location = new System.Drawing.Point(21, 68);
            this.radioButtonAL.Name = "radioButtonAL";
            this.radioButtonAL.Size = new System.Drawing.Size(102, 24);
            this.radioButtonAL.TabIndex = 2;
            this.radioButtonAL.Text = "Низкое (L)";
            this.radioButtonAL.UseVisualStyleBackColor = true;
            // 
            // radioButtonAH
            // 
            this.radioButtonAH.AutoSize = true;
            this.radioButtonAH.Checked = true;
            this.radioButtonAH.Location = new System.Drawing.Point(21, 38);
            this.radioButtonAH.Name = "radioButtonAH";
            this.radioButtonAH.Size = new System.Drawing.Size(115, 24);
            this.radioButtonAH.TabIndex = 2;
            this.radioButtonAH.TabStop = true;
            this.radioButtonAH.Text = "Высокое (H)";
            this.radioButtonAH.UseVisualStyleBackColor = true;
            // 
            // radioButtonAN
            // 
            this.radioButtonAN.AutoSize = true;
            this.radioButtonAN.Location = new System.Drawing.Point(21, 98);
            this.radioButtonAN.Name = "radioButtonAN";
            this.radioButtonAN.Size = new System.Drawing.Size(165, 24);
            this.radioButtonAN.TabIndex = 3;
            this.radioButtonAN.Text = "Не оказывается (N)";
            this.radioButtonAN.UseVisualStyleBackColor = true;
            // 
            // labelRes
            // 
            this.labelRes.AutoSize = true;
            this.labelRes.Location = new System.Drawing.Point(314, 635);
            this.labelRes.Name = "labelRes";
            this.labelRes.Size = new System.Drawing.Size(0, 20);
            this.labelRes.TabIndex = 65;
            // 
            // CVSS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(814, 688);
            this.Controls.Add(this.labelRes);
            this.Controls.Add(this.groupBox7);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBoxAV);
            this.Controls.Add(this.button_ex);
            this.Controls.Add(this.button_calc);
            this.Controls.Add(this.label1);
            this.Name = "CVSS";
            this.Text = "CVSS";
            this.groupBoxAV.ResumeLayout(false);
            this.groupBoxAV.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.GroupBox groupBoxAV;
        public System.Windows.Forms.RadioButton radioButtonAVP;
        public System.Windows.Forms.RadioButton radioButtonAVL;
        public System.Windows.Forms.RadioButton radioButtonAVA;
        public System.Windows.Forms.RadioButton radioButtonAVN;
        private System.Windows.Forms.Button button_ex;
        private System.Windows.Forms.Button button_calc;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.GroupBox groupBox1;
        public System.Windows.Forms.RadioButton radioButtonACL;
        public System.Windows.Forms.RadioButton radioButtonACH;
        public System.Windows.Forms.GroupBox groupBox2;
        public System.Windows.Forms.RadioButton radioButtonPRL;
        public System.Windows.Forms.RadioButton radioButtonPRH;
        public System.Windows.Forms.RadioButton radioButtonPRN;
        public System.Windows.Forms.GroupBox groupBox3;
        public System.Windows.Forms.RadioButton radioButtonUIN;
        public System.Windows.Forms.RadioButton radioButtonUIR;
        public System.Windows.Forms.GroupBox groupBox4;
        public System.Windows.Forms.RadioButton radioButtonSU;
        public System.Windows.Forms.RadioButton radioButtonSC;
        public System.Windows.Forms.GroupBox groupBox5;
        public System.Windows.Forms.RadioButton radioButtonCL;
        public System.Windows.Forms.RadioButton radioButtonCH;
        public System.Windows.Forms.RadioButton radioButtonCN;
        public System.Windows.Forms.GroupBox groupBox6;
        public System.Windows.Forms.RadioButton radioButtonIL;
        public System.Windows.Forms.RadioButton radioButtonIH;
        public System.Windows.Forms.RadioButton radioButtonIN;
        public System.Windows.Forms.GroupBox groupBox7;
        public System.Windows.Forms.RadioButton radioButtonAL;
        public System.Windows.Forms.RadioButton radioButtonAH;
        public System.Windows.Forms.RadioButton radioButtonAN;
        private System.Windows.Forms.Label labelRes;
    }
}