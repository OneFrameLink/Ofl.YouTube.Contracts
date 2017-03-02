﻿namespace Ofl.YouTube.V3.PlaylistItemResource
{
    public class PlaylistItemResource
    {
        public string Kind { get; set; }
        public string Etag { get; set; }
        public string Id { get; set; }
        public Snippet Snippet { get; set; }
        public ContentDetails ContentDetails { get; set; }
        public Status Status { get; set; }
    }
}
