﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DemoAPI.Models
{
    /// <summary>
    /// Represents one specific person
    /// </summary>
    public class Person
    {
        /// <summary>
        /// ID from SQL
        /// </summary>
        public int Id { get; set; } = 0;

        /// <summary>
        /// The users first name
        /// </summary>
        public string FirstName { get; set; } = "";

        /// <summary>
        /// The users last name duh
        /// </summary>
        public string LastName { get; set; } = "";

    }
}