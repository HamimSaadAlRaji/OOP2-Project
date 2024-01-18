﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem
{
    public class ResearchBook 
    {               
        public string Title { get; set; }
        public string Author { get; set; }
        public string Description { get; set; }
        public ResearchBook( string title, string author, string description)
        {            
            Title = title;
            Author = author;
            Description = description;
        }

       
       
    }

}
