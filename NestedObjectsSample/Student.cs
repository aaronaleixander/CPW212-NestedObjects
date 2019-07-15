﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NestedObjectsSample
{
    /// <summary>
    /// Represents an individual student.
    /// </summary>
    class Student
    {
        private string _fullName;
        private string _emailAddress;

        public Student(string fullName)
        {
            FullName = fullName;
        }

        /// <summary>
        /// Legal First and Last Name.
        /// i.e. J Doe
        /// </summary>
        public string FullName
        {
            get { return _fullName; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Full Name cannot be null or whitespace.");
                }
                _fullName = value;

            }
        }

        /// <summary>
        /// The students school provided email address.
        /// </summary>
        public string EmailAddress
        {
            get { return _emailAddress; }
            set
            {
                // REGEX for more strict validation
                if(value.EndsWith("@student.cptc.edu"))
                {
                    _emailAddress = value;
                }
                else
                {
                    throw new ArgumentException("Email must end with @student.cptc.edu");
                }
                
            }
        }

        /// <summary>
        /// Students mailing address.
        /// </summary>
        public string HomeAddress { get; set; }

        /// <summary>
        /// The students home phone number.
        /// </summary>
        public string Phone { get; set; }

    }
}
