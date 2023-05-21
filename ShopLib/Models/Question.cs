﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopLib.Models
{
    public record Question : BaseEntity
    {
        public Question() { }
        public Question(int id, int userId, string title, string text)
        {
            Id = id;
            UserId = userId;
            Title = title;
            Text = text;
        }

        public int UserId { get; set; }
        public string Title { get; set; }
        public string Text { get; set; }
        public virtual User User { get; set; }
    }
}
