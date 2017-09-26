// Add your javascript here
var li = document.getElementsByTagName("li");
var map = {"One":1, "Two":2, "Three":3, "Four": 4, "Five": 5, "Six": 6, "Seven": 7, "Eight": 8, "Nine": 9, "Ten": 10};
for (var i=0; i<li.length; i++) {
	if (i%2 == 0) {
		li[i].setAttribute("class", "odd");
	}
	li[i].addEventListener("click", function() {
		this.setAttribute("class", "highlighted");
		document.getElementsByClassName("total-selected")[0].innerText = getCurrentHighlight ();
	});
	li[i].innerText = map[li[i].innerText];
}

function getCurrentHighlight () {
	var highlighted = 0;
	li = document.getElementsByTagName("li");
	for (var i=0; i<li.length; i++) {
		if (li[i].getAttribute("class") == "highlighted") {
			highlighted = highlighted + 1
		}
	}
	//console.log(highlighted);
	return highlighted;
}
