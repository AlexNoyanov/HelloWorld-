var fsize = 15;

function $(id){
  return document.getElementById(id);
}

function add() {
  var list = $("list");

  var li = document.createElement("li");
  li.innerHTML = $("input").value;
  $("input").value = "";
  list.appendChild(li);
  list.lastChild.style.fontSize = fsize + 'px';

  fsize = fsize + 5;
  return;
}

function del() {
    var list = $("list");
    if (list.lastChild == null) return;
    fsize = fsize - 5;
    list.removeChild(list.lastChild);
    return;
}
