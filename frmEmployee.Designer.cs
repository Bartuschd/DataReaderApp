namespace DataReaderApp
{
  partial class frmEmployee
  {
    /// <summary>
    /// Erforderliche Designervariable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Verwendete Ressourcen bereinigen.
    /// </summary>
    /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
    protected override void Dispose(bool disposing)
    {
      if (disposing && (components != null))
      {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Vom Windows Form-Designer generierter Code

    /// <summary>
    /// Erforderliche Methode für die Designerunterstützung.
    /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
    /// </summary>
    private void InitializeComponent()
    {
      this.dataSet1 = new System.Data.DataSet();
      this.label1 = new System.Windows.Forms.Label();
      this.label2 = new System.Windows.Forms.Label();
      this.txtFirstName = new System.Windows.Forms.TextBox();
      this.txtLastName = new System.Windows.Forms.TextBox();
      this.label3 = new System.Windows.Forms.Label();
      this.label4 = new System.Windows.Forms.Label();
      this.txtBirthDate = new System.Windows.Forms.TextBox();
      this.txtDepartmentID = new System.Windows.Forms.TextBox();
      this.btnNext = new System.Windows.Forms.Button();
      this.btnInsert = new System.Windows.Forms.Button();
      this.btnNew = new System.Windows.Forms.Button();
      this.btnUpdate = new System.Windows.Forms.Button();
      this.btnDelete = new System.Windows.Forms.Button();
      this.labelID = new System.Windows.Forms.Label();
      this.txtEmployeeID = new System.Windows.Forms.TextBox();
      ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
      this.SuspendLayout();
      // 
      // dataSet1
      // 
      this.dataSet1.DataSetName = "NewDataSet";
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(12, 49);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(72, 16);
      this.label1.TabIndex = 0;
      this.label1.Text = "First Name";
      this.label1.Click += new System.EventHandler(this.label1_Click);
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(12, 79);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(72, 16);
      this.label2.TabIndex = 1;
      this.label2.Text = "Last Name";
      this.label2.Click += new System.EventHandler(this.label2_Click);
      // 
      // txtFirstName
      // 
      this.txtFirstName.Location = new System.Drawing.Point(153, 48);
      this.txtFirstName.Name = "txtFirstName";
      this.txtFirstName.Size = new System.Drawing.Size(168, 22);
      this.txtFirstName.TabIndex = 2;
      this.txtFirstName.TextChanged += new System.EventHandler(this.txtFirstName_TextChanged);
      // 
      // txtLastName
      // 
      this.txtLastName.Location = new System.Drawing.Point(153, 78);
      this.txtLastName.Name = "txtLastName";
      this.txtLastName.Size = new System.Drawing.Size(168, 22);
      this.txtLastName.TabIndex = 3;
      this.txtLastName.TextChanged += new System.EventHandler(this.txtLastName_TextChanged);
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Location = new System.Drawing.Point(12, 109);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(65, 16);
      this.label3.TabIndex = 5;
      this.label3.Text = "Birth Date";
      this.label3.Click += new System.EventHandler(this.label3_Click);
      // 
      // label4
      // 
      this.label4.AutoSize = true;
      this.label4.Location = new System.Drawing.Point(12, 137);
      this.label4.Name = "label4";
      this.label4.Size = new System.Drawing.Size(93, 16);
      this.label4.TabIndex = 6;
      this.label4.Text = "Department ID";
      this.label4.Click += new System.EventHandler(this.label4_Click);
      // 
      // txtBirthDate
      // 
      this.txtBirthDate.Location = new System.Drawing.Point(153, 106);
      this.txtBirthDate.Name = "txtBirthDate";
      this.txtBirthDate.Size = new System.Drawing.Size(168, 22);
      this.txtBirthDate.TabIndex = 7;
      this.txtBirthDate.TextChanged += new System.EventHandler(this.txtBirthDate_TextChanged);
      // 
      // txtDepartmentID
      // 
      this.txtDepartmentID.Location = new System.Drawing.Point(154, 137);
      this.txtDepartmentID.Name = "txtDepartmentID";
      this.txtDepartmentID.Size = new System.Drawing.Size(168, 22);
      this.txtDepartmentID.TabIndex = 8;
      this.txtDepartmentID.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
      // 
      // btnNext
      // 
      this.btnNext.Location = new System.Drawing.Point(3, 165);
      this.btnNext.Name = "btnNext";
      this.btnNext.Size = new System.Drawing.Size(102, 28);
      this.btnNext.TabIndex = 10;
      this.btnNext.Text = "Next";
      this.btnNext.UseVisualStyleBackColor = true;
      this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
      // 
      // btnInsert
      // 
      this.btnInsert.Location = new System.Drawing.Point(220, 233);
      this.btnInsert.Name = "btnInsert";
      this.btnInsert.Size = new System.Drawing.Size(102, 28);
      this.btnInsert.TabIndex = 11;
      this.btnInsert.Text = "Insert";
      this.btnInsert.UseVisualStyleBackColor = true;
      this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
      // 
      // btnNew
      // 
      this.btnNew.Location = new System.Drawing.Point(3, 199);
      this.btnNew.Name = "btnNew";
      this.btnNew.Size = new System.Drawing.Size(102, 28);
      this.btnNew.TabIndex = 12;
      this.btnNew.Text = "New";
      this.btnNew.UseVisualStyleBackColor = true;
      this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
      // 
      // btnUpdate
      // 
      this.btnUpdate.Location = new System.Drawing.Point(3, 233);
      this.btnUpdate.Name = "btnUpdate";
      this.btnUpdate.Size = new System.Drawing.Size(102, 28);
      this.btnUpdate.TabIndex = 13;
      this.btnUpdate.Text = "Update";
      this.btnUpdate.UseVisualStyleBackColor = true;
      this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
      // 
      // btnDelete
      // 
      this.btnDelete.Location = new System.Drawing.Point(111, 233);
      this.btnDelete.Name = "btnDelete";
      this.btnDelete.Size = new System.Drawing.Size(102, 28);
      this.btnDelete.TabIndex = 14;
      this.btnDelete.Text = "Delete";
      this.btnDelete.UseVisualStyleBackColor = true;
      this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
      // 
      // labelID
      // 
      this.labelID.AutoSize = true;
      this.labelID.Location = new System.Drawing.Point(12, 23);
      this.labelID.Name = "labelID";
      this.labelID.Size = new System.Drawing.Size(20, 16);
      this.labelID.TabIndex = 15;
      this.labelID.Text = "ID";
      // 
      // txtEmployeeID
      // 
      this.txtEmployeeID.Location = new System.Drawing.Point(153, 20);
      this.txtEmployeeID.Name = "txtEmployeeID";
      this.txtEmployeeID.Size = new System.Drawing.Size(168, 22);
      this.txtEmployeeID.TabIndex = 16;
      this.txtEmployeeID.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
      // 
      // frmEmployee
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(320, 264);
      this.Controls.Add(this.txtEmployeeID);
      this.Controls.Add(this.labelID);
      this.Controls.Add(this.btnDelete);
      this.Controls.Add(this.btnUpdate);
      this.Controls.Add(this.btnNew);
      this.Controls.Add(this.btnInsert);
      this.Controls.Add(this.btnNext);
      this.Controls.Add(this.txtDepartmentID);
      this.Controls.Add(this.txtBirthDate);
      this.Controls.Add(this.label4);
      this.Controls.Add(this.label3);
      this.Controls.Add(this.txtLastName);
      this.Controls.Add(this.txtFirstName);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.label1);
      this.Name = "frmEmployee";
      this.Text = "Employees";
      this.Load += new System.EventHandler(this.frmEmployee_Load);
      ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Data.DataSet dataSet1;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.TextBox txtFirstName;
    private System.Windows.Forms.TextBox txtLastName;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.TextBox txtBirthDate;
    private System.Windows.Forms.TextBox txtDepartmentID;
    private System.Windows.Forms.Button btnNext;
    private System.Windows.Forms.Button btnInsert;
    private System.Windows.Forms.Button btnNew;
    private System.Windows.Forms.Button btnUpdate;
    private System.Windows.Forms.Button btnDelete;
    private System.Windows.Forms.Label labelID;
    private System.Windows.Forms.TextBox txtEmployeeID;
  }
}

