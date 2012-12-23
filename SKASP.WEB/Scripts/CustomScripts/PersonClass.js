var Person = Class.create({
        initialize:
            function(name, age) {
                this.name = name;
                this.age = age;
            },
        SubName: "",
        Cash: 0,
        addCash: function(count) {
            this.Cash += count;
        }
    });

var Student = Class.create(Person,
    {
        addMark: function(mark) {
            if (!this.Marks) {
                this.Marks = [];
            }
            this.Marks.push(mark);
        }
    });