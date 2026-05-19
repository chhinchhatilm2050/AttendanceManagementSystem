using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ValidationInfos
{
    public class InfoValidation
    {
        private string firstName;
        private string lastName;
        private string email;
        private string phoneNumber;

        public string FirstName
        {
            get { return firstName; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                  
                    MessageBox.Show("First Name is required!");

                }
                else if (!Regex.IsMatch(value, @"^[a-zA-Z]+$"))
                {
                    
                    MessageBox.Show("First Name only allow English letter");
                    firstName = "";
                }
                else
                {
                    firstName = value;
                }
            }
        }

        public string LastName
        {
            get { return lastName; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    MessageBox.Show("Last Name is required");

                }
                else if (!Regex.IsMatch(value, @"^[a-zA-Z]+$"))
                {
                    MessageBox.Show("Last Name only allow English letter");
                    lastName = "";
                }
                else
                {
                    lastName = value;
                }
            }
        }

        public string Email
        {
            get { return email; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {

                    MessageBox.Show("Email is required!");

                }
                else if (!Regex.IsMatch(value, @"^[^@\s]+@[^@\s]+\.[^@\s]+$"))
                {
                    MessageBox.Show("Invalid Email");
                    email = "";
                }
                else
                {
                    email = value;
                }
            }
        }

        public string PhoneNumber
        {
            get { return phoneNumber; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    MessageBox.Show("Phonenumber is required!");

                }
                else if (!Regex.IsMatch(value, @"^[0-9]{8,15}$"))
                {
                    MessageBox.Show("Phonenumber must be 8-15 digits");
                    phoneNumber = "";
                }
                else
                {
                    phoneNumber = value;
                }
            }
        }
    }
    internal class Program
    {
        //static void Main(string[] args)
        //{
        //    try
        //    {

        //        InfoValidation infoValidation = new InfoValidation();
        //        Console.Write("Enter First Name:");
        //        infoValidation.FirstName = Console.ReadLine();
        //        Console.Write("Enter Last Name:");
        //        infoValidation.LastName = Console.ReadLine();
        //        Console.Write("Enter Email:");
        //        infoValidation.Email = Console.ReadLine();
        //        Console.Write("Enter Phonenumber:");
        //        infoValidation.PhoneNumber = Console.ReadLine();

        //        Console.WriteLine("==============Information==============");
        //        Console.WriteLine($"First Name  : {infoValidation.FirstName}");
        //        Console.WriteLine($"Last Nmae   : {infoValidation.LastName}");
        //        Console.WriteLine($"Email       : {infoValidation.Email}");
        //        Console.WriteLine($"Phonenumber : {infoValidation.PhoneNumber}");

        //    }
        //    catch (Exception error)
        //    {
        //        Console.WriteLine("Validation Error: " + error.Message);

        //    }

        //    Console.ReadKey();

        //}
    }

}

