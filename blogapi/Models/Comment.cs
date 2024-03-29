﻿using System.Text.Json.Serialization;

namespace blogapi.Models
{
    public class Comment
    {
        public int Id { get; set; }

        public string Text { get; set; }

        public int PostId { get; set; }
        public Post Post { get; set; }
    }
}
