using System;
using System.Collections.Generic;
using System.Text;

namespace Netflix.Entities.ComplexTypes
{
    public class SeasonChapterComplexType
    {
        public int SeriesId { get; set; }

        public int SeasonId { get; set; }

        public int ChapterId { get; set; }

        public string SeasonName { get; set; }

        public string SeasonTitle { get; set; }

        public string ChapterName { get; set; }

        public string ChapterTopic { get; set; }
    }
}
