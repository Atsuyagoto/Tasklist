using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using System.ComponentModel; // 追加
using System.ComponentModel.DataAnnotations; // 追加


namespace Tasklist.Models
{
    public class Tasks
    {
        [Key]
        [DisplayName("ID")]
        public int Id { get; set; }

        [DisplayName("作成日時")]
        public DateTime CreatedAt { get; set; }

        [DisplayName("更新日時")]
        public DateTime UpdatedAt { get; set; }

        [DisplayName("タスクの内容")]
        [DataType(DataType.MultilineText)] // 追加
        public string Task { get; set; }


   

       
    }
}