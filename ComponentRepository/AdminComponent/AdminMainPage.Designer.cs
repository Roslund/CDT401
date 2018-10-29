namespace AdminComponent
{
    partial class AdminMainPage
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
            this.Search = new System.Windows.Forms.Button();
            this.searchTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.AddPanel = new System.Windows.Forms.Panel();
            this.SelectCheckBox = new System.Windows.Forms.CheckBox();
            this.SelectFileButton = new System.Windows.Forms.Button();
            this.TypeTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.PathTextBox = new System.Windows.Forms.TextBox();
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.AddButton = new System.Windows.Forms.Button();
            this.ListViewComponents = new System.Windows.Forms.ListView();
            this.ID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.TITLE = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.FILENAME = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.DESCRIPTION = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.RemoveButton = new System.Windows.Forms.Button();
            this.EditButton = new System.Windows.Forms.Button();
            this.ViewButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.RefreshButton = new System.Windows.Forms.Button();
            this.AddPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // Search
            // 
            this.Search.Location = new System.Drawing.Point(12, 12);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(75, 23);
            this.Search.TabIndex = 0;
            this.Search.Text = "Search";
            this.Search.UseVisualStyleBackColor = true;
            this.Search.Click += new System.EventHandler(this.Search_Click);
            // 
            // searchTextBox
            // 
            this.searchTextBox.Location = new System.Drawing.Point(94, 14);
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.Size = new System.Drawing.Size(180, 20);
            this.searchTextBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "List of Components :";
            // 
            // AddPanel
            // 
            this.AddPanel.BackColor = System.Drawing.SystemColors.ControlLight;
            this.AddPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.AddPanel.Controls.Add(this.SelectCheckBox);
            this.AddPanel.Controls.Add(this.SelectFileButton);
            this.AddPanel.Controls.Add(this.TypeTextBox);
            this.AddPanel.Controls.Add(this.label6);
            this.AddPanel.Controls.Add(this.label5);
            this.AddPanel.Controls.Add(this.label4);
            this.AddPanel.Controls.Add(this.PathTextBox);
            this.AddPanel.Controls.Add(this.NameTextBox);
            this.AddPanel.Controls.Add(this.AddButton);
            this.AddPanel.Location = new System.Drawing.Point(665, 65);
            this.AddPanel.Name = "AddPanel";
            this.AddPanel.Size = new System.Drawing.Size(183, 243);
            this.AddPanel.TabIndex = 5;
            // 
            // SelectCheckBox
            // 
            this.SelectCheckBox.AutoCheck = false;
            this.SelectCheckBox.AutoSize = true;
            this.SelectCheckBox.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.SelectCheckBox.Location = new System.Drawing.Point(163, 8);
            this.SelectCheckBox.Name = "SelectCheckBox";
            this.SelectCheckBox.Size = new System.Drawing.Size(15, 14);
            this.SelectCheckBox.TabIndex = 9;
            this.SelectCheckBox.UseVisualStyleBackColor = false;
            // 
            // SelectFileButton
            // 
            this.SelectFileButton.Location = new System.Drawing.Point(6, 3);
            this.SelectFileButton.Name = "SelectFileButton";
            this.SelectFileButton.Size = new System.Drawing.Size(151, 23);
            this.SelectFileButton.TabIndex = 8;
            this.SelectFileButton.Text = "SELECT FILE";
            this.SelectFileButton.UseVisualStyleBackColor = true;
            // 
            // TypeTextBox
            // 
            this.TypeTextBox.BackColor = System.Drawing.SystemColors.MenuBar;
            this.TypeTextBox.Location = new System.Drawing.Point(3, 160);
            this.TypeTextBox.Name = "TypeTextBox";
            this.TypeTextBox.Size = new System.Drawing.Size(175, 20);
            this.TypeTextBox.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 144);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "TYPE :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 91);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "PATH :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 41);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "NAME :";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // PathTextBox
            // 
            this.PathTextBox.BackColor = System.Drawing.SystemColors.MenuBar;
            this.PathTextBox.Location = new System.Drawing.Point(3, 107);
            this.PathTextBox.Name = "PathTextBox";
            this.PathTextBox.Size = new System.Drawing.Size(175, 20);
            this.PathTextBox.TabIndex = 2;
            this.PathTextBox.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // NameTextBox
            // 
            this.NameTextBox.BackColor = System.Drawing.SystemColors.MenuBar;
            this.NameTextBox.Location = new System.Drawing.Point(3, 57);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(175, 20);
            this.NameTextBox.TabIndex = 1;
            this.NameTextBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // AddButton
            // 
            this.AddButton.BackColor = System.Drawing.SystemColors.ControlLight;
            this.AddButton.Location = new System.Drawing.Point(3, 204);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(175, 23);
            this.AddButton.TabIndex = 0;
            this.AddButton.Text = "ADD";
            this.AddButton.UseVisualStyleBackColor = true;
            // 
            // ListViewComponents
            // 
            this.ListViewComponents.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.ListViewComponents.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ID,
            this.TITLE,
            this.FILENAME,
            this.DESCRIPTION});
            this.ListViewComponents.FullRowSelect = true;
            this.ListViewComponents.Location = new System.Drawing.Point(15, 65);
            this.ListViewComponents.Name = "ListViewComponents";
            this.ListViewComponents.Size = new System.Drawing.Size(528, 243);
            this.ListViewComponents.TabIndex = 6;
            this.ListViewComponents.UseCompatibleStateImageBehavior = false;
            this.ListViewComponents.View = System.Windows.Forms.View.Details;
            this.ListViewComponents.SelectedIndexChanged += new System.EventHandler(this.ListViewComponents_SelectedIndexChanged);
            // 
            // ID
            // 
            this.ID.Text = "ID";
            this.ID.Width = 30;
            // 
            // TITLE
            // 
            this.TITLE.Text = "TITLE";
            this.TITLE.Width = 150;
            // 
            // FILENAME
            // 
            this.FILENAME.Text = "FILENAME";
            this.FILENAME.Width = 150;
            // 
            // DESCRIPTION
            // 
            this.DESCRIPTION.Text = "DESCRIPTION";
            this.DESCRIPTION.Width = 240;
            // 
            // RemoveButton
            // 
            this.RemoveButton.Location = new System.Drawing.Point(177, 314);
            this.RemoveButton.Name = "RemoveButton";
            this.RemoveButton.Size = new System.Drawing.Size(75, 23);
            this.RemoveButton.TabIndex = 7;
            this.RemoveButton.Text = "Remove";
            this.RemoveButton.UseVisualStyleBackColor = true;
            this.RemoveButton.Click += new System.EventHandler(this.RemoveButton_Click);
            // 
            // EditButton
            // 
            this.EditButton.Location = new System.Drawing.Point(96, 314);
            this.EditButton.Name = "EditButton";
            this.EditButton.Size = new System.Drawing.Size(75, 23);
            this.EditButton.TabIndex = 8;
            this.EditButton.Text = "Edit";
            this.EditButton.UseVisualStyleBackColor = true;
            this.EditButton.Click += new System.EventHandler(this.EditButton_Click);
            // 
            // ViewButton
            // 
            this.ViewButton.Location = new System.Drawing.Point(15, 314);
            this.ViewButton.Name = "ViewButton";
            this.ViewButton.Size = new System.Drawing.Size(75, 23);
            this.ViewButton.TabIndex = 9;
            this.ViewButton.Text = "View";
            this.ViewButton.UseVisualStyleBackColor = true;
            this.ViewButton.Click += new System.EventHandler(this.ViewButton_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(258, 315);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 10;
            this.button1.Text = "Add";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // RefreshButton
            // 
            this.RefreshButton.Image = global::AdminComponent.Properties.Resources.refresh2;
            this.RefreshButton.Location = new System.Drawing.Point(518, 34);
            this.RefreshButton.Name = "RefreshButton";
            this.RefreshButton.Size = new System.Drawing.Size(25, 25);
            this.RefreshButton.TabIndex = 11;
            this.RefreshButton.UseVisualStyleBackColor = true;
            this.RefreshButton.Click += new System.EventHandler(this.RefreshButton_Click);
            // 
            // AdminMainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(557, 352);
            this.Controls.Add(this.RefreshButton);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ViewButton);
            this.Controls.Add(this.EditButton);
            this.Controls.Add(this.RemoveButton);
            this.Controls.Add(this.ListViewComponents);
            this.Controls.Add(this.AddPanel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.searchTextBox);
            this.Controls.Add(this.Search);
            this.Name = "AdminMainPage";
            this.Text = "AdminMainPage";
            this.Activated += new System.EventHandler(this.AdminMainPage_Activated);
            this.Load += new System.EventHandler(this.AdminMainPage_Load);
            this.AddPanel.ResumeLayout(false);
            this.AddPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Search;
        private System.Windows.Forms.TextBox searchTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel AddPanel;
        private System.Windows.Forms.ListView ListViewComponents;
        private System.Windows.Forms.ColumnHeader ID;
        private System.Windows.Forms.ColumnHeader TITLE;
        private System.Windows.Forms.ColumnHeader DESCRIPTION;
        private System.Windows.Forms.ColumnHeader FILENAME;
        private System.Windows.Forms.Button RemoveButton;
        private System.Windows.Forms.Button EditButton;
        private System.Windows.Forms.Button ViewButton;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.TextBox PathTextBox;
        private System.Windows.Forms.TextBox NameTextBox;
        private System.Windows.Forms.CheckBox SelectCheckBox;
        private System.Windows.Forms.Button SelectFileButton;
        private System.Windows.Forms.TextBox TypeTextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button RefreshButton;
    }
}