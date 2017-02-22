﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ComicBookDiary.Models
{
    public class ComicBook
    {
        public int Id { get; set; }
        public string SeriesTitle { get; set; }
        public int IssueNumber { get; set; }
        public string Description { get; set; }
        public Artist[] Artist { get; set; }
        public bool Favorite { get; set; }

        public string DisplayText
        {
            get
            {
                return SeriesTitle + " #" + IssueNumber;
            }
        }
        // Series-Title-IssueNumber.jpg
        public string CoverImageFileName
        {
            get
            {
                return SeriesTitle.Replace("", "-").ToLower() + "-" + IssueNumber + ".jpg";
            }

        }
    }
}