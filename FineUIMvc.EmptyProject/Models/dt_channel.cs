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
    
    public partial class dt_channel
    {
        public dt_channel()
        {
            this.dt_channel_field = new HashSet<dt_channel_field>();
        }
    
        public int id { get; set; }
        public Nullable<int> category_id { get; set; }
        public string name { get; set; }
        public string title { get; set; }
        public Nullable<byte> is_albums { get; set; }
        public Nullable<byte> is_attach { get; set; }
        public Nullable<byte> is_group_price { get; set; }
        public Nullable<int> page_size { get; set; }
        public Nullable<int> sort_id { get; set; }
        public Nullable<int> wid { get; set; }
    
        public virtual dt_channel_category dt_channel_category { get; set; }
        public virtual ICollection<dt_channel_field> dt_channel_field { get; set; }
    }
}
