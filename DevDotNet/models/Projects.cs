using System;
using System.ComponentModel.DataAnnotations;

namespace DevDotNet.models
{
    public class Projects
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public string Stargazes { get; set; }
        public string Whatches { get; set; }
    }
}