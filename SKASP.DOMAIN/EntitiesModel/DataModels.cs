using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace SKASP.DOMAIN.EntitiesModel
{
	/// <summary>
	/// The database entities.
	/// </summary>
	public class DatabaseEntities : DbContext
    {
		/// <summary>
		/// Initializes a new instance of the <see cref="DatabaseEntities"/> class.
		/// </summary>
		public DatabaseEntities()
            : base("DefaultConnection")
        {
        }

		/// <summary>
		/// Gets or sets the messages.
		/// </summary>
		public DbSet<Message> Messages { get; set; }

		/// <summary>
		/// Gets or sets the message storages.
		/// </summary>
		public DbSet<MessageStorage> MessageStorages { get; set; }

		/// <summary>
		/// Gets or sets the news.
		/// </summary>
		public DbSet<News> News { get; set; }

		/// <summary>
		/// Gets or sets the statistics.
		/// </summary>
		public DbSet<Statistic> Statistics { get; set; }

		/// <summary>
		/// Gets or sets the themes.
		/// </summary>
		public DbSet<Theme> Themes { get; set; }

		/// <summary>
		/// Gets or sets the topics.
		/// </summary>
		public DbSet<Topic> Topics { get; set; }

		/// <summary>
		/// Gets or sets the pictures.
		/// </summary>
		public DbSet<Picture> Pictures { get; set; }

		/// <summary>
		/// Gets or sets the user data storage.
		/// </summary>
		public DbSet<UserData> UserDataStorage { get; set; }
    }

	/// <summary>
	/// The user data.
	/// </summary>
	[Table("UserData")]
	public class UserData
	{
		/// <summary>
		/// Gets or sets the user id.
		/// </summary>
		[Key]
		public int UserId { get; set; }

		/// <summary>
		/// Gets or sets the name.
		/// </summary>
		public string Name { get; set; }

		/// <summary>
		/// Gets or sets the sub name.
		/// </summary>
		public string SubName { get; set; }

		/// <summary>
		/// Gets or sets the birth date.
		/// </summary>
		public Nullable<System.DateTime> BirthDate { get; set; }

		/// <summary>
		/// Gets or sets the interests.
		/// </summary>
		public string Interests { get; set; }

		/// <summary>
		/// Gets or sets the birth city.
		/// </summary>
		public string BirthCity { get; set; }

		/// <summary>
		/// Gets or sets the avatar id.
		/// </summary>
		public int AvatarId { get; set; }

		/// <summary>
		/// The get avatar.
		/// </summary>
		/// <param name="pictures">
		/// The pictures.
		/// </param>
		/// <returns>
		/// The <see cref="Picture"/>.
		/// </returns>
		public Picture GetAvatar(DbSet<Picture> pictures)
		{
			return pictures.FirstOrDefault(x => x.PictureId == this.AvatarId);
		}
	}

	/// <summary>
	/// The picture.
	/// </summary>
	[Table("PictureStorage")]
	public class Picture
	{
		/// <summary>
		/// Gets or sets the picture id.
		/// </summary>
		[Key]
		[DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]
		public int PictureId { get; set; }

		/// <summary>
		/// Gets or sets the picture binary.
		/// </summary>
		public byte[] PictureBinary { get; set; }
	}

	/// <summary>
	/// The message.
	/// </summary>
	[Table("Message")]
    public class Message
    {
		/// <summary>
		/// Gets or sets the id.
		/// </summary>
		[Key]
        public int ID { get; set; }

		/// <summary>
		/// Gets or sets the creator.
		/// </summary>
		public int Creator { get; set; }

		/// <summary>
		/// Gets or sets the topic.
		/// </summary>
		public int Topic { get; set; }

		/// <summary>
		/// Gets or sets the text.
		/// </summary>
		public string Text { get; set; }

		/// <summary>
		/// Gets or sets the created_on.
		/// </summary>
		public System.DateTime Created_on { get; set; }
    }

	/// <summary>
	/// The topic.
	/// </summary>
	[Table("Topic")]
    public class Topic
    {
		/// <summary>
		/// Gets or sets the id.
		/// </summary>
		[Key]
        public int ID { get; set; }

		/// <summary>
		/// Gets or sets the name.
		/// </summary>
		public string Name { get; set; }

		/// <summary>
		/// Gets or sets the description.
		/// </summary>
		public string Description { get; set; }

		/// <summary>
		/// Gets or sets the creator.
		/// </summary>
		public int Creator { get; set; }

		/// <summary>
		/// Gets or sets the created_on.
		/// </summary>
		public System.DateTime Created_on { get; set; }

		/// <summary>
		/// Gets or sets the theme.
		/// </summary>
		public int Theme { get; set; }
    }

	/// <summary>
	/// The theme.
	/// </summary>
	[Table("Theme")]
    public class Theme
    {
		/// <summary>
		/// Gets or sets the id.
		/// </summary>
		[Key]
        public int ID { get; set; }

		/// <summary>
		/// Gets or sets the name.
		/// </summary>
		public string Name { get; set; }

		/// <summary>
		/// Gets or sets the description.
		/// </summary>
		public string Description { get; set; }

		/// <summary>
		/// Gets or sets the creator.
		/// </summary>
		public int Creator { get; set; }

		/// <summary>
		/// Gets or sets the created_on.
		/// </summary>
		public System.DateTime Created_on { get; set; }

		/// <summary>
		/// Gets or sets the subgroup.
		/// </summary>
		public string Subgroup { get; set; }
    }

	/// <summary>
	/// The statistic.
	/// </summary>
	[Table("Statistic")]
    public class Statistic
    {
		/// <summary>
		/// Gets or sets the id.
		/// </summary>
		[Key]
        public int ID { get; set; }

		/// <summary>
		/// Gets or sets the date.
		/// </summary>
		public System.DateTime Date { get; set; }

		/// <summary>
		/// Gets or sets the count.
		/// </summary>
		public int Count { get; set; }
    }

	/// <summary>
	/// The news.
	/// </summary>
	[Table("News")]
    public class News
    {
		/// <summary>
		/// Gets or sets the id.
		/// </summary>
		[Key]
        public int ID { get; set; }

		/// <summary>
		/// Gets or sets the name.
		/// </summary>
		public string Name { get; set; }

		/// <summary>
		/// Gets or sets the news content.
		/// </summary>
		public string NewsContent { get; set; }

		/// <summary>
		/// Gets or sets the date.
		/// </summary>
		public Nullable<System.DateTime> Date { get; set; }
    }

	/// <summary>
	/// The message storage.
	/// </summary>
	[Table("MessageStorage")]
    public class MessageStorage
    {
		/// <summary>
		/// Gets or sets the id.
		/// </summary>
		[Key]
        public int ID { get; set; }

		/// <summary>
		/// Gets or sets the name.
		/// </summary>
		public string Name { get; set; }

		/// <summary>
		/// Gets or sets the data.
		/// </summary>
		public string Data { get; set; }

		/// <summary>
		/// Gets or sets the msg owner.
		/// </summary>
		public string MsgOwner { get; set; }
    }
}
