using System.Data.OleDb;

namespace B_A_Software
{
    public partial class Login : Form
    {
        public Login(OleDbConnection conn)
        {
            this.connection = conn;
            InitializeComponent();
            LoginBtn.Click += (sender, EventArgs) => { LoginBtn_Click(sender, EventArgs, connection); };

            // TODO entfernen
            var xyz = DBHandler.GetTable(1);
            Console.WriteLine();
        }

        private void LoginBtn_Click(object sender, EventArgs e, OleDbConnection connection)
        {
            LoginCheck(connection);
        }

        private void LoginCheck(OleDbConnection connection)
        {
            string username = EmployeeNumTxtBox.Text;
            string password = PasswordTxtBox.Text;

            if (IsValidUser(username, password, connection))
            {
                MessageBox.Show("Login erfolgreich!");

                AreaSelect areaselect = new AreaSelect();

                this.Hide();

                if (areaselect.ShowDialog() == DialogResult.OK)
                {

                }
            }
            else
            {
                MessageBox.Show("Ungültige Anmeldedaten. Bitte versuchen Sie es erneut.");
            }
        }

        private bool IsValidUser(string username, string password, OleDbConnection connection)
        {
            if (username == null
                    || password == null
                    || username == ""
                    || password == "")
                return false;

            string query = $"SELECT COUNT(*) FROM Mitarbeiter WHERE MitarbeiterID = {username} AND Passwort = '{password}'";
            using (OleDbCommand command = new OleDbCommand(query, connection))
            {

                int count = (int)command.ExecuteScalar();

                return count > 0;
            }

        }

        private void LoginBtn_Click(object sender, EventArgs e)
        {

        }
    }
}