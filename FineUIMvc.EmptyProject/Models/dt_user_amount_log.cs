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
    
    public partial class dt_user_amount_log
    {
        public int id { get; set; }
        public Nullable<int> user_id { get; set; }
        public string user_name { get; set; }
        public string type { get; set; }
        public string order_no { get; set; }
        public string trade_no { get; set; }
        public Nullable<int> payment_id { get; set; }
        public Nullable<decimal> value { get; set; }
        public string remark { get; set; }
        public Nullable<byte> status { get; set; }
        public Nullable<System.DateTime> add_time { get; set; }
        public Nullable<System.DateTime> complete_time { get; set; }
    }
}
