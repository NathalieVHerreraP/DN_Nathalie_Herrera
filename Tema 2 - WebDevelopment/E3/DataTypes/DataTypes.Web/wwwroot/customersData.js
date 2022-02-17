var element = document.getElementById("example");

var dateNow = Date.now();
var CustomerCollection = [[ "Hugo J.",  dateNow ],
                          [  "Luis D.", dateNow ],
                          [ "Jorge A.", dateNow ],
                          [ "Nath H.",  dateNow ],
                          [ "Ness P.",  dateNow ],
                          [ "Karen M.", dateNow ],
                          [ "Luis U.",  dateNow ],
                          [ "Marco E.", dateNow ],
                          [ "Fred S.",  dateNow ],
                          ["Any F.",    dateNow]];

var list = "<ul>";

for (var i = 0; i < 10; i++) {

    list += ("<li> Name: " + CustomerCollection[i][0] + " Join Date: " + CustomerCollection[i][1] + "</li>");

}

list += "</ul>";

element.innerHTML = list;