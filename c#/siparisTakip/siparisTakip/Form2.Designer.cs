
namespace siparisTakip
{
    partial class Form2
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox13 = new System.Windows.Forms.GroupBox();
            this.label34 = new System.Windows.Forms.Label();
            this.label36 = new System.Windows.Forms.Label();
            this.button22 = new System.Windows.Forms.Button();
            this.dateTimePicker5 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker6 = new System.Windows.Forms.DateTimePicker();
            this.button21 = new System.Windows.Forms.Button();
            this.dataGridView6 = new System.Windows.Forms.DataGridView();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox13.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView6)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(889, 556);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.Orange;
            this.tabPage1.Controls.Add(this.groupBox13);
            this.tabPage1.Controls.Add(this.button21);
            this.tabPage1.Controls.Add(this.dataGridView6);
            this.tabPage1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(881, 530);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Muhasebeci";
            // 
            // groupBox13
            // 
            this.groupBox13.Controls.Add(this.label34);
            this.groupBox13.Controls.Add(this.label36);
            this.groupBox13.Controls.Add(this.button22);
            this.groupBox13.Controls.Add(this.dateTimePicker5);
            this.groupBox13.Controls.Add(this.dateTimePicker6);
            this.groupBox13.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox13.Location = new System.Drawing.Point(26, 257);
            this.groupBox13.Name = "groupBox13";
            this.groupBox13.Size = new System.Drawing.Size(275, 256);
            this.groupBox13.TabIndex = 13;
            this.groupBox13.TabStop = false;
            this.groupBox13.Text = "Tarihe Göre Arama";
            // 
            // label34
            // 
            this.label34.AutoSize = true;
            this.label34.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label34.Location = new System.Drawing.Point(73, 32);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(128, 18);
            this.label34.TabIndex = 5;
            this.label34.Text = "Başlangıç Tarihi";
            // 
            // label36
            // 
            this.label36.AutoSize = true;
            this.label36.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label36.Location = new System.Drawing.Point(96, 93);
            this.label36.Name = "label36";
            this.label36.Size = new System.Drawing.Size(88, 18);
            this.label36.TabIndex = 6;
            this.label36.Text = "Bitiş Tarihi";
            // 
            // button22
            // 
            this.button22.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button22.Location = new System.Drawing.Point(50, 159);
            this.button22.Margin = new System.Windows.Forms.Padding(2);
            this.button22.Name = "button22";
            this.button22.Size = new System.Drawing.Size(181, 65);
            this.button22.TabIndex = 2;
            this.button22.Text = "Aralığı Listele";
            this.button22.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker5
            // 
            this.dateTimePicker5.Location = new System.Drawing.Point(65, 63);
            this.dateTimePicker5.Margin = new System.Windows.Forms.Padding(2);
            this.dateTimePicker5.Name = "dateTimePicker5";
            this.dateTimePicker5.Size = new System.Drawing.Size(151, 24);
            this.dateTimePicker5.TabIndex = 3;
            // 
            // dateTimePicker6
            // 
            this.dateTimePicker6.Location = new System.Drawing.Point(65, 117);
            this.dateTimePicker6.Margin = new System.Windows.Forms.Padding(2);
            this.dateTimePicker6.Name = "dateTimePicker6";
            this.dateTimePicker6.Size = new System.Drawing.Size(151, 24);
            this.dateTimePicker6.TabIndex = 4;
            // 
            // button21
            // 
            this.button21.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button21.Location = new System.Drawing.Point(415, 289);
            this.button21.Margin = new System.Windows.Forms.Padding(2);
            this.button21.Name = "button21";
            this.button21.Size = new System.Drawing.Size(337, 48);
            this.button21.TabIndex = 12;
            this.button21.Text = "Tümünü Listele";
            this.button21.UseVisualStyleBackColor = true;
            this.button21.Click += new System.EventHandler(this.button21_Click);
            // 
            // dataGridView6
            // 
            this.dataGridView6.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView6.Location = new System.Drawing.Point(8, 17);
            this.dataGridView6.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView6.Name = "dataGridView6";
            this.dataGridView6.RowHeadersWidth = 51;
            this.dataGridView6.RowTemplate.Height = 24;
            this.dataGridView6.Size = new System.Drawing.Size(864, 221);
            this.dataGridView6.TabIndex = 11;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Orange;
            this.ClientSize = new System.Drawing.Size(889, 556);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupBox13.ResumeLayout(false);
            this.groupBox13.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView6)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.GroupBox groupBox13;
        private System.Windows.Forms.Label label34;
        private System.Windows.Forms.Label label36;
        private System.Windows.Forms.Button button22;
        private System.Windows.Forms.DateTimePicker dateTimePicker5;
        private System.Windows.Forms.DateTimePicker dateTimePicker6;
        private System.Windows.Forms.Button button21;
        private System.Windows.Forms.DataGridView dataGridView6;
    }
}