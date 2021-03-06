﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Craftsman.Models
{
    /// <summary>
    /// This is the complete object representation of the API that we will read in from our input file and scaffold out the necessary files
    /// </summary>
    public class ApiTemplate
    {
        /// <summary>
        /// The name of the solution you want to build
        /// </summary>
        public string SolutionName { get; set; }

        /// <summary>
        /// The name of the solution you want to build
        /// </summary>
        public TemplateDbContext DbContext { get; set; } = new TemplateDbContext();

        /// <summary>
        /// Complete list of database entities
        /// </summary>
        public List<Entity> Entities { get; set; } = new List<Entity>();

        /// <summary>
        /// Layout of the swagger configuration for the API
        /// </summary>
        public SwaggerConfig SwaggerConfig { get; set; } = new SwaggerConfig();

        /// <summary>
        /// List of each environment to add into the API
        /// </summary>
        public List<ApiEnvironment> Environments { get; set; } = new List<ApiEnvironment>();

        /// <summary>
        /// Boolean that determines whether or not craftsman will do an initial git set up for this project.
        /// </summary>
        public bool AddGit { get; set; } = true;
    }
}
