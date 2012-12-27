namespace SKASP.DOMAIN.ViewModels
{
    using System.Linq;

    using SKASP.DOMAIN.EntitiesModel;
	
	public enum ForumPlace{
		ThemeList,
		TopicList,
		MessageList
	}
	
	public class ForumViewModel
	{
		public ForumPlace Place { get; set; }
		public IForumRepository ForumRepo { get; }
		public Message CurrrentMessage {get; set; }
		public Topic CurrentTopic { get; set; }
		public Theme CurrentTheme { get; set; }
		public Message CurremtMessage { get; set; }
	}
}