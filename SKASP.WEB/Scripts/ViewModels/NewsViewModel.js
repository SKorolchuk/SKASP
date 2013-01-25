//TODO: Edit route URLs

var NewsViewModel = Class.create({
	initialize:	function() {
		self.Loader = new JSONLoader("all", LoadNewsModel);
		self.NewsCountOnPage = 4;
		self.PageCount = self.News.length / self.NewsCountOnPage;
	},
	self: this,
	Loader: null,
	News: null,
	LoadNewsModel: function(data){
			self.News = [];
			for (var i = 0; i < data.length; i++){
				self.News[i] = new News(data[i]);
			}
		},
	UpdateList: function(){
			self.Loader.Load("/NewsApi/GetNews");
		},
	AddNews: function(item){
			self.Loader.Send("/NewsApi/PostNews", item);
		},
	RemoveNews: function(item){
			self.Loader.Remove("/NewsApi/RemoveNews", item);
		},
	UpdateNews: function(item){
			self.Loader.Remove("/NewsApi/PutNews", item);
		},
	NewsCountOnPage: 4,
	PageCount: 0
});

ko.applyBindings(new NewsViewModel());