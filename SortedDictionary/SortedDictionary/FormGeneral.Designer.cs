namespace Dictionary
{
    partial class FormGeneral
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
            this.ListBoxDictionary = new System.Windows.Forms.ListBox();
            this.ListBoxFiltered = new System.Windows.Forms.ListBox();
            this.InputStaffKey = new System.Windows.Forms.TextBox();
            this.InputStaffName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.KeyboardControls = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // ListBoxDictionary
            // 
            this.ListBoxDictionary.FormattingEnabled = true;
            this.ListBoxDictionary.Location = new System.Drawing.Point(12, 12);
            this.ListBoxDictionary.Name = "ListBoxDictionary";
            this.ListBoxDictionary.Size = new System.Drawing.Size(196, 420);
            this.ListBoxDictionary.TabIndex = 0;
            this.ListBoxDictionary.SelectedIndexChanged += new System.EventHandler(this.ListBox_SelectedIndexChanged);
            // 
            // ListBoxFiltered
            // 
            this.ListBoxFiltered.FormattingEnabled = true;
            this.ListBoxFiltered.Location = new System.Drawing.Point(230, 90);
            this.ListBoxFiltered.Name = "ListBoxFiltered";
            this.ListBoxFiltered.Size = new System.Drawing.Size(263, 342);
            this.ListBoxFiltered.TabIndex = 3;
            this.ListBoxFiltered.SelectedIndexChanged += new System.EventHandler(this.ListBox_SelectedIndexChanged);
            this.ListBoxFiltered.Enter += new System.EventHandler(this.ListBox_EnterFocus);
            // 
            // InputStaffKey
            // 
            this.InputStaffKey.Location = new System.Drawing.Point(293, 15);
            this.InputStaffKey.Name = "InputStaffKey";
            this.InputStaffKey.Size = new System.Drawing.Size(118, 20);
            this.InputStaffKey.TabIndex = 1;
            this.InputStaffKey.TextChanged += new System.EventHandler(this.InputStaffKey_TextChanged);
            this.InputStaffKey.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.InputStaffKey_KeyPress);
            // 
            // InputStaffName
            // 
            this.InputStaffName.Location = new System.Drawing.Point(293, 54);
            this.InputStaffName.Name = "InputStaffName";
            this.InputStaffName.Size = new System.Drawing.Size(200, 20);
            this.InputStaffName.TabIndex = 2;
            this.InputStaffName.TextChanged += new System.EventHandler(this.InputStaffName_TextChanged);
            this.InputStaffName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.InputStaffName_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(227, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Staff Key";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(227, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Staff Name";
            // 
            // KeyboardControls
            // 
            this.KeyboardControls.Location = new System.Drawing.Point(517, 12);
            this.KeyboardControls.Multiline = true;
            this.KeyboardControls.Name = "KeyboardControls";
            this.KeyboardControls.ReadOnly = true;
            this.KeyboardControls.Size = new System.Drawing.Size(141, 102);
            this.KeyboardControls.TabIndex = 999;
            this.KeyboardControls.TabStop = false;
            this.KeyboardControls.Text = "Alt + A (Open Admin)\r\nAlt + K (Clear Staff Key)\r\nAlt + V (Clear Staff Name)\r\nAlt " +
    "+ Q (Close)";
            // 
            // FormGeneral
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(670, 446);
            this.Controls.Add(this.KeyboardControls);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.InputStaffName);
            this.Controls.Add(this.InputStaffKey);
            this.Controls.Add(this.ListBoxFiltered);
            this.Controls.Add(this.ListBoxDictionary);
            this.KeyPreview = true;
            this.Name = "FormGeneral";
            this.Text = "General Form";
            this.Load += new System.EventHandler(this.FormGeneral_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.GeneralForm_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox ListBoxDictionary;
        private System.Windows.Forms.ListBox ListBoxFiltered;
        private System.Windows.Forms.TextBox InputStaffKey;
        private System.Windows.Forms.TextBox InputStaffName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox KeyboardControls;
    }
}

