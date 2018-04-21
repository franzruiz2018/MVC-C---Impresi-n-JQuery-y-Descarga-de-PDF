function DescargarPDF(ContenidoID, nombre) {
    var pdf = new jsPDF('p', 'pt', 'letter');
    html = $('#' + ContenidoID).html();
    specialElementHandlers = {};
    margins = { top: 10, bottom: 20, left: 20, width: 700 };
    pdf.fromHTML(html, margins.left, margins.top, { 'width': margins.width }, function (dispose) { pdf.save(nombre + '.pdf'); }, margins);
}



function ImprimirPrintJQuery() {
    $("#reporte").print();
}
function ImprimirJS(ContenidoId) {
    var restorePage = document.body.innerHTML;
    var printContent = document.getElementById(ContenidoId).innerHTML;
    document.body.innerHTML = printContent;
    window.print();
    document.body.innerHTML = restorePage;
}


