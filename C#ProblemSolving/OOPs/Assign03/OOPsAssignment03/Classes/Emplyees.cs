using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OOPsAssignment03.Enums.Quation1;

namespace OOPsAssignment03.Classes
{
    internal class Emplyees
    {
        #region Properities
        private int Id { get; set; }
        private string? Name { get; set; }
        private string? gender { get; set; }
        private SecurityLevel? SecurityLevel { get; set; }
        private decimal Salary { get; set; }
        public HireDate HireDate { get; set; }  

        public string Gender {
            get { return gender!; } 
            set { 
                if(value == "M" || value == "F")
                {
                    gender = value;
                }else
                {
                    throw new ArgumentException("Gender can only be M | F");
                }
            } 
        }
        #endregion

        #region Constructor
        public Emplyees(int id, string? name, string? gender, SecurityLevel? securityLevel, decimal salary, HireDate hireDate)
        {
            Id = id;
            Name = name;
            this.gender = gender;
            SecurityLevel = securityLevel;
            Salary = salary;
            HireDate = hireDate;
        }

        #endregion

        #region Methods
        public override string ToString()
        {
            return $"Employee Name {Name}\nEmployee Id {Id}\n Employee Gender {gender}\n Employee Security Level {SecurityLevel}\n Employee Salary {Salary:c}\n Employee Hire Date {HireDate}";
        }
        #endregion

    }
}
