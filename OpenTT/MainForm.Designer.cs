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
            this.dgfTimeTable = new System.Windows.Forms.DataGridView();
            this.btnSearchConnections = new System.Windows.Forms.Button();
            this.rbConnections = new System.Windows.Forms.RadioButton();
            this.rbStationBoard = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgfTimeTable)).BeginInit();
            this.SuspendLayout();
            // 
            // lblFrom
            // 
            this.lblFrom.AutoSize = true;
            this.lblFrom.Location = new System.Drawing.Point(13, 43);
            this.lblFrom.Name = "lblFrom";
            this.lblFrom.Size = new System.Drawing.Size(26, 13);
            this.lblFrom.TabIndex = 0;
            this.lblFrom.Text = "Von";
            // 
            // lblTo
            // 
            this.lblTo.AutoSize = true;
            this.lblTo.Location = new System.Drawing.Point(277, 42);
            this.lblTo.Name = "lblTo";
            this.lblTo.Size = new System.Drawing.Size(33, 13);
            this.lblTo.TabIndex = 1;
            this.lblTo.Text = "Nach";
            // 
            // txtFrom
            // 
            this.txtFrom.Location = new System.Drawing.Point(60, 40);
            this.txtFrom.Name = "txtFrom";
            this.txtFrom.Size = new System.Drawing.Size(150, 20);
            this.txtFrom.TabIndex = 2;
            this.txtFrom.TextChanged += new System.EventHandler(this.txtFrom_TextChanged);
            this.txtFrom.Enter += new System.EventHandler(this.txtFrom_Enter);
            this.txtFrom.Leave += new System.EventHandler(this.txtFrom_Leave);
            // 
            // txtTo
            // 
            this.txtTo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTo.Location = new System.Drawing.Point(327, 40);
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
            this.btnSearchFrom.Location = new System.Drawing.Point(216, 37);
            this.btnSearchFrom.Name = "btnSearchFrom";
            this.btnSearchFrom.Size = new System.Drawing.Size(26, 26);
            this.btnSearchFrom.TabIndex = 4;
            this.btnSearchFrom.UseVisualStyleBackColor = true;
            this.btnSearchFrom.Click += new System.EventHandler(this.btnSearchFrom_Click);
            // 
            // btnSearchTo
            // 
            this.btnSearchTo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSearchTo.BackgroundImage = global::OpenTT.Properties.Resources.magnifier;
            this.btnSearchTo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSearchTo.Enabled = false;
            this.btnSearchTo.Location = new System.Drawing.Point(483, 37);
            this.btnSearchTo.Name = "btnSearchTo";
            this.btnSearchTo.Size = new System.Drawing.Size(26, 26);
            this.btnSearchTo.TabIndex = 5;
            this.btnSearchTo.UseVisualStyleBackColor = true;
            this.btnSearchTo.Click += new System.EventHandler(this.btnSearchTo_Click);
            // 
            // dgfTimeTable
            // 
            this.dgfTimeTable.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgfTimeTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgfTimeTable.Location = new System.Drawing.Point(12, 66);
            this.dgfTimeTable.Name = "dgfTimeTable";
            this.dgfTimeTable.Size = new System.Drawing.Size(665, 240);
            this.dgfTimeTable.TabIndex = 6;
            this.dgfTimeTable.DataSourceChanged += new System.EventHandler(this.dgfTimeTable_DataSourceChanged);
            // 
            // btnSearchConnections
            // 
            this.btnSearchConnections.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSearchConnections.Enabled = false;
            this.btnSearchConnections.Location = new System.Drawing.Point(554, 37);
            this.btnSearchConnections.Name = "btnSearchConnections";
            this.btnSearchConnections.Size = new System.Drawing.Size(123, 23);
            this.btnSearchConnections.TabIndex = 7;
            this.btnSearchConnections.Text = "Verbindungen &Suchen";
            this.btnSearchConnections.UseVisualStyleBackColor = true;
            this.btnSearchConnections.Click += new System.EventHandler(this.btnSearchConnections_Click);
            // 
            // rbConnections
            // 
            this.rbConnections.AutoSize = true;
            this.rbConnections.Checked = true;
            this.rbConnections.Location = new System.Drawing.Point(16, 17);
            this.rbConnections.Name = "rbConnections";
            this.rbConnections.Size = new System.Drawing.Size(66, 17);
            this.rbConnections.TabIndex = 8;
            this.rbConnections.TabStop = true;
            this.rbConnections.Text = "Fahrplan";
            this.rbConnections.UseVisualStyleBackColor = true;
            this.rbConnections.Click += new System.EventHandler(this.rbConnections_Click);
            // 
            // rbStationBoard
            // 
            this.rbStationBoard.AutoSize = true;
            this.rbStationBoard.Location = new System.Drawing.Point(88, 17);
            this.rbStationBoard.Name = "rbStationBoard";
            this.rbStationBoard.Size = new System.Drawing.Size(84, 17);
            this.rbStationBoard.TabIndex = 9;
            this.rbStationBoard.Text = "Abfahrtstafel";
            this.rbStationBoard.UseVisualStyleBackColor = true;
            this.rbStationBoard.Click += new System.EventHandler(this.rbStationBoard_Click);
            // 
            // MainForm
            // 
            this.AcceptButton = this.btnSearchConnections;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(692, 318);
            this.Controls.Add(this.rbStationBoard);
            this.Controls.Add(this.rbConnections);
            this.Controls.Add(this.btnSearchConnections);
            this.Controls.Add(this.dgfTimeTable);
            this.Controls.Add(this.btnSearchTo);
            this.Controls.Add(this.btnSearchFrom);
            this.Controls.Add(this.txtTo);
            this.Controls.Add(this.txtFrom);
            this.Controls.Add(this.lblTo);
            this.Controls.Add(this.lblFrom);
            this.MinimumSize = new System.Drawing.Size(200, 50);
            this.Name = "MainForm";
            this.Text = "OpenTT";
            ((System.ComponentModel.ISupportInitialize)(this.dgfTimeTable)).EndInit();
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
        private System.Windows.Forms.DataGridView dgfTimeTable;
        private System.Windows.Forms.Button btnSearchConnections;
        private System.Windows.Forms.RadioButton rbConnections;
        private System.Windows.Forms.RadioButton rbStationBoard;
    }
}

