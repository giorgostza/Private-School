using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BRIEF_PART_A
{
    class Program
    {


        class Student
        {
            public List<Assignment> lista_Assignments = new List<Assignment>();


            public string FirstName { get; set; }
            public string LastName { get; set; }
            public string DateOfBirth { get; set; }
            public string Fees { get; set; }

            public bool prop { get; set; }

            public void Addassignment(Assignment assignment)
            {
                lista_Assignments.Add(assignment);
            }


            public override string ToString()
            {
                return " Ονομα: " + FirstName + "  ,   Επιθετο: " + LastName + "  ,   Ημερομηνια Γεννησης: " + DateOfBirth + "  ,   Διδακτρα: " + Fees;
            }

        }




        class Course
        {
            public List<Student> lista_Students = new List<Student>();

            public List<Teacher> lista_Teachers = new List<Teacher>();

            public List<Assignment> lista_Assignments = new List<Assignment>();


            public string Title { get; set; }
            public string Stream { get; set; }
            public string Type { get; set; }
            public string Startdate { get; set; }
            public string Enddate { get; set; }




            public void Addstudent(Student student)
            {
                lista_Students.Add(student);
            }

            public void Addteacher(Teacher teacher)
            {
                lista_Teachers.Add(teacher);
            }

            public void Addassignment(Assignment assignment)
            {
                lista_Assignments.Add(assignment);
            }


            public override string ToString()
            {
                return "Τιτλος: " + Title + " ,   Κλαδος: " + Stream + " ,  Τυπος: " + Type + " ,  Ημερομηνια εναρξης: " + Startdate + " ,  Ημερονηνια ληξης: " + Enddate;
            }

        }





        class Teacher

        {
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public string Subject { get; set; }



            public override string ToString()
            {
                return "Ονομα: " + FirstName + "  , Επονυμο: " + LastName + "  , Αντικειμενο : " + Subject;
            }



        }




        class Assignment
        {
            public string Title { get; set; }
            public string Description { get; set; }
            public string SubDateTime { get; set; }
            public string OralMark { get; set; }
            public string TotalMark { get; set; }


            public override string ToString()
            {
                return " Τιτλος: " + Title + ",  Περιγραφη : " + Description + ",  Ημερομηνια Υποβολης : " + SubDateTime + ",  Προφορικη Βαθμολογια : " + OralMark + ",  Συνολικη Βαθμολογια : " + TotalMark;
            }

        }




        static void Main(string[] args)
        {

            int arithmos1;                //     Μετρητης αριθμων μαθητων
            int arithmos2;                //     Μετρητης αριθμων καθηγητων
            int arithmos3;                //     Μετρητης αριθμων εργασιων
            int arithmos4;                //     Μετρητης αριθμων μαθηματων




            List<Student> lista_me_olous_tous_mathites = new List<Student>();

            Console.WriteLine("Choose an option:");
            Console.WriteLine(" ");
            Console.WriteLine("Αν θες να μπουν by default τα δεδομενα για τους ΜΑΘΗΤΕΣ παρακαλω πατησε (1) :");
            Console.WriteLine(" ");
            Console.WriteLine("Αν θες να εκχωρησεις δεδομενα για τους ΜΑΘΗΤΕΣ παρακαλω πατα  οποιοδηποτε νουμερο  εκτος του (1)  :");

            //Στη λογικη αυτη που εχω διαλεξει ο χρηστης πρεπει να πατησει νουμερο και οχι γραμμα καθως απο κατω παιρνω αυτο που βαζει ο χρηστης και το μετατρεπω σε νουμερο.

            int param1 = int.Parse(Console.ReadLine());

            if (param1 == 1)
            {


                Console.Clear();
                lista_me_olous_tous_mathites = new List<Student>()                                                         // Λιστα με τους 20 μαθητες by default
                {
                  new Student{ FirstName="onoma1",LastName="epitheto1",DateOfBirth="date1",Fees= "2500"},
                  new Student{ FirstName="onoma2",LastName="epitheto2",DateOfBirth="date2",Fees="1900"},
                  new Student{ FirstName="onoma3",LastName="epitheto3",DateOfBirth="date3",Fees="3000"},
                  new Student{ FirstName="onoma4",LastName="epitheto4",DateOfBirth="date4",Fees="1587"},
                  new Student{ FirstName="onoma5",LastName="epitheto5",DateOfBirth="date5",Fees="2598"},
                  new Student{ FirstName="onoma6",LastName="epitheto6",DateOfBirth="date6",Fees="100"},
                  new Student{ FirstName="onoma7",LastName="epitheto7",DateOfBirth="date7",Fees="2658"},
                  new Student{ FirstName="onoma8",LastName="epitheto8",DateOfBirth="date8",Fees="25"},
                  new Student{ FirstName="onoma9",LastName="epitheto9",DateOfBirth="date9",Fees="25"},
                  new Student{ FirstName="onoma10",LastName="epitheto10",DateOfBirth="date10",Fees="1564"},
                  new Student{ FirstName="onoma11",LastName="epitheto11",DateOfBirth="date11",Fees="1453"},
                  new Student{ FirstName="onoma12",LastName="epitheto12",DateOfBirth="date12",Fees="1957"},
                  new Student{ FirstName="onoma13",LastName="epitheto13",DateOfBirth="date13",Fees="1652"},
                  new Student{ FirstName="onoma14",LastName="epitheto14",DateOfBirth="date14",Fees="2654"},
                  new Student{ FirstName="onoma15",LastName="epitheto15",DateOfBirth="date15",Fees="654"},
                  new Student{ FirstName="onoma16",LastName="epitheto16",DateOfBirth="date16",Fees="2500"},
                  new Student{ FirstName="onoma17",LastName="epitheto17",DateOfBirth="date17",Fees="555"},
                  new Student{ FirstName="onoma18",LastName="epitheto18",DateOfBirth="date18",Fees="6954"},
                  new Student{ FirstName="onoma19",LastName="epitheto19",DateOfBirth="date19",Fees="7865"},
                  new Student{ FirstName="onoma20",LastName="epitheto20",DateOfBirth="date20",Fees="2365"}

                };

                Console.WriteLine("Οι 20  ΜΑΘΗΤΕΣ που εχεις καταχωρησει πως θα σπουδασουν σε αυτο το κυκλο σπουδων ειναι:");
                Console.WriteLine(" ");

                arithmos1 = 20;

                for (int i = 0; i < 20; i++)                                                 // Εκτυπωνει ολη τη λιστα με τους 20 μαθητες
                {
                    Console.WriteLine(" ");
                    Console.WriteLine("{0}", lista_me_olous_tous_mathites[i]);
                }
                Console.ReadKey();
                Console.Clear();


            }
            else                                                                              // Η επιλογη να εκχωρησει ο χρηστης τα δεδομενα για τους μαθητες
            {
                Console.Clear();
                lista_me_olous_tous_mathites = new List<Student>();

                Console.WriteLine("εκχωρισε ΜΑΘΗΤΗ");
                arithmos1 = 0;
                bool b = true;


                while (b == true)
                {
                    Console.Clear();
                    Console.WriteLine("Δωσε ονομα {0}ου μαθητη :", arithmos1 + 1);
                    string f = Console.ReadLine();
                    Console.WriteLine("Δωσε επιθετο {0} μαθητη:", arithmos1 + 1);
                    string l = Console.ReadLine();
                    Console.WriteLine("Δωσε ημερομηνια γεννησης:");
                    string d = Console.ReadLine();
                    Console.WriteLine("Δωσε ποσο διδακτρων:");
                    string fees = (Console.ReadLine());
                    lista_me_olous_tous_mathites.Add(new Student { FirstName = f, LastName = l, DateOfBirth = d, Fees = fees });

                    arithmos1++;

                    Console.WriteLine("Αν θες να συνεχισεις να κανεις εκχωρηση πατα (1) ");

                    int a = int.Parse(Console.ReadLine());

                    b = false;
                    if (a == 1)
                    {
                        b = true;
                    }

                }
                Console.Clear();

                Console.WriteLine("Οι ΜΑΘΗΤΕΣ που εχεις καταχωρησει πως θα σπουδασουν σε αυτο το κυκλο σπουδων ειναι:");

                for (int i = 0; i < arithmos1; i++)                                                                           // Εκτυπωνει τη λιστα με τους μαθητες που εδωσε ο χρηστης
                {
                    Console.WriteLine(" ");
                    Console.WriteLine("{0}", lista_me_olous_tous_mathites[i]);
                }
                Console.ReadKey();
                Console.Clear();

            }


            // Η ιδια λογικη και σχεδον ο ιδιος κωδικας γινεται και για τους καθηγητες ,  τις εργασιες   , τα μαθηματα


            List<Teacher> lista_me_olous_tous_kathigites = new List<Teacher>();


            Console.WriteLine("Choose an option:");
            Console.WriteLine(" ");
            Console.WriteLine("Αν θες να μπουν by default τα δεδομενα για ολους τους ΚΑΘΗΓΗΤΕΣ παρακαλω πατησε (1) :");
            Console.WriteLine(" ");
            Console.WriteLine("Αν θες να εκχωρησεις δεδομενα για ολους τους ΚΑΘΗΓΗΤΕΣ παρακαλω πατα (0)  :");

            param1 = 0;
            param1 = int.Parse(Console.ReadLine());

            if (param1 == 1)
            {


                Console.Clear();
                lista_me_olous_tous_kathigites = new List<Teacher>()
                {
                  new Teacher{FirstName="FirstName1",LastName="LastName1",Subject="Subject1"},
                  new Teacher{ FirstName="FirstName2",LastName="LastName2",Subject="Subject2"},
                  new Teacher{ FirstName="FirstName3",LastName="LastName3",Subject="Subject3"},
                  new Teacher{ FirstName="FirstName4",LastName="LastName4",Subject="Subject4"},
                  new Teacher{ FirstName="FirstName5",LastName="LastName5",Subject="Subject5"},

                };

                Console.WriteLine("Τα 5 ΚΑΘΗΓΗΤΕΣ που ανηκουν σε αυτο το κυκλο σπουδων ειναι:");
                Console.WriteLine(" ");

                arithmos2 = 5;

                for (int i = 0; i < 5; i++)
                {
                    Console.WriteLine(" ");
                    Console.WriteLine("{0}", lista_me_olous_tous_kathigites[i]);
                }
                Console.ReadKey();
                Console.Clear();


            }
            else
            {

                Console.Clear();
                lista_me_olous_tous_kathigites = new List<Teacher>();


                Console.WriteLine("Εκχωρισε ΚΑΘΗΓΗΤΗ ");
                arithmos2 = 0;
                bool b = true;

                while (b == true)
                {
                    Console.Clear();
                    Console.WriteLine("Δωσε ονομα {0}ου καθηγητη :", arithmos2 + 1);
                    string f = Console.ReadLine();
                    Console.WriteLine("Δωσε επιθετο {0}ου καθηγητη:", arithmos2 + 1);
                    string l = Console.ReadLine();
                    Console.WriteLine("Δωσε αντικειμενο καθηγητη:");
                    string d = Console.ReadLine();

                    lista_me_olous_tous_kathigites.Add(new Teacher { FirstName = f, LastName = l, Subject = d });

                    arithmos2++;

                    Console.WriteLine("Αν θες να συνεχισεις να κανεις εκχωρηση πατα (1) ");

                    int a = int.Parse(Console.ReadLine());

                    b = false;
                    if (a == 1)
                    {
                        b = true;
                    }

                }
                Console.Clear();
                Console.WriteLine("Οι ΚΑΘΗΓΗΤΕΣ που εχεις καταχωρησει πως θα σπουδασουν σε αυτο το κυκλο σπουδων ειναι:");

                for (int i = 0; i < arithmos2; i++)
                {
                    Console.WriteLine(" ");
                    Console.WriteLine("{0}", lista_me_olous_tous_kathigites[i]);
                }
                Console.ReadKey();
                Console.Clear();

            }





            List<Assignment> lista_me_ola_ta_assignments = new List<Assignment>();


            Console.WriteLine("Choose an option:");
            Console.WriteLine(" ");
            Console.WriteLine("Αν θες να μπουν by default τα δεδομενα για ολες τις ΕΡΓΑΣΙΕΣ παρακαλω πατησε (1) :");
            Console.WriteLine(" ");
            Console.WriteLine("Αν θες να εκχωρησεις δεδομενα για  για ολες τις ΕΡΓΑΣΙΕΣ παρακαλω πατα (0)  :");


            param1 = 0;
            param1 = int.Parse(Console.ReadLine());


            if (param1 == 1)
            {


                Console.Clear();
                lista_me_ola_ta_assignments = new List<Assignment>()
                {
                  new Assignment{Title="Title1",Description="Description1",SubDateTime="SubDateTime1", OralMark="OralMark1",TotalMark="TotalMark1"},
                  new Assignment{ Title="Title2",Description="Description2",SubDateTime="SubDateTime2", OralMark="OralMark2",TotalMark="TotalMark2"},
                  new Assignment{ Title="Title3",Description="Description3",SubDateTime="SubDateTime3", OralMark="OralMark3",TotalMark="TotalMark3"},
                  new Assignment{ Title="Title4",Description="Description4",SubDateTime="SubDateTime4", OralMark="OralMark4",TotalMark="TotalMark4"},
                  new Assignment{ Title="Title5",Description="Description5",SubDateTime="SubDateTime5", OralMark="OralMark5",TotalMark="TotalMark5"},

                };

                Console.WriteLine("Οι 5 ΕΡΓΑΣΙΕΣ που ανηκουν σε αυτο το κυκλο σπουδων ειναι:");
                Console.WriteLine(" ");

                arithmos3 = 5;

                for (int i = 0; i < 5; i++)
                {
                    Console.WriteLine(" ");
                    Console.WriteLine("{0}", lista_me_ola_ta_assignments[i]);
                }
                Console.ReadKey();
                Console.Clear();

            }
            else
            {
                Console.Clear();
                Console.Clear();
                lista_me_ola_ta_assignments = new List<Assignment>();

                Console.WriteLine("Εκχωρισε ΕΡΓΑΣΙΑ ");
                arithmos3 = 0;
                bool b = true;


                while (b == true)
                {
                    Console.Clear();
                    Console.WriteLine("Δωσε τιτλο {0}ης εργασιας :", arithmos3 + 1);
                    string f = Console.ReadLine();
                    Console.WriteLine("Δωσε περιγραφη {0}ης εργασιας:", arithmos3 + 1);
                    string l = Console.ReadLine();
                    Console.WriteLine("Δωσε ημερομηνια υποβολης:");
                    string d = Console.ReadLine();
                    Console.WriteLine("Δωσε προφορικες μοναδες:");
                    string p = Console.ReadLine();
                    Console.WriteLine("Δωσε συνολικες μοναδες:");
                    string z = Console.ReadLine();

                    lista_me_ola_ta_assignments.Add(new Assignment { Title = f, Description = l, SubDateTime = d, OralMark = p, TotalMark = z });

                    arithmos3++;

                    Console.WriteLine("Αν θες να συνεχισεις να κανεις εκχωρηση πατα (1) ");

                    int a = int.Parse(Console.ReadLine());

                    b = false;
                    if (a == 1)
                    {
                        b = true;
                    }

                }
                Console.Clear();
                Console.WriteLine("Οι ΕΡΓΑΣΙΕΣ που εχεις δηλωσει πως θα υπαρχουν σε αυτο το κυκλο σπουδων ειναι:");

                for (int i = 0; i < arithmos3; i++)
                {
                    Console.WriteLine(" ");
                    Console.WriteLine("{0}", lista_me_ola_ta_assignments[i]);
                }
                Console.ReadKey();
                Console.Clear();

            }




            List<Course> lista_me_ola_ta_courses = new List<Course>();


            Console.WriteLine("Choose an option:");
            Console.WriteLine(" ");
            Console.WriteLine("Αν θες να μπουν by default τα δεδομενα για τα ΜΑΘΗΜΑΤΑ παρακαλω πατησε (1) :");
            Console.WriteLine(" ");
            Console.WriteLine("Αν θες να εκχωρησεις δεδομενα για τα ΜΑΘΗΜΑΤΑ παρακαλω πατα (0)  :");

            param1 = 0;
            param1 = int.Parse(Console.ReadLine());

            if (param1 == 1)
            {


                Console.Clear();
                lista_me_ola_ta_courses = new List<Course>()
                {
                  new Course{Title="Title1",Stream="Stream1",Type="Type1",Startdate= "13.2",Enddate=" 13.6 "},
                  new Course{ Title="Title2",Stream="Stream2",Type="Type2",Startdate="14.2",Enddate=" 14.6"},
                  new Course{ Title="Title3",Stream="Stream3",Type="Type3",Startdate="15.2",Enddate=" 15.6"},
                  new Course{ Title="Title4",Stream="Stream4",Type="Type4",Startdate="16.2",Enddate=" 17.6"},
                  new Course{ Title="Title5",Stream="Stream5",Type="Type5",Startdate="17.2",Enddate=" 18.6"},

                };

                Console.WriteLine("Τα 5 ΜΑΘΗΜΑΤΑ που θα πραγματοποιηθουν σε αυτο το κυκλο σπουδων ειναι:");
                Console.WriteLine(" ");

                arithmos4 = 5;

                for (int i = 0; i < 5; i++)
                {
                    Console.WriteLine(" ");
                    Console.WriteLine("{0}", lista_me_ola_ta_courses[i]);
                }
                Console.ReadKey();
                Console.Clear();


            }
            else
            {
                Console.Clear();
                Console.Clear();
                lista_me_ola_ta_courses = new List<Course>();

                Console.WriteLine("Εκχωρισε ΜΑΘΗΜΑ ");
                arithmos4 = 0;
                bool b = true;


                while (b == true)
                {
                    Console.Clear();
                    Console.WriteLine("Δωσε τιτλο {0}ου μαθηματος :", arithmos4 + 1);
                    string f = Console.ReadLine();
                    Console.WriteLine("Δωσε Stream {0}ου μαθηματος:", arithmos4 + 1);
                    string l = Console.ReadLine();
                    Console.WriteLine("Δωσε Type :");
                    string d = Console.ReadLine();
                    Console.WriteLine("Δωσε ημερομηνια εναρξης:");
                    string p = Console.ReadLine();
                    Console.WriteLine("Δωσε ημερομηνια ληξης:");
                    string z = Console.ReadLine();

                    lista_me_ola_ta_courses.Add(new Course { Title = f, Stream = l, Type = d, Startdate = p, Enddate = z });

                    arithmos4++;

                    Console.WriteLine("Αν θες να συνεχισεις να κανεις εκχωρηση πατα (1) ");

                    int a = int.Parse(Console.ReadLine());

                    b = false;
                    if (a == 1)
                    {
                        b = true;
                    }

                }
                Console.Clear();
                Console.WriteLine("Τα ΜΑΘΗΜΑΤΑ  που εχεις δηλωσει πως θα υπαρχουν σε αυτο το κυκλο σπουδων ειναι:");

                for (int i = 0; i < arithmos4; i++)
                {
                    Console.WriteLine(" ");
                    Console.WriteLine("{0}", lista_me_ola_ta_courses[i]);
                }
                Console.ReadKey();
                Console.Clear();

            }

            //           ----------------------------ΤΕΛΟΣ ΜΕ ΤΗΝ ΕΚΧΩΡΗΣΗ ΔΕΔΟΜΕΝΩΝ ΣΤΙς ΠΙΣΤΕΣ----------------------------



            List<Student> lista_me_mathites_pou_parakolouthoun_parapano_apo_ena_mathima = new List<Student>();
            int metritis_mathiton_parapano_apo_ena_mathima = 0;


            for (int i = 0; i < arithmos4; i++)
            {



                int metritis_mathiton_sto_tmima = 0;
                Console.WriteLine("Για το μαθημα   {0} :", lista_me_ola_ta_courses[i].Title);

                for (int j = 0; j < arithmos1; j++)
                {
                    int epilogi;
                    Console.WriteLine("Ο ΜΑΘΗΤΗΣ  {0}_{1} εχει διαλεξει αυτο το μαθημα ? ", lista_me_olous_tous_mathites[j].FirstName, lista_me_olous_tous_mathites[j].LastName);
                    Console.WriteLine("Αν ΝΑΙ πατα (1) ");
                    epilogi = int.Parse(Console.ReadLine());

                    if (epilogi == 1)
                    {
                        lista_me_ola_ta_courses[i].Addstudent(lista_me_olous_tous_mathites[j]);

                        metritis_mathiton_sto_tmima++;


                        lista_me_mathites_pou_parakolouthoun_parapano_apo_ena_mathima.Add(lista_me_olous_tous_mathites[j]);

                        metritis_mathiton_parapano_apo_ena_mathima++;


                    }

                }
                Console.ReadKey();
                Console.Clear();

                Console.WriteLine(" Το μαθημα {0} εχει τους εξης ΜΑΘΗΤΕΣ :", lista_me_ola_ta_courses[i].Title);
                Console.WriteLine(" ");


                for (int j = 0; j < metritis_mathiton_sto_tmima; j++)
                {
                    Console.WriteLine(lista_me_ola_ta_courses[i].lista_Students[j]);

                }
                Console.ReadKey();
                Console.Clear();




                int metritis_kathigiton_sto_tmima = 0;
                Console.WriteLine("Για το μαθημα   {0}", lista_me_ola_ta_courses[i].Title);

                for (int j = 0; j < arithmos2; j++)
                {
                    int epilogi;
                    Console.WriteLine("Ο ΚΑΘΗΓΗΤΗΣ  {0}_{1} εχει διαλεξει αυτο το μαθημα ? ", lista_me_olous_tous_kathigites[j].FirstName, lista_me_olous_tous_mathites[j].LastName);
                    Console.WriteLine("Αν ΝΑΙ πατα (1) ");
                    epilogi = int.Parse(Console.ReadLine());

                    if (epilogi == 1)
                    {
                        lista_me_ola_ta_courses[i].Addteacher(lista_me_olous_tous_kathigites[j]);

                        metritis_kathigiton_sto_tmima++;
                    }

                }

                Console.ReadKey();
                Console.Clear();

                Console.WriteLine(" Το μαθημα {0} εχει τους εξης ΚΑΘΗΓΗΤΕΣ :", lista_me_ola_ta_courses[i].Title);
                Console.WriteLine(" ");


                for (int j = 0; j < metritis_kathigiton_sto_tmima; j++)
                {
                    Console.WriteLine(lista_me_ola_ta_courses[i].lista_Teachers[j]);

                }
                Console.ReadKey();
                Console.Clear();

                //+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++




                int metritis_ergasion_sto_tmima = 0;
                Console.WriteLine("Για το μαθημα   {0} :", lista_me_ola_ta_courses[i].Title);

                for (int j = 0; j < arithmos3; j++)
                {
                    int epilogi;
                    Console.WriteLine("Η ΕΡΓΑΣΙΑ  {0} υπαρχει σε αυτο το μαθημα ? ", lista_me_ola_ta_assignments[j].Title);
                    Console.WriteLine("Αν ΝΑΙ πατα (1) ");
                    epilogi = int.Parse(Console.ReadLine());

                    if (epilogi == 1)
                    {
                        lista_me_ola_ta_courses[i].Addassignment(lista_me_ola_ta_assignments[j]);

                        metritis_ergasion_sto_tmima++;
                    }

                }
                Console.ReadKey();
                Console.Clear();

                Console.WriteLine(" Το μαθημα {0} εχει τις εξης ΕΡΓΑΣΙΕΣ :", lista_me_ola_ta_courses[i].Title);
                Console.WriteLine(" ");


                for (int j = 0; j < metritis_ergasion_sto_tmima; j++)
                {
                    Console.WriteLine(lista_me_ola_ta_courses[i].lista_Assignments[j]);

                }
                Console.ReadKey();
                Console.Clear();


            }

            //===========================================================


            for (int i = 0; i < arithmos1; i++)
            {

                int metritis_ergasion_ana_mathiti = 0;
                Console.WriteLine("Για τον μαθητη   {0}_{1} :", lista_me_olous_tous_mathites[i].FirstName, lista_me_olous_tous_mathites[i].LastName);


                for (int j = 0; j < arithmos3; j++)
                {
                    int epilogi;
                    Console.WriteLine("Ο ΜΑΘΗΤΗΣ  εχει διαλεξει την ΕΡΓΑΣΙΑ  με τιτλο {0} και περιγραφη {1}   ? ", lista_me_ola_ta_assignments[j].Title, lista_me_ola_ta_assignments[j].Description);
                    Console.WriteLine("Αν ΝΑΙ πατα (1) ");
                    epilogi = int.Parse(Console.ReadLine());

                    if (epilogi == 1)
                    {
                        lista_me_olous_tous_mathites[i].Addassignment(lista_me_ola_ta_assignments[j]);

                        metritis_ergasion_ana_mathiti++;
                    }

                }
                Console.ReadKey();
                Console.Clear();

                Console.WriteLine(" Ο ΜΑΘΗΤΗΣ {0}_{1} εχει τις εξης ΕΡΓΑΣΙΕΣ :", lista_me_olous_tous_mathites[i].FirstName, lista_me_olous_tous_mathites[i].LastName);
                Console.WriteLine(" ");


                for (int j = 0; j < metritis_ergasion_ana_mathiti; j++)
                {
                    Console.WriteLine(lista_me_olous_tous_mathites[i].lista_Assignments[j]);


                }
                Console.ReadKey();
                Console.Clear();

            }


            bool result1;
            bool result2;
            int k;

            Console.WriteLine("Οι μαθητες οι οποιοι παρακολουθουν παραπανω απο ενα μαθημα ειναι :");

            for (int i = 0; i < arithmos1; i++)
            {
                k = 0;
                result1 = false;
                result2 = false;

                for (int j = 0; j < metritis_mathiton_parapano_apo_ena_mathima; j++)
                {

                    result1 = lista_me_olous_tous_mathites[i].FirstName.Equals(lista_me_mathites_pou_parakolouthoun_parapano_apo_ena_mathima[j].FirstName);
                    result2 = lista_me_olous_tous_mathites[i].LastName.Equals(lista_me_mathites_pou_parakolouthoun_parapano_apo_ena_mathima[j].LastName);


                    if (result1 == true && result2 == true)  // ΔΕΝ ΣΥΓΚΡΙΝΩ ΑΛΛΕΣ ΠΑΡΑΜΕΤΡΟΥΣ ,ΘΕΩΡΩ ΠΩΣ ΜΕΧΡΙ ΙΔΙΟ ΟΝΟΜΑ ΚΑΙ ΕΠΙΘΕΤΟ ΜΠΟΡΕΙ ΝΑ ΥΠΑΡΧΕΙ 
                    {
                        k++;
                    }

                    if (k == 2)
                    {
                        lista_me_olous_tous_mathites[i].prop = true;
                    }



                }

                if (lista_me_olous_tous_mathites[i].prop == true)
                {
                    Console.WriteLine(lista_me_olous_tous_mathites[i]);

                }
                Console.ReadKey();

            }


           






        }
    }
}
