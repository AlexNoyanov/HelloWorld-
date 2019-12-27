var sqrs = document.getElementById('squares');

function addSquare(color) {
    var sqrs = document.getElementById('squares'), newdiv = document.createElement('div');
    newdiv.style.display = 'inline-block';
    newdiv.style.width = '100px';
    newdiv.style.height = '100px';
    newdiv.style.backgroundColor = color;
    sqrs.appendChild(newdiv);
}

function delfirst() {
    var sqrs = document.getElementById('squares');
    sqrs.removeChild(sqrs.firstChild);
}

function dellast() {
    var sqrs = document.getElementById('squares');
    sqrs.removeChild(sqrs.lastChild);
}