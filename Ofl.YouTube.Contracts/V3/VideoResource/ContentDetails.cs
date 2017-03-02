using System;

namespace Ofl.YouTube.V3.VideoResource
{
    public class ContentDetails
    {
        public TimeSpan Duration { get; set; }

        public string Dimension { get; set; }
        public string Definition { get; set; }
        public bool Caption { get; set; }
        public bool LicensedContent { get; set; }
        public RegionRestriction RegionRestriction { get; set; }
        public ContentRating ContentRating { get; set; }
        public string Projection { get; set; }
        public bool HasCustomThumbnail { get; set; }
    }
}
