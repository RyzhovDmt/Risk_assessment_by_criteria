
namespace Risk_assessment_by_criteria
{
    partial class NewArea
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
            this.button_ex = new System.Windows.Forms.Button();
            this.button_add = new System.Windows.Forms.Button();
            this.textBox_name = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox_loc = new System.Windows.Forms.ComboBox();
            this.button_newloc = new System.Windows.Forms.Button();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.textBox_k = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBox_resp = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.SuspendLayout();
            // 
            // button_ex
            // 
            this.button_ex.Location = new System.Drawing.Point(532, 377);
            this.button_ex.Name = "button_ex";
            this.button_ex.Size = new System.Drawing.Size(122, 39);
            this.button_ex.TabIndex = 22;
            this.button_ex.Text = "Закрыть";
            this.button_ex.UseVisualStyleBackColor = true;
            this.button_ex.Click += new System.EventHandler(this.button_ex_Click);
            // 
            // button_add
            // 
            this.button_add.Location = new System.Drawing.Point(48, 377);
            this.button_add.Name = "button_add";
            this.button_add.Size = new System.Drawing.Size(122, 39);
            this.button_add.TabIndex = 21;
            this.button_add.Text = "Создать";
            this.button_add.UseVisualStyleBackColor = true;
            this.button_add.Click += new System.EventHandler(this.button_add_Click);
            // 
            // textBox_name
            // 
            this.textBox_name.Location = new System.Drawing.Point(173, 107);
            this.textBox_name.Name = "textBox_name";
            this.textBox_name.ReadOnly = true;
            this.textBox_name.Size = new System.Drawing.Size(305, 27);
            this.textBox_name.TabIndex = 19;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(49, 243);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 20);
            this.label3.TabIndex = 18;
            this.label3.Text = "Локация";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(49, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 20);
            this.label2.TabIndex = 17;
            this.label2.Text = "Название";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(50, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 25);
            this.label1.TabIndex = 16;
            this.label1.Text = "Новая область";
            // 
            // comboBox_loc
            // 
            this.comboBox_loc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_loc.FormattingEnabled = true;
            this.comboBox_loc.Location = new System.Drawing.Point(243, 240);
            this.comboBox_loc.Name = "comboBox_loc";
            this.comboBox_loc.Size = new System.Drawing.Size(235, 28);
            this.comboBox_loc.TabIndex = 24;
            this.comboBox_loc.SelectedIndexChanged += new System.EventHandler(this.comboBox_loc_SelectedIndexChanged);
            // 
            // button_newloc
            // 
            this.button_newloc.Location = new System.Drawing.Point(532, 234);
            this.button_newloc.Name = "button_newloc";
            this.button_newloc.Size = new System.Drawing.Size(122, 39);
            this.button_newloc.TabIndex = 23;
            this.button_newloc.Text = "Новая";
            this.button_newloc.UseVisualStyleBackColor = true;
            this.button_newloc.Click += new System.EventHandler(this.button_newloc_Click);
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(318, 175);
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(208, 56);
            this.trackBar1.TabIndex = 30;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // textBox_k
            // 
            this.textBox_k.Location = new System.Drawing.Point(544, 175);
            this.textBox_k.Name = "textBox_k";
            this.textBox_k.ReadOnly = true;
            this.textBox_k.Size = new System.Drawing.Size(95, 27);
            this.textBox_k.TabIndex = 29;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(49, 175);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(244, 20);
            this.label4.TabIndex = 28;
            this.label4.Text = "Коэффициент критичности риска ";
            // 
            // comboBox_resp
            // 
            this.comboBox_resp.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_resp.FormattingEnabled = true;
            this.comboBox_resp.Location = new System.Drawing.Point(243, 300);
            this.comboBox_resp.Name = "comboBox_resp";
            this.comboBox_resp.Size = new System.Drawing.Size(235, 28);
            this.comboBox_resp.TabIndex = 32;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(49, 303);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(162, 20);
            this.label5.TabIndex = 31;
            this.label5.Text = "Зона ответственности";
            // 
            // NewArea
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(699, 443);
            this.Controls.Add(this.comboBox_resp);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.textBox_k);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.comboBox_loc);
            this.Controls.Add(this.button_newloc);
            this.Controls.Add(this.button_ex);
            this.Controls.Add(this.button_add);
            this.Controls.Add(this.textBox_name);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "NewArea";
            this.Text = "Область";
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_ex;
        private System.Windows.Forms.Button button_add;
        private System.Windows.Forms.TextBox textBox_name;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox_loc;
        private System.Windows.Forms.Button button_newloc;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.TextBox textBox_k;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBox_resp;
        private System.Windows.Forms.Label label5;
    }
}