using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace GiphyAPIContract
{
    [DataContract]
    public class ImageProperty
    {
        [DataMember] 
        public string height { get; set; }
        [DataMember] 
        public string size { get; set; }
        [DataMember] 
        public string url { get; set; }
        [DataMember] 
        public string width { get; set; }
    }

    [DataContract]
    public class Original:ImageProperty
    {
        [DataMember] 
        public string frames { get; set; }
        [DataMember] 
        public string hash { get; set; }
        [DataMember] 
        public string mp4 { get; set; }
        [DataMember] 
        public string mp4_size { get; set; }
        [DataMember] 
        public string webp { get; set; }
        [DataMember] 
        public string webp_size { get; set; }
    }
    [DataContract]
    public class FixedHeightDownsampled:ImageProperty
    {

        [DataMember] 
        public string webp { get; set; }
        [DataMember] 
        public string webp_size { get; set; }
     
    }


    [DataContract]
    public class OriginalMp4
    {
        [DataMember] 
        public string height { get; set; }
        [DataMember] 
        public string mp4 { get; set; }
        [DataMember] 
        
        public string mp4_size { get; set; }
        [DataMember] 
        public string width { get; set; }
    }
    [DataContract]
    public class FixedHeightSmall
    {
        [DataMember] 
        public string height { get; set; }
        [DataMember] 
        public string mp4 { get; set; }
        [DataMember] 
        public string mp4_size { get; set; }
        [DataMember] 
        public string size { get; set; }
        [DataMember] 
        public string url { get; set; }
        [DataMember] 
        
        public string webp { get; set; }
        [DataMember] 
        public string webp_size { get; set; }
        [DataMember] 
        public string width { get; set; }
    }
    [DataContract]
    public class FixedHeight:ImageProperty
    {
        [DataMember] 
        public string mp4 { get; set; }
        [DataMember] 
        public string mp4_size { get; set; }
        [DataMember] 
        public string webp { get; set; }
        [DataMember] 
        public string webp_size { get; set; }
    }
    [DataContract]
    public class DownsizedSmall
    {

        [DataMember] 
        public string height { get; set; }

        [DataMember] 
        public string mp4 { get; set; }
        [DataMember]
        public string mp4_size { get; set; }
        [DataMember]
        public string width { get; set; }
    }
    [DataContract]
    public class Preview
    {
        [DataMember]
        public string height { get; set; }
        [DataMember]
        public string mp4 { get; set; }

        [DataMember] 
        public string mp4_size { get; set; }
        [DataMember]
        public string width { get; set; }
    }
    [DataContract]
    public class FixedWidthDownsampled:ImageProperty
    {
        [DataMember]
        public string webp { get; set; }
        [DataMember]
        public string webp_size { get; set; }
    }

    [DataContract]
    public class FixedWidthSmall:ImageProperty
    {
        [DataMember]
        public string mp4 { get; set; }

        [DataMember] 
        public string mp4_size { get; set; }
        [DataMember]
        public string webp { get; set; }
        [DataMember]
        public string webp_size { get; set; }
    }



    [DataContract]
    public class Looping
    {

        [DataMember] 
        public string mp4 { get; set; }
        [DataMember]
        public string mp4_size { get; set; }
    }

    [DataContract]
    public class FixedWidth:ImageProperty
    {

        [DataMember] 
        public string mp4 { get; set; }
        [DataMember]
        public string mp4_size { get; set; }
        [DataMember]
        public string webp { get; set; }
        [DataMember]
        public string webp_size { get; set; }
    }

    [DataContract]
    public class _480wStill
    {
        [DataMember]
        public string url { get; set; }
        [DataMember]
        public string width { get; set; }
        [DataMember]
        public string height { get; set; }
    }
    [DataContract]
    public class Hd
    {
        [DataMember]
        public string height { get; set; }

        [DataMember] 
        public string mp4 { get; set; }
        [DataMember]
        public string mp4_size { get; set; }
        [DataMember]
        public string width { get; set; }
    }
    [DataContract]
    public class Images
    {
        [DataMember]
        public ImageProperty downsized_large { get; set; }
        [DataMember]
        public ImageProperty fixed_height_small_still { get; set; }
        [DataMember]
        public Original original { get; set; }
        [DataMember]
        public FixedHeightDownsampled fixed_height_downsampled { get; set; }
        [DataMember]
        public ImageProperty downsized_still { get; set; }
        [DataMember]
        public ImageProperty fixed_height_still { get; set; }
        [DataMember]
        public ImageProperty downsized_medium { get; set; }

        [DataMember] 
        public ImageProperty downsized { get; set; }
        [DataMember]
        public ImageProperty preview_webp { get; set; }
        [DataMember]
        public OriginalMp4 original_mp4 { get; set; }
        [DataMember]
        public FixedHeightSmall fixed_height_small { get; set; }
        [DataMember]
        public FixedHeight fixed_height { get; set; }

        [DataMember] 
        public DownsizedSmall downsized_small { get; set; }
        [DataMember]
        public Preview preview { get; set; }
        [DataMember]
        public FixedWidthDownsampled fixed_width_downsampled { get; set; }
        [DataMember]
        public ImageProperty fixed_width_small_still { get; set; }
        [DataMember]
        public FixedWidthSmall fixed_width_small { get; set; }
        [DataMember]
        public ImageProperty original_still { get; set; }
        [DataMember]
        public ImageProperty fixed_width_still { get; set; }
        [DataMember]
        public Looping looping { get; set; }
        [DataMember]
        public FixedWidth fixed_width { get; set; }
        [DataMember]
        public ImageProperty preview_gif { get; set; }

        [DataMember] 
        public _480wStill _480w_still { get; set; }
        [DataMember]
        public Hd hd { get; set; }
    }
    [DataContract]
    public class User
    {
        [DataMember]
        public string avatar_url { get; set; }
        [DataMember]
        public string banner_image { get; set; }
        [DataMember]
        public string banner_url { get; set; }

        [DataMember] 
        public string profile_url { get; set; }
        [DataMember]
        public string username { get; set; }
        [DataMember]
        public string display_name { get; set; }
        [DataMember]
        public string description { get; set; }
        [DataMember]
        public bool is_verified { get; set; }
    }
    [DataContract]
    public class Gif
    {
        [DataMember]
        public string type { get; set; }
        [DataMember]
        public string id { get; set; }
        [DataMember]
        public string url { get; set; }
        [DataMember]
        public string slug { get; set; }
        [DataMember]
        public string bitly_gif_url { get; set; }

        [DataMember] 
        public string bitly_url { get; set; }
        [DataMember]
        public string embed_url { get; set; }
        [DataMember]
        public string username { get; set; }

        [DataMember]
        public string source { get; set; }
        [DataMember]
        public string title { get; set; }
        [DataMember]
        public string rating { get; set; }

        [DataMember] 
        public string content_url { get; set; }
        [DataMember]
        public string source_tld { get; set; }
        [DataMember]
        public string source_post_url { get; set; }
        [DataMember]
        public int is_sticker { get; set; }
        [DataMember]
        public string import_datetime { get; set; }
        [DataMember]
        public string trending_datetime { get; set; }
        [DataMember]
        public Images images { get; set; }
        [DataMember]
        public User user { get; set; }
    }
    [DataContract]
    public class Pagination
    {
        [DataMember]
        public int total_count { get; set; }
        [DataMember]
        public int count { get; set; }
        [DataMember]
        public int offset { get; set; }
    }
    [DataContract]
    public class Meta
    {
        [DataMember]
        public int status { get; set; }
        [DataMember]
        public string msg { get; set; }
        [DataMember]
        public string response_id { get; set; }
    }
    [DataContract]
    public class Root
    {
        [DataMember]
        public List<Gif> data { get; set; }
        [DataMember]
        public Pagination pagination { get; set; }
        [DataMember]
        public Meta meta { get; set; }
    }

}
