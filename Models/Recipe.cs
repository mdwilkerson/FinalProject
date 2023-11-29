using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FinalProject.Models
{
    public class Recipe
    {
        public int RecipeId{get; set;}
        public string Title {get; set;}
        public string Description {get; set;} 
        public Category Category {get; set;}
        public int CategoryId {get; set;}
    }
}