using System;
using SQLite; 

namespace ICT13580091FinalA.Models
{
    public class Product
    {
        [PrimaryKey]
        [AutoIncrement]
        public int Id { get; set; }

        [NotNull]
        [MaxLength(100)]
        public string Name { get; set; }
        public string Lastname { get; set; }
        public int Age { get; set; }

        public string Department { get; set; }
        public int Tel { get; set; }

        [NotNull]
        [MaxLength(200)]
        public string Address { get; set; }
        public string email { get; set; }
        public string Status { get; set; }
        public string Gender { get; set; }
        public string Children { get; set; }

        public decimal Saraly { get; set; }

    }
}