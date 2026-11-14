namespace GymMangementSystem
{
    partial class ctrlCoachDetailsWithFiltering
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
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.ctrlCoachDetails1 = new GymMangementSystem.ctrlCoachDetails();
            this.gbFiltering = new Guna.UI2.WinForms.Guna2GroupBox();
            this.txtFiltering = new GymMangementSystem.MyTextBox();
            this.btnAddNewCoach = new Guna.UI2.WinForms.Guna2Button();
            this.btnFind = new Guna.UI2.WinForms.Guna2Button();
            this.cmFilteringType = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.guna2Panel1.SuspendLayout();
            this.gbFiltering.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BorderColor = System.Drawing.Color.Silver;
            this.guna2Panel1.BorderRadius = 5;
            this.guna2Panel1.BorderThickness = 1;
            this.guna2Panel1.Controls.Add(this.ctrlCoachDetails1);
            this.guna2Panel1.Controls.Add(this.gbFiltering);
            this.guna2Panel1.CustomBorderColor = System.Drawing.Color.Silver;
            this.guna2Panel1.Location = new System.Drawing.Point(4, 4);
            this.guna2Panel1.Margin = new System.Windows.Forms.Padding(4);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(1197, 657);
            this.guna2Panel1.TabIndex = 0;
            // 
            // ctrlCoachDetails1
            // 
            this.ctrlCoachDetails1.BackColor = System.Drawing.Color.White;
            this.ctrlCoachDetails1.Location = new System.Drawing.Point(4, 75);
            this.ctrlCoachDetails1.Margin = new System.Windows.Forms.Padding(4);
            this.ctrlCoachDetails1.Name = "ctrlCoachDetails1";
            this.ctrlCoachDetails1.Size = new System.Drawing.Size(1189, 570);
            this.ctrlCoachDetails1.TabIndex = 4;
            // 
            // gbFiltering
            // 
            this.gbFiltering.BorderColor = System.Drawing.Color.Gainsboro;
            this.gbFiltering.BorderRadius = 5;
            this.gbFiltering.Controls.Add(this.txtFiltering);
            this.gbFiltering.Controls.Add(this.btnAddNewCoach);
            this.gbFiltering.Controls.Add(this.btnFind);
            this.gbFiltering.Controls.Add(this.cmFilteringType);
            this.gbFiltering.Controls.Add(this.label9);
            this.gbFiltering.CustomBorderColor = System.Drawing.Color.Transparent;
            this.gbFiltering.Font = new System.Drawing.Font("Segoe UI Emoji", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbFiltering.ForeColor = System.Drawing.Color.Black;
            this.gbFiltering.Location = new System.Drawing.Point(13, 9);
            this.gbFiltering.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbFiltering.Name = "gbFiltering";
            this.gbFiltering.Size = new System.Drawing.Size(1172, 65);
            this.gbFiltering.TabIndex = 3;
            this.gbFiltering.Text = "Filter";
            // 
            // txtFiltering
            // 
            this.txtFiltering.BorderRadius = 5;
            this.txtFiltering.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtFiltering.DefaultText = "";
            this.txtFiltering.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtFiltering.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtFiltering.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtFiltering.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtFiltering.ErrorMessage = "This Field is Required";
            this.txtFiltering.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtFiltering.Font = new System.Drawing.Font("Segoe UI Emoji", 10.2F, System.Drawing.FontStyle.Bold);
            this.txtFiltering.ForeColor = System.Drawing.Color.Black;
            this.txtFiltering.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtFiltering.InputType = GymMangementSystem.MyTextBox.TextType.Numeric;
            this.txtFiltering.IsRequired = true;
            this.txtFiltering.Location = new System.Drawing.Point(517, 17);
            this.txtFiltering.Margin = new System.Windows.Forms.Padding(5);
            this.txtFiltering.Name = "txtFiltering";
            this.txtFiltering.PlaceholderText = "Search...";
            this.txtFiltering.SelectedText = "";
            this.txtFiltering.Size = new System.Drawing.Size(311, 34);
            this.txtFiltering.TabIndex = 90;
            this.txtFiltering.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFiltering_KeyPress);
            // 
            // btnAddNewCoach
            // 
            this.btnAddNewCoach.BorderColor = System.Drawing.Color.Gainsboro;
            this.btnAddNewCoach.BorderRadius = 5;
            this.btnAddNewCoach.BorderThickness = 1;
            this.btnAddNewCoach.CheckedState.FillColor = System.Drawing.Color.Transparent;
            this.btnAddNewCoach.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAddNewCoach.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAddNewCoach.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAddNewCoach.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAddNewCoach.FillColor = System.Drawing.Color.Transparent;
            this.btnAddNewCoach.Font = new System.Drawing.Font("Segoe UI Emoji", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddNewCoach.ForeColor = System.Drawing.Color.Black;
            this.btnAddNewCoach.HoverState.FillColor = System.Drawing.Color.Transparent;
            this.btnAddNewCoach.Image = global::GymMangementSystem.Properties.Resources.AddUser;
            this.btnAddNewCoach.ImageOffset = new System.Drawing.Point(1, 1);
            this.btnAddNewCoach.ImageSize = new System.Drawing.Size(30, 30);
            this.btnAddNewCoach.Location = new System.Drawing.Point(1003, 16);
            this.btnAddNewCoach.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAddNewCoach.Name = "btnAddNewCoach";
            this.btnAddNewCoach.Size = new System.Drawing.Size(83, 36);
            this.btnAddNewCoach.TabIndex = 89;
            this.btnAddNewCoach.Click += new System.EventHandler(this.btnAddNewCoach_Click);
            // 
            // btnFind
            // 
            this.btnFind.BorderColor = System.Drawing.Color.Gainsboro;
            this.btnFind.BorderRadius = 5;
            this.btnFind.BorderThickness = 1;
            this.btnFind.CheckedState.FillColor = System.Drawing.Color.Transparent;
            this.btnFind.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnFind.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnFind.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnFind.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnFind.FillColor = System.Drawing.Color.Transparent;
            this.btnFind.Font = new System.Drawing.Font("Segoe UI Emoji", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFind.ForeColor = System.Drawing.Color.Black;
            this.btnFind.HoverState.FillColor = System.Drawing.Color.White;
            this.btnFind.Image = global::GymMangementSystem.Properties.Resources.SearchPerson;
            this.btnFind.ImageOffset = new System.Drawing.Point(1, 1);
            this.btnFind.ImageSize = new System.Drawing.Size(30, 30);
            this.btnFind.Location = new System.Drawing.Point(897, 16);
            this.btnFind.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(83, 36);
            this.btnFind.TabIndex = 88;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // cmFilteringType
            // 
            this.cmFilteringType.BackColor = System.Drawing.Color.Transparent;
            this.cmFilteringType.BorderRadius = 5;
            this.cmFilteringType.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmFilteringType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmFilteringType.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmFilteringType.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmFilteringType.Font = new System.Drawing.Font("Segoe UI Emoji", 10.2F, System.Drawing.FontStyle.Bold);
            this.cmFilteringType.ForeColor = System.Drawing.Color.Black;
            this.cmFilteringType.ItemHeight = 30;
            this.cmFilteringType.Items.AddRange(new object[] {
            "Coach ID",
            "National No"});
            this.cmFilteringType.Location = new System.Drawing.Point(241, 12);
            this.cmFilteringType.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmFilteringType.Name = "cmFilteringType";
            this.cmFilteringType.Size = new System.Drawing.Size(265, 36);
            this.cmFilteringType.StartIndex = 0;
            this.cmFilteringType.TabIndex = 86;
            this.cmFilteringType.SelectedIndexChanged += new System.EventHandler(this.cmFilteringType_SelectedIndexChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(128, 22);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(78, 22);
            this.label9.TabIndex = 85;
            this.label9.Text = "FindBy:";
            // 
            // ctrlCoachDetailsWithFiltering
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.guna2Panel1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ctrlCoachDetailsWithFiltering";
            this.Size = new System.Drawing.Size(1208, 665);
            this.guna2Panel1.ResumeLayout(false);
            this.gbFiltering.ResumeLayout(false);
            this.gbFiltering.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2GroupBox gbFiltering;
        private MyTextBox txtFiltering;
        private Guna.UI2.WinForms.Guna2Button btnAddNewCoach;
        private Guna.UI2.WinForms.Guna2Button btnFind;
        private Guna.UI2.WinForms.Guna2ComboBox cmFilteringType;
        private System.Windows.Forms.Label label9;
        private ctrlCoachDetails ctrlCoachDetails1;
    }
}
