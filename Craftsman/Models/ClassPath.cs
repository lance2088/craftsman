﻿namespace Craftsman.Models
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Text;

    public class ClassPath
    {
        public ClassPath(string solutionDirectory, string topPath, string className)
        {
            ClassDirectory = Path.Combine(solutionDirectory, topPath);
            FullClassPath = Path.Combine(ClassDirectory, className);
            ClassNamespace = topPath.Replace(Path.DirectorySeparatorChar, '.');
            SolutionDirectory = solutionDirectory;
        }

        /// <summary>
        /// This is the full path to the class, including the filename (e.g. C:\repo\Pets.cs)
        /// </summary>
        public string ClassDirectory { get; private set; }

        /// <summary>
        /// This is the full path to the class, including the filename (e.g. C:\repo\Pets.cs)
        /// </summary>
        public string FullClassPath { get; private set; }

        /// <summary>
        /// This is the converted namespace from the top path
        /// </summary>
        public string ClassNamespace { get; private set; }

        /// <summary>
        /// This is the solution directory mirrored back
        /// </summary>
        public string SolutionDirectory { get; set; }
    }
}
