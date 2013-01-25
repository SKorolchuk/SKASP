//TODO: Edit route URLs

var ForumViewModel = Class.create({
	initialize: function(){
		self.Loader = new JSONLoader();
		self.LoadForumModel();
	},
	self: this,
	LoadForumModel: function(){
		Themes = [];
		Topics = [];
		Messages = [];
		self.Loader.Load("/ForumApi/GetMessages", function(data){
			for (var i = 0; i < data.length; i++){
				Messages[i] = new Message(data[i]);
			}
		});
		self.Loader.Load("/ForumApi/GetTopics", function(data){
			for (var i = 0; i < data.length; i++){
				Topics[i] = new Topic(data[i]);
			}
		});
		self.Loader.Load("/ForumApi/GetThemes", function(data){
			for (var i = 0; i < data.length; i++){
				Themes[i] = new Theme(data[i]);
			}
		});
	},
	AddTheme: function(item){
		self.Loader.Send("ForumApi/PostTheme", item, self.LoadForumModel);
	},
	RemoveTheme: function(item){
		self.Loader.Send("ForumApi/RemoveTheme", item, self.LoadForumModel);
	},
	UpdateTheme: function(item){
		self.Loader.Send("ForumApi/PutTheme", item, self.LoadForumModel);
	},
	AddTopic: function(item){
		self.Loader.Send("ForumApi/PostTopic", item, self.LoadForumModel);
	},
	RemoveTopic: function(item){
		self.Loader.Send("ForumApi/RemoveTopic", item, self.LoadForumModel);
	},
	UpdateTopic: function(item){
		self.Loader.Send("ForumApi/PutTopic", item, self.LoadForumModel);
	},
	AddMessage: function(item){
		self.Loader.Send("ForumApi/PostMessage", item, self.LoadForumModel);
	},
	RemoveMessage: function(item){
		self.Loader.Send("ForumApi/RemoveMessage", item, self.LoadForumModel);
	},
	UpdateMessage: function(item){
		self.Loader.Send("ForumApi/PutMessage", item, self.LoadForumModel);
	},
	Loader: null,
	Themes: null,
	Topics: null,
	Messages: null,
	CurrentTheme: null,
	CurrentTopic: null
});

ko.applyBindings(new ForumViewModel());