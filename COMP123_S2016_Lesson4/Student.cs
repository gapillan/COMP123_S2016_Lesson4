using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP123_S2016_Lesson4
{ 
    /**
     *<summary>
     *This is the Student class. IT is derived from the Person class 
     *</summary>
     *
     * @class Student 
     * @extends Person
     */
    class Student : Person
    {
        // PRIVATE INSTANCE VARIABLES +++++++++++++++++++++++++++++++++++++++++
        
        private string _studentID;

        // PUBLIC PROPERTIES ++++++++++++++++++++++++++++++++++++++++++++++++++

        /**
         * <summary>
         * This property, StudentID, includes a getter and setter for the private 
         * instance variable _studentID
         * </summary> 
         */
        public string StudentID
        {
            get 
            {
                return this._studentID;
            }
            set 
            {
                this._studentID = value; 
            }
        }

        // CONSTRUCTORS ++++++++++++++++++++++++++++++++++++++++++++++++++++++

        /**
         * <summary> 
         * This constructor takes three parameters: name, age and studentID
         * Student Class
         * </summary> 
         * 
         * @constructor Student 
         * @extends Person
         * @param {string} name 
         * @param {int} age 
         * @param {string} studentID
         */
        public Student(string name, int age, string studentID):base(name, age)
        {
        }
    }
}
