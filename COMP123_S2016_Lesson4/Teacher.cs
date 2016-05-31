using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP123_S2016_Lesson4
{
    /**
     * <summary>
     * The Teacher is derived from the Person class 
     * </summary>
     * 
     * @class Teacher 
     * @extends Person
     */
    class Teacher : Person
    {
        // PRIVATE INSTANCE VARIABES +++++++++++++++++++++++++++++++

        private string _employeeID;

        // PUBLIC PROPERTIES +++++++++++++++++++++++++++++++++++++++

        public string EmployeeID 
        {
            get 
            {
                return this._employeeID;
            }
            set 
            {
                this._employeeID = value;
            }
        }

        // CONSTRUCTORS ++++++++++++++++++++++++++++++++++++++++++

        public Teacher(string name, int age, string employeeID) 
            : base(name, age)
        {
            this.EmployeeID = employeeID;
        }
    }
}
