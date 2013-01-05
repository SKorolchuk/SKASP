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
    }

    [Table("Message")]
    public class Message
    {
        [Key]
        public int ID { get; set; }
        public int Creator { get; set; }
        public int Topic { get; set; }
        public string Text { get; set; }
        public System.DateTime Created_on { get; set; }
    }

    [Table("Topic")]
    public class Topic
    {
        [Key]
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
        public int ID { get; set; }
        public System.DateTime Date { get; set; }
        public int Count { get; set; }
    }

    [Table("News")]
    public class News
    {
        [Key]
        public int ID { get; set; }
        public string Name { get; set; }
        public string NewsContent { get; set; }
        public Nullable<System.DateTime> Date { get; set; }
    }

    [Table("MessageStorage")]
    public class MessageStorage
    {
        [Key]
        public int ID { get; set; }
        public string Name { get; set; }
        public string Data { get; set; }
        public string MsgOwner { get; set; }
    }
}
