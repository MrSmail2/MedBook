namespace MedicalReference
{
    partial class DiseaseDetailsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DiseaseDetailsForm));
            this.textBoxDiseaseInfo = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // textBoxDiseaseInfo
            // 
            this.textBoxDiseaseInfo.Location = new System.Drawing.Point(-1, 1);
            this.textBoxDiseaseInfo.Multiline = true;
            this.textBoxDiseaseInfo.Name = "textBoxDiseaseInfo";
            this.textBoxDiseaseInfo.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxDiseaseInfo.Size = new System.Drawing.Size(800, 448);
            this.textBoxDiseaseInfo.TabIndex = 0;
            // 
            // DiseaseDetailsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBoxDiseaseInfo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DiseaseDetailsForm";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxDiseaseInfo;
    }
}