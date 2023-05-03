using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataReaderApp.Config
{
  public class sqlCommands
  {
    public static string getAll = "SELECT * FROM employees";

    public static string CreateEmployee = "INSERT INTO employees(first_name,last_name,department_id) VALUES('" + txtFirstName.Text + "','" + txtLastName.Text + "'," + Convert.ToInt32(txtDepartmentID.Text) + ")";
  }
}
