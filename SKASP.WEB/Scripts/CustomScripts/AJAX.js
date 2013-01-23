var JSONLoader = Class.create({
	initialize: function(post, callback) {
		PostData = post;
		Callback = callback;
		self = this;
	},
	Load: function(url, callback) {
		if (callback) Callback = callback;
		var Request = new Ajax.Request(url, {
			method: "GET",
			onSuccess: function(json) {
				RecievedData = json.responseText.evalJSON(true);
				Callback(RecievedData);
			}
			onFailure: function(){
				alert('Failed to get requested data');
			}
		});
	},
	Send: function(url, post, callback) {
		if (callback) Callback = callback;
		if (post) PostData = post;
		var Request = new Ajax.Request(url, {
			method: "POST",
			parameters: {
				data: PostData
			},
			onSuccess: function(json) {
				RecievedData = json.responseText.evalJSON(true);				
				Callback(RecievedData);
			},
			onFailure: function(){
				alert('Failed to get requested data');
			}
		});
	},
	SetAttributes: function(callback, postData){
		Callback = callback;
		PostData = postData;
	},
	GetRecievedData: function(){
		if (isSuccess)
			return RecievedData;
		else 
			return null;
	}
	self: null,
	isSuccess: false,
	PostData: null,
	RecievedData: null,
	Callback: null
});

(
var loader = new JSONLoader();
)();