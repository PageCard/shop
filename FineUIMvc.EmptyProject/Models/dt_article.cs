//------------------------------------------------------------------------------
// <auto-generated>
//     此代码已从模板生成。
//
//     手动更改此文件可能导致应用程序出现意外的行为。
//     如果重新生成代码，将覆盖对此文件的手动更改。
// </auto-generated>
//------------------------------------------------------------------------------

namespace FineUIMvc.EmptyProject.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class dt_article
    {
        public int id { get; set; }
        public int channel_id { get; set; }
        public int category_id { get; set; }
        public string call_index { get; set; }
        public string title { get; set; }
        public string link_url { get; set; }
        public string img_url { get; set; }
        public string seo_title { get; set; }
        public string seo_keywords { get; set; }
        public string seo_description { get; set; }
        public string zhaiyao { get; set; }
        public string content { get; set; }
        public Nullable<int> sort_id { get; set; }
        public Nullable<int> click { get; set; }
        public Nullable<byte> status { get; set; }
        public string groupids_view { get; set; }
        public Nullable<int> vote_id { get; set; }
        public Nullable<byte> is_msg { get; set; }
        public Nullable<byte> is_top { get; set; }
        public Nullable<byte> is_red { get; set; }
        public Nullable<byte> is_hot { get; set; }
        public Nullable<byte> is_slide { get; set; }
        public Nullable<byte> is_sys { get; set; }
        public string user_name { get; set; }
        public Nullable<System.DateTime> add_time { get; set; }
        public Nullable<System.DateTime> update_time { get; set; }
        public Nullable<int> wid { get; set; }
    
        public virtual dt_article_attribute_value dt_article_attribute_value { get; set; }
    }
}
