using Newtonsoft.Json; 
namespace WLDesigna.Pages{ 

    public class MP3
    {
        [JsonProperty("title")]
        public required string Title { get; set; }

        [JsonProperty("file")]
        public required File File { get; set; }

        [JsonProperty("filesize")]
        public int? Filesize { get; set; }

        [JsonProperty("trackImage")]
        public required TrackImage TrackImage { get; set; }

        [JsonProperty("markers")]
        public required Marker Markers { get; set; }

        [JsonProperty("label")]
        public required string Label { get; set; }

        [JsonProperty("track")]
        public int? Track { get; set; }

        [JsonProperty("hasTrack")]
        public bool? HasTrack { get; set; }

        [JsonProperty("pub")]
        public required string Pub { get; set; }

        [JsonProperty("docid")]
        public int? Docid { get; set; }

        [JsonProperty("booknum")]
        public int? Booknum { get; set; }

        [JsonProperty("mimetype")]
        public required string Mimetype { get; set; }

        [JsonProperty("edition")]
        public required string Edition { get; set; }

        [JsonProperty("editionDescr")]
        public required string EditionDescr { get; set; }

        [JsonProperty("format")]
        public required string Format { get; set; }

        [JsonProperty("formatDescr")]
        public required string FormatDescr { get; set; }

        [JsonProperty("specialty")]
        public required string Specialty { get; set; }

        [JsonProperty("specialtyDescr")]
        public required string SpecialtyDescr { get; set; }

        [JsonProperty("subtitled")]
        public bool? Subtitled { get; set; }

        [JsonProperty("frameWidth")]
        public int? FrameWidth { get; set; }

        [JsonProperty("frameHeight")]
        public int? FrameHeight { get; set; }

        [JsonProperty("frameRate")]
        public int? FrameRate { get; set; }

        [JsonProperty("duration")]
        public double? Duration { get; set; }

        [JsonProperty("bitRate")]
        public double? BitRate { get; set; }
    }

}