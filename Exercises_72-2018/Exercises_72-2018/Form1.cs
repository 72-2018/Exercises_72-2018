using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercises_72_2018
{
    public partial class Results : Form
    {
        public string connString = "Data Source=(localdb)\\ProjectsV13;Initial Catalog=FacultyDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        public Results()
        {
            InitializeComponent();
        }

        private void Results_Load(object sender, EventArgs e)
        {
            SqlConnection dataConnection = new SqlConnection();
            dataConnection.ConnectionString = connString;
            List<ExerciseResults> results = new List<ExerciseResults>();

            dataConnection.Open();

            SqlCommand command = new SqlCommand();
            command.Connection = dataConnection;
            command.CommandText = "SELECT * FROM ExerciseResults";

            SqlDataReader dataReader = command.ExecuteReader();

            while (dataReader.Read())
            {
                ExerciseResults result = new ExerciseResults();
                result.Id = dataReader.GetInt32(0);
                result.StudentName = dataReader.GetString(1);
                result.StudentIndex = dataReader.GetString(2);
                result.Points = dataReader.GetInt32(3);

                results.Add(result);

            }

            dataConnection.Close();

            foreach (ExerciseResults r in results)
            {
                Rezultati.Items.Add(r.Id + ". " + 
                    r.StudentName + ", " + 
                    r.StudentIndex + ", "+
                    r.Points);
            }

        }
    }
}
