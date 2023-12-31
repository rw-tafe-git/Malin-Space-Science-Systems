﻿namespace Dictionary
{
    partial class FormAdmin
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
            this.InputStaffIDKey = new System.Windows.Forms.TextBox();
            this.InputStaffNameValue = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.KeyboardControls = new System.Windows.Forms.TextBox();
            this.StatusStrip = new System.Windows.Forms.StatusStrip();
            this.StatusStripLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.StatusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // InputStaffIDKey
            // 
            this.InputStaffIDKey.Location = new System.Drawing.Point(12, 29);
            this.InputStaffIDKey.Name = "InputStaffIDKey";
            this.InputStaffIDKey.ReadOnly = true;
            this.InputStaffIDKey.Size = new System.Drawing.Size(100, 20);
            this.InputStaffIDKey.TabIndex = 0;
            // 
            // InputStaffNameValue
            // 
            this.InputStaffNameValue.Location = new System.Drawing.Point(12, 98);
            this.InputStaffNameValue.Name = "InputStaffNameValue";
            this.InputStaffNameValue.Size = new System.Drawing.Size(148, 20);
            this.InputStaffNameValue.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Staff Name Value";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Staff ID Key";
            // 
            // KeyboardControls
            // 
            this.KeyboardControls.Location = new System.Drawing.Point(190, 13);
            this.KeyboardControls.Multiline = true;
            this.KeyboardControls.Name = "KeyboardControls";
            this.KeyboardControls.ReadOnly = true;
            this.KeyboardControls.Size = new System.Drawing.Size(118, 105);
            this.KeyboardControls.TabIndex = 4;
            this.KeyboardControls.TabStop = false;
            this.KeyboardControls.Text = "Alt + C (Create)\r\nAlt + U (Update)\r\nAlt + D (Delete)\r\nAlt + L (Close form)";
            // 
            // StatusStrip
            // 
            this.StatusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.StatusStripLabel});
            this.StatusStrip.Location = new System.Drawing.Point(0, 137);
            this.StatusStrip.Name = "StatusStrip";
            this.StatusStrip.Size = new System.Drawing.Size(322, 22);
            this.StatusStrip.TabIndex = 5;
            this.StatusStrip.Text = "statusStrip1";
            // 
            // StatusStripLabel
            // 
            this.StatusStripLabel.Name = "StatusStripLabel";
            this.StatusStripLabel.Size = new System.Drawing.Size(10, 17);
            this.StatusStripLabel.Text = " ";
            // 
            // FormAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(322, 159);
            this.ControlBox = false;
            this.Controls.Add(this.StatusStrip);
            this.Controls.Add(this.KeyboardControls);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.InputStaffNameValue);
            this.Controls.Add(this.InputStaffIDKey);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormAdmin";
            this.Text = "Administration Form";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormAdmin_KeyDown);
            this.StatusStrip.ResumeLayout(false);
            this.StatusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox InputStaffIDKey;
        private System.Windows.Forms.TextBox InputStaffNameValue;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox KeyboardControls;
        private System.Windows.Forms.StatusStrip StatusStrip;
        private System.Windows.Forms.ToolStripStatusLabel StatusStripLabel;
    }
}