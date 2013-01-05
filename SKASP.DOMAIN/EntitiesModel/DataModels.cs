using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Globalization;
using System.Web.Security;

namespace SKASP.DOMAIN.EntitiesModel
{
    public class DatabaseEntities : DbContext
    {
        public DatabaseEntities()
            : base("DefaultConnection")
        {
        }

        public DbSet<Message> Messages { get; set; }
        public DbSet<MessageStorage> MessageStorages { get; set; }
        public DbSet<News> News { get; set; }
        public DbSet<Statistic> Statistics { get; set; }
        public DbSet<Theme> Themes { get; set; }
        public DbSet<Topic> Topics { get; set; }
        //public DbSet<Usr_lg_data> Usr_lg_data { get; set; }
    }

    [Table("Message")]
    public class Message
    {
        [Key]
        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }
        public int Creator { get; set; }
        public int Topic { get; set; }
        public string Text { get; set; }
        public System.DateTime Created_on { get; set; }
    }

    /*[Table("Usr_lg_data")]
    public partial class Usr_lg_data
    {
        [Key]
        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }
        public string Name { get; set; }
        public string SubName { get; set; }
        public string loginstr { get; set; }
        public string passwd { get; set; }
        public System.DateTime created_on { get; set; }
    }*/

    [Table("Topic")]
    public class Topic
    {
        [Key]
        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int Creator { get; set; }
        public System.DateTime Created_on { get; set; }
        public int Theme { get; set; }
    }

    [Table("Theme")]
    public class Theme
    {
        [Key]
        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int Creator { get; set; }
        public System.DateTime Created_on { get; set; }
        public string Subgroup { get; set; }
    }

    [Table("Statistic")]
    public class Statistic
    {
        [Key]
        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }
        public System.DateTime Date { get; set; }
        public int Count { get; set; }
    }

    [Table("News")]
    public class News
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string NewsContent { get; set; }
        public Nullable<System.DateTime> Date { get; set; }
    }

    [Table("MessageStorage")]
    public class MessageStorage
    {
        [Key]
        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }
        public string Name { get; set; }
        public string Data { get; set; }
        public string MsgOwner { get; set; }
    }
}
