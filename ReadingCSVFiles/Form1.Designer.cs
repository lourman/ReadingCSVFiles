namespace ReadingCSVFiles
{
    partial class FormRecipeViewer
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBoxPersonal = new System.Windows.Forms.GroupBox();
            this.textBoxNumberIngedients = new System.Windows.Forms.TextBox();
            this.textBoxNumberSteps = new System.Windows.Forms.TextBox();
            this.textBoxRecipeMinutes = new System.Windows.Forms.TextBox();
            this.textBoxRecipeName = new System.Windows.Forms.TextBox();
            this.labelSex = new System.Windows.Forms.Label();
            this.labelDOB = new System.Windows.Forms.Label();
            this.labelFirstName = new System.Windows.Forms.Label();
            this.labelLastName = new System.Windows.Forms.Label();
            this.buttonNextRecord = new System.Windows.Forms.Button();
            this.buttonOpenFile = new System.Windows.Forms.Button();
            this.groupBoxRecipeSteps = new System.Windows.Forms.GroupBox();
            this.listBoxRecipeSteps = new System.Windows.Forms.ListBox();
            this.groupBoxRecipeIngredients = new System.Windows.Forms.GroupBox();
            this.listBoxIngredientsList = new System.Windows.Forms.ListBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBoxPersonal.SuspendLayout();
            this.groupBoxRecipeSteps.SuspendLayout();
            this.groupBoxRecipeIngredients.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Location = new System.Drawing.Point(12, 352);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Size = new System.Drawing.Size(1252, 273);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Ingredients";
            // 
            // groupBoxPersonal
            // 
            this.groupBoxPersonal.Controls.Add(this.textBoxNumberIngedients);
            this.groupBoxPersonal.Controls.Add(this.textBoxNumberSteps);
            this.groupBoxPersonal.Controls.Add(this.textBoxRecipeMinutes);
            this.groupBoxPersonal.Controls.Add(this.textBoxRecipeName);
            this.groupBoxPersonal.Controls.Add(this.labelSex);
            this.groupBoxPersonal.Controls.Add(this.labelDOB);
            this.groupBoxPersonal.Controls.Add(this.labelFirstName);
            this.groupBoxPersonal.Controls.Add(this.labelLastName);
            this.groupBoxPersonal.Location = new System.Drawing.Point(12, 56);
            this.groupBoxPersonal.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBoxPersonal.Name = "groupBoxPersonal";
            this.groupBoxPersonal.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBoxPersonal.Size = new System.Drawing.Size(411, 272);
            this.groupBoxPersonal.TabIndex = 6;
            this.groupBoxPersonal.TabStop = false;
            this.groupBoxPersonal.Text = "Recipe";
            // 
            // textBoxNumberIngedients
            // 
            this.textBoxNumberIngedients.Location = new System.Drawing.Point(164, 167);
            this.textBoxNumberIngedients.Name = "textBoxNumberIngedients";
            this.textBoxNumberIngedients.Size = new System.Drawing.Size(63, 22);
            this.textBoxNumberIngedients.TabIndex = 9;
            // 
            // textBoxNumberSteps
            // 
            this.textBoxNumberSteps.Location = new System.Drawing.Point(164, 129);
            this.textBoxNumberSteps.Name = "textBoxNumberSteps";
            this.textBoxNumberSteps.Size = new System.Drawing.Size(63, 22);
            this.textBoxNumberSteps.TabIndex = 8;
            // 
            // textBoxRecipeMinutes
            // 
            this.textBoxRecipeMinutes.Location = new System.Drawing.Point(164, 91);
            this.textBoxRecipeMinutes.Name = "textBoxRecipeMinutes";
            this.textBoxRecipeMinutes.Size = new System.Drawing.Size(63, 22);
            this.textBoxRecipeMinutes.TabIndex = 7;
            // 
            // textBoxRecipeName
            // 
            this.textBoxRecipeName.Location = new System.Drawing.Point(164, 53);
            this.textBoxRecipeName.Name = "textBoxRecipeName";
            this.textBoxRecipeName.Size = new System.Drawing.Size(228, 22);
            this.textBoxRecipeName.TabIndex = 6;
            // 
            // labelSex
            // 
            this.labelSex.AutoSize = true;
            this.labelSex.Location = new System.Drawing.Point(61, 53);
            this.labelSex.Name = "labelSex";
            this.labelSex.Size = new System.Drawing.Size(97, 17);
            this.labelSex.TabIndex = 2;
            this.labelSex.Text = "Recipe Name:";
            // 
            // labelDOB
            // 
            this.labelDOB.AutoSize = true;
            this.labelDOB.Location = new System.Drawing.Point(97, 91);
            this.labelDOB.Name = "labelDOB";
            this.labelDOB.Size = new System.Drawing.Size(61, 17);
            this.labelDOB.TabIndex = 3;
            this.labelDOB.Text = "Minutes:";
            // 
            // labelFirstName
            // 
            this.labelFirstName.AutoSize = true;
            this.labelFirstName.Location = new System.Drawing.Point(40, 129);
            this.labelFirstName.Name = "labelFirstName";
            this.labelFirstName.Size = new System.Drawing.Size(118, 17);
            this.labelFirstName.TabIndex = 4;
            this.labelFirstName.Text = "Number of Steps:";
            // 
            // labelLastName
            // 
            this.labelLastName.AutoSize = true;
            this.labelLastName.Location = new System.Drawing.Point(6, 167);
            this.labelLastName.Name = "labelLastName";
            this.labelLastName.Size = new System.Drawing.Size(152, 17);
            this.labelLastName.TabIndex = 5;
            this.labelLastName.Text = "Number of Ingredients:";
            // 
            // buttonNextRecord
            // 
            this.buttonNextRecord.Location = new System.Drawing.Point(301, 20);
            this.buttonNextRecord.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonNextRecord.Name = "buttonNextRecord";
            this.buttonNextRecord.Size = new System.Drawing.Size(103, 32);
            this.buttonNextRecord.TabIndex = 2;
            this.buttonNextRecord.Text = "Next Recipe";
            this.buttonNextRecord.UseVisualStyleBackColor = true;
            this.buttonNextRecord.Click += new System.EventHandler(this.buttonNextRecord_Click);
            // 
            // buttonOpenFile
            // 
            this.buttonOpenFile.Location = new System.Drawing.Point(18, 20);
            this.buttonOpenFile.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonOpenFile.Name = "buttonOpenFile";
            this.buttonOpenFile.Size = new System.Drawing.Size(104, 32);
            this.buttonOpenFile.TabIndex = 3;
            this.buttonOpenFile.Text = "Open File";
            this.buttonOpenFile.UseVisualStyleBackColor = true;
            this.buttonOpenFile.Click += new System.EventHandler(this.buttonOpenFile_Click);
            // 
            // groupBoxRecipeSteps
            // 
            this.groupBoxRecipeSteps.Controls.Add(this.listBoxRecipeSteps);
            this.groupBoxRecipeSteps.Location = new System.Drawing.Point(429, 20);
            this.groupBoxRecipeSteps.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBoxRecipeSteps.Name = "groupBoxRecipeSteps";
            this.groupBoxRecipeSteps.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBoxRecipeSteps.Size = new System.Drawing.Size(411, 308);
            this.groupBoxRecipeSteps.TabIndex = 10;
            this.groupBoxRecipeSteps.TabStop = false;
            this.groupBoxRecipeSteps.Text = "List of Steps";
            // 
            // listBoxRecipeSteps
            // 
            this.listBoxRecipeSteps.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBoxRecipeSteps.FormattingEnabled = true;
            this.listBoxRecipeSteps.ItemHeight = 16;
            this.listBoxRecipeSteps.Location = new System.Drawing.Point(3, 17);
            this.listBoxRecipeSteps.Name = "listBoxRecipeSteps";
            this.listBoxRecipeSteps.Size = new System.Drawing.Size(405, 289);
            this.listBoxRecipeSteps.TabIndex = 0;
            // 
            // groupBoxRecipeIngredients
            // 
            this.groupBoxRecipeIngredients.Controls.Add(this.listBoxIngredientsList);
            this.groupBoxRecipeIngredients.Location = new System.Drawing.Point(853, 20);
            this.groupBoxRecipeIngredients.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBoxRecipeIngredients.Name = "groupBoxRecipeIngredients";
            this.groupBoxRecipeIngredients.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBoxRecipeIngredients.Size = new System.Drawing.Size(411, 308);
            this.groupBoxRecipeIngredients.TabIndex = 11;
            this.groupBoxRecipeIngredients.TabStop = false;
            this.groupBoxRecipeIngredients.Text = "List of Ingredients";
            // 
            // listBoxIngredientsList
            // 
            this.listBoxIngredientsList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBoxIngredientsList.FormattingEnabled = true;
            this.listBoxIngredientsList.ItemHeight = 16;
            this.listBoxIngredientsList.Location = new System.Drawing.Point(3, 17);
            this.listBoxIngredientsList.Name = "listBoxIngredientsList";
            this.listBoxIngredientsList.Size = new System.Drawing.Size(405, 289);
            this.listBoxIngredientsList.TabIndex = 0;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.groupBoxRecipeIngredients);
            this.groupBox4.Controls.Add(this.buttonOpenFile);
            this.groupBox4.Controls.Add(this.buttonNextRecord);
            this.groupBox4.Controls.Add(this.groupBoxPersonal);
            this.groupBox4.Controls.Add(this.groupBoxRecipeSteps);
            this.groupBox4.Location = new System.Drawing.Point(0, 11);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(1270, 336);
            this.groupBox4.TabIndex = 10;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Recipe";
            // 
            // FormRecipeViewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1286, 636);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox4);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormRecipeViewer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Recipe Data Viewer";
            this.groupBoxPersonal.ResumeLayout(false);
            this.groupBoxPersonal.PerformLayout();
            this.groupBoxRecipeSteps.ResumeLayout(false);
            this.groupBoxRecipeIngredients.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button buttonNextRecord;
        private System.Windows.Forms.Button buttonOpenFile;
        private System.Windows.Forms.GroupBox groupBoxPersonal;
        private System.Windows.Forms.Label labelLastName;
        private System.Windows.Forms.Label labelFirstName;
        private System.Windows.Forms.Label labelDOB;
        private System.Windows.Forms.Label labelSex;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox textBoxNumberIngedients;
        private System.Windows.Forms.TextBox textBoxNumberSteps;
        private System.Windows.Forms.TextBox textBoxRecipeMinutes;
        private System.Windows.Forms.TextBox textBoxRecipeName;
        private System.Windows.Forms.GroupBox groupBoxRecipeSteps;
        private System.Windows.Forms.ListBox listBoxRecipeSteps;
        private System.Windows.Forms.GroupBox groupBoxRecipeIngredients;
        private System.Windows.Forms.ListBox listBoxIngredientsList;
        private System.Windows.Forms.GroupBox groupBox4;
    }
}

