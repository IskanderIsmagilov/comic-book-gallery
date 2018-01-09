using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ComicBookGallery.Models
{
    public class ComicBook : IComparable<ComicBook>
    {
        public int Id { get; set; }
        public string SeriesTitle { get; set; }
        public int IssueNumber { get; set; }
        public string DescriptionHtml { get; set; }
        public Artist[] Artists { get; set; }
        public bool Favorite { get; set; }

        public string DisplayText
        {
            get { return SeriesTitle + " #" + IssueNumber; }
        }
        public string CoverImageFile
        {
            get { return SeriesTitle.Replace(' ', '-').ToLower() + 
                    "-" + IssueNumber + ".jpg"; }
        }

        public int CompareTo(ComicBook that)
        {            
            return this.SeriesTitle.CompareTo(that.SeriesTitle) == 0 ?
                   this.IssueNumber.CompareTo(that.IssueNumber) :
                   this.SeriesTitle.CompareTo(that.SeriesTitle);
        }
    }


}