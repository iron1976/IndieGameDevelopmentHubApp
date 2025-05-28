using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms; 
using main = IndieGameDevelopmentHubApp.Program;

namespace IndieGameDevelopmentHubApp
{
    public partial class ManageAccountPanel : UserControl
    {
        public ManageAccountPanel()
        {
            InitializeComponent();
            if (main.LoggedInUser == null)
                return;
            if (main.LoggedInUser.UserType == main.UserTypeEnum.Tester)
                IsLicensedCheckBox.Visible = true;
            else
                IsLicensedCheckBox.Visible = false;

            UpdateCurrentInformations();

        }
        private void UpdateCurrentInformations()
        {

            UserIDText.Text = "Current User ID: " + main.LoggedInUser.UserID;
            UserTypeText.Text = "Current User Type: " + main.LoggedInUser.UserType.ToString();

            if (main.LoggedInUser.UserType == main.UserTypeEnum.Developer)
            {
                //LINQ USAGE:
                main.SQLAccess(x =>
                {
                    var foundUser = x.Developers.Where(x => x.DevId == main.LoggedInUser.UserID).FirstOrDefault();
                    MailText.Text = "Email: " + foundUser.Email;
                    FirstNameText.Text = "First Name: " + foundUser.FirstName;
                    LastName.Text = "Last Name: " + foundUser.LastName;
                    PasswordText.Text = "Password: " + foundUser.Password;
                }); 
            }
            else if (main.LoggedInUser.UserType == main.UserTypeEnum.Tester)
            {
                //LINQ USAGE:
                main.SQLAccess(x =>
                {
                    var foundUser =  x.Testers.Where(x => x.TesterId == main.LoggedInUser.UserID).FirstOrDefault();
                    MailText.Text = "Email: " + foundUser.Email;
                    FirstNameText.Text = "First Name: " + foundUser.FirstName;
                    LastName.Text = "Last Name: " + foundUser.LastName;
                    PasswordText.Text = "Password: " + foundUser.Password;
                }); 
            }
            else if (main.LoggedInUser.UserType == main.UserTypeEnum.Player)
            {
                //LINQ USAGE:
                main.SQLAccess(x =>
                {
                    var foundUser = x.Players.Where(x => x.PlayerId == main.LoggedInUser.UserID).FirstOrDefault();
                    MailText.Text = "Email: " + foundUser.Email;
                    FirstNameText.Text = "First Name: " + foundUser.FirstName;
                    LastName.Text = "Last Name: " + foundUser.LastName;
                    PasswordText.Text = "Password: " + foundUser.Password;
                }); 
            }

        }
        private void UpdateButtonClicked(object sender, EventArgs e)
        {
            if (main.LoggedInUser == null)
                return;
            if (main.LoggedInUser.UserType == main.UserTypeEnum.Developer)
            {
                //LINQ USAGE:
                main.SQLAccess(x =>
                {
                    x.Developers.Where(x => x.DevId == main.LoggedInUser.UserID).ToList().ForEach(dev =>
                    {
                        dev.Email = NewMailTextBox.Text;
                        dev.FirstName = NewFirstNameTextBox.Text;
                        dev.LastName = NewLastNameTextBox.Text;
                    });
                });
                MessageBox.Show("Successfully updated your information.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (main.LoggedInUser.UserType == main.UserTypeEnum.Tester)
            {
                //LINQ USAGE:
                main.SQLAccess(x =>
                {
                    x.Testers.Where(x => x.TesterId == main.LoggedInUser.UserID).ToList().ForEach(tester =>
                    {
                        tester.Email = NewMailTextBox.Text;
                        tester.FirstName = NewFirstNameTextBox.Text;
                        tester.LastName = NewLastNameTextBox.Text; 
                        tester.IsLicensed = IsLicensedCheckBox.Checked;
                    });
                });
                MessageBox.Show("Successfully updated your information.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (main.LoggedInUser.UserType == main.UserTypeEnum.Player)
            {
                //LINQ USAGE:
                main.SQLAccess(x =>
                {
                    x.Players.Where(x => x.PlayerId == main.LoggedInUser.UserID).ToList().ForEach(player =>
                    {
                        player.Email = NewMailTextBox.Text;
                        player.FirstName = NewFirstNameTextBox.Text;
                        player.LastName = NewLastNameTextBox.Text;
                    });
                });
                MessageBox.Show("Successfully updated your information.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            UpdateCurrentInformations();
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

    }
}
