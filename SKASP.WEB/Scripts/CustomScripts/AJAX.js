var JSONLoader = Class.create({
	initialize: function(post, callback) {
		PostData = post;
		Callback = callback;
	},
	Load: function(url, callback) {
		if (callback) Callback = callback;
		var Request = new Ajax.Request(url, {
			method: "GET",
			onSuccess: function(json) {
				RecievedData = json.responseText.evalJSON(true);
				Callback(RecievedData);
				isSuccess = true;
			},
			onFailure: function(){
				alert('Failed to get requested data');
				isSuccess = false;
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
				isSuccess = true;
			},
			onFailure: function(){
				alert('Failed to get requested data');
				isSuccess = false;
			}
		});
	},
	Put: function(url, put, callback) {
		if (callback) Callback = callback;
		if (put) PostData = put;
		var Request = new Ajax.Request(url, {
			method: "PUT",
			parameters:	{
				data: PostData
			},
			onSuccess: function(json) {
				RecievedData = json.responseText.evalJSON(true);				
				Callback(RecievedData);
				isSuccess = true;
			},
			onFailure: function(){
				alert('Failed to get requested data');
				isSuccess = false;
			}
		});
	},
	Remove: function(url, remove, callback) {
		if (callback) Callback = callback;
		if (remove) PostData = remove;
		var Request = new Ajax.Request(url, {
			method: "REMOVE",
			parameters: {
				data: PostData
			},
			onSuccess: function(json) {
				RecievedData = json.responseText.evalJSON(true);				
				Callback(RecievedData);
				isSuccess = true;
			},
			onFailure: function(){
				alert('Failed to get requested data');
				isSuccess = false;
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
	},
	isSuccess: false,
	PostData: null,
	RecievedData: null,
	Callback: null
});