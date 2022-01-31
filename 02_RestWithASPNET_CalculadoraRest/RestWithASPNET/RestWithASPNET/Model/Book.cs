using RestWithASPNET.Model.Base;
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace RestWithASPNET.Model
{
    [Table("Books")]
    public class Book : BaseEntity
    {

        [Column("author")]
        public string Author { get; set; }

        [Column("launch_date")]
        public DateTime LauchDate { get; set; }

        [Column("price")]
        public decimal Price { get; set; }

        [Column("title")]
        public string LongText { get; set; }
    }
}
