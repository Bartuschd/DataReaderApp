using Npgsql;
using System;
using System.Windows.Forms;

namespace DataReaderApp
{

  public partial class frmEmployee : Form
  {
    private NpgsqlConnection sqlConnection;
    private NpgsqlDataReader sqlDataReader;
    private NpgsqlCommand sqlCommand;
    public frmEmployee()
    {
      InitializeComponent();
    }

    private void frmEmployee_Load(object sender, EventArgs e)
    {
     DisplayFirstRecord();
    }

    private void GetEmployee()
    {
      try
      {
        sqlConnection.Open();
        sqlDataReader = sqlCommand.ExecuteReader();

        if (sqlDataReader.Read())
        {
          txtEmployeeID.Text = Convert.ToString(sqlDataReader["id"]);
          txtFirstName.Text = Convert.ToString(sqlDataReader["first_name"]);
          txtLastName.Text = Convert.ToString(sqlDataReader["last_name"]);
          txtBirthDate.Text = Convert.ToString(sqlDataReader["birth_date"]);
          txtDepartmentID.Text = Convert.ToString(sqlDataReader["department_id"]);
        }
      }
      catch (Exception exception)
      {
        MessageBox.Show(exception.Message);
        throw;
      }
    }

    private void DisplayFirstRecord()
    {
      string connectionString = "Host=docker.bueltel.com;Port=5432;Database=Test;Username=test;Password=JhWY2GVuafoSto2QoQl4";
      sqlConnection = new NpgsqlConnection(connectionString);

      string commandString = "SELECT * FROM employees";
      sqlCommand = new NpgsqlCommand(commandString, sqlConnection);

      GetEmployee();
    }



    private void btnNext_Click(object sender, EventArgs e)
    {
      try
      {
        if (sqlDataReader.Read())
        {
          txtEmployeeID.Text = Convert.ToString(sqlDataReader["id"]);
          txtFirstName.Text = Convert.ToString(sqlDataReader["first_name"]);
          txtLastName.Text = Convert.ToString(sqlDataReader["last_name"]);
          txtBirthDate.Text = Convert.ToString(sqlDataReader["birth_date"]);
          txtDepartmentID.Text = Convert.ToString(sqlDataReader["department_id"]);
        }
        else {
          DisplayFirstRecord();
        }
      }
      catch (Exception exception)
      {
        MessageBox.Show(exception.Message);
        throw;
      }
    }

    private void btnNew_Click(object sender, EventArgs e)
    {
      txtEmployeeID.Enabled = false;
      txtEmployeeID.Text = "";
      txtFirstName.Text = "";
      txtLastName.Text = "";
      txtBirthDate.Text = "";
      txtDepartmentID.Text = "";
    }

    private void btnInsert_Click(object sender, EventArgs e)
    {
      sqlConnection.Close();
      string commandString="INSERT INTO employees(first_name,last_name,department_id) VALUES('"+txtFirstName.Text+"','"+txtLastName.Text + "',"+Convert.ToInt32(txtDepartmentID.Text)+")";
      sqlCommand = new NpgsqlCommand(commandString, sqlConnection);

      try
      {
        sqlConnection.Open();
        sqlCommand.ExecuteNonQuery();
        MessageBox.Show("Record insert successful.");
        DisplayFirstRecord();

      }
      catch (Exception exception)
      {
        MessageBox.Show(exception.Message);
        throw;
      }
    }

    private void btnUpdate_Click(object sender, EventArgs e)
    {
      sqlConnection.Close();
      string commandString = "UPDATE employees SET first_name='" + txtFirstName.Text + "', last_name='" + txtLastName.Text + "' WHERE id="+txtEmployeeID.Text+"";
      sqlCommand = new NpgsqlCommand(commandString, sqlConnection);

      try
      {
        sqlConnection.Open();
        sqlCommand.ExecuteNonQuery();
        MessageBox.Show("Record Update successful.");
        DisplayFirstRecord();

      }
      catch (Exception exception)
      {
        MessageBox.Show(exception.Message);
        throw;
      }
    }

    private void btnDelete_Click(object sender, EventArgs e)
    {
      sqlConnection.Close();
      string commandString = "DELETE FROM employees WHERE id = " + txtEmployeeID.Text;

      sqlCommand = new NpgsqlCommand(commandString, sqlConnection);
    }

    //--------------------UNUSED---------------------------
    private void txtLastName_TextChanged(object sender, EventArgs e)
    {

    }

    private void txtFirstName_TextChanged(object sender, EventArgs e)
    {

    }

    private void txtBirthDate_TextChanged(object sender, EventArgs e)
    {

    }

    private void label4_Click(object sender, EventArgs e)
    {

    }

    private void textBox1_TextChanged(object sender, EventArgs e)
    {

    }

    private void label1_Click(object sender, EventArgs e)
    {

    }

    private void label3_Click(object sender, EventArgs e)
    {

    }

    private void label2_Click(object sender, EventArgs e)
    {

    }

    private void textBox4_TextChanged(object sender, EventArgs e)
    {

    }


  }
}
