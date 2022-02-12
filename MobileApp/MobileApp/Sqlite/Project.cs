using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace MobileApp.Sql_Lite
{
    [Table("Projects")]
    public class Project
    {
        [PrimaryKey, AutoIncrement, Column("_id")]
        public int Id { get; set; }
        [Unique]
        public string Name { get; set; }
        public string Description { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
    }
}
