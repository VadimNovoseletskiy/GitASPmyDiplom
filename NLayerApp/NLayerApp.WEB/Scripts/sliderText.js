function SelectedOperation(a) {
    var label = a.value;
    if (label == "оренда") {
        document.getElementById("grn").style.display = 'inline-block';
        document.getElementById("dol").style.display = 'none';
    }
    else {
        document.getElementById("dol").style.display = 'inline-block';
        document.getElementById("grn").style.display = 'none';
    }
}