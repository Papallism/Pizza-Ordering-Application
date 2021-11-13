using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace PizzaOrderingApplication
{
    public partial class LoginForm : Form
    {
        private const string DEFAULT_USERNAME = "admin";
        private const string DEFAULT_PASSWORD = "admin";

        private List<User> users = new List<User>();

        private User loggedInUser = new User();

        public LoginForm()
        {
            InitializeComponent();

            // Load any saved user data in the list
            GetUserData();
        }

        // If saved users exist, deserialize them into the list
        private void GetUserData()
        {
            string userData = ReadUsersFromJson();
            if (userData != null)
            {
                users = JsonConvert.DeserializeObject<List<User>>(userData);
            }
        }

        // Read the JSON file for any saved users or return null
        private string ReadUsersFromJson()
        {
            if (File.Exists("PizzaUsers.json"))
            {
                return File.ReadAllText("PizzaUsers.json");
            }
            else
            {
                return null;
            }
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            // Check if there are no existing users and if not, use default credentials only
            if (users.Count == 0)
            {
                if (textBoxUsername.Text == DEFAULT_USERNAME && textBoxPassword.Text == DEFAULT_PASSWORD)
                {
                    MessageBox.Show("Login");

                    MainWindowForm mainWindowForm = new MainWindowForm();
                    this.Hide();
                    mainWindowForm.ShowDialog();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Invalid credentials");
                }
            }
            // Check if match with an existing user
            else
            {
                loggedInUser = users.FirstOrDefault(x => x.Username == textBoxUsername.Text);

                if (loggedInUser != null)
                {
                    if (loggedInUser.Password == textBoxPassword.Text)
                    {
                        MessageBox.Show("Login!");

                        this.Hide();
                        // Create a Main Window Form with the logged in user passed as an argument
                        MainWindowForm mainWindowForm = new MainWindowForm(loggedInUser);
                        mainWindowForm.ShowDialog();
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Wrong password");
                    }
                }
                else
                {
                    MessageBox.Show("No such user exists");
                }
            }
        }
    }
}