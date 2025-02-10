using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using System.Data.SqlClient;

namespace HamburgerMenuDemo
{
  
    public partial class User
    {
        public int user_id;
        public int user_role_id;
        public string userName;
        public string userEmail;
        public string userPhone;

        public string user_login;
        public string user_password;

        
        public User(int u_id, int u_rid, string u_name, string u_email, string u_phone, string u_login,string u_pass)
        {
            user_id = u_id;
            user_role_id = u_rid;
            userName = u_name;
            userEmail = u_email;
            userPhone = u_phone;
            user_login = u_login;
            user_password = u_pass;
        }

        public void ShowInfo()
        {
           //MessageBox.Show(user_id + " " + user_role_id + " " + userName + " " + userEmail + " " + userPhone);
        }
        
    }
   


    /// <summary>
    /// Логика взаимодействия для AuthWindow.xaml
    /// </summary>
    public partial class AuthWindow : Window
    {
       

        public AuthWindow()
        {
            InitializeComponent();
        }

        
      
        public void SetUpDB(object sender, RoutedEventArgs e)
        {
           
            

        }
        

        private void SignUpButton_Click(object sender, RoutedEventArgs e)
        {
            
            string username, password;
            string username_from_db, password_from_db;
            username = usernameInput.Text;
            password = passwordInput.Text;
            //MessageBox.Show("On start:" + username + " " + password);


            if ((username == ""))
            {
                usernameException.Visibility = Visibility.Visible;
            }
            else usernameException.Visibility = Visibility.Hidden;


            if ((password == ""))
            {
                passwordException.Visibility = Visibility.Visible;
            }
            else passwordException.Visibility = Visibility.Hidden;




            using (UserContext db = new UserContext())
            {
                
                var all_users = db.UsersHere.ToList();
                int k = 0;
                k = 0;

                foreach (Users to_output in all_users)
                {
                    username_from_db = to_output.userLogin;
                    password_from_db = to_output.userPassword;
                    if ((username_from_db == username) && (password_from_db == password))
                    {

                        if ((to_output.userRoleId >0))//== 5))
                        {

                            CurrentUser.userName = to_output.userName;
                            CurrentUser.userId = to_output.userId;
                            CurrentUser.userLogin = to_output.userLogin;
                            CurrentUser.userPassword = to_output.userPassword;
                            CurrentUser.userPhone = to_output.userPhone;
                            CurrentUser.userRoleId = to_output.userRoleId;
                            CurrentUser.userEmail = to_output.userEmail;



                          
                            MainWindow AdminPanelWindow = new MainWindow();
                            AdminPanelWindow.Show();
                            App.Current.Windows[0].Close();
                            k++;
                        }
                        else
                        {
                            //MessageBox.Show("Ви ввели правильний логін та пароль, однак на поточний момент система розроблена лише для адміністраторів. Особистий кабінет для вашої ролі буде створено в найближчому майбутньому", "Помилка");
                            k++;
                        }



                    }
                }

                if (k == 0) { MessageBox.Show("Wrong auth info"); }

            
            }



         
        }


    }
}
