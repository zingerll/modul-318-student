namespace OpenTT
{
    partial class MainForm
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
            this.lblFrom = new System.Windows.Forms.Label();
            this.lblTo = new System.Windows.Forms.Label();
            this.txtFrom = new System.Windows.Forms.TextBox();
            this.txtTo = new System.Windows.Forms.TextBox();
            this.btnSearchFrom = new System.Windows.Forms.Button();
            this.btnSearchTo = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnSearchConnections = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblFrom
            // 
            this.lblFrom.AutoSize = true;
            this.lblFrom.Location = new System.Drawing.Point(12, 9);
            this.lblFrom.Name = "lblFrom";
            this.lblFrom.Size = new System.Drawing.Size(26, 13);
            this.lblFrom.TabIndex = 0;
            this.lblFrom.Text = "Von";
            // 
            // lblTo
            // 
            this.lblTo.AutoSize = true;
            this.lblTo.Location = new System.Drawing.Point(276, 8);
            this.lblTo.Name = "lblTo";
            this.lblTo.Size = new System.Drawing.Size(33, 13);
            this.lblTo.TabIndex = 1;
            this.lblTo.Text = "Nach";
            // 
            // txtFrom
            // 
            this.txtFrom.Location = new System.Drawing.Point(44, 6);
            this.txtFrom.Name = "txtFrom";
            this.txtFrom.Size = new System.Drawing.Size(150, 20);
            this.txtFrom.TabIndex = 2;
            this.txtFrom.TextChanged += new System.EventHandler(this.txtFrom_TextChanged);
            // 
            // txtTo
            // 
            this.txtTo.Location = new System.Drawing.Point(315, 6);
            this.txtTo.Name = "txtTo";
            this.txtTo.Size = new System.Drawing.Size(150, 20);
            this.txtTo.TabIndex = 3;
            this.txtTo.TextChanged += new System.EventHandler(this.txtTo_TextChanged);
            // 
            // btnSearchFrom
            // 
            this.btnSearchFrom.BackgroundImage = global::OpenTT.Properties.Resources.magnifier;
            this.btnSearchFrom.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSearchFrom.Enabled = false;
            this.btnSearchFrom.Location = new System.Drawing.Point(200, 3);
            this.btnSearchFrom.Name = "btnSearchFrom";
            this.btnSearchFrom.Size = new System.Drawing.Size(26, 26);
            this.btnSearchFrom.TabIndex = 4;
            this.btnSearchFrom.UseVisualStyleBackColor = true;
            this.btnSearchFrom.Click += new System.EventHandler(this.btnSearchFrom_Click);
            // 
            // btnSearchTo
            // 
            this.btnSearchTo.BackgroundImage = global::OpenTT.Properties.Resources.magnifier;
            this.btnSearchTo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSearchTo.Enabled = false;
            this.btnSearchTo.Location = new System.Drawing.Point(471, 3);
            this.btnSearchTo.Name = "btnSearchTo";
            this.btnSearchTo.Size = new System.Drawing.Size(26, 26);
            this.btnSearchTo.TabIndex = 5;
            this.btnSearchTo.UseVisualStyleBackColor = true;
            this.btnSearchTo.Click += new System.EventHandler(this.btnSearchTo_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(15, 43);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(653, 150);
            this.dataGridView1.TabIndex = 6;
            // 
            // btnSearchConnections
            // 
            this.btnSearchConnections.Location = new System.Drawing.Point(545, 3);
            this.btnSearchConnections.Name = "btnSearchConnections";
            this.btnSearchConnections.Size = new System.Drawing.Size(123, 23);
            this.btnSearchConnections.TabIndex = 7;
            this.btnSearchConnections.Text = "Verbindungen Suchen";
            this.btnSearchConnections.UseVisualStyleBackColor = true;
            this.btnSearchConnections.Click += new System.EventHandler(this.btnSearchConnections_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(774, 261);
            this.Controls.Add(this.btnSearchConnections);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnSearchTo);
            this.Controls.Add(this.btnSearchFrom);
            this.Controls.Add(this.txtTo);
            this.Controls.Add(this.txtFrom);
            this.Controls.Add(this.lblTo);
            this.Controls.Add(this.lblFrom);
            this.Name = "MainForm";
            this.Text = "OpenTT";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFrom;
        private System.Windows.Forms.Label lblTo;
        private System.Windows.Forms.TextBox txtFrom;
        private System.Windows.Forms.TextBox txtTo;
        private System.Windows.Forms.Button btnSearchFrom;
        private System.Windows.Forms.Button btnSearchTo;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnSearchConnections;
    }
}

