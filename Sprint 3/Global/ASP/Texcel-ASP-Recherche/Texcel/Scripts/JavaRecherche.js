function FiltrerTableau(nomtableau, nomRecherche) {
    var $rows = $('#'+nomtableau+' tr');
    $('#'+nomRecherche).keyup(function () {
        var val = $.trim($(this).val()).replace(/ +/g, ' ').toLowerCase();

        $rows.show().filter(function () {
            var text = $(this).text().replace(/\s+/g, ' ').toLowerCase();
            return !~text.indexOf(val);
        }).hide();
    });
}