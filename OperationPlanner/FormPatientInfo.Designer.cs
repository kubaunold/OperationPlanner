
namespace OperationPlanner
{
    partial class FormPatientInfo
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cancer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CVD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Dementia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Diabetes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Digestive = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Osteoart = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Psych = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Pulmonary = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Charlson = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Mortality_rsi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Complication_rsi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Surgery_type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.JUP_priority_predicted = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.JUP_priority_ideal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnNew = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.predictButton = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(52)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(939, 191);
            this.panel1.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(222)))), ((int)(((byte)(233)))));
            this.label1.Location = new System.Drawing.Point(10, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(359, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Patient information";
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.dataGridView1);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.txtSearch);
            this.panel2.Controls.Add(this.btnNew);
            this.panel2.Location = new System.Drawing.Point(52, 219);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(827, 215);
            this.panel2.TabIndex = 0;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column5,
            this.Cancer,
            this.CVD,
            this.Dementia,
            this.Diabetes,
            this.Digestive,
            this.Osteoart,
            this.Psych,
            this.Pulmonary,
            this.Charlson,
            this.Mortality_rsi,
            this.Complication_rsi,
            this.Surgery_type,
            this.JUP_priority_predicted,
            this.JUP_priority_ideal,
            this.Column6,
            this.Column7});
            this.dataGridView1.GridColor = System.Drawing.Color.White;
            this.dataGridView1.Location = new System.Drawing.Point(0, 62);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridView1.ShowEditingIcon = false;
            this.dataGridView1.Size = new System.Drawing.Size(809, 131);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "ID";
            this.Column1.HeaderText = "#";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "Name";
            this.Column2.HeaderText = "Name";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "Age";
            this.Column3.HeaderText = "Age";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "BMI";
            this.Column5.HeaderText = "BMI";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Cancer
            // 
            this.Cancer.DataPropertyName = "Cancer";
            this.Cancer.HeaderText = "Cancer";
            this.Cancer.Name = "Cancer";
            this.Cancer.ReadOnly = true;
            // 
            // CVD
            // 
            this.CVD.DataPropertyName = "CVD";
            this.CVD.HeaderText = "CVD";
            this.CVD.Name = "CVD";
            this.CVD.ReadOnly = true;
            // 
            // Dementia
            // 
            this.Dementia.DataPropertyName = "Dementia";
            this.Dementia.HeaderText = "Dementia";
            this.Dementia.Name = "Dementia";
            this.Dementia.ReadOnly = true;
            // 
            // Diabetes
            // 
            this.Diabetes.DataPropertyName = "Diabetes";
            this.Diabetes.HeaderText = "Diabetes";
            this.Diabetes.Name = "Diabetes";
            this.Diabetes.ReadOnly = true;
            // 
            // Digestive
            // 
            this.Digestive.DataPropertyName = "Digestive";
            this.Digestive.HeaderText = "Digestive";
            this.Digestive.Name = "Digestive";
            this.Digestive.ReadOnly = true;
            // 
            // Osteoart
            // 
            this.Osteoart.DataPropertyName = "Osteoart";
            this.Osteoart.HeaderText = "Osteoart";
            this.Osteoart.Name = "Osteoart";
            this.Osteoart.ReadOnly = true;
            // 
            // Psych
            // 
            this.Psych.DataPropertyName = "Psych";
            this.Psych.HeaderText = "Psych";
            this.Psych.Name = "Psych";
            this.Psych.ReadOnly = true;
            // 
            // Pulmonary
            // 
            this.Pulmonary.DataPropertyName = "Pulmonary";
            this.Pulmonary.HeaderText = "Pulmonary";
            this.Pulmonary.Name = "Pulmonary";
            this.Pulmonary.ReadOnly = true;
            // 
            // Charlson
            // 
            this.Charlson.DataPropertyName = "Charlson";
            this.Charlson.HeaderText = "Charlson";
            this.Charlson.Name = "Charlson";
            this.Charlson.ReadOnly = true;
            // 
            // Mortality_rsi
            // 
            this.Mortality_rsi.DataPropertyName = "Mortality_rsi";
            this.Mortality_rsi.HeaderText = "Mortality_rsi";
            this.Mortality_rsi.Name = "Mortality_rsi";
            this.Mortality_rsi.ReadOnly = true;
            // 
            // Complication_rsi
            // 
            this.Complication_rsi.DataPropertyName = "Complication_rsi";
            this.Complication_rsi.HeaderText = "Complication_rsi";
            this.Complication_rsi.Name = "Complication_rsi";
            this.Complication_rsi.ReadOnly = true;
            // 
            // Surgery_type
            // 
            this.Surgery_type.DataPropertyName = "Surgery_type";
            this.Surgery_type.HeaderText = "Surgery_type";
            this.Surgery_type.Name = "Surgery_type";
            this.Surgery_type.ReadOnly = true;
            // 
            // JUP_priority_predicted
            // 
            this.JUP_priority_predicted.DataPropertyName = "JUP_priority_predicted";
            this.JUP_priority_predicted.HeaderText = "JUP_predicted";
            this.JUP_priority_predicted.Name = "JUP_priority_predicted";
            this.JUP_priority_predicted.ReadOnly = true;
            // 
            // JUP_priority_ideal
            // 
            this.JUP_priority_ideal.DataPropertyName = "JUP_priority_ideal";
            this.JUP_priority_ideal.HeaderText = "JUP_ideal";
            this.JUP_priority_ideal.Name = "JUP_priority_ideal";
            this.JUP_priority_ideal.ReadOnly = true;
            // 
            // Column6
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(86)))), ((int)(((byte)(106)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            this.Column6.DefaultCellStyle = dataGridViewCellStyle1;
            this.Column6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Column6.HeaderText = "";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            this.Column6.Text = "Edit";
            this.Column6.UseColumnTextForButtonValue = true;
            // 
            // Column7
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(59)))), ((int)(((byte)(34)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Consolas", 8.25F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            this.Column7.DefaultCellStyle = dataGridViewCellStyle2;
            this.Column7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Column7.HeaderText = "";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            this.Column7.Text = "Delete";
            this.Column7.UseColumnTextForButtonValue = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BackColor = System.Drawing.SystemColors.Control;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Image = global::OperationPlanner.Properties.Resources.magnifying_glass;
            this.pictureBox1.Location = new System.Drawing.Point(731, 24);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(50, 23);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // txtSearch
            // 
            this.txtSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSearch.Font = new System.Drawing.Font("Consolas", 10F);
            this.txtSearch.Location = new System.Drawing.Point(567, 24);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(168, 23);
            this.txtSearch.TabIndex = 2;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // btnNew
            // 
            this.btnNew.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(52)))), ((int)(((byte)(64)))));
            this.btnNew.FlatAppearance.BorderSize = 0;
            this.btnNew.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNew.Font = new System.Drawing.Font("Consolas", 10F);
            this.btnNew.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(222)))), ((int)(((byte)(233)))));
            this.btnNew.Location = new System.Drawing.Point(19, 14);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(105, 39);
            this.btnNew.TabIndex = 1;
            this.btnNew.Text = "New";
            this.btnNew.UseVisualStyleBackColor = false;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(724, 719);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(155, 64);
            this.button1.TabIndex = 6;
            this.button1.Text = "Train";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // predictButton
            // 
            this.predictButton.Location = new System.Drawing.Point(518, 719);
            this.predictButton.Name = "predictButton";
            this.predictButton.Size = new System.Drawing.Size(146, 64);
            this.predictButton.TabIndex = 7;
            this.predictButton.Text = "Predict for all";
            this.predictButton.UseVisualStyleBackColor = true;
            this.predictButton.Click += new System.EventHandler(this.predictButton_Click);
            // 
            // FormPatientInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(939, 815);
            this.Controls.Add(this.predictButton);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "FormPatientInfo";
            this.Text = "Form1";
            this.Shown += new System.EventHandler(this.FormPatientInfo_Shown);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn JUP_pred;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cancer;
        private System.Windows.Forms.DataGridViewTextBoxColumn CVD;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dementia;
        private System.Windows.Forms.DataGridViewTextBoxColumn Diabetes;
        private System.Windows.Forms.DataGridViewTextBoxColumn Digestive;
        private System.Windows.Forms.DataGridViewTextBoxColumn Osteoart;
        private System.Windows.Forms.DataGridViewTextBoxColumn Psych;
        private System.Windows.Forms.DataGridViewTextBoxColumn Pulmonary;
        private System.Windows.Forms.DataGridViewTextBoxColumn Charlson;
        private System.Windows.Forms.DataGridViewTextBoxColumn Mortality_rsi;
        private System.Windows.Forms.DataGridViewTextBoxColumn Complication_rsi;
        private System.Windows.Forms.DataGridViewTextBoxColumn Surgery_type;
        private System.Windows.Forms.DataGridViewTextBoxColumn JUP_priority_predicted;
        private System.Windows.Forms.DataGridViewTextBoxColumn JUP_priority_ideal;
        private System.Windows.Forms.DataGridViewButtonColumn Column6;
        private System.Windows.Forms.DataGridViewButtonColumn Column7;
        private System.Windows.Forms.Button predictButton;
    }
}

