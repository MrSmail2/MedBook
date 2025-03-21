namespace MedList
{
    partial class FontEditorForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FontEditorForm));
            this.comboBoxFont = new System.Windows.Forms.ComboBox();
            this.comboBoxSize = new System.Windows.Forms.ComboBox();
            this.checkBoxBold = new System.Windows.Forms.CheckBox();
            this.checkBoxItalic = new System.Windows.Forms.CheckBox();
            this.Apply = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // comboBoxFont
            // 
            this.comboBoxFont.FormattingEnabled = true;
            this.comboBoxFont.Location = new System.Drawing.Point(52, 30);
            this.comboBoxFont.Name = "comboBoxFont";
            this.comboBoxFont.Size = new System.Drawing.Size(173, 21);
            this.comboBoxFont.TabIndex = 0;
            // 
            // comboBoxSize
            // 
            this.comboBoxSize.FormattingEnabled = true;
            this.comboBoxSize.Location = new System.Drawing.Point(52, 81);
            this.comboBoxSize.Name = "comboBoxSize";
            this.comboBoxSize.Size = new System.Drawing.Size(173, 21);
            this.comboBoxSize.TabIndex = 1;
            // 
            // checkBoxBold
            // 
            this.checkBoxBold.AutoSize = true;
            this.checkBoxBold.Location = new System.Drawing.Point(52, 130);
            this.checkBoxBold.Name = "checkBoxBold";
            this.checkBoxBold.Size = new System.Drawing.Size(105, 17);
            this.checkBoxBold.TabIndex = 2;
            this.checkBoxBold.Text = "Жирный шрифт";
            this.checkBoxBold.UseVisualStyleBackColor = true;
            // 
            // checkBoxItalic
            // 
            this.checkBoxItalic.AutoSize = true;
            this.checkBoxItalic.Location = new System.Drawing.Point(52, 181);
            this.checkBoxItalic.Name = "checkBoxItalic";
            this.checkBoxItalic.Size = new System.Drawing.Size(118, 17);
            this.checkBoxItalic.TabIndex = 3;
            this.checkBoxItalic.Text = "Курсивный шрифт";
            this.checkBoxItalic.UseVisualStyleBackColor = true;
            // 
            // Apply
            // 
            this.Apply.Location = new System.Drawing.Point(52, 242);
            this.Apply.Name = "Apply";
            this.Apply.Size = new System.Drawing.Size(75, 23);
            this.Apply.TabIndex = 4;
            this.Apply.Text = "Применить";
            this.Apply.UseVisualStyleBackColor = true;
            this.Apply.Click += new System.EventHandler(this.buttonApply_Click);
            // 
            // FontEditorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Apply);
            this.Controls.Add(this.checkBoxItalic);
            this.Controls.Add(this.checkBoxBold);
            this.Controls.Add(this.comboBoxSize);
            this.Controls.Add(this.comboBoxFont);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FontEditorForm";
            this.Text = "FontEditor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxFont;
        private System.Windows.Forms.ComboBox comboBoxSize;
        private System.Windows.Forms.CheckBox checkBoxBold;
        private System.Windows.Forms.CheckBox checkBoxItalic;
        private System.Windows.Forms.Button Apply;
    }
}