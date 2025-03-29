namespace CSC202FinalProject
{
    public partial class LoginPage : Form
    {
        public LoginPage()
        {
            InitializeComponent();
            this.Load += LoginPage_Load;
        }
        private void LoginPage_Load(object? sender, EventArgs e)
        {//this will emake the password as ** when being put 
         //clude at least 2 instances of exception handling.
         //EXCEPTION HANDLER 
            try
            {
                txtbxPassword.UseSystemPasswordChar = true;
                // this page will try and load with the passwords covered 
            }
            
            catch(Exception ex)
            {//if there is an error in my code and this does not load properly this error message will pop up 
                MessageBox.Show("An error has occured loading this page.\nError: try again" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }
        private void chckShowPass_CheckedChanged(object sender, EventArgs e)
        {
            txtbxPassword.UseSystemPasswordChar = !chckShowPass.Checked;
        }
        //1ST FUNCTION 
        private void btnLogin_Click(object sender, EventArgs e)
        {//this iniaties what happens when the login button is clicked, private means local to this class
            //on Click is when ithappens and objet sender represents the object that triggered
            //username used for testing, using an array to store multiple values 

            if (string.IsNullOrEmpty(txtbxUsername.Text) || string.IsNullOrEmpty(txtbxPassword.Text))
            {//this happens first and occurs if you either username or password using an OR operator so that if either of these are true the message will show
                MessageBox.Show("Please enter both username and password", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                //message box with please enter both usernae and password, and then Warning with an message box 
                return; // Stop execution if fields are empty
            }
            //"Include at least 1 array."
            //ARRAY WITH 2 VARIABLES 
            string[] usersnames = { "Admin", "User1", "User2", "User3" };
            //usernames have set ID's ie Admin. array [] implied, and name of variable is usersnames
            string[] passwords = { "1234", "5678", "abcd", "efgh" };
            //the usernames will correlate to these passwords 


            for (int i = 0; i < usersnames.Length; i++)
            //FOR LOOP, loop will start with 0, this loop will continue the entire length of the array, 
            //after each iteration the number is moved up by 1 
            {
                if (txtbxUsername.Text == usersnames[i] && txtbxPassword.Text == passwords[i])
                {//this condition will check if username is valid with the above listed usernames as well 
                    //as the passwords . it will check if either are valid 
                    MessageBox.Show("Login Successful");

                    this.Hide();//hides the login page once successful 
                    StudentPage studentPage = new StudentPage(); // will show the student page 
                    studentPage.ShowDialog();//student page is popped up as dialog
                    this.Show(); //will show login page when student page is closed 
                    break; //exit the loop after login 
                }
                else
                {
                    MessageBox.Show("Invalid Username or Password");
                    //second half of if else statment. If not a valid user name or password this message box will appear 
                }
            }

        }

    }

}
