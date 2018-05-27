﻿namespace Idream_Attendance
{
    partial class AttenReportFrom
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
            this.splitContainerControl1 = new DevExpress.XtraEditors.SplitContainerControl();
            this.mainGridControl = new DevExpress.XtraGrid.GridControl();
            this.mainView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.btnGetAttenDate = new DevExpress.XtraEditors.SimpleButton();
            this.cbMonth = new DevExpress.XtraEditors.ComboBoxEdit();
            this.lblMonth = new DevExpress.XtraEditors.LabelControl();
            this.seYear = new DevExpress.XtraEditors.SpinEdit();
            this.lblYear = new DevExpress.XtraEditors.LabelControl();
            this.btnExportAtten = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).BeginInit();
            this.splitContainerControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mainGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbMonth.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.seYear.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainerControl1
            // 
            this.splitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerControl1.Horizontal = false;
            this.splitContainerControl1.Location = new System.Drawing.Point(0, 0);
            this.splitContainerControl1.Name = "splitContainerControl1";
            this.splitContainerControl1.Panel1.Controls.Add(this.btnExportAtten);
            this.splitContainerControl1.Panel1.Controls.Add(this.btnGetAttenDate);
            this.splitContainerControl1.Panel1.Controls.Add(this.cbMonth);
            this.splitContainerControl1.Panel1.Controls.Add(this.lblMonth);
            this.splitContainerControl1.Panel1.Controls.Add(this.seYear);
            this.splitContainerControl1.Panel1.Controls.Add(this.lblYear);
            this.splitContainerControl1.Panel1.Text = "Panel1";
            this.splitContainerControl1.Panel2.Controls.Add(this.mainGridControl);
            this.splitContainerControl1.Panel2.Text = "Panel2";
            this.splitContainerControl1.Size = new System.Drawing.Size(1293, 554);
            this.splitContainerControl1.SplitterPosition = 62;
            this.splitContainerControl1.TabIndex = 0;
            this.splitContainerControl1.Text = "splitContainerControl1";
            // 
            // mainGridControl
            // 
            this.mainGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainGridControl.Location = new System.Drawing.Point(0, 0);
            this.mainGridControl.MainView = this.mainView;
            this.mainGridControl.Name = "mainGridControl";
            this.mainGridControl.Size = new System.Drawing.Size(1293, 487);
            this.mainGridControl.TabIndex = 0;
            this.mainGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.mainView});
            // 
            // mainView
            // 
            this.mainView.GridControl = this.mainGridControl;
            this.mainView.Name = "mainView";
            // 
            // btnGetAttenDate
            // 
            this.btnGetAttenDate.Location = new System.Drawing.Point(368, 22);
            this.btnGetAttenDate.Name = "btnGetAttenDate";
            this.btnGetAttenDate.Size = new System.Drawing.Size(92, 23);
            this.btnGetAttenDate.TabIndex = 17;
            this.btnGetAttenDate.Text = "生成考勤报表";
            this.btnGetAttenDate.Click += new System.EventHandler(this.btnGetAttenDate_Click);
            // 
            // cbMonth
            // 
            this.cbMonth.Location = new System.Drawing.Point(246, 23);
            this.cbMonth.Name = "cbMonth";
            this.cbMonth.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbMonth.Size = new System.Drawing.Size(100, 20);
            this.cbMonth.TabIndex = 16;
            // 
            // lblMonth
            // 
            this.lblMonth.Location = new System.Drawing.Point(188, 26);
            this.lblMonth.Name = "lblMonth";
            this.lblMonth.Size = new System.Drawing.Size(52, 14);
            this.lblMonth.TabIndex = 15;
            this.lblMonth.Text = "月    份：";
            // 
            // seYear
            // 
            this.seYear.EditValue = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            this.seYear.Location = new System.Drawing.Point(70, 23);
            this.seYear.Name = "seYear";
            this.seYear.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.seYear.Properties.IsFloatValue = false;
            this.seYear.Properties.Mask.EditMask = "N00";
            this.seYear.Properties.MaxValue = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.seYear.Properties.MinValue = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            this.seYear.Size = new System.Drawing.Size(100, 20);
            this.seYear.TabIndex = 14;
            // 
            // lblYear
            // 
            this.lblYear.Location = new System.Drawing.Point(12, 26);
            this.lblYear.Name = "lblYear";
            this.lblYear.Size = new System.Drawing.Size(52, 14);
            this.lblYear.TabIndex = 13;
            this.lblYear.Text = "年    份：";
            // 
            // btnExportAtten
            // 
            this.btnExportAtten.Location = new System.Drawing.Point(476, 22);
            this.btnExportAtten.Name = "btnExportAtten";
            this.btnExportAtten.Size = new System.Drawing.Size(75, 23);
            this.btnExportAtten.TabIndex = 18;
            this.btnExportAtten.Text = "报表导出";
            // 
            // AttenReportFrom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1293, 554);
            this.Controls.Add(this.splitContainerControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AttenReportFrom";
            this.ShowIcon = false;
            this.Text = "考勤报表生成";
            this.Load += new System.EventHandler(this.AttenReportFrom_Load);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).EndInit();
            this.splitContainerControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.mainGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbMonth.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.seYear.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl1;
        private DevExpress.XtraGrid.GridControl mainGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView mainView;
        private DevExpress.XtraEditors.SimpleButton btnGetAttenDate;
        private DevExpress.XtraEditors.ComboBoxEdit cbMonth;
        private DevExpress.XtraEditors.LabelControl lblMonth;
        private DevExpress.XtraEditors.SpinEdit seYear;
        private DevExpress.XtraEditors.LabelControl lblYear;
        private DevExpress.XtraEditors.SimpleButton btnExportAtten;
    }
}