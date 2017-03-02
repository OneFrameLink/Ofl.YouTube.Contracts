using System.Collections.Generic;

namespace Ofl.YouTube.V3.VideoResource
{
    public class VideoListRequest
    {
        public IList<Part> Parts { get; } = new List<Part>();

        public IList<string> Ids { get; } = new List<string>();

        public string PageToken { get; set; }

        public int? MaxResults { get; set; }
    }
}
