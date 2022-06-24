
namespace Risk_assessment_by_criteria
{
    partial class EditComp
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
            this.button_newar = new System.Windows.Forms.Button();
            this.button_newloc = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox_name = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button_ex = new System.Windows.Forms.Button();
            this.button_add = new System.Windows.Forms.Button();
            this.comboBox_loc = new System.Windows.Forms.ComboBox();
            this.comboBox_area = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // button_newar
            // 
            this.button_newar.Location = new System.Drawing.Point(527, 191);
            this.button_newar.Name = "button_newar";
            this.button_newar.Size = new System.Drawing.Size(122, 39);
            this.button_newar.TabIndex = 26;
            this.button_newar.Text = "Новая";
            this.button_newar.UseVisualStyleBackColor = true;
            // 
            // button_newloc
            // 
            this.button_newloc.Location = new System.Drawing.Point(527, 145);
            this.button_newloc.Name = "button_newloc";
            this.button_newloc.Size = new System.Drawing.Size(122, 39);
            this.button_newloc.TabIndex = 25;
            this.button_newloc.Text = "Новая";
            this.button_newloc.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(41, 200);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 20);
            this.label5.TabIndex = 24;
            this.label5.Text = "Область";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(41, 154);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 20);
            this.label4.TabIndex = 23;
            this.label4.Text = "Локация";
            // 
            // textBox_name
            // 
            this.textBox_name.Location = new System.Drawing.Point(169, 101);
            this.textBox_name.Name = "textBox_name";
            this.textBox_name.Size = new System.Drawing.Size(305, 27);
            this.textBox_name.TabIndex = 21;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 20);
            this.label2.TabIndex = 19;
            this.label2.Text = "Название";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(40, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(215, 25);
            this.label1.TabIndex = 18;
            this.label1.Text = "Изменить компонент";
            // 
            // button_ex
            // 
            this.button_ex.Location = new System.Drawing.Point(527, 267);
            this.button_ex.Name = "button_ex";
            this.button_ex.Size = new System.Drawing.Size(122, 39);
            this.button_ex.TabIndex = 17;
            this.button_ex.Text = "Закрыть";
            this.button_ex.UseVisualStyleBackColor = true;
            this.button_ex.Click += new System.EventHandler(this.button_ex_Click);
            // 
            // button_add
            // 
            this.button_add.Location = new System.Drawing.Point(41, 267);
            this.button_add.Name = "button_add";
            this.button_add.Size = new System.Drawing.Size(122, 39);
            this.button_add.TabIndex = 16;
            this.button_add.Text = "Сохранить";
            this.button_add.UseVisualStyleBackColor = true;
            this.button_add.Click += new System.EventHandler(this.button_add_Click);
            // 
            // comboBox_loc
            // 
            this.comboBox_loc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_loc.FormattingEnabled = true;
            this.comboBox_loc.Location = new System.Drawing.Point(170, 151);
            this.comboBox_loc.Name = "comboBox_loc";
            this.comboBox_loc.Size = new System.Drawing.Size(305, 28);
            this.comboBox_loc.TabIndex = 39;
            this.comboBox_loc.SelectedIndexChanged += new System.EventHandler(this.comboBox_loc_SelectedIndexChanged);
            // 
            // comboBox_area
            // 
            this.comboBox_area.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_area.FormattingEnabled = true;
            this.comboBox_area.Location = new System.Drawing.Point(170, 197);
            this.comboBox_area.Name = "comboBox_area";
            this.comboBox_area.Size = new System.Drawing.Size(305, 28);
            this.comboBox_area.TabIndex = 40;
            // 
            // EditComp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(691, 337);
            this.Controls.Add(this.comboBox_area);
            this.Controls.Add(this.comboBox_loc);
            this.Controls.Add(this.button_newar);
            this.Controls.Add(this.button_newloc);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox_name);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_ex);
            this.Controls.Add(this.button_add);
            this.Name = "EditComp";
            this.Text = "Компонент";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button_newar;
        private System.Windows.Forms.Button button_newloc;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.TextBox textBox_name;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_ex;
        private System.Windows.Forms.Button button_add;
        public System.Windows.Forms.ComboBox comboBox_loc;
        public System.Windows.Forms.ComboBox comboBox_area;
    }
}