#pragma checksum "C:\Users\User\Desktop\Programacion 3\Tarea-9\Tarea-9\Pages\Index.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "72a4c36b7d619d98201482fb1b28a0618a747ea9"
// <auto-generated/>
#pragma warning disable 1591
namespace Tarea_9.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\User\Desktop\Programacion 3\Tarea-9\Tarea-9\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\User\Desktop\Programacion 3\Tarea-9\Tarea-9\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\User\Desktop\Programacion 3\Tarea-9\Tarea-9\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\User\Desktop\Programacion 3\Tarea-9\Tarea-9\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\User\Desktop\Programacion 3\Tarea-9\Tarea-9\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\User\Desktop\Programacion 3\Tarea-9\Tarea-9\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\User\Desktop\Programacion 3\Tarea-9\Tarea-9\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\User\Desktop\Programacion 3\Tarea-9\Tarea-9\_Imports.razor"
using Tarea_9;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\User\Desktop\Programacion 3\Tarea-9\Tarea-9\_Imports.razor"
using Tarea_9.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\User\Desktop\Programacion 3\Tarea-9\Tarea-9\Pages\Index.razor"
using Models;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    public partial class Index : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddMarkupContent(1, "\r\n    ");
            __builder.AddMarkupContent(2, "<h1 class=\"text-center\">Formulario para ser vacunado en casa</h1>\r\n    <hr>\r\n    <br>\r\n    ");
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "class", "card");
            __builder.AddAttribute(5, "style", "width: 55rem;");
            __builder.AddMarkupContent(6, "\r\n        ");
            __builder.OpenElement(7, "div");
            __builder.AddAttribute(8, "class", "card-body");
            __builder.AddMarkupContent(9, "\r\n            ");
            __builder.AddMarkupContent(10, "<h5 class=\"card-title\" style=\"text-align: center;\">Datos Requeridos</h5>\r\n            ");
            __builder.OpenElement(11, "input");
            __builder.AddAttribute(12, "type", "text");
            __builder.AddAttribute(13, "class", "form-control");
            __builder.AddAttribute(14, "placeholder", "Cedula");
            __builder.AddAttribute(15, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 11 "C:\Users\User\Desktop\Programacion 3\Tarea-9\Tarea-9\Pages\Index.razor"
                                                                                cedula

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(16, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => cedula = __value, cedula));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(17, "\r\n            ");
            __builder.OpenElement(18, "input");
            __builder.AddAttribute(19, "type", "text");
            __builder.AddAttribute(20, "class", "form-control");
            __builder.AddAttribute(21, "placeholder", "Nombre");
            __builder.AddAttribute(22, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 12 "C:\Users\User\Desktop\Programacion 3\Tarea-9\Tarea-9\Pages\Index.razor"
                                                                                nombre

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(23, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => nombre = __value, nombre));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(24, "\r\n            ");
            __builder.OpenElement(25, "input");
            __builder.AddAttribute(26, "type", "text");
            __builder.AddAttribute(27, "class", "form-control");
            __builder.AddAttribute(28, "placeholder", "Apellido");
            __builder.AddAttribute(29, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 13 "C:\Users\User\Desktop\Programacion 3\Tarea-9\Tarea-9\Pages\Index.razor"
                                                                                  apellido

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(30, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => apellido = __value, apellido));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(31, "\r\n            ");
            __builder.OpenElement(32, "input");
            __builder.AddAttribute(33, "type", "text");
            __builder.AddAttribute(34, "class", "form-control");
            __builder.AddAttribute(35, "placeholder", "Teléfono");
            __builder.AddAttribute(36, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 14 "C:\Users\User\Desktop\Programacion 3\Tarea-9\Tarea-9\Pages\Index.razor"
                                                                                  telefono

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(37, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => telefono = __value, telefono));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(38, "\r\n            ");
            __builder.OpenElement(39, "input");
            __builder.AddAttribute(40, "type", "text");
            __builder.AddAttribute(41, "class", "form-control");
            __builder.AddAttribute(42, "placeholder", "Correo Electrónico");
            __builder.AddAttribute(43, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 15 "C:\Users\User\Desktop\Programacion 3\Tarea-9\Tarea-9\Pages\Index.razor"
                                                                                            correo

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(44, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => correo = __value, correo));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(45, "\r\n            ");
            __builder.OpenElement(46, "input");
            __builder.AddAttribute(47, "type", "text");
            __builder.AddAttribute(48, "class", "form-control");
            __builder.AddAttribute(49, "placeholder", "Fecha de Nacimiento");
            __builder.AddAttribute(50, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 16 "C:\Users\User\Desktop\Programacion 3\Tarea-9\Tarea-9\Pages\Index.razor"
                                                                                             fecha_nacimiento

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(51, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => fecha_nacimiento = __value, fecha_nacimiento));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(52, "\r\n            ");
            __builder.OpenElement(53, "input");
            __builder.AddAttribute(54, "type", "text");
            __builder.AddAttribute(55, "class", "form-control");
            __builder.AddAttribute(56, "placeholder", "Tipo de Sangre");
            __builder.AddAttribute(57, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 17 "C:\Users\User\Desktop\Programacion 3\Tarea-9\Tarea-9\Pages\Index.razor"
                                                                                        tipo_sangre

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(58, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => tipo_sangre = __value, tipo_sangre));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(59, "\r\n            ");
            __builder.OpenElement(60, "input");
            __builder.AddAttribute(61, "type", "text");
            __builder.AddAttribute(62, "class", "form-control");
            __builder.AddAttribute(63, "placeholder", "Provincia");
            __builder.AddAttribute(64, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 18 "C:\Users\User\Desktop\Programacion 3\Tarea-9\Tarea-9\Pages\Index.razor"
                                                                                   provincia

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(65, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => provincia = __value, provincia));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(66, "\r\n            ");
            __builder.OpenElement(67, "input");
            __builder.AddAttribute(68, "type", "text");
            __builder.AddAttribute(69, "class", "form-control");
            __builder.AddAttribute(70, "placeholder", "Dirección");
            __builder.AddAttribute(71, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 19 "C:\Users\User\Desktop\Programacion 3\Tarea-9\Tarea-9\Pages\Index.razor"
                                                                                   direccion

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(72, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => direccion = __value, direccion));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(73, "\r\n            ");
            __builder.OpenElement(74, "input");
            __builder.AddAttribute(75, "type", "text");
            __builder.AddAttribute(76, "class", "form-control");
            __builder.AddAttribute(77, "placeholder", "Latitud");
            __builder.AddAttribute(78, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 20 "C:\Users\User\Desktop\Programacion 3\Tarea-9\Tarea-9\Pages\Index.razor"
                                                                                 lat

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(79, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => lat = __value, lat));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(80, "\r\n            ");
            __builder.OpenElement(81, "input");
            __builder.AddAttribute(82, "type", "text");
            __builder.AddAttribute(83, "class", "form-control");
            __builder.AddAttribute(84, "placeholder", "Longitud");
            __builder.AddAttribute(85, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 21 "C:\Users\User\Desktop\Programacion 3\Tarea-9\Tarea-9\Pages\Index.razor"
                                                                                  lon

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(86, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => lon = __value, lon));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(87, "\r\n            ");
            __builder.OpenElement(88, "input");
            __builder.AddAttribute(89, "type", "text");
            __builder.AddAttribute(90, "class", "form-control");
            __builder.AddAttribute(91, "placeholder", "Le ha dado covid");
            __builder.AddAttribute(92, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 22 "C:\Users\User\Desktop\Programacion 3\Tarea-9\Tarea-9\Pages\Index.razor"
                                                                                          covid

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(93, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => covid = __value, covid));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(94, "\r\n            ");
            __builder.OpenElement(95, "input");
            __builder.AddAttribute(96, "type", "text");
            __builder.AddAttribute(97, "class", "form-control");
            __builder.AddAttribute(98, "placeholder", "Justifiqué");
            __builder.AddAttribute(99, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 23 "C:\Users\User\Desktop\Programacion 3\Tarea-9\Tarea-9\Pages\Index.razor"
                                                                                    justificacion

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(100, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => justificacion = __value, justificacion));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(101, "\r\n            ");
            __builder.OpenElement(102, "button");
            __builder.AddAttribute(103, "class", "btn btn-primary");
            __builder.AddAttribute(104, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 24 "C:\Users\User\Desktop\Programacion 3\Tarea-9\Tarea-9\Pages\Index.razor"
                                                      AgregarVacuna

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(105, "id", "btnejemplo");
            __builder.AddContent(106, "Enviar datos");
            __builder.CloseElement();
            __builder.AddMarkupContent(107, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(108, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(109, "\r\n    <br><br>\r\n\r\n    ");
            __builder.OpenElement(110, "div");
            __builder.AddAttribute(111, "id", "ca");
            __builder.AddMarkupContent(112, "\r\n");
#nullable restore
#line 30 "C:\Users\User\Desktop\Programacion 3\Tarea-9\Tarea-9\Pages\Index.razor"
         if (mensaje == 1)
        {

#line default
#line hidden
#nullable disable
            __builder.AddContent(113, "            ");
            __builder.OpenElement(114, "div");
            __builder.AddAttribute(115, "class", "alert alert-success mb-2");
            __builder.AddAttribute(116, "role", "alert");
            __builder.AddMarkupContent(117, "\r\n                Gracias por enviar los datos Sr/a. ");
            __builder.AddContent(118, 
#nullable restore
#line 33 "C:\Users\User\Desktop\Programacion 3\Tarea-9\Tarea-9\Pages\Index.razor"
                                                    nombre

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(119, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(120, "\r\n");
#nullable restore
#line 35 "C:\Users\User\Desktop\Programacion 3\Tarea-9\Tarea-9\Pages\Index.razor"
        }

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(121, "\r\n");
#nullable restore
#line 37 "C:\Users\User\Desktop\Programacion 3\Tarea-9\Tarea-9\Pages\Index.razor"
         if (mensaje_error == 1)
        {

#line default
#line hidden
#nullable disable
            __builder.AddContent(122, "            ");
            __builder.OpenElement(123, "div");
            __builder.AddAttribute(124, "class", "alert alert-danger mb-2");
            __builder.AddAttribute(125, "role", "alert");
            __builder.AddMarkupContent(126, "\r\n                Ya su solicitud fue registrada, se envió una confirmación al correo: ");
            __builder.AddContent(127, 
#nullable restore
#line 40 "C:\Users\User\Desktop\Programacion 3\Tarea-9\Tarea-9\Pages\Index.razor"
                                                                                      correo_verificado

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(128, " favor verificar.\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(129, "\r\n");
#nullable restore
#line 42 "C:\Users\User\Desktop\Programacion 3\Tarea-9\Tarea-9\Pages\Index.razor"
        }

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(130, "\r\n");
#nullable restore
#line 44 "C:\Users\User\Desktop\Programacion 3\Tarea-9\Tarea-9\Pages\Index.razor"
         if (mensaje_vacio == 1)
        {

#line default
#line hidden
#nullable disable
            __builder.AddContent(131, "            ");
            __builder.AddMarkupContent(132, "<div class=\"alert alert-danger mb-2\" role=\"alert\">\r\n                Por favor complete todos los datos.\r\n            </div>\r\n");
#nullable restore
#line 49 "C:\Users\User\Desktop\Programacion 3\Tarea-9\Tarea-9\Pages\Index.razor"
        }

#line default
#line hidden
#nullable disable
            __builder.AddContent(133, "    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(134, "\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 53 "C:\Users\User\Desktop\Programacion 3\Tarea-9\Tarea-9\Pages\Index.razor"
      
    string cedula = "", nombre = "", apellido = "", telefono = "", correo = "",
        fecha_nacimiento = "", tipo_sangre = "", provincia = "", direccion = "", lat = "", lon = "", covid = "";

    int mensaje = 0, mensaje_error = 0, mensaje_vacio = 0;
    string justificacion = "";
    string correo_verificado;
    bool validar;

    public void AgregarVacuna()
    {
        using (db_a72461_backupContext contexto = new db_a72461_backupContext())
        {
            validar = contexto.Vacunas.Any(ee => ee.Cedula == cedula);

            if (validar)
            {
                Vacunas va = contexto.Vacunas
                        .Where(e => e.Cedula == cedula)
                        .FirstOrDefault();

                correo_verificado = va.CorreoElectronico;
                mensaje = 0;
                mensaje_vacio = 0;
                mensaje_error = 1;
            }

            else
            {
                Vacunas vacu = new Vacunas();
                vacu.Cedula = cedula;
                vacu.Nombre = nombre;
                vacu.Apellido = apellido;
                vacu.Teléfono = telefono;
                vacu.CorreoElectronico = correo;
                vacu.FechaDeNacimiento = fecha_nacimiento;
                vacu.TipoDeSangre = tipo_sangre;
                vacu.Provincia = provincia;
                vacu.Direccion = direccion;
                vacu.Latitud = lat;
                vacu.Longitud = lon;
                vacu.LeHaDadoCovid = covid;
                vacu.Justifique = justificacion;

                if (vacu.Cedula == "" || vacu.Nombre == "" || vacu.Apellido == "" || vacu.Teléfono == "" || vacu.CorreoElectronico == "" ||
                    vacu.FechaDeNacimiento == "" || vacu.TipoDeSangre == "" || vacu.Provincia == "" || vacu.Direccion == "" || vacu.Latitud == "" ||
                    vacu.Longitud == "" || vacu.LeHaDadoCovid == "" || vacu.Justifique == "")
                {
                    mensaje = 0;
                    mensaje_error = 0;
                    mensaje_vacio = 1;
                }

                else
                {
                    contexto.Add(vacu);
                    contexto.SaveChanges();
                    mensaje_error = 0;
                    mensaje_vacio = 0;
                    mensaje = 1;
                }
            }

        }
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
