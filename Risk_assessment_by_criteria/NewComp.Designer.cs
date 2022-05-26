
namespace Risk_assessment_by_criteria
{
    partial class NewComp
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
            this.button_add = new System.Windows.Forms.Button();
            this.button_ex = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_name = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.button_newloc = new System.Windows.Forms.Button();
            this.button_newar = new System.Windows.Forms.Button();
            this.comboBox_loc = new System.Windows.Forms.ComboBox();
            this.comboBox_area = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // button_add
            // 
            this.button_add.Location = new System.Drawing.Point(53, 278);
            this.button_add.Name = "button_add";
            this.button_add.Size = new System.Drawing.Size(122, 39);
            this.button_add.TabIndex = 3;
            this.button_add.Text = "Создать";
            this.button_add.UseVisualStyleBackColor = true;
            this.button_add.Click += new System.EventHandler(this.button_add_Click);
            // 
            // button_ex
            // 
            this.button_ex.Location = new System.Drawing.Point(546, 278);
            this.button_ex.Name = "button_ex";
            this.button_ex.Size = new System.Drawing.Size(122, 39);
            this.button_ex.TabIndex = 4;
            this.button_ex.Text = "Закрыть";
            this.button_ex.UseVisualStyleBackColor = true;
            this.button_ex.Click += new System.EventHandler(this.button_ex_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(50, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(187, 25);
            this.label1.TabIndex = 5;
            this.label1.Text = "Новый компонент";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(50, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Название";
            // 
            // textBox_name
            // 
            this.textBox_name.Location = new System.Drawing.Point(179, 112);
            this.textBox_name.Name = "textBox_name";
            this.textBox_name.Size = new System.Drawing.Size(305, 27);
            this.textBox_name.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(53, 165);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 20);
            this.label4.TabIndex = 10;
            this.label4.Text = "Локация";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(53, 211);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 20);
            this.label5.TabIndex = 11;
            this.label5.Text = "Область";
            // 
            // button_newloc
            // 
            this.button_newloc.Location = new System.Drawing.Point(546, 156);
            this.button_newloc.Name = "button_newloc";
            this.button_newloc.Size = new System.Drawing.Size(122, 39);
            this.button_newloc.TabIndex = 12;
            this.button_newloc.Text = "Новая";
            this.button_newloc.UseVisualStyleBackColor = true;
            this.button_newloc.Click += new System.EventHandler(this.button_newloc_Click);
            // 
            // button_newar
            // 
            this.button_newar.Location = new System.Drawing.Point(546, 202);
            this.button_newar.Name = "button_newar";
            this.button_newar.Size = new System.Drawing.Size(122, 39);
            this.button_newar.TabIndex = 13;
            this.button_newar.Text = "Новая";
            this.button_newar.UseVisualStyleBackColor = true;
            this.button_newar.Click += new System.EventHandler(this.button1_Click);
            // 
            // comboBox_loc
            // 
            this.comboBox_loc.FormattingEnabled = true;
            this.comboBox_loc.Location = new System.Drawing.Point(182, 162);
            this.comboBox_loc.Name = "comboBox_loc";
            this.comboBox_loc.Size = new System.Drawing.Size(305, 28);
            this.comboBox_loc.TabIndex = 14;
            this.comboBox_loc.SelectedIndexChanged += new System.EventHandler(this.comboBox_loc_SelectedIndexChanged);
            // 
            // comboBox_area
            // 
            this.comboBox_area.FormattingEnabled = true;
            this.comboBox_area.Location = new System.Drawing.Point(182, 208);
            this.comboBox_area.Name = "comboBox_area";
            this.comboBox_area.Size = new System.Drawing.Size(305, 28);
            this.comboBox_area.TabIndex = 15;
            // 
            // NewComp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(713, 337);
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
            this.Name = "NewComp";
            this.Text = "Компонент";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button_add;
        private System.Windows.Forms.Button button_ex;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_name;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button_newloc;
        private System.Windows.Forms.Button button_newar;
        private System.Windows.Forms.ComboBox comboBox_loc;
        private System.Windows.Forms.ComboBox comboBox_area;
    }
}