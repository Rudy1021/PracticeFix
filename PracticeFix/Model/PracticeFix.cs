using System;
using System.Collections.Generic;
using System.Text;
using SQLite;
using System.Linq;
using SQLitePCL;

namespace PracticeFix.Model
{
    [Table("FAB-1")]
    public class PracticeFix
    {
        [PrimaryKey,AutoIncrement]
        public int Item_Id { get; set; }
        public string Board_Name { get; set; }
        public string Board_Location { get; set; }
        public string Year { get; set; }
        public string Measure_Value_Temperture { get; set; }
        public string Measure_Value_R { get; set; }
        public string Measure_Value_S { get; set; }
        public string Measure_Value_T { get; set; }
        public string Current_R { get; set; }
        public string Current_S { get; set; }
        public string Current_T { get; set; }
        public string Inspection_Result { get; set; }
        public DateTime Inspection_Date { get; set; }
        public string Remarks { get; set; }

    }
}
