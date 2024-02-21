namespace ADONetDisconnectedDemo
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
            this.btnShowall = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.comboDept = new System.Windows.Forms.ComboBox();
            this.labelDept = new System.Windows.Forms.Label();
            this.textId = new System.Windows.Forms.TextBox();
            this.labelId = new System.Windows.Forms.Label();
            this.textSalary = new System.Windows.Forms.TextBox();
            this.labelSalary = new System.Windows.Forms.Label();
            this.textAge = new System.Windows.Forms.TextBox();
            this.labelAge = new System.Windows.Forms.Label();
            this.textEmail = new System.Windows.Forms.TextBox();
            this.labelEmail = new System.Windows.Forms.Label();
            this.textName = new System.Windows.Forms.TextBox();
            this.labelName = new System.Windows.Forms.Label();
            this.lId = new System.Windows.Forms.Label();
            this.lName = new System.Windows.Forms.Label();
            this.lEmail = new System.Windows.Forms.Label();
            this.lDept = new System.Windows.Forms.Label();
            this.lSalary = new System.Windows.Forms.Label();
            this.lAge = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnShowall
            // 
            this.btnShowall.Location = new System.Drawing.Point(926, 450);
            this.btnShowall.Name = "btnShowall";
            this.btnShowall.Size = new System.Drawing.Size(151, 40);
            this.btnShowall.TabIndex = 37;
            this.btnShowall.Text = "Show All";
            this.btnShowall.UseVisualStyleBackColor = true;
            this.btnShowall.Click += new System.EventHandler(this.btnShowall_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(554, 78);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1141, 323);
            this.dataGridView1.TabIndex = 36;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(388, 329);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(128, 36);
            this.btnDelete.TabIndex = 35;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(387, 248);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(128, 37);
            this.btnUpdate.TabIndex = 34;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(388, 171);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(127, 37);
            this.btnSave.TabIndex = 33;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(388, 90);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(127, 40);
            this.btnSearch.TabIndex = 32;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // comboDept
            // 
            this.comboDept.FormattingEnabled = true;
            this.comboDept.Location = new System.Drawing.Point(95, 441);
            this.comboDept.Name = "comboDept";
            this.comboDept.Size = new System.Drawing.Size(254, 24);
            this.comboDept.TabIndex = 31;
            // 
            // labelDept
            // 
            this.labelDept.AutoSize = true;
            this.labelDept.Location = new System.Drawing.Point(-107, 433);
            this.labelDept.Name = "labelDept";
            this.labelDept.Size = new System.Drawing.Size(77, 16);
            this.labelDept.TabIndex = 30;
            this.labelDept.Text = "Department";
            // 
            // textId
            // 
            this.textId.Location = new System.Drawing.Point(84, 90);
            this.textId.Name = "textId";
            this.textId.Size = new System.Drawing.Size(254, 22);
            this.textId.TabIndex = 29;
            // 
            // labelId
            // 
            this.labelId.AutoSize = true;
            this.labelId.Location = new System.Drawing.Point(-104, 96);
            this.labelId.Name = "labelId";
            this.labelId.Size = new System.Drawing.Size(18, 16);
            this.labelId.TabIndex = 28;
            this.labelId.Text = "Id";
            // 
            // textSalary
            // 
            this.textSalary.Location = new System.Drawing.Point(84, 379);
            this.textSalary.Name = "textSalary";
            this.textSalary.Size = new System.Drawing.Size(254, 22);
            this.textSalary.TabIndex = 27;
            // 
            // labelSalary
            // 
            this.labelSalary.AutoSize = true;
            this.labelSalary.Location = new System.Drawing.Point(-104, 366);
            this.labelSalary.Name = "labelSalary";
            this.labelSalary.Size = new System.Drawing.Size(46, 16);
            this.labelSalary.TabIndex = 26;
            this.labelSalary.Text = "Salary";
            // 
            // textAge
            // 
            this.textAge.Location = new System.Drawing.Point(84, 308);
            this.textAge.Name = "textAge";
            this.textAge.Size = new System.Drawing.Size(254, 22);
            this.textAge.TabIndex = 25;
            // 
            // labelAge
            // 
            this.labelAge.AutoSize = true;
            this.labelAge.Location = new System.Drawing.Point(-107, 298);
            this.labelAge.Name = "labelAge";
            this.labelAge.Size = new System.Drawing.Size(32, 16);
            this.labelAge.TabIndex = 24;
            this.labelAge.Text = "Age";
            // 
            // textEmail
            // 
            this.textEmail.Location = new System.Drawing.Point(84, 239);
            this.textEmail.Name = "textEmail";
            this.textEmail.Size = new System.Drawing.Size(254, 22);
            this.textEmail.TabIndex = 23;
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.Location = new System.Drawing.Point(-107, 225);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(41, 16);
            this.labelEmail.TabIndex = 22;
            this.labelEmail.Text = "Email";
            // 
            // textName
            // 
            this.textName.Location = new System.Drawing.Point(84, 171);
            this.textName.Name = "textName";
            this.textName.Size = new System.Drawing.Size(254, 22);
            this.textName.TabIndex = 21;
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(-110, 158);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(44, 16);
            this.labelName.TabIndex = 20;
            this.labelName.Text = "Name";
            // 
            // lId
            // 
            this.lId.AutoSize = true;
            this.lId.Location = new System.Drawing.Point(28, 90);
            this.lId.Name = "lId";
            this.lId.Size = new System.Drawing.Size(18, 16);
            this.lId.TabIndex = 38;
            this.lId.Text = "Id";
            // 
            // lName
            // 
            this.lName.AutoSize = true;
            this.lName.Location = new System.Drawing.Point(12, 177);
            this.lName.Name = "lName";
            this.lName.Size = new System.Drawing.Size(44, 16);
            this.lName.TabIndex = 39;
            this.lName.Text = "Name";
            // 
            // lEmail
            // 
            this.lEmail.AutoSize = true;
            this.lEmail.Location = new System.Drawing.Point(15, 245);
            this.lEmail.Name = "lEmail";
            this.lEmail.Size = new System.Drawing.Size(41, 16);
            this.lEmail.TabIndex = 40;
            this.lEmail.Text = "Email";
            // 
            // lDept
            // 
            this.lDept.AutoSize = true;
            this.lDept.Location = new System.Drawing.Point(12, 449);
            this.lDept.Name = "lDept";
            this.lDept.Size = new System.Drawing.Size(77, 16);
            this.lDept.TabIndex = 43;
            this.lDept.Text = "Department";
            // 
            // lSalary
            // 
            this.lSalary.AutoSize = true;
            this.lSalary.Location = new System.Drawing.Point(15, 382);
            this.lSalary.Name = "lSalary";
            this.lSalary.Size = new System.Drawing.Size(46, 16);
            this.lSalary.TabIndex = 42;
            this.lSalary.Text = "Salary";
            // 
            // lAge
            // 
            this.lAge.AutoSize = true;
            this.lAge.Location = new System.Drawing.Point(12, 314);
            this.lAge.Name = "lAge";
            this.lAge.Size = new System.Drawing.Size(32, 16);
            this.lAge.TabIndex = 41;
            this.lAge.Text = "Age";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1477, 523);
            this.Controls.Add(this.lDept);
            this.Controls.Add(this.lSalary);
            this.Controls.Add(this.lAge);
            this.Controls.Add(this.lEmail);
            this.Controls.Add(this.lName);
            this.Controls.Add(this.lId);
            this.Controls.Add(this.btnShowall);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.comboDept);
            this.Controls.Add(this.labelDept);
            this.Controls.Add(this.textId);
            this.Controls.Add(this.labelId);
            this.Controls.Add(this.textSalary);
            this.Controls.Add(this.labelSalary);
            this.Controls.Add(this.textAge);
            this.Controls.Add(this.labelAge);
            this.Controls.Add(this.textEmail);
            this.Controls.Add(this.labelEmail);
            this.Controls.Add(this.textName);
            this.Controls.Add(this.labelName);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnShowall;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.ComboBox comboDept;
        private System.Windows.Forms.Label labelDept;
        private System.Windows.Forms.TextBox textId;
        private System.Windows.Forms.Label labelId;
        private System.Windows.Forms.TextBox textSalary;
        private System.Windows.Forms.Label labelSalary;
        private System.Windows.Forms.TextBox textAge;
        private System.Windows.Forms.Label labelAge;
        private System.Windows.Forms.TextBox textEmail;
        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.TextBox textName;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label lId;
        private System.Windows.Forms.Label lName;
        private System.Windows.Forms.Label lEmail;
        private System.Windows.Forms.Label lDept;
        private System.Windows.Forms.Label lSalary;
        private System.Windows.Forms.Label lAge;
    }
}

