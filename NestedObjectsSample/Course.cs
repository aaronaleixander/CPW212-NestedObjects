using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NestedObjectsSample
{ 
    /// <summary>
    /// Represents a single course
    /// </summary>
    class Course
    {
        /// <summary>
        /// Create a course object with a empty student roster.
        /// </summary>
        public Course()
        {
            Roster = new List<Student>();
        }

        /// <summary>
        /// The unique course number
        /// ex. CPW 212
        /// </summary>
        public string CourseNumber { get; set; }

        /// <summary>
        /// Official course title
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// Number of credits received upon successful completion of class.
        /// </summary>
        public byte NumberOfCredits { get; set; }

        /// <summary>
        /// The official course catalog description of the course.
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Students currently enrolled in course
        /// </summary>
        public List<Student> Roster { get; set; }

    }
}
