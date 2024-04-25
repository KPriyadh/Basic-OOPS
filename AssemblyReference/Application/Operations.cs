using System;
using System.Collections.Generic;
using CollegeDetails;

namespace Application;

    public static class Operations
    {
        //LOcal/Global 
        static StudentDetails currentLoggedInStudent;

        //Static List Creation
        static List<StudentDetails> studentList = new List<StudentDetails>();
        static List<DepartmentDetails> departmentList = new List<DepartmentDetails>();
        static List<AdmissionDetails> admissionList = new List<AdmissionDetails>();

        //Main Menu
        public static void MainMenu()
        {
            Console.WriteLine("Welcome to Syncfusion College of Engineering and Technology");
            string mainChoice = "yes";

            do
            {
                //Need to show the Main Menu Option
                Console.WriteLine("MainMenu\n1. Registration\n2. Login\n3. Departmentwise Seat Availability\n4. Exit");
                //Need to get an input from the user and validate.
                Console.WriteLine("Select an Option:");
                int mainOption = int.Parse(Console.ReadLine());
                //Need to create mainmenu Structure
                switch (mainOption)
                {
                    case 1:
                        {
                            Console.WriteLine("**********Student Registration************");
                            StudentRegistration();
                            break;
                        }
                    case 2:
                        {
                            Console.WriteLine("***********Student Login***********");
                            StudentLogin();
                            break;
                        }
                    case 3:
                        {
                            Console.WriteLine("**************Departmentwise Seat Availability***************");
                            DepartmentwiseSeatAvailability();
                            break;
                        }
                    case 4:
                        {
                            Console.WriteLine("Application Exited Successfully");
                            mainChoice = "no";
                            break;
                        }
                }
                //Need to Iterate until the option is exit.

            } while (mainChoice == "yes");
        }//MainMenu ends

        //Student Registration
        public static void StudentRegistration()
        {
            //Need to get Required Details
            Console.Write("Enter your Name:");
            string StudentName = Console.ReadLine();
            Console.Write("Enter your Father's Name:");
            string FatherName = Console.ReadLine();
            Console.Write("Enter your Date of Birth as Specified DD/MM/YYYY:");
            DateTime DOB = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", null);
            Console.Write("Enter your Gender (Male/Female/Transgender):");
            Gender gender = Enum.Parse<Gender>(Console.ReadLine(), true);
            Console.Write("Enter your Physics Mark:");
            int Physics = int.Parse(Console.ReadLine());
            Console.Write("Enter your Chemistry Mark:");
            int Chemistry = int.Parse(Console.ReadLine());
            Console.Write("Enter your Maths Mark:");
            int Maths = int.Parse(Console.ReadLine());

            //need to create an Object
            StudentDetails student = new StudentDetails(StudentName, FatherName, DOB, gender, Physics, Chemistry, Maths);
            studentList.Add(student);
            //Need to add in the List
            //Need to display Confirmation message and ID
            Console.WriteLine($"Registration Successfull. YourStudent ID is: {student.StudentID}");
        }
        // Student registartion Ends

        //Student Login
        public static void StudentLogin()
        {
            //Need to get ID Input
            Console.Write("Enter your Student ID:");
            string loginID = Console.ReadLine().ToUpper();
            //Validate by its  presence in the list.
            bool flag = true;
            foreach (StudentDetails student in studentList)
            {
                if (loginID.Equals(student.StudentID))
                {
                    flag = false;
                    //current user assigning to global variable
                    currentLoggedInStudent = student;
                    Console.WriteLine("Logged In Successfully");
                    //Need to call submenu
                    SubMenu();
                    break;

                }
            }
            //If not - Ivalid Input
            if (flag)
            {
                Console.WriteLine("Invalid ID");
            }



        }
        //Student Login Ends

        //SubMenu
        public static void SubMenu()
        {
            string subChoice = "yes";
            do
            {
                Console.WriteLine("***********SubMenu*************");
                //Need to show submenu options
                Console.WriteLine("Select an Option:\n1. Check Eligibility\n2. Show Details\n3. Take Admission\n4. Cancel Admission\n5. Admission Details\n6. Exit");
                //Getting user Option
                Console.Write("Enter your Option:");
                int subOption = int.Parse(Console.ReadLine());
                switch (subOption)
                {
                    case 1:
                        {
                            Console.WriteLine("**********Check Eligibility************");
                            CheckEligibility();
                            break;

                        }
                    case 2:
                        {
                            Console.WriteLine("**********Show Details************");
                            ShowDetails();
                            break;

                        }
                    case 3:
                        {
                            Console.WriteLine("**********Take Admission************");
                            TakeAdmission();
                            break;
                        }
                    case 4:
                        {
                            Console.WriteLine("**********Cancel Admission************");
                            CancelAdmission();
                            break;
                        }
                    case 5:
                        {
                            Console.WriteLine("**********Admission Details************");
                            AdmissionDetails();
                            break;
                        }
                    case 6:
                        {
                            Console.WriteLine("**********Exit************");
                            subChoice = "no";
                            break;
                        }
                }
                //Iterate till the option is exit.

            } while (subChoice == "yes");
        }


        //Check Eligibility
        public static void CheckEligibility()
        {
            //Get cutoff value as input
            Console.Write("Enter your CutOff value:");
            double cutOff = double.Parse(Console.ReadLine());
            //Check Eligible or Not
            if (currentLoggedInStudent.CheckEligibility(cutOff))
            {
                Console.WriteLine("Student is Eligible");

            }
            else
            {
                Console.WriteLine("Student is not Eligible");
            }


        }//Check Eligibility Ends

        //Show details
        public static void ShowDetails()
        {
            //Need to Show Current Student's Details
            Console.WriteLine("|Student ID|Student name|Father Name|DOB|Gender|Physics|Chemistry|Maths| ");
            Console.WriteLine($"|{currentLoggedInStudent.StudentID}|{currentLoggedInStudent.FatherName}|{currentLoggedInStudent.DOB}|{currentLoggedInStudent.Gender}|{currentLoggedInStudent.Physics}|{currentLoggedInStudent.Chemistry}|{currentLoggedInStudent.Maths}|");

        }

        //Take Admission
        public static void TakeAdmission()
        {
            //Need to show available Department Details
            DepartmentwiseSeatAvailability();
            //Ask Department ID from use
            Console.Write("Select a Department ID");
            string departmentID = Console.ReadLine();
            //Check if ID is Present or not
            bool flag = true;

            foreach (DepartmentDetails department in departmentList)
            {
                if (departmentID.Equals(department.DepartmentID))
                {
                    flag = false;

                    //Check if the student is eligible or not
                    if (currentLoggedInStudent.CheckEligibility(75.0))
                    {
                        // Check the seat Availability
                        if (department.NumberOfSeats > 0)
                        {
                            //Check student already taken a Admission
                            int count = 0;
                            foreach (AdmissionDetails admission in admissionList)
                            {
                                if (currentLoggedInStudent.StudentID.Equals(admission.AdmissionID) && admission.AdmissionStatus.Equals(AdmissionStatus.Admitted))
                                {
                                    count++;
                                }
                            }
                            if (count == 0)
                            {
                                //Create Admission Object 
                                AdmissionDetails admissionTaken = new AdmissionDetails(currentLoggedInStudent.StudentID, department.DepartmentID, DateTime.Now, AdmissionStatus.Admitted);
                                //Reduce seat Count
                                department.NumberOfSeats--;

                                //Add to the admissionList
                                admissionList.Add(admissionTaken);
                                //Display Admission successful Meassage
                                Console.WriteLine($"You have taken Admission successfully. Admission Id : {admissionTaken.AdmissionID}");

                            }
                            else
                            {
                                Console.WriteLine("You have already taken Admission");
                            }

                        }
                        else
                        {
                            Console.WriteLine("Seats are not Available");
                        }

                    }
                    else
                    {
                        Console.WriteLine("You are not eligible due to Low CutOff");
                    }



                }
            }
            if (flag)
            {
                Console.WriteLine("Invalid ID");
            }

        }// Take Admission Ends

        //Cancel Admission
        public static void CancelAdmission()
        {
            bool flag = true;
            foreach (AdmissionDetails admission in admissionList)
            {
                if (currentLoggedInStudent.StudentID.Equals(admission.StudentID) && admission.AdmissionStatus.Equals(AdmissionStatus.Admitted))
                {
                    //cancel the admission       
                    admission.AdmissionStatus = AdmissionStatus.Cancelled;
                    //return the seat to department
                    foreach (DepartmentDetails department in departmentList)
                    {
                        if (admission.DepartmentID.Equals(department.DepartmentID))
                        {
                            department.NumberOfSeats++;
                            break;
                        }

                    }
                    break;

                }

            }
            if (flag)
            {
                Console.WriteLine("You have no admission to cancel");
            }

        }//Cancel Admission Ends
         //Admission Details
        public static void AdmissionDetails()
        {
            //Need to show current admission details
            foreach (AdmissionDetails admission in admissionList)
            {
                if (currentLoggedInStudent.StudentID.Equals(admission.StudentID))
                {
                    Console.WriteLine($"|{admission.StudentID}|{admission.DepartmentID}|{admission.AdmissionID}|{admission.AdmissionDate}|{admission.AdmissionStatus}|");
                }
            }



        }// Admission Details Ends


        //Departmentwise Seat Availability
        public static void DepartmentwiseSeatAvailability()
        {
            //Need to show all Departmentdetails
            string line = "_______________________________________________";
            Console.WriteLine("|Department ID|Department Name|Number of Seats Available|");
            Console.WriteLine();
            foreach (DepartmentDetails department in departmentList)
            {
                Console.WriteLine($"|{department.DepartmentID,-12}|{department.DepartmentName,-14}|{department.NumberOfSeats,-13}|");
                Console.WriteLine(line);
            }


        }
        //Departmentwise Seat Availability Ends

        //Adding Default Data
        public static void AddDefaultData()
        {
            StudentDetails student1 = new StudentDetails("Ravichandran", "Ettapparajan", new DateTime(1999, 11, 11), Gender.Male, 95, 95, 95);
            StudentDetails student2 = new StudentDetails("Baskaran", "Sethurajan", new DateTime(1999, 11, 11), Gender.Male, 95, 95, 95);
            studentList.AddRange(new List<StudentDetails>() { student1, student2 });

            DepartmentDetails department1 = new DepartmentDetails("DID101", "EEE", 29);
            DepartmentDetails department2 = new DepartmentDetails("DID102", "CSE", 29);
            DepartmentDetails department3 = new DepartmentDetails("DID103", "MECH", 30);
            DepartmentDetails department4 = new DepartmentDetails("DID104", "ECE", 30);
            departmentList.AddRange(new List<DepartmentDetails>() { department1, department2, department3, department4 });

            AdmissionDetails admission1 = new AdmissionDetails("SF3001", "DID101", new DateTime(2022, 05, 11), AdmissionStatus.Admitted);
            AdmissionDetails admission2 = new AdmissionDetails(student2.StudentID, department2.DepartmentID, new DateTime(2022, 05, 12), AdmissionStatus.Admitted);
            admissionList.AddRange(new List<AdmissionDetails>() { admission1, admission2 });

        }

    }//show Details Ends


