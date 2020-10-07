function substring() {
    var str = getElementById("summaryArea");
    var res = str.substring(0, 20);
    document.getElementById("summaryArea").innerHTML = res;
}