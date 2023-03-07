﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace News.Model
{
    public class Article
    {
        public Article() { }
        public int Id { get; set; }

        public string  LinkImage { get; set; }
        public string Title { get; set; }

        public string Description { get; set; }

        public string LinkToWeb { get; set; }
    }
}
