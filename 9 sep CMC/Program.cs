using System.Data.SqlClient;

namespace _9_sep_CMC
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string db_path = "\"server=localhost;database=CMC;integrated security=true\"";
            start1:
            Console.WriteLine("Welcome to Bhavna Corp. CMC Admin Login Portal");

            Console.WriteLine("For Login press 1 and for exit press any other key");

            int A = int.Parse(Console.ReadLine());
            
            //Username Login if else condition
            if (A == 1)
            {
                start2:
                string un = "admin@123";
                string up = "admin@123";
                Console.WriteLine("Enter Username : ");
                string UN = Console.ReadLine();
                Console.WriteLine("Enter Password : ");
                string UP = Console.ReadLine();

                //SqlConnection con = new SqlConnection(db_path);

                if (UN==up && UP==up)
                {
                    Console.WriteLine("----------|| Login Sucess  ||----------\n\n\n");
                    Console.WriteLine("press : \n 1 for entering car parts room. \n2 for entering employee room\n\n\n");
                    int E = int.Parse(Console.ReadLine());
                    if (E==1)
                    {
                        startc:
                        Console.WriteLine("Press : \n1 for add new parts to the list\n2 for showing the all list\n3 to remove existing part from the list\n4 to chane the quantity of a specific part\n5 to to to main menu");
                        int C = int.Parse(Console.ReadLine());

                        switch (C)
                        {
                            //add part
                            case 1:
                                AddPart.add();
                                break;
                            //add part
                            case 2:

                                break;
                            //add part
                            case 3:

                                break;
                            //add part
                            case 4:

                                break;

                            default:
                                Console.WriteLine("Please Enter something valid");
                                goto startc;
                                break;
                        }
                        Console.Clear();
                        

                    }
                }
                else
                {
                    Console.WriteLine("Please Enter Something valid \n\n\n");
                    goto start2;
                }




            }
            else
            {
                Environment.ExitCode = 0;
            }

        }
    }
}