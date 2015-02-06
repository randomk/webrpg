function horizontal(idMenu) {

    var navItems = document.getElementById("ulMenu").getElementsByTagName("li");

    for (var i = 0; i < navItems.length; i++) {
        if (navItems[i].className == "submenu") {
            if (navItems[i].getElementsByTagName('ul')[0] != null) {
                navItems[i].onmouseover = function () {
                    this.getElementsByTagName('ul')[0].style.display = "block";
                    //this.getElementsByTagName('a')[0].style.color="#DE5D29";
                }
                navItems[i].onmouseout = function () {
                    this.getElementsByTagName('ul')[0].style.display = "none";
                    //this.getElementsByTagName('a')[0].style.color="#fff";
                }
            }
        }
    }
}

function exp(me) {
    var el = me.parentNode.getElementsByTagName('UL')[0];
    if (!el.style) el.style = {};
    if (el.style.display == 'block') el.style.display = 'none';
    else el.style.display = 'block';
}