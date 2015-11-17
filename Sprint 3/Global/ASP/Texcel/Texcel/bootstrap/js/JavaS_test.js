//function test() {
//    alert("Super cool!");
//}
function loadList(){
    $(document).ready(function () {
        alert("Chef de projet");
        $.ajax({
            url: '/Projet/selectChefs',
            contentType: 'application/html; charset=utf-8',
            type: 'GET',
            dataType: 'html'
        })
        .success(function (result) {
            $('#lstChefs').replaceWith(result);
            alert(result.dataType);

        })
        .error(function (xhr, status) {
            alert(status);
        });

        alert("test2");
        $.ajax({
            url: '/Projet/selectVersions',
            contentType: 'application/html; charset=utf-8',
            type: 'GET',
            dataType: 'html'
        })
        .success(function (result) {
            $('#lstVersions').replaceWith(result);
            alert(result.dataType);

        })
        .error(function (xhr, status) {
            alert(status);
        });
    });
}
// 1 = nouv : 2 = modif
function enregistrer(code) {
    if (code === undefined) {
        alert("code non valide");
    }
    else {
        switch (code) {
            default:
        }
    }
}
function getInfoInterface() {
    var projet = {codeP:,e:"lol"};
    return projet;
}
function nouveau(){

}
function modifier(){

}