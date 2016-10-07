namespace FirstSummative
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.openCard = new System.Windows.Forms.Button();
            this.starInfo = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // openCard
            // 
            this.openCard.Font = new System.Drawing.Font("Courier New", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.openCard.Location = new System.Drawing.Point(176, 173);
            this.openCard.Name = "openCard";
            this.openCard.Size = new System.Drawing.Size(137, 62);
            this.openCard.TabIndex = 0;
            this.openCard.Text = "Open Card";
            this.openCard.UseVisualStyleBackColor = true;
            this.openCard.Click += new System.EventHandler(this.openCard_Click);
            // 
            // starInfo
            // 
            this.starInfo.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.starInfo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.starInfo.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.starInfo.ForeColor = System.Drawing.Color.Lime;
            this.starInfo.Location = new System.Drawing.Point(319, 28);
            this.starInfo.Multiline = true;
            this.starInfo.Name = "starInfo";
            this.starInfo.Size = new System.Drawing.Size(160, 246);
            this.starInfo.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(498, 297);
            this.Controls.Add(this.starInfo);
            this.Controls.Add(this.openCard);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Greeting Card";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button openCard;
        private System.Windows.Forms.TextBox starInfo;
    }
}

