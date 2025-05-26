using IndieGameDevelopmentHubApp.Models;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using main = IndieGameDevelopmentHubApp.Program;

namespace IndieGameDevelopmentHubApp
{
    public partial class LoginRegisterScreen : UserControl
    {
        public LoginRegisterScreen()
        {
            InitializeComponent();
            IsLicensedCheckBox.Visible = false;
            OpenHomeScreen();//THIS IS FOR DEBUG REMOVE FOR RELEASE
        }


        private void RegisterButtonClicked(object sender, EventArgs e)
        {
            this.RegisterError.Visible = true;


            string mail = RegisterMailInput.Text;
            string password = RegisterPasswordInput.Text;
            string firstName = RegisterFirstNameInput.Text;
            string lastName = RegisterLastNameInput.Text;
            main.UserTypeEnum userType = (main.UserTypeEnum)UserTypeBox.SelectedIndex + 1;
            main.print("ENTERED: " + mail + " " + password + " " + userType.ToString());

            if (!mail.Contains('@'))
            {
                this.RegisterError.Visible = true;
                this.RegisterError.Text = "*Email doesn't include \'@\'.";
            }
            else if (string.IsNullOrEmpty(firstName))
            {
                this.RegisterError.Visible = true;
                this.RegisterError.Text = "*First name is empty.";
            }
            else if (string.IsNullOrEmpty(lastName))
            {
                this.RegisterError.Visible = true;
                this.RegisterError.Text = "*Last name is empty.";
            }
            else
                main.SQLAccess((x) =>
                {
                    if (x.Developers.Where(p => p.Email == mail).Count() > 0
                    || x.Players.Where(p => p.Email == mail).Count() > 0
                    || x.Testers.Where(p => p.Email == mail).Count() > 0)
                    {
                        this.RegisterError.Visible = true;
                        this.RegisterError.Text = "*This mail exists.";
                    }
                    else if (userType == main.UserTypeEnum.Developer)
                    {
                        decimal DevId = x.Developers.Any() ? x.Developers.OrderBy(x => x.DevId).Last().DevId + 1 : 1;
                        x.Developers.Add(new Developer()
                        {
                            FirstName = firstName,
                            LastName = lastName,
                            Email = mail,
                            Password = password,
                            DevId = DevId,
                            RegisterDate = DateTime.Now
                        });
                        RegisterError.Visible = false;
                        RegisterCompleteText.Visible = true;
                        RegisterCompleteText.Text = $"Your mail: {mail} \n Your password: {password}";
                    }
                    else if (userType == main.UserTypeEnum.Player)
                    {
                        decimal PlayerId = x.Players.Any() ? x.Players.OrderBy(x => x.PlayerId).Last().PlayerId + 1 : 1;
                        x.Players.Add(new Player()
                        {
                            FirstName = firstName,
                            LastName = lastName,
                            Email = mail,
                            Password = password,
                            PlayerId = PlayerId,
                            RegisterDate = DateTime.Now
                        });
                        RegisterError.Visible = false;
                        RegisterCompleteText.Visible = true;
                        RegisterCompleteText.Text = $"Your mail: {mail} \n Your password: {password}";
                    }
                    else if (userType == main.UserTypeEnum.Tester)
                    {
                        decimal TesterId = x.Testers.Any() ? x.Testers.OrderBy(x => x.TesterId).Last().TesterId + 1 : 1;
                        x.Testers.Add(new Tester()
                        {
                            FirstName = firstName,
                            LastName = lastName,
                            Email = mail,
                            Password = password,
                            TesterId = TesterId,
                            RegisterDate = DateTime.Now,
                            IsLicensed = IsLicensedCheckBox.Checked
                        });
                        RegisterError.Visible = false;
                        RegisterCompleteText.Visible = true;
                        RegisterCompleteText.Text = $"Your mail: {mail} \n Your password: {password}";
                    }
                    else
                    {
                        this.RegisterError.Visible = true;
                        this.RegisterError.Text = "*User Type isn't selected.";
                    }
                });
        }

        private void LoginButtonClicked(object sender, EventArgs e)
        {
            string mail = LoginMailInput.Text;
            string password = LoginPasswordInput.Text;
            main.print("ENTERED: " + mail + " " + password);

            if (!mail.Contains('@'))
            {
                this.LoginError.Visible = true;
                this.LoginError.Text = "*Email doesn't include \'@\'.";
            }
            else
                main.SQLAccess((x) =>
                {
                    if (x.Developers.Where(p => p.Email == mail && p.Password == password).Count() > 0)
                    {
                        main.LoggedInUser = new main.User();
                        main.LoggedInUser.UserID = x.Developers.Where(p => p.Email == mail && p.Password == password).First().DevId;
                        main.LoggedInUser.UserType = main.UserTypeEnum.Developer;
                        OpenHomeScreen();
                    }
                    else if (x.Players.Where(p => p.Email == mail && p.Password == password).Count() > 0)
                    {
                        main.LoggedInUser = new main.User();
                        main.LoggedInUser.UserID = x.Players.Where(p => p.Email == mail && p.Password == password).First().PlayerId;
                        main.LoggedInUser.UserType = main.UserTypeEnum.Player;
                        OpenHomeScreen();
                    }
                    else if (x.Testers.Where(p => p.Email == mail && p.Password == password).Count() > 0)
                    {
                        main.LoggedInUser = new main.User();
                        main.LoggedInUser.UserID = x.Testers.Where(p => p.Email == mail && p.Password == password).First().TesterId;
                        main.LoggedInUser.UserType = main.UserTypeEnum.Tester;
                        OpenHomeScreen();
                    }
                    else
                    {
                        this.LoginError.Visible = true;
                        this.LoginError.Text = "*Invalid email or password.";
                    }
                });



        }
        private void OpenHomeScreen()
        {

            this.Controls.Clear();   // Clear previous control
            HomeScreen form2 = new();
            form2.Dock = DockStyle.Fill;     // Fill the panel
            this.Controls.Add(form2);   // Add new one
        }

        private void UserTypeBoxChanged(object sender, EventArgs e)
        {

            if (UserTypeBox.SelectedIndex == 2)//Choosing TESTER
                IsLicensedCheckBox.Visible = true;
            else
                IsLicensedCheckBox.Visible = false;
        }
    }
}
