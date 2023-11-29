using SQLite;

namespace MauiSqliteDemo
{
    [Table("customer")]
    public class Customer
    {
        [PrimaryKey]
        [AutoIncrement]
        [Column("id")]
        public int Id { get; set; }

        [Column("customer_name")]
        public string CustomerName { get; set; }

        [Column("mobile")]
        public string Mobile { get; set; }

        [Column("email")]
        public string Email { get; set; }
    }
}
