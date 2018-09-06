﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace journal.Entities
{
    public class JournalModel
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string FilePath { get; set; }
        public DateTime UploadDate { get; set; }
        public  string  Status { get; set; }
        public DateTime UploadedDate { get; set; }
        public DateTime ReviewDate { get; set; }
        public bool IsActive { get; set; }
    }
}