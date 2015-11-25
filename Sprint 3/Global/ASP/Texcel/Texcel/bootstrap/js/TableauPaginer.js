//balisesPage:Balise pour ou les page vont etre,tableau: Le tableau,rowShow: nombre de ligne par pages
function Paginer(balisePage, tableau, rowShow) {
    $('#'+balisePage).html('<ul id="nav" class="pagination"></ul>');
    var rowsShown = rowShow;
    var rowsTotal = $('#'+tableau+' tbody tr').length;
    var numPages = rowsTotal/rowsShown;
    for(i = 0;i < numPages;i++) {
        var pageNum = i + 1;
        $('#nav').append('<li class="paginate_button"><a href="#" rel="' + i + '">' + pageNum + '</a></li> ');
    }
    $('#' + tableau + ' tbody tr').hide();
    $('#' + tableau + ' tbody tr').slice(0, rowsShown).show();
    $('#nav a').bind('click', function(){

        var currPage = $(this).attr('rel');
        var startItem = currPage * rowsShown;
        var endItem = startItem + rowsShown; 
        $('#' + tableau + ' tbody tr').css('opacity', '0.0').hide().slice(startItem, endItem).
                css('display','table-row').animate({opacity:1}, 300);
    });
}