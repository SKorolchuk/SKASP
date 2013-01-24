function NewsViewModel() {
    var self = this;  
	self.loader = new JSONLoader("all", function(data){
		self.News = data;
	});
    self.UpdateList = function(){
		self.loader.Load("/NewsApi/GetNews");
	}
	self.NewsCountOnPage = 4;
	self.PageCount = self.News.length / self.NewsCountOnPage;
}

ko.applyBindings(new NewsViewModel());