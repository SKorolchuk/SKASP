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

var ForumItemTemplate = Class.create(TableTemplate, {
	initialize: function($super, arg){
		$super(arg);
		Creator = arg.Creator;
		Created_on = ParseDate(arg.Created_on);
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

var Picture = Class.create({
	initialize: fucntion(arg){
		PictureId  = arg.PictureId;
		PictureSrc = arg.PictureSrc;
	},
	PictureId: null,
	PictureSrc: null
});

var Statistic = Class.create({
	initialize: fucntion(arg){
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
		return $super() + ('<p>' + this.Data + '</p><p>' + this.MsgOwner + '</p>');
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
		return $super() + ('<p>' + this.Data + '</p><p>' + this.MsgOwner + '</p>');
	}
});

var Theme = Class.create(ForumItemTemplate, {
	initialize: function($super, arg){
		$super(arg);
		
	},
	Description: null,	
	Subgroup: null
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


(functiion ParseDate(date){
	return (new Date(parseInt(data.Date.replace(/\/Date\((-?\d+)\)\//, '$1'))));
}
)();