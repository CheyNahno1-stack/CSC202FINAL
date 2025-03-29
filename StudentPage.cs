using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSC202FinalProject
{
    public partial class StudentPage : Form
    {//"Include at least 2 forms."
        //MY TWO FORMS ARE STUDENTPAGE AND LOGINPAGE
        public StudentPage()
        {
            InitializeComponent();
            LoadStudentData();
        }
        //"Create at least 5 variables of different types."
        //5 VARIABLES : STUDENTID, NAME, GRADE, ATTENDANCE, score, STRING, DOUBLE
        public class Student
        {
            public int StudentID { get; set; }  // Unique student ID. Public so it can be accessed in any form. integer or number is being used. GET geta the student id and Set assigns it a value
            public string Name { get; set; }    // variable to hold the students name. Its a String this time because its a name
            //public so it can be accessed anywhere. Get grabs the name and Set stores the name 
            public string Grade { get; set; }   // Variable Grade and will be able to hold numbers and letters so a string. Public again 
            public int Attendance { get; set; } // Attendance percentage and doesnt need a double. This is also public 
            //Variable name Attendance
            public double Score { get; set; } // students overall grades, double to hold decimal points, more precise, 
            //public to all forms, Score is the variable name, and get will gran the score and set will set value . 
        }
        private List<Student> students = new List<Student>//didnt use a dictionary or list because this was the most flexible 
        {//initialization , 
            //calling back to the variables that were inialized, asigning a set of students placed in this rather than using a differnet file such as SQL 
            new Student { StudentID = 1, Name = "Tryion Lannister", Grade = "7th", Attendance = 99, Score = 89.8 },
            new Student { StudentID = 2, Name = "Arya Stark", Grade = "12th", Attendance = 78, Score = 92.9 },
            new Student { StudentID = 3, Name = "Rhaena Targaryan", Grade = "8th", Attendance = 89, Score = 72.7 },
            new Student { StudentID = 4, Name = "Brenden Tulley", Grade = "10th", Attendance = 95, Score = 79.5},
            new Student { StudentID =5, Name = "Visenya Targaryan", Grade = "6th", Attendance = 66, Score = 82.6 },
            new Student {StudentID = 6, Name = "Aero Hota", Grade = "10th", Attendance = 68, Score = 99.1},
            new Student { StudentID = 7, Name = "Young Griff", Grade = "9th", Attendance = 78, Score = 88.6},
            new Student { StudentID = 8, Name = "Garlan Tyrell", Grade = "12th", Attendance = 49, Score = 79.9},
            new Student { StudentID = 9, Name = "Lady StoneHeart", Grade = "11th", Attendance = 76, Score = 67.9},
            new Student { StudentID = 10, Name = "Maya Stone", Grade = "10th", Attendance = 79, Score = 82.4}
            //these are something that i can pull up in the search bar as well. use commas to seperate values, commas around strings and nothing around numbers or int/double
        };
        //"Create at least 5 functions."
        //2ND FUNCTION THAT WILL LOAD THE DATA TOT HE DATA GIRD VIEW 
        private void LoadStudentData()
        {
            DtaGrdStudent.DataSource = null;//first clears the grid 
            DtaGrdStudent.DataSource = students; //plaxes the students values into the grid
        }

        private void txtbxStudentSearch_TextChanged(object sender, EventArgs e)
        {   //"Include at least 2 instances of exception handling."
            //1ST EXCEPTION HANDLING 
            try
            {//this will help with exceptions 
                string searchText = txtbxStudenSearch.Text.Trim();
                //using a string and with a variable  search text and what that would include which is the string information from StudenSearch text with the trimmed away extra space 
                if (string.IsNullOrEmpty(searchText))
                {//this is what happens if there is white space, null, or empty 
                    LoadStudentData();//the current student list will laod 
                    return;//no other code will continue 
                }

                List<Student> filteredStudents;
                //the List of the students is being called and only student related items can be added  

                if (int.TryParse(searchText, out int studentID))
                {//checks if this is an interger first and then convert it and if it failes it runs false

                    filteredStudents = students.Where(s => s.StudentID == studentID).ToList();
                    //first will check through all the students in a loop until a match is found 
                    //will go thorugh the filtered results and reconfirgure the student list into the filtered one 
                }
                else
                {//this is what will happen if its not found by the student id it will now try to find it through thr name 
                    // Searching by Name (case-insensitive)
                    filteredStudents = students.Where(s => s.Name.IndexOf(searchText, StringComparison.OrdinalIgnoreCase) >= 0).ToList();
                    //this will filter through the students looking for the name and will then create a new student list that has the filter
                }

                if (filteredStudents.Count == 0)
                {//checks list to see if its empty if it is then it will execut the prompt 
                    // No students found
                    MessageBox.Show("No matching student found.", "Search Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //the title of box will say search results, the message box will show no student found and to close it the user has to press ok 
                }

                // Display the filtered results 
                DtaGrdStudent.DataSource = null;
                //first clears out previous data 
                DtaGrdStudent.DataSource = filteredStudents;
                //places in the new data will a filtered results 
            }
            catch (FormatException ex)
            {//this exception will help with any format errors like not putting in the right numbers or letters into the search box 
                MessageBox.Show("Invalid input format. Please enter a valid Student ID or Name.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {//this is genral exception and should only occur when there is an unexpected error
                MessageBox.Show("An unexpected error occurred " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //a message box with a title error and the message boxsaying unexpected error 
            }
        }



        private void DtaGrdStudent_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        //"Create at least 5 functions."
        //3RD FUNCTION WITH IS A EVENT HANDLER FOR THE ADD BUTTON 
        private void btnAddStudent_Click(object sender, EventArgs e)
        {//first we are going to grab the information in the text boxes and stores them 
            string name = txtbxStudentName.Text;  // Retrieves the information from student name, only accepting a string and then storing it to the variable Name 
            string grade = txtbxStudentGrade.Text; // retrives the string from the Student grade text box and then store it to the Grade string
            int attendance = int.Parse(txtbxAttendance.Text); // Takes int data from the attentance text box and then stores it in the Attendance Variable
            double score = double.Parse(txtbxScore.Text); // Takes the double data from the Score text box and then stores it in the Score variable 

            int newStudentId = students.Count + 1; //this creates a new student id wichh is the number value assigned and then will add i by 1 
                                                   //because we are adding a new student . this line calls back to the Student List and the Student ID variable 
                                                   //uses the information stored from textbox and assigning it to a new object 
            Student newStudent = new Student
            {//the student variable  has a new object 
                StudentID = newStudentId,//allows us to add a new student id to the new object, this is dynamic and with the code above will allow an added number 
                Name = name, //sets a new name to the new object 
                Grade = grade, //assigns a grade to the new object with is a new student 
                Attendance = attendance, //has an attendance assigned to the new student 
                Score = score, //sets a score to the new object with is the new student 

            };

            //now we add the student to the list with the other students 
            students.Add(newStudent);
            //student refers to the list, ADD is within the language and will ADD whatever you are refering, new student refers to the variable and the instances we have already places 

            //this refers to the function that i made earlier that will load the student list 
            LoadStudentData();
            //this will clear the text boxes once done with the add text box 
            txtbxStudentName.Clear();// will clear the student name text box
            txtbxStudentGrade.Clear();//clears the students grade text box 
            txtbxAttendance.Clear();//clears the students attendance text box 
            txtbxScore.Clear();//clears the students score text box 


        }
        //"Create at least 5 functions."
        //"Include at least 2 instances of event handling."
        //4th FUNCTION WITH IS A EVENT HANDLER FOR THE ADD BUTTON 
        private void btnRemoveStudent_Click(object sender, EventArgs e)
        {//"Include at least 2 separate instances of decision logic."
            if (DtaGrdStudent.SelectedRows.Count > 0)
            {

                int studentIDToRemove = Convert.ToInt32(DtaGrdStudent.SelectedRows[0].Cells["StudentID"].Value);
                //this is an integer and its using the StudentID to first store the variable that needs to be removed 
                //convert will convert the student id value and everythign associated withit into a value and the row its on.

                Student studentToRemove = students.FirstOrDefault(s => s.StudentID == studentIDToRemove);
                //student refers to the student list and student to remove is what we previously stored 
                //first or default is used to use call upon the first object or the default one
                //this condition looks throught the student list and goes to the numer we selected and if null something happens 
                if (studentToRemove != null)
                {//if statement remoces the student and uses the stored information we used ealier

                    students.Remove(studentToRemove);//will actually remove student from list 
                    //"Include at least 1 loop."
                    //LOOP 
                    for (int i = 0; i < students.Count; i++)
                    {//this loop will update the student count to be inline with the removed task
                        //refers to the student arry made 
                        students[i].StudentID = i + 1; // refers to student list, and will renumber 
                        //instead of skipping the missing number that was deleted
                    }

                    LoadStudentData();
                    //reloads with new list without the student and with the correct student ID numbering
                }
                else
                { //first else statement if the the student Id wasnt found or nothing selected
                    MessageBox.Show("Student not found. Please select a student to continue");
                }
            }
            else
            {//this means nothing was selected and the message box will show up 
                MessageBox.Show("Please select a student to remove.");
            }
        }

        ////"Create at least 5 functions."
        //"Include at least 2 instances of event handling."
        //5TH FUNCTION 
        private void btnSearch_Click(object sender, EventArgs e)
        { //"Include at least 2 separate instances of decision logic."
            //2ND DECISION LOGIC 
            string searchTerm = txtbxStudenSearch.Text.Trim().ToLower(); // for case sensitivity 
            //refers to the student search text box and first trims away the white space and then then allows everything to converted to lowercase and one standard thing 

            //this is what happens id you 
            if (string.IsNullOrWhiteSpace(searchTerm))
            {//checks to see whether it is empty Null, or just white space 
                LoadStudentData(); // Reload original data if search box is empty
                return;
            }


            var filteredStudents = students
                //declares filtered students and the students refers to the students list
                .Where(s => s.Name.ToLower().Contains(searchTerm) || s.Grade.ToLower().Contains(searchTerm))
                //this is the filtering eleement. and whats inside the parenthesis is the conditions. which si the lower case insesnstivity 
                //the OR statement refers to if the Name or Grade is correct 
                .ToList();//makes sure the student list containes the filtered students 


            DtaGrdStudent.DataSource = null;
            //first clears out previous data placed in data grid student which is what null does 
            DtaGrdStudent.DataSource = filteredStudents;
            //has only the filtered students displayed in the data grid view


            if (filteredStudents.Count == 0)
            {//this is what happens if there is no student found 
                // ==0 means that it is true that the list is empty 
                MessageBox.Show("No students found with those credentials.");
                //this is the pop up box that says there was nothing there 
            }
        }

        private void txtbxStudentName_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtbxStudentGrade_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtbxAttendance_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtbxScore_TextChanged(object sender, EventArgs e)
        {

        }

        
    }
}
