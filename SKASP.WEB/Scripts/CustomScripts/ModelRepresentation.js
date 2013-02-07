//Base Classes
var TableTemplate = Class.create({
	initialize: function(arg){
		var self = this;
		self.ID = arg.ID;
		self.Name = arg.Name;
	},
	ID: 0,
	Name: null,
	getRepresentation: function(){
		return ('<p>' + this.ID + ' ' + this.Name + '</p>');
	}
});

var ForumItemTemplate = Class.create(TableTemplate, {
	initialize: function($super, arg){
		$super(arg);
		var self = this;
		self.Creator = arg.Creator;
		self.Created_on = /*ParseDate(*/arg.Created_on/*)*/;
	},
	Creator: null,
	Created_on: null,
	getRepresentation: function($super){
		return $super() + ('<p>' + this.Creator + ' ' + this.Created_on.toString() + '</p>');
	}
});
//End Base Classes

//Miscellaneous models
var News = Class.create(TableTemplate, {
	initialize: function($super, arg){
		$super(arg);
		this.NewsContent = arg.NewsContent;
		this.Date = ParseDate(arg.Date);
	},
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
	},
	Data: null,
	MsgOwner: null,
	getRepresentation: function($super){
		return $super() + ('<p>' + this.Data + '</p><p>' + this.MsgOwner + '</p>');
	}
});

var Picture = Class.create({
	initialize: function(arg){
		PictureId  = arg.PictureId;
		PictureSrc = arg.PictureSrc;
	},
	PictureId: null,
	PictureSrc: null
});

var Statistic = Class.create({
	initialize: function(arg){
		ID = arg.ID;
		Date = ParseDate(arg.Date);
		Count = arg.Count;
	},
	ID: null,
	Date: null,
	Count: 0
});
//End Miscellaneous models


//Forum representation

var Message = Class.create(ForumItemTemplate, {
	initialize: function($super, arg){
		$super(arg);
		this.Creator = arg.Creator;
		this.Topic = arg.Topic;
		this.Text = arg.Text;
		this.Created_on = ParseDate(arg.Created_on);
	},
	Topic: null,
	Text: null,
	getRepresentation: function($super){
		//ISSUE: Need Proper Realization
		return $super() + ('<p>' + this.Topic + '</p><p>' + this.Text + '</p>');
	}
});

var Topic = Class.create(ForumItemTemplate, {	
	initialize: function($super, arg){
		$super(arg);
		this.Description = arg.Description;		
		this.Theme = arg.Theme;
	},
	Description: null,	
	Theme: null,
	getRepresentation: function($super){
		//ISSUE: Need Proper Realization
		return $super() + ('<p>' + this.Description + '</p><p>' + this.Theme + '</p>');
	}
});

var Theme = Class.create(ForumItemTemplate, {
	initialize: function($super, arg){
		$super(arg);
		var self = this;
		self.Description = arg.Description;
		self.Subgroup = arg.Subgroup;
	},
	Description: null,	
	Subgroup: null,
	getRepresentation: function($super){
		return $super() + ('<p>' + this.Description + '</p><p>' + this.Subgroup + '</p>');
	}
});

//End Forum rep.

var UserData = Class.create({
	initialize: function(arg){
		UserId = arg.UserId;
		Name = arg.Name;
		SubName = arg.SubName;
		BirthDate = arg.BirthDate;
		Interests = arg.Interests;
		BirthCity = arg.BirthCity;
		AvatarId = arg.AvatarId;
	},
	UserId: null,
	Name: null,
	SubName: null,
	BirthDate: null,
	Interests: null,
	BirthCity: null,
	AvatarId: null
});


function ParseDate(date){
	return (new Date(parseInt(date.Date.replace(/\/Date\((-?\d+)\)\//, '$1'))));
}