﻿namespace Nikse.SubtitleEdit.Forms
{
    sealed partial class AudioToText
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
            this.components = new System.ComponentModel.Container();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonGenerate = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.labelProgress = new System.Windows.Forms.Label();
            this.textBoxLog = new System.Windows.Forms.TextBox();
            this.labelInfo = new System.Windows.Forms.Label();
            this.groupBoxModels = new System.Windows.Forms.GroupBox();
            this.buttonDownload = new System.Windows.Forms.Button();
            this.linkLabelOpenModelsFolder = new System.Windows.Forms.LinkLabel();
            this.labelModel = new System.Windows.Forms.Label();
            this.comboBoxModels = new System.Windows.Forms.ComboBox();
            this.linkLabelVoskWebSite = new System.Windows.Forms.LinkLabel();
            this.labelTime = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.checkBoxUsePostProcessing = new System.Windows.Forms.CheckBox();
            this.groupBoxModels.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonCancel
            // 
            this.buttonCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.buttonCancel.Location = new System.Drawing.Point(529, 228);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 8;
            this.buttonCancel.Text = "C&ancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // buttonGenerate
            // 
            this.buttonGenerate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonGenerate.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.buttonGenerate.Location = new System.Drawing.Point(398, 228);
            this.buttonGenerate.Name = "buttonGenerate";
            this.buttonGenerate.Size = new System.Drawing.Size(125, 23);
            this.buttonGenerate.TabIndex = 7;
            this.buttonGenerate.Text = "&Generate";
            this.buttonGenerate.UseVisualStyleBackColor = true;
            this.buttonGenerate.Click += new System.EventHandler(this.ButtonGenerate_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.progressBar1.Location = new System.Drawing.Point(12, 226);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(380, 13);
            this.progressBar1.TabIndex = 5;
            this.progressBar1.Visible = false;
            // 
            // labelProgress
            // 
            this.labelProgress.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelProgress.AutoSize = true;
            this.labelProgress.Location = new System.Drawing.Point(12, 210);
            this.labelProgress.Name = "labelProgress";
            this.labelProgress.Size = new System.Drawing.Size(70, 13);
            this.labelProgress.TabIndex = 4;
            this.labelProgress.Text = "labelProgress";
            // 
            // textBoxLog
            // 
            this.textBoxLog.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxLog.Location = new System.Drawing.Point(529, 9);
            this.textBoxLog.Multiline = true;
            this.textBoxLog.Name = "textBoxLog";
            this.textBoxLog.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBoxLog.Size = new System.Drawing.Size(75, 57);
            this.textBoxLog.TabIndex = 116;
            // 
            // labelInfo
            // 
            this.labelInfo.AutoSize = true;
            this.labelInfo.Location = new System.Drawing.Point(12, 9);
            this.labelInfo.Name = "labelInfo";
            this.labelInfo.Size = new System.Drawing.Size(288, 13);
            this.labelInfo.TabIndex = 0;
            this.labelInfo.Text = "Generate text from audio via Vosk/Kaldi speech recognition";
            // 
            // groupBoxModels
            // 
            this.groupBoxModels.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxModels.Controls.Add(this.buttonDownload);
            this.groupBoxModels.Controls.Add(this.linkLabelOpenModelsFolder);
            this.groupBoxModels.Controls.Add(this.labelModel);
            this.groupBoxModels.Controls.Add(this.comboBoxModels);
            this.groupBoxModels.Location = new System.Drawing.Point(15, 66);
            this.groupBoxModels.Name = "groupBoxModels";
            this.groupBoxModels.Size = new System.Drawing.Size(589, 86);
            this.groupBoxModels.TabIndex = 2;
            this.groupBoxModels.TabStop = false;
            this.groupBoxModels.Text = "Models";
            // 
            // buttonDownload
            // 
            this.buttonDownload.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonDownload.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.buttonDownload.Location = new System.Drawing.Point(265, 43);
            this.buttonDownload.Name = "buttonDownload";
            this.buttonDownload.Size = new System.Drawing.Size(28, 23);
            this.buttonDownload.TabIndex = 2;
            this.buttonDownload.Text = "...";
            this.buttonDownload.UseVisualStyleBackColor = true;
            this.buttonDownload.Click += new System.EventHandler(this.buttonDownload_Click);
            // 
            // linkLabelOpenModelsFolder
            // 
            this.linkLabelOpenModelsFolder.AutoSize = true;
            this.linkLabelOpenModelsFolder.Location = new System.Drawing.Point(314, 53);
            this.linkLabelOpenModelsFolder.Name = "linkLabelOpenModelsFolder";
            this.linkLabelOpenModelsFolder.Size = new System.Drawing.Size(98, 13);
            this.linkLabelOpenModelsFolder.TabIndex = 3;
            this.linkLabelOpenModelsFolder.TabStop = true;
            this.linkLabelOpenModelsFolder.Text = "Open models folder";
            this.linkLabelOpenModelsFolder.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelOpenModelFolder_LinkClicked);
            // 
            // labelModel
            // 
            this.labelModel.AutoSize = true;
            this.labelModel.Location = new System.Drawing.Point(16, 29);
            this.labelModel.Name = "labelModel";
            this.labelModel.Size = new System.Drawing.Size(167, 13);
            this.labelModel.TabIndex = 0;
            this.labelModel.Text = "Choose speech recognition model";
            // 
            // comboBoxModels
            // 
            this.comboBoxModels.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxModels.FormattingEnabled = true;
            this.comboBoxModels.Location = new System.Drawing.Point(19, 45);
            this.comboBoxModels.Name = "comboBoxModels";
            this.comboBoxModels.Size = new System.Drawing.Size(240, 21);
            this.comboBoxModels.TabIndex = 1;
            // 
            // linkLabelVoskWebSite
            // 
            this.linkLabelVoskWebSite.AutoSize = true;
            this.linkLabelVoskWebSite.Location = new System.Drawing.Point(12, 26);
            this.linkLabelVoskWebSite.Name = "linkLabelVoskWebSite";
            this.linkLabelVoskWebSite.Size = new System.Drawing.Size(70, 13);
            this.linkLabelVoskWebSite.TabIndex = 1;
            this.linkLabelVoskWebSite.TabStop = true;
            this.linkLabelVoskWebSite.Text = "Vosk website";
            this.linkLabelVoskWebSite.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelVoskWebsite_LinkClicked);
            // 
            // labelTime
            // 
            this.labelTime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelTime.AutoSize = true;
            this.labelTime.Location = new System.Drawing.Point(12, 241);
            this.labelTime.Name = "labelTime";
            this.labelTime.Size = new System.Drawing.Size(88, 13);
            this.labelTime.TabIndex = 6;
            this.labelTime.Text = "Remaining time...";
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // checkBoxUsePostProcessing
            // 
            this.checkBoxUsePostProcessing.AutoSize = true;
            this.checkBoxUsePostProcessing.Location = new System.Drawing.Point(15, 158);
            this.checkBoxUsePostProcessing.Name = "checkBoxUsePostProcessing";
            this.checkBoxUsePostProcessing.Size = new System.Drawing.Size(312, 17);
            this.checkBoxUsePostProcessing.TabIndex = 3;
            this.checkBoxUsePostProcessing.Text = "Use post-processing (line merge, fix casing, and punctuation)";
            this.checkBoxUsePostProcessing.UseVisualStyleBackColor = true;
            // 
            // AudioToText
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(616, 263);
            this.Controls.Add(this.checkBoxUsePostProcessing);
            this.Controls.Add(this.labelTime);
            this.Controls.Add(this.linkLabelVoskWebSite);
            this.Controls.Add(this.groupBoxModels);
            this.Controls.Add(this.labelInfo);
            this.Controls.Add(this.labelProgress);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonGenerate);
            this.Controls.Add(this.textBoxLog);
            this.KeyPreview = true;
            this.MinimumSize = new System.Drawing.Size(575, 250);
            this.Name = "AudioToText";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Video/audio to text";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AudioToText_FormClosing);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.AudioToText_KeyDown);
            this.groupBoxModels.ResumeLayout(false);
            this.groupBoxModels.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonGenerate;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label labelProgress;
        private System.Windows.Forms.TextBox textBoxLog;
        private System.Windows.Forms.Label labelInfo;
        private System.Windows.Forms.GroupBox groupBoxModels;
        private System.Windows.Forms.LinkLabel linkLabelVoskWebSite;
        private System.Windows.Forms.Label labelModel;
        private System.Windows.Forms.ComboBox comboBoxModels;
        private System.Windows.Forms.LinkLabel linkLabelOpenModelsFolder;
        private System.Windows.Forms.Label labelTime;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.CheckBox checkBoxUsePostProcessing;
        private System.Windows.Forms.Button buttonDownload;
    }
}