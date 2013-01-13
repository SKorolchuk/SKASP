var JSONLoader = Class.create();

JSONLoader.prototype = {
	initialize: function() {
		this.data = {};
	},
	Load: function(divId, url) {
		var divElement = $(divId);
		var Request = new Ajax.Request(url, {
			method: "GET",
			onSuccess: function(json) {
				var data = json.responseText.evalJSON();
				var name = data.Name;
				var description = data.NewsContent;
				var date = new Date(parseInt(data.Date.replace(/\/Date\((-?\d+)\)\//, '$1')));
				divElement.innerHTML = '<p>' + name + '</p><p>' + description + '</p><p>' + date.toDateString() + '</p>';
			}
		});
	},
	Send: function(divId, url, message) {
		var divElement = $(divId);
		var Request = new Ajax.Request(url, {
			method: "POST",
			parameters: {
				message: message
			},
			onSuccess: function(json) {
				var data = json.responseText.evalJSON(true);
				var name = data.Name;
				var description = data.NewsContent;
				var date = new Date(data.Date.replace(/\/Date\((-?\d+)\)\//, '$1'));
				divElement.innerHTML = '<p>' + name + '</p><p>' + description + '</p><p>' + date + '</p>';
			}
		});
	}
};

var loader = new JSONLoader();