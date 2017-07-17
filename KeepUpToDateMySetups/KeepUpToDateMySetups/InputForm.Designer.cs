namespace KeepUpToDateMySetups
{
    partial class InputForm
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
            this.AddInfo = new System.Windows.Forms.Label();
            this.AddSelection = new System.Windows.Forms.ComboBox();
            this.AddConfirm = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // AddInfo
            // 
            this.AddInfo.AutoSize = true;
            this.AddInfo.Location = new System.Drawing.Point(13, 13);
            this.AddInfo.Name = "AddInfo";
            this.AddInfo.Size = new System.Drawing.Size(45, 13);
            this.AddInfo.TabIndex = 0;
            this.AddInfo.Text = "Presets:";
            // 
            // AddSelection
            // 
            this.AddSelection.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.AddSelection.FormattingEnabled = true;
            this.AddSelection.Location = new System.Drawing.Point(65, 13);
            this.AddSelection.Name = "AddSelection";
            this.AddSelection.Size = new System.Drawing.Size(358, 21);
            this.AddSelection.TabIndex = 1;
            // 
            // AddConfirm
            // 
            this.AddConfirm.Location = new System.Drawing.Point(13, 55);
            this.AddConfirm.Name = "AddConfirm";
            this.AddConfirm.Size = new System.Drawing.Size(410, 23);
            this.AddConfirm.TabIndex = 2;
            this.AddConfirm.Text = "Add Software";
            this.AddConfirm.UseVisualStyleBackColor = true;
            this.AddConfirm.Click += new System.EventHandler(this.AddConfirm_Click);
            // 
            // InputForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(435, 91);
            this.Controls.Add(this.AddConfirm);
            this.Controls.Add(this.AddSelection);
            this.Controls.Add(this.AddInfo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "InputForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Select a Preset of Software to use";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label AddInfo;
        private System.Windows.Forms.ComboBox AddSelection;
        private System.Windows.Forms.Button AddConfirm;
    }
}