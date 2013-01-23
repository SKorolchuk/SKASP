//Base Classes
var TableTemplate = Class.Create({
	initialize: function(arg){
		this.ID = arg.ID;
		this.Name = arg.Name;
	}
	ID: 0,
	Name: null,
	getRepresentation: function(){
		return ('<p>' + this.ID + ' ' + this.Name + '</p>');
	}
});
//End Base Classes

//Miscellaneous models
var News = Class.create(TableTemplate, {
	initialize: function($super, arg){
		$super(arg);
		this.NewsContent = arg.NewsContent;
		this.Date = ParseDate(arg.Date);
	}
	NewsContent: null,
	Date: null,
	getRepresentation: function($super){
		return $super() + ('<p>' + this.NewsContent + '</p><p>' + this.Date + '</p>');
	}
});

var MessageStorage = Class.create(TableTemplate, {
	initialize: function($super, arg){
		$super(arg);
		this.Data = arg.Data;
		this.MsgOwner = arg.MsgOwner;
	}
	Data: null,
	MsgOwner: null,
	getRepresentation: function($super){
		return $super() + ('<p>' + this.Data + '</p><p>' + this.MsgOwner + '</p>');
	}
});
//End Miscellaneous models


//Forum representation

var Message = Class.create(TableTemplate, {
	initialize: function($super, arg){
		$super(arg);
		this.Creator = arg.Creator;
		this.Topic = arg.Topic;
		this.Text = arg.Text;
		this.Created_on = ParseDate(arg.Created_on);
	},
	Creator: null,
	Topic: null,
	Text: null,
	Created_on: null,
	getRepresentation: function($super){
		//ISSUE: Need Proper Realization
		return $super() + ('<p>' + this.Data + '</p><p>' + this.MsgOwner + '</p>');
	}
});

var Topic = Class.create(TableTemplate, {	
	initialize: function($super, arg){
		$super(arg);
		this.Description = arg.Description;
		this.Creator = arg.Creator;
		this.Created_on = ParseDate(arg.Created_on);	
		this.Theme = arg.Theme;
	},
	Description: null,
	Creator: null,
	Created_on: null,
	Theme: null,
	getRepresentation: function($super){
		//ISSUE: Need Proper Realization
		return $super() + ('<p>' + this.Data + '</p><p>' + this.MsgOwner + '</p>');
	}
});

var Theme = Class.create(TableTemplate, {
	
});

//End Forum rep.

var UserData = Class.create({
	initialize: null
});


(functiion ParseDate(date){
	return (new Date(parseInt(data.Date.replace(/\/Date\((-?\d+)\)\//, '$1'))));
}
)();