
namespace OperationPlanner
{
    partial class Form1
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
            this.dataGridView_database = new System.Windows.Forms.DataGridView();
            this.button_connect = new System.Windows.Forms.Button();
            this.label_logger = new System.Windows.Forms.Label();
            this.richTextBox_logger = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_database)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView_database
            // 
            this.dataGridView_database.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_database.Location = new System.Drawing.Point(12, 82);
            this.dataGridView_database.Name = "dataGridView_database";
            this.dataGridView_database.Size = new System.Drawing.Size(468, 359);
            this.dataGridView_database.TabIndex = 0;
            // 
            // button_connect
            // 
            this.button_connect.Location = new System.Drawing.Point(12, 12);
            this.button_connect.Name = "button_connect";
            this.button_connect.Size = new System.Drawing.Size(142, 64);
            this.button_connect.TabIndex = 1;
            this.button_connect.Text = "Connect to database!";
            this.button_connect.UseVisualStyleBackColor = true;
            this.button_connect.Click += new System.EventHandler(this.btn_connect_Click);
            // 
            // label_logger
            // 
            this.label_logger.AutoSize = true;
            this.label_logger.Location = new System.Drawing.Point(483, 66);
            this.label_logger.Name = "label_logger";
            this.label_logger.Size = new System.Drawing.Size(40, 13);
            this.label_logger.TabIndex = 3;
            this.label_logger.Text = "Logger";
            this.label_logger.Click += new System.EventHandler(this.label_logger_Click);
            // 
            // richTextBox_logger
            // 
            this.richTextBox_logger.Location = new System.Drawing.Point(486, 82);
            this.richTextBox_logger.Name = "richTextBox_logger";
            this.richTextBox_logger.Size = new System.Drawing.Size(359, 359);
            this.richTextBox_logger.TabIndex = 4;
            this.richTextBox_logger.Text = "";
            this.richTextBox_logger.TextChanged += new System.EventHandler(this.richTextBox_logger_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(857, 677);
            this.Controls.Add(this.richTextBox_logger);
            this.Controls.Add(this.label_logger);
            this.Controls.Add(this.button_connect);
            this.Controls.Add(this.dataGridView_database);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_database)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView_database;
        private System.Windows.Forms.Button button_connect;
        private System.Windows.Forms.Label label_logger;
        private System.Windows.Forms.RichTextBox richTextBox_logger;
    }
}

