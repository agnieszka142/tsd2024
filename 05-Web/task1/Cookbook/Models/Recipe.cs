using System;
using System.Collections.Generic;

namespace Cookbook.Models
{
    public class Recipe
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public TimeSpan Time { get; set; }
        public string Difficulty { get; set; }
        public int NumberOfLikes { get; set; }
        public string Ingredients { get; set; }
        public string Process { get; set; }
        public string TipsAndTricks { get; set; }
    }
}
