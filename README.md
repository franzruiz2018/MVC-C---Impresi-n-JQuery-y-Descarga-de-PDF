# MVC-C---Impresión-JQuery-y-Descarga-de-PDF

**Se crea la clase alumnos y el metodo ListaAlumnos en el cual se carga de devolver una lista con registros de alumnos.**
``` 
public class Alumno
    {
        public int id { get; set; }
        public string name { get; set; }
        public int dni { get; set; }
        public string direccion { get; set; }
        public DateTime fechaRegistro { get; set; }

        public List<Alumno> ListaAlumnos()
        {
           List<Alumno> _ListaAlumnos=new   List<Alumno>();

           Alumno alumno1 = new Alumno();
           alumno1.id = 1;
           alumno1.name = "Franz";
           alumno1.dni = 12345678;
           alumno1.direccion = "Lima";
           alumno1.fechaRegistro = Convert.ToDateTime("01/02/2018 08:00:00");
           _ListaAlumnos.Add(alumno1);

           Alumno alumno2 = new Alumno();
           alumno2.id = 2;
           alumno2.name = "Milka";
           alumno2.dni = 12345678;
           alumno2.direccion = "Lima";
           alumno2.fechaRegistro = Convert.ToDateTime("01/02/2018 08:00:00");
           _ListaAlumnos.Add(alumno2);

           Alumno alumno3 = new Alumno();
           alumno3.id = 3;
           alumno3.name = "Carmen";
           alumno3.dni = 12345678;
           alumno3.direccion = "Lima";
           alumno3.fechaRegistro = Convert.ToDateTime("01/02/2018 08:00:00");
           _ListaAlumnos.Add(alumno3);

           Alumno alumno4 = new Alumno();
           alumno4.id = 4;
           alumno4.name = "Harold";
           alumno4.dni = 12345678;
           alumno4.direccion = "Lima";
           alumno4.fechaRegistro = Convert.ToDateTime("01/02/2018 08:00:00");
           _ListaAlumnos.Add(alumno4);
          
           return _ListaAlumnos;

        }
  ```
  
  **En el controlador se envia a la vista la lista de alumnos creados en el modelo**
  ```
   public class AlumnoController : Controller
    {
        //
        // GET: /Alumno/
        public ActionResult Index()
        {
            Alumno a = new Alumno();
            ViewBag.ListaAlumnos = a.ListaAlumnos();
            ViewBag.NumRegistros = a.ListaAlumnos().Count();

            return View();
        }
	}
  ```
  
  **En la vista se recorre la lista y se muestra los datos en una tabla**
  ```
  <div id="reporte" class="reporte" >
    <h3>Lista de Alumnos</h3>
    <p>Total de Alumnos: @ViewBag.NumRegistros</p>
    <p>Total de Alumnos:  @Enumerable.Count(ViewBag.ListaAlumnos)</p>
    <table class="table">
        <tr>
            <th>ID</th>
            <th>Nombre</th>
            <th>DNI</th>
            <th>Dirección</th>
            <th>Fecha Registro</th>
            <th>Hora Registro</th>
        </tr>
        @foreach (var alumno in ViewBag.ListaAlumnos)
        { 
        <tr>
            <td>@alumno.id</td>
            <td>@alumno.name</td>
            <td>@alumno.dni</td>
            <td>@alumno.direccion</td>
            <td>@Convert.ToDateTime(alumno.fechaRegistro).ToString("dd/MM/yyyy")</td>
            <td>@Convert.ToDateTime(alumno.fechaRegistro).ToString("hh:mm")</td>
        </tr>
        }
    </table>
</div>
  ```
  
  **Se crea 3 botonos, la primera para descargar un pdf, la segunda imprimir un contenido especifico a traves de Jquery y por ultimo el tercer boton realiza lo mismo que el segundo boton solo con la diferencia que lo realiza con JavaScript**
  
  ```
  <input type="button" class="btn btn-default"  onclick="DescargarPDF('reporte', 'ReporteNet')" value="Descargar PDF" />
<input type="button" class="btn btn-default" onclick="ImprimirPrintJQuery()" value="Imprimir PrintJQuery" />
<input type="button" class="btn btn-default" onclick="ImprimirJS('reporte')" value="Imprimir JS" />

  ```
**El primer boton utiliza la libreria jspdf.debug.js y se crea la función DescargarPDF el cual tienen como primer parametro el contenedor a exportar y el segundo parametro el nombre del archivo pdf**

 ```
 function DescargarPDF(ContenidoID, nombre) {
    var pdf = new jsPDF('p', 'pt', 'letter');
    html = $('#' + ContenidoID).html();
    specialElementHandlers = {};
    margins = { top: 10, bottom: 20, left: 20, width: 700 };
    pdf.fromHTML(html, margins.left, margins.top, { 'width': margins.width }, function (dispose) { pdf.save(nombre + '.pdf'); }, margins);
}
  ```

 **El segundo botón utiliza la librería  jQuery.print.js y se crea la funcion ImprimirPrintJQuery(ContenidoID) el cual tiene como parametro el contenedor a imprimir**

 ```
 function ImprimirPrintJQuery(ContenidoID) {
    $('#' + ContenidoID).print();
}
 ```

 **El tercer botón realiza lo mismo que el segundo, con la diferencia que la funcion ImprimirJS('reporte') es creada con JavaScript**
```
function ImprimirJS(ContenidoId) {
    var restorePage = document.body.innerHTML;
    var printContent = document.getElementById(ContenidoId).innerHTML;
    document.body.innerHTML = printContent;
    window.print();
    document.body.innerHTML = restorePage;
}
```
