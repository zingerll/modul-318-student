namespace OpenTT
{
    partial class StationSelection
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
            this.libStationList = new System.Windows.Forms.ListBox();
            this.btnSelectStation = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // libStationList
            // 
            this.libStationList.FormattingEnabled = true;
            this.libStationList.Location = new System.Drawing.Point(12, 12);
            this.libStationList.Name = "libStationList";
            this.libStationList.Size = new System.Drawing.Size(151, 173);
            this.libStationList.TabIndex = 0;
            this.libStationList.SelectedIndexChanged += new System.EventHandler(this.libStationList_SelectedIndexChanged);
            // 
            // btnSelectStation
            // 
            this.btnSelectStation.Enabled = false;
            this.btnSelectStation.Location = new System.Drawing.Point(12, 191);
            this.btnSelectStation.Name = "btnSelectStation";
            this.btnSelectStation.Size = new System.Drawing.Size(151, 23);
            this.btnSelectStation.TabIndex = 1;
            this.btnSelectStation.Text = "Auswählen";
            this.btnSelectStation.UseVisualStyleBackColor = true;
            this.btnSelectStation.Click += new System.EventHandler(this.btnSelectStation_Click);
            // 
            // StationSelection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(178, 261);
            this.Controls.Add(this.btnSelectStation);
            this.Controls.Add(this.libStationList);
            this.Name = "StationSelection";
            this.Text = "Auswahl der Haltestelle";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.StationSelection_FormClosing);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox libStationList;
        private System.Windows.Forms.Button btnSelectStation;
    }
}