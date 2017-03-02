using System.Collections.Generic;

namespace Ofl.YouTube.V3.PlaylistItemResource
{
    public class PlaylistItemListRequest
    {
        public IList<Part> Parts { get; } = new List<Part>();

        public string PlaylistId { get; set; }

        public string PageToken { get; set; }

        public int? MaxResults { get; set; }
    }
}
