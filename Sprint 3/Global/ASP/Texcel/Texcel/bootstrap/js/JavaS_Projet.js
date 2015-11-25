function loadList(){
    $.ajax({
        url: '../Projet/selectChefs',
        contentType: 'application/html; charset=utf-8',
        type: 'GET',
        dataType: 'html'
    })
    .success(function (result) {
        $('#lstChefs').replaceWith(result);

    })
    .error(function (xhr, status) {
        alert(status);
    });
    $.ajax({
        url: '../Projet/selectVersions',
        contentType: 'application/html; charset=utf-8',
        type: 'GET',
        dataType: 'html'
    })
    .success(function (result) {
        $('#lstVersions').replaceWith(result);

    })
    .error(function (xhr, status) {
        alert(status);
    });
}
//0 : nouveau , 1 : Modifier , 2 : supprimer
function buttonClick(code) {
    alert(code + " yay");
    switch (code) {
        case 0: enregistrer(code);
            alert("enregistrement");
            break;
        case 1: enregistrer(code);
            break;
        case 2: supprimmer();
            break;
        default: alert("pas un code valide avec un bouton");
            break;
    }
}
//Prend les donnee du formulaire pour les envoyer au controller pour l'enregistrer
function enregistrer(code) {
    var donnee;
    var stringArray = new Array();
    stringArray[0] = code;
    stringArray[1] = $("#txtCodeP").val();
    donnee = document.getElementById("lstChefs");
    donnee = donnee.options[donnee.selectedIndex].value;
    stringArray[2] = donnee;
    stringArray[3] = $("#txtTitreP").val();
    donnee = document.getElementById("lstVersions");
    donnee = donnee.options[donnee.selectedIndex].value;
    stringArray[4] = donnee;
    stringArray[5] = $("#dateCrea").val();
    stringArray[6] = $("#dateEch").val();
    stringArray[7] = $("#txtDesc").val();
    stringArray[8] = $("#txtAutre").val();
    stringArray[9] = $("#txtObj").val();
    var postData = { values: stringArray };

    $.ajax({
        type: "POST",
        url: '../Projet/EnrProjet',
        data: postData,
        dataType: "text",
        traditional: true,
        success: function (data) {
            alert(data);
        }
    });
}
