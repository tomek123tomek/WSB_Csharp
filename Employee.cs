using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wsb_lab1
{
    class Employee
    {
        public string firstName { get; set; }
        public string lastName { get; set; }
        string login { get; set; }
        private string password { get; set; }
        public decimal salary { get; private set; }
        //public int age { get; set; }


        public Employee(string _login, string _password, decimal _salary)
        {
            login = _login ;
            password = _password ;
            salary = _salary ;
        }
        

         // tym sposobem wyrzuca mi błąd podczas uruchomienia programy stackoverflowexception :/,
         //     public int age { get; set; } <-- tym sposobem jest wszystko Ok
        public int age
        {
            get
            {
                return age;
            }
            set
            {
                age = value;
            }
        }
        


        public enum Education
        {
            Primary,
            Secondary,
            Higher
        }

        public Education ItsEducation { get; set; }

        /*
        public bool isAdult()
        {
            if(age >= 18)
            {
                return true;
            } else
            {
                return false;
            }
        }
        */

        public bool isAdult()
        {
            return (age >= 18) ? true: false;
        }

        public bool CheckCredentials(string login, string password)
        {
            if(login == this.login && password == this.password)
            {
                return true;
            } else {
                return false;
            }
            
        }


        public string FullName() => $"{ firstName } { lastName }";




    }
}
