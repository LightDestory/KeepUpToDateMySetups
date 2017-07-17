namespace KeepUpToDateMySetups
{
    partial class Main
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.TabbedMain = new System.Windows.Forms.TabControl();
            this.KeepUpToDateTab = new System.Windows.Forms.TabPage();
            this.Log = new System.Windows.Forms.ListBox();
            this.LogsInfo = new System.Windows.Forms.Label();
            this.CurrStatusInfo = new System.Windows.Forms.Label();
            this.CurrStatus = new System.Windows.Forms.Label();
            this.UpdateAll = new System.Windows.Forms.Button();
            this.UpdateSoftware = new System.Windows.Forms.Button();
            this.DeleteSoftware = new System.Windows.Forms.Button();
            this.AddSoftware = new System.Windows.Forms.Button();
            this.UsedPresets = new System.Windows.Forms.ComboBox();
            this.UsedPresetsInfo = new System.Windows.Forms.Label();
            this.InfoTab = new System.Windows.Forms.TabPage();
            this.checkforupdate = new System.Windows.Forms.Button();
            this.RequestSoftware = new System.Windows.Forms.Button();
            this.Count = new System.Windows.Forms.Label();
            this.CountInfo = new System.Windows.Forms.Label();
            this.AvailablePresetsBorder = new System.Windows.Forms.GroupBox();
            this.AvailableList = new System.Windows.Forms.ListBox();
            this.TabbedMain.SuspendLayout();
            this.KeepUpToDateTab.SuspendLayout();
            this.InfoTab.SuspendLayout();
            this.AvailablePresetsBorder.SuspendLayout();
            this.SuspendLayout();
            // 
            // TabbedMain
            // 
            this.TabbedMain.Controls.Add(this.KeepUpToDateTab);
            this.TabbedMain.Controls.Add(this.InfoTab);
            this.TabbedMain.Location = new System.Drawing.Point(-4, 1);
            this.TabbedMain.Name = "TabbedMain";
            this.TabbedMain.SelectedIndex = 0;
            this.TabbedMain.Size = new System.Drawing.Size(492, 454);
            this.TabbedMain.TabIndex = 4;
            // 
            // KeepUpToDateTab
            // 
            this.KeepUpToDateTab.Controls.Add(this.Log);
            this.KeepUpToDateTab.Controls.Add(this.LogsInfo);
            this.KeepUpToDateTab.Controls.Add(this.CurrStatusInfo);
            this.KeepUpToDateTab.Controls.Add(this.CurrStatus);
            this.KeepUpToDateTab.Controls.Add(this.UpdateAll);
            this.KeepUpToDateTab.Controls.Add(this.UpdateSoftware);
            this.KeepUpToDateTab.Controls.Add(this.DeleteSoftware);
            this.KeepUpToDateTab.Controls.Add(this.AddSoftware);
            this.KeepUpToDateTab.Controls.Add(this.UsedPresets);
            this.KeepUpToDateTab.Controls.Add(this.UsedPresetsInfo);
            this.KeepUpToDateTab.Location = new System.Drawing.Point(4, 22);
            this.KeepUpToDateTab.Name = "KeepUpToDateTab";
            this.KeepUpToDateTab.Padding = new System.Windows.Forms.Padding(3);
            this.KeepUpToDateTab.Size = new System.Drawing.Size(484, 428);
            this.KeepUpToDateTab.TabIndex = 0;
            this.KeepUpToDateTab.Text = "Keep Up To Date";
            this.KeepUpToDateTab.UseVisualStyleBackColor = true;
            // 
            // Log
            // 
            this.Log.BackColor = System.Drawing.SystemColors.Control;
            this.Log.FormattingEnabled = true;
            this.Log.Location = new System.Drawing.Point(12, 180);
            this.Log.Name = "Log";
            this.Log.Size = new System.Drawing.Size(460, 225);
            this.Log.TabIndex = 8;
            // 
            // LogsInfo
            // 
            this.LogsInfo.AutoSize = true;
            this.LogsInfo.Location = new System.Drawing.Point(10, 164);
            this.LogsInfo.Name = "LogsInfo";
            this.LogsInfo.Size = new System.Drawing.Size(33, 13);
            this.LogsInfo.TabIndex = 7;
            this.LogsInfo.Text = "Logs:";
            // 
            // CurrStatusInfo
            // 
            this.CurrStatusInfo.AutoSize = true;
            this.CurrStatusInfo.Location = new System.Drawing.Point(7, 133);
            this.CurrStatusInfo.Name = "CurrStatusInfo";
            this.CurrStatusInfo.Size = new System.Drawing.Size(77, 13);
            this.CurrStatusInfo.TabIndex = 6;
            this.CurrStatusInfo.Text = "Current Status:";
            // 
            // CurrStatus
            // 
            this.CurrStatus.AutoSize = true;
            this.CurrStatus.Location = new System.Drawing.Point(90, 133);
            this.CurrStatus.Name = "CurrStatus";
            this.CurrStatus.Size = new System.Drawing.Size(38, 13);
            this.CurrStatus.TabIndex = 5;
            this.CurrStatus.Text = "Ready";
            // 
            // UpdateAll
            // 
            this.UpdateAll.Location = new System.Drawing.Point(292, 85);
            this.UpdateAll.Name = "UpdateAll";
            this.UpdateAll.Size = new System.Drawing.Size(180, 23);
            this.UpdateAll.TabIndex = 4;
            this.UpdateAll.Text = "Update All Softwares";
            this.UpdateAll.UseVisualStyleBackColor = true;
            this.UpdateAll.Click += new System.EventHandler(this.UpdateAll_Click);
            // 
            // UpdateSoftware
            // 
            this.UpdateSoftware.Location = new System.Drawing.Point(292, 56);
            this.UpdateSoftware.Name = "UpdateSoftware";
            this.UpdateSoftware.Size = new System.Drawing.Size(180, 23);
            this.UpdateSoftware.TabIndex = 3;
            this.UpdateSoftware.Text = "Update Selected Software";
            this.UpdateSoftware.UseVisualStyleBackColor = true;
            this.UpdateSoftware.Click += new System.EventHandler(this.UpdateSoftware_Click);
            // 
            // DeleteSoftware
            // 
            this.DeleteSoftware.Location = new System.Drawing.Point(12, 85);
            this.DeleteSoftware.Name = "DeleteSoftware";
            this.DeleteSoftware.Size = new System.Drawing.Size(180, 23);
            this.DeleteSoftware.TabIndex = 2;
            this.DeleteSoftware.Text = "Delete Selected Software";
            this.DeleteSoftware.UseVisualStyleBackColor = true;
            this.DeleteSoftware.Click += new System.EventHandler(this.DeleteSoftware_Click);
            // 
            // AddSoftware
            // 
            this.AddSoftware.Location = new System.Drawing.Point(12, 56);
            this.AddSoftware.Name = "AddSoftware";
            this.AddSoftware.Size = new System.Drawing.Size(180, 23);
            this.AddSoftware.TabIndex = 1;
            this.AddSoftware.Text = "Add a Software\r\n";
            this.AddSoftware.UseVisualStyleBackColor = true;
            this.AddSoftware.Click += new System.EventHandler(this.AddSoftware_Click);
            // 
            // UsedPresets
            // 
            this.UsedPresets.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.UsedPresets.FormattingEnabled = true;
            this.UsedPresets.Location = new System.Drawing.Point(211, 18);
            this.UsedPresets.Name = "UsedPresets";
            this.UsedPresets.Size = new System.Drawing.Size(261, 21);
            this.UsedPresets.TabIndex = 1;
            // 
            // UsedPresetsInfo
            // 
            this.UsedPresetsInfo.AutoSize = true;
            this.UsedPresetsInfo.Location = new System.Drawing.Point(12, 21);
            this.UsedPresetsInfo.Name = "UsedPresetsInfo";
            this.UsedPresetsInfo.Size = new System.Drawing.Size(192, 13);
            this.UsedPresetsInfo.TabIndex = 0;
            this.UsedPresetsInfo.Text = "Select which is the Software to update:";
            // 
            // InfoTab
            // 
            this.InfoTab.Controls.Add(this.checkforupdate);
            this.InfoTab.Controls.Add(this.RequestSoftware);
            this.InfoTab.Controls.Add(this.Count);
            this.InfoTab.Controls.Add(this.CountInfo);
            this.InfoTab.Controls.Add(this.AvailablePresetsBorder);
            this.InfoTab.Location = new System.Drawing.Point(4, 22);
            this.InfoTab.Name = "InfoTab";
            this.InfoTab.Padding = new System.Windows.Forms.Padding(3);
            this.InfoTab.Size = new System.Drawing.Size(484, 428);
            this.InfoTab.TabIndex = 1;
            this.InfoTab.Text = "Info";
            this.InfoTab.UseVisualStyleBackColor = true;
            // 
            // checkforupdate
            // 
            this.checkforupdate.Location = new System.Drawing.Point(222, 91);
            this.checkforupdate.Name = "checkforupdate";
            this.checkforupdate.Size = new System.Drawing.Size(250, 23);
            this.checkforupdate.TabIndex = 5;
            this.checkforupdate.Text = "Check for Update";
            this.checkforupdate.UseVisualStyleBackColor = true;
            // 
            // RequestSoftware
            // 
            this.RequestSoftware.Location = new System.Drawing.Point(222, 62);
            this.RequestSoftware.Name = "RequestSoftware";
            this.RequestSoftware.Size = new System.Drawing.Size(250, 23);
            this.RequestSoftware.TabIndex = 4;
            this.RequestSoftware.Text = "Request a Software";
            this.RequestSoftware.UseVisualStyleBackColor = true;
            // 
            // Count
            // 
            this.Count.AutoSize = true;
            this.Count.Location = new System.Drawing.Point(328, 37);
            this.Count.Name = "Count";
            this.Count.Size = new System.Drawing.Size(13, 13);
            this.Count.TabIndex = 3;
            this.Count.Text = "0";
            // 
            // CountInfo
            // 
            this.CountInfo.AutoSize = true;
            this.CountInfo.Location = new System.Drawing.Point(219, 37);
            this.CountInfo.Name = "CountInfo";
            this.CountInfo.Size = new System.Drawing.Size(103, 13);
            this.CountInfo.TabIndex = 2;
            this.CountInfo.Text = "Available Softwares:";
            // 
            // AvailablePresetsBorder
            // 
            this.AvailablePresetsBorder.BackColor = System.Drawing.SystemColors.Control;
            this.AvailablePresetsBorder.Controls.Add(this.AvailableList);
            this.AvailablePresetsBorder.Location = new System.Drawing.Point(12, 18);
            this.AvailablePresetsBorder.Name = "AvailablePresetsBorder";
            this.AvailablePresetsBorder.Size = new System.Drawing.Size(200, 398);
            this.AvailablePresetsBorder.TabIndex = 1;
            this.AvailablePresetsBorder.TabStop = false;
            this.AvailablePresetsBorder.Text = "Available Presets:";
            // 
            // AvailableList
            // 
            this.AvailableList.FormattingEnabled = true;
            this.AvailableList.Location = new System.Drawing.Point(6, 19);
            this.AvailableList.Name = "AvailableList";
            this.AvailableList.Size = new System.Drawing.Size(188, 368);
            this.AvailableList.TabIndex = 0;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 451);
            this.Controls.Add(this.TabbedMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Kepp Up to Date My Setups By LightDestory";
            this.TabbedMain.ResumeLayout(false);
            this.KeepUpToDateTab.ResumeLayout(false);
            this.KeepUpToDateTab.PerformLayout();
            this.InfoTab.ResumeLayout(false);
            this.InfoTab.PerformLayout();
            this.AvailablePresetsBorder.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl TabbedMain;
        private System.Windows.Forms.TabPage KeepUpToDateTab;
        private System.Windows.Forms.TabPage InfoTab;
        private System.Windows.Forms.GroupBox AvailablePresetsBorder;
        private System.Windows.Forms.ListBox AvailableList;
        private System.Windows.Forms.Label Count;
        private System.Windows.Forms.Label CountInfo;
        private System.Windows.Forms.Button RequestSoftware;
        private System.Windows.Forms.ComboBox UsedPresets;
        private System.Windows.Forms.Label UsedPresetsInfo;
        private System.Windows.Forms.Button UpdateAll;
        private System.Windows.Forms.Button UpdateSoftware;
        private System.Windows.Forms.Button DeleteSoftware;
        private System.Windows.Forms.Button AddSoftware;
        private System.Windows.Forms.Button checkforupdate;
        private System.Windows.Forms.Label CurrStatusInfo;
        private System.Windows.Forms.Label LogsInfo;
        private System.Windows.Forms.Label CurrStatus;
        private System.Windows.Forms.ListBox Log;
    }
}

