﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace PizzaOrderingApplication
{
    public partial class LoginForm : Form
    {
        private const string DEFAULT_USERNAME = "admin";
        private const string DEFAULT_PASSWORD = "admin";

        private List<User> users = new List<User>();

        public LoginForm()
        {
            InitializeComponent();

            GetUserData();
        }

        private void GetUserData()
        {
            string userData = ReadUsersFromJson();
            if (userData != null)
            {
                users = JsonConvert.DeserializeObject<List<User>>(userData);
            }
        }

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
            // Check if there are no existing users
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
            else
            {
                if (textBoxUsername.Text == "Michalis" && textBoxPassword.Text == "1234")
                {
                    MessageBox.Show("User login");
                }
                else
                {
                    MessageBox.Show("Wrong input");
                }
            }
        }
    }
}