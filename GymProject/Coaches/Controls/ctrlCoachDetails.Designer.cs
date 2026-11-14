namespace GymMangementSystem
{
    partial class ctrlCoachDetails
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ctrlCoachBasicDetais1 = new GymMangementSystem.ctrlCoachBasicDetais();
            this.ctrlPersonDetails1 = new GymMangementSystem.ctrlPersonDetails();
            this.SuspendLayout();
            // 
            // ctrlCoachBasicDetais1
            // 
            this.ctrlCoachBasicDetais1.BackColor = System.Drawing.Color.White;
            this.ctrlCoachBasicDetais1.Location = new System.Drawing.Point(3, 340);
            this.ctrlCoachBasicDetais1.Margin = new System.Windows.Forms.Padding(5);
            this.ctrlCoachBasicDetais1.Name = "ctrlCoachBasicDetais1";
            this.ctrlCoachBasicDetais1.Size = new System.Drawing.Size(1186, 235);
            this.ctrlCoachBasicDetais1.TabIndex = 21;
            // 
            // ctrlPersonDetails1
            // 
            this.ctrlPersonDetails1.BackColor = System.Drawing.Color.White;
            this.ctrlPersonDetails1.Location = new System.Drawing.Point(2, 1);
            this.ctrlPersonDetails1.Margin = new System.Windows.Forms.Padding(5);
            this.ctrlPersonDetails1.Name = "ctrlPersonDetails1";
            this.ctrlPersonDetails1.Size = new System.Drawing.Size(1188, 339);
            this.ctrlPersonDetails1.TabIndex = 20;
            // 
            // ctrlCoachDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.ctrlPersonDetails1);
            this.Controls.Add(this.ctrlCoachBasicDetais1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ctrlCoachDetails";
            this.Size = new System.Drawing.Size(1191, 578);
            this.Load += new System.EventHandler(this.ctrlCoachDetails_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private ctrlPersonDetails ctrlPersonDetails1;
        private ctrlCoachBasicDetais ctrlCoachBasicDetais1;
    }
}
