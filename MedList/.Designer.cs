namespace MedList
{
    partial class AboutForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AboutForm));
            this.labelAuthorInfo = new System.Windows.Forms.Label();
            this.back = new System.Windows.Forms.Button();
            this.labelProjectInfo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelAuthorInfo
            // 
            this.labelAuthorInfo.AutoSize = true;
            this.labelAuthorInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelAuthorInfo.Location = new System.Drawing.Point(110, 52);
            this.labelAuthorInfo.Name = "labelAuthorInfo";
            this.labelAuthorInfo.Size = new System.Drawing.Size(60, 24);
            this.labelAuthorInfo.TabIndex = 0;
            this.labelAuthorInfo.Text = "label1";
            // 
            // back
            // 
            this.back.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.back.Location = new System.Drawing.Point(928, 544);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(165, 36);
            this.back.TabIndex = 1;
            this.back.Text = "Закрыть";
            this.back.UseVisualStyleBackColor = true;
            this.back.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // labelProjectInfo
            // 
            this.labelProjectInfo.AutoSize = true;
            this.labelProjectInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelProjectInfo.Location = new System.Drawing.Point(110, 191);
            this.labelProjectInfo.Name = "labelProjectInfo";
            this.labelProjectInfo.Size = new System.Drawing.Size(60, 24);
            this.labelProjectInfo.TabIndex = 2;
            this.labelProjectInfo.Text = "label1";
            // 
            // AboutForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1154, 605);
            this.Controls.Add(this.labelProjectInfo);
            this.Controls.Add(this.back);
            this.Controls.Add(this.labelAuthorInfo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AboutForm";
            this.Text = "Справка о приложении";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelAuthorInfo;
        private System.Windows.Forms.Button back;
        private System.Windows.Forms.Label labelProjectInfo;
    }
}