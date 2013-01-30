//TODO: Edit route URLs

var ChatViewModel = Class.create({
	initialize: function(){
		self.Loader = new JSONLoader("all", LoadChatModel);
		self.Load("/ChatApi/GetMessages");
	},
	self: this,
	Loader: null,
	Messages: null,
	LoadChatModel: function(data){
			self.Messages = [];
			for (var i = 0; i < data.length; i++){
				self.Messages[i] = new MessageStorage(data[i]);
			}
	}
});

ko.applyBindings(new ChatViewModel());