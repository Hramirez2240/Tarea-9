#pragma checksum "C:\Users\One Piece\Desktop\Tarea-9\Tarea-9\Pages\Index.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d0c7e1599961407d0b7714f7acba7ea1caf45310"
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
#line 1 "C:\Users\One Piece\Desktop\Tarea-9\Tarea-9\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\One Piece\Desktop\Tarea-9\Tarea-9\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\One Piece\Desktop\Tarea-9\Tarea-9\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\One Piece\Desktop\Tarea-9\Tarea-9\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\One Piece\Desktop\Tarea-9\Tarea-9\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\One Piece\Desktop\Tarea-9\Tarea-9\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\One Piece\Desktop\Tarea-9\Tarea-9\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\One Piece\Desktop\Tarea-9\Tarea-9\_Imports.razor"
using Tarea_9;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\One Piece\Desktop\Tarea-9\Tarea-9\_Imports.razor"
using Tarea_9.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\One Piece\Desktop\Tarea-9\Tarea-9\Pages\Index.razor"
using Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\One Piece\Desktop\Tarea-9\Tarea-9\Pages\Index.razor"
using System.Net.Mail;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\One Piece\Desktop\Tarea-9\Tarea-9\Pages\Index.razor"
using System.Text.RegularExpressions;

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
#line 13 "C:\Users\One Piece\Desktop\Tarea-9\Tarea-9\Pages\Index.razor"
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
#line 14 "C:\Users\One Piece\Desktop\Tarea-9\Tarea-9\Pages\Index.razor"
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
#line 15 "C:\Users\One Piece\Desktop\Tarea-9\Tarea-9\Pages\Index.razor"
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
#line 16 "C:\Users\One Piece\Desktop\Tarea-9\Tarea-9\Pages\Index.razor"
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
#line 17 "C:\Users\One Piece\Desktop\Tarea-9\Tarea-9\Pages\Index.razor"
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
#line 18 "C:\Users\One Piece\Desktop\Tarea-9\Tarea-9\Pages\Index.razor"
                                                                                             fecha_nacimiento

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(51, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => fecha_nacimiento = __value, fecha_nacimiento));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(52, "\r\n            ");
            __builder.OpenElement(53, "select");
            __builder.AddAttribute(54, "class", "form-control");
            __builder.AddAttribute(55, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 19 "C:\Users\One Piece\Desktop\Tarea-9\Tarea-9\Pages\Index.razor"
                           tipo_sangre

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(56, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => tipo_sangre = __value, tipo_sangre));
            __builder.SetUpdatesAttributeName("value");
            __builder.AddMarkupContent(57, "\r\n                ");
            __builder.OpenElement(58, "option");
            __builder.AddAttribute(59, "value", true);
            __builder.AddAttribute(60, "disabled", true);
            __builder.AddAttribute(61, "selected", true);
            __builder.AddAttribute(62, "hidden", true);
            __builder.AddContent(63, "Tipo de sangre");
            __builder.CloseElement();
            __builder.AddMarkupContent(64, "\r\n                ");
            __builder.OpenElement(65, "option");
            __builder.AddAttribute(66, "value", "A+");
            __builder.AddContent(67, "A+");
            __builder.CloseElement();
            __builder.AddMarkupContent(68, "\r\n                ");
            __builder.OpenElement(69, "option");
            __builder.AddAttribute(70, "value", "A-");
            __builder.AddContent(71, "A-");
            __builder.CloseElement();
            __builder.AddMarkupContent(72, "\r\n                ");
            __builder.OpenElement(73, "option");
            __builder.AddAttribute(74, "value", "B+");
            __builder.AddContent(75, "B+");
            __builder.CloseElement();
            __builder.AddMarkupContent(76, "\r\n                ");
            __builder.OpenElement(77, "option");
            __builder.AddAttribute(78, "value", "B-");
            __builder.AddContent(79, "B-");
            __builder.CloseElement();
            __builder.AddMarkupContent(80, "\r\n                ");
            __builder.OpenElement(81, "option");
            __builder.AddAttribute(82, "value", "O+");
            __builder.AddContent(83, "O+");
            __builder.CloseElement();
            __builder.AddMarkupContent(84, "\r\n                ");
            __builder.OpenElement(85, "option");
            __builder.AddAttribute(86, "value", "O-");
            __builder.AddContent(87, "O-");
            __builder.CloseElement();
            __builder.AddMarkupContent(88, "\r\n                ");
            __builder.OpenElement(89, "option");
            __builder.AddAttribute(90, "value", "AB+");
            __builder.AddContent(91, "AB+");
            __builder.CloseElement();
            __builder.AddMarkupContent(92, "\r\n                ");
            __builder.OpenElement(93, "option");
            __builder.AddAttribute(94, "value", "AB-");
            __builder.AddContent(95, "AB-");
            __builder.CloseElement();
            __builder.AddMarkupContent(96, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(97, "\r\n            ");
            __builder.OpenElement(98, "input");
            __builder.AddAttribute(99, "type", "text");
            __builder.AddAttribute(100, "class", "form-control");
            __builder.AddAttribute(101, "placeholder", "Provincia");
            __builder.AddAttribute(102, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 30 "C:\Users\One Piece\Desktop\Tarea-9\Tarea-9\Pages\Index.razor"
                                                                                   provincia

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(103, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => provincia = __value, provincia));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(104, "\r\n            ");
            __builder.OpenElement(105, "input");
            __builder.AddAttribute(106, "type", "text");
            __builder.AddAttribute(107, "class", "form-control");
            __builder.AddAttribute(108, "placeholder", "Dirección");
            __builder.AddAttribute(109, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 31 "C:\Users\One Piece\Desktop\Tarea-9\Tarea-9\Pages\Index.razor"
                                                                                   direccion

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(110, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => direccion = __value, direccion));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(111, "\r\n            ");
            __builder.OpenElement(112, "input");
            __builder.AddAttribute(113, "type", "text");
            __builder.AddAttribute(114, "class", "form-control");
            __builder.AddAttribute(115, "placeholder", "Latitud");
            __builder.AddAttribute(116, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 32 "C:\Users\One Piece\Desktop\Tarea-9\Tarea-9\Pages\Index.razor"
                                                                                 lat

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(117, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => lat = __value, lat));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(118, "\r\n            ");
            __builder.OpenElement(119, "input");
            __builder.AddAttribute(120, "type", "text");
            __builder.AddAttribute(121, "class", "form-control");
            __builder.AddAttribute(122, "placeholder", "Longitud");
            __builder.AddAttribute(123, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 33 "C:\Users\One Piece\Desktop\Tarea-9\Tarea-9\Pages\Index.razor"
                                                                                  lon

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(124, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => lon = __value, lon));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(125, "\r\n            ");
            __builder.OpenElement(126, "select");
            __builder.AddAttribute(127, "class", "form-control");
            __builder.AddAttribute(128, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 34 "C:\Users\One Piece\Desktop\Tarea-9\Tarea-9\Pages\Index.razor"
                           covid

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(129, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => covid = __value, covid));
            __builder.SetUpdatesAttributeName("value");
            __builder.AddMarkupContent(130, "\r\n                ");
            __builder.OpenElement(131, "option");
            __builder.AddAttribute(132, "value", true);
            __builder.AddAttribute(133, "disabled", true);
            __builder.AddAttribute(134, "selected", true);
            __builder.AddAttribute(135, "hidden", true);
            __builder.AddMarkupContent(136, "¿Le dio covid?");
            __builder.CloseElement();
            __builder.AddMarkupContent(137, "\r\n                ");
            __builder.OpenElement(138, "option");
            __builder.AddAttribute(139, "value", "Si");
            __builder.AddContent(140, "Si");
            __builder.CloseElement();
            __builder.AddMarkupContent(141, "\r\n                ");
            __builder.OpenElement(142, "option");
            __builder.AddAttribute(143, "value", "No");
            __builder.AddContent(144, "No");
            __builder.CloseElement();
            __builder.AddMarkupContent(145, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(146, "\r\n            ");
            __builder.OpenElement(147, "input");
            __builder.AddAttribute(148, "type", "text");
            __builder.AddAttribute(149, "class", "form-control");
            __builder.AddAttribute(150, "placeholder", "Justifique");
            __builder.AddAttribute(151, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 39 "C:\Users\One Piece\Desktop\Tarea-9\Tarea-9\Pages\Index.razor"
                                                                                    justificacion

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(152, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => justificacion = __value, justificacion));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(153, "\r\n            ");
            __builder.OpenElement(154, "button");
            __builder.AddAttribute(155, "class", "btn btn-primary");
            __builder.AddAttribute(156, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 40 "C:\Users\One Piece\Desktop\Tarea-9\Tarea-9\Pages\Index.razor"
                                                      AgregarVacuna

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(157, "id", "btnejemplo");
            __builder.AddContent(158, "Enviar datos");
            __builder.CloseElement();
            __builder.AddMarkupContent(159, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(160, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(161, "\r\n    <br><br>\r\n\r\n    ");
            __builder.OpenElement(162, "div");
            __builder.AddAttribute(163, "id", "ca");
            __builder.AddMarkupContent(164, "\r\n");
#nullable restore
#line 46 "C:\Users\One Piece\Desktop\Tarea-9\Tarea-9\Pages\Index.razor"
         if (mensaje == 1)
        {

#line default
#line hidden
#nullable disable
            __builder.AddContent(165, "            ");
            __builder.OpenElement(166, "div");
            __builder.AddAttribute(167, "class", "alert alert-success");
            __builder.AddAttribute(168, "role", "alert");
            __builder.AddMarkupContent(169, "\r\n                Gracias por enviar los datos Sr/a. ");
            __builder.AddContent(170, 
#nullable restore
#line 49 "C:\Users\One Piece\Desktop\Tarea-9\Tarea-9\Pages\Index.razor"
                                                    nombre

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(171, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(172, "\r\n");
#nullable restore
#line 51 "C:\Users\One Piece\Desktop\Tarea-9\Tarea-9\Pages\Index.razor"
        }

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(173, "\r\n");
#nullable restore
#line 53 "C:\Users\One Piece\Desktop\Tarea-9\Tarea-9\Pages\Index.razor"
         if (mensaje_error == 1)
        {

#line default
#line hidden
#nullable disable
            __builder.AddContent(174, "            ");
            __builder.OpenElement(175, "div");
            __builder.AddAttribute(176, "class", "alert alert-danger");
            __builder.AddAttribute(177, "role", "alert");
            __builder.AddMarkupContent(178, "\r\n                Ya su solicitud fue registrada, se envió una confirmación al correo: ");
            __builder.AddContent(179, 
#nullable restore
#line 56 "C:\Users\One Piece\Desktop\Tarea-9\Tarea-9\Pages\Index.razor"
                                                                                      correo_verificado

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(180, " favor verificar.\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(181, "\r\n");
#nullable restore
#line 58 "C:\Users\One Piece\Desktop\Tarea-9\Tarea-9\Pages\Index.razor"
        }

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(182, "\r\n");
#nullable restore
#line 60 "C:\Users\One Piece\Desktop\Tarea-9\Tarea-9\Pages\Index.razor"
         if (mensaje_vacio == 1)
        {

#line default
#line hidden
#nullable disable
            __builder.AddContent(183, "            ");
            __builder.AddMarkupContent(184, "<div class=\"alert alert-danger\" role=\"alert\">\r\n                Por favor complete todos los datos.\r\n            </div>\r\n");
#nullable restore
#line 65 "C:\Users\One Piece\Desktop\Tarea-9\Tarea-9\Pages\Index.razor"
        }

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(185, "\r\n");
#nullable restore
#line 67 "C:\Users\One Piece\Desktop\Tarea-9\Tarea-9\Pages\Index.razor"
           if (mensaje_vacio == 15)
        {

#line default
#line hidden
#nullable disable
            __builder.AddContent(186, "            ");
            __builder.AddMarkupContent(187, "<div class=\"alert alert-danger\" role=\"alert\">\r\n                Favor de ingresar un correo Valido\r\n            </div>\r\n");
#nullable restore
#line 72 "C:\Users\One Piece\Desktop\Tarea-9\Tarea-9\Pages\Index.razor"
        }

#line default
#line hidden
#nullable disable
            __builder.AddContent(188, "    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(189, "\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(190, "\r\n<hr>");
        }
        #pragma warning restore 1998
#nullable restore
#line 77 "C:\Users\One Piece\Desktop\Tarea-9\Tarea-9\Pages\Index.razor"
      

    private string Menssage{get;set;} = "";
    string cedula = "", nombre = "", apellido = "", telefono = "", correo = "",
        fecha_nacimiento = "", tipo_sangre = "", provincia = "", direccion = "", lat = "", lon = "", covid = "";

    int mensaje = 0, mensaje_error = 0, mensaje_vacio = 0;
    string justificacion = "";
    string correo_verificado;
    string recibido="Saludos,<br> Muchas gracias por registrarte en la jornardada de Prevencion del Covid-19.";
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

                correo_verificado = va.Correo;
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
                vacu.Telefono = telefono;
                vacu.Correo = correo;
                vacu.FechaNacimiento = fecha_nacimiento;
                vacu.TipoSangre = tipo_sangre;
                vacu.Provincia = provincia;
                vacu.Direccion = direccion;
                vacu.Latitud = lat;
                vacu.Longitud = lon;
                vacu.Covid = covid;
                vacu.Justifique = justificacion;

                if (vacu.Cedula == "" || vacu.Nombre == "" || vacu.Apellido == "" || vacu.Telefono == "" || vacu.Correo == "" ||
                    vacu.FechaNacimiento == "" || vacu.TipoSangre == "" || vacu.Provincia == "" || vacu.Direccion == "" || vacu.Latitud == "" ||
                    vacu.Longitud == "" || vacu.Covid == "" || vacu.Justifique == "")
                {
                    mensaje = 0;
                    mensaje_error = 0;
                    mensaje_vacio = 1;
                }

                else
                {
                    if(IsValidEmail(vacu.Correo)){
                        contexto.Add(vacu);
                        contexto.SaveChanges();
                        mensaje_error = 0;
                        mensaje_vacio = 0;
                        mensaje = 1;

                        SenMail(vacu.Correo,recibido);


                    

                       cedula = "";
                       apellido = "";
                       telefono = "";
                       correo = "";
                       fecha_nacimiento = "";
                       tipo_sangre = "";
                       provincia = "";
                       direccion = "";
                       lat = "";
                       lon = "";
                       covid = "";
                       justificacion = "";
                    }else{
                            mensaje_vacio = 15;
                    }
                    
                }
            }

        }
    }


    

#line default
#line hidden
#nullable disable
#nullable restore
#line 170 "C:\Users\One Piece\Desktop\Tarea-9\Tarea-9\Pages\Index.razor"
                                                      
    public static bool IsValidEmail(string strMailAddress)
        {
        // Return true if strIn is in valid e-mail format.
        return Regex.IsMatch(strMailAddress, @"^(?("")("".+?""@)|(([0-9a-zA-Z]((\.(?!\.))|[-!#\$%&'\*\+/=\?\^`\{\}\|~\w])*)(?<=[0-9a-zA-Z])@))" + @"(?(\[)(\[(\d{1,3}\.){3}\d{1,3}\])|(([0-9a-zA-Z][-\w]*[0-9a-zA-Z]\.)+[a-zA-Z]{2,6}))$");
    }

    

#line default
#line hidden
#nullable disable
#nullable restore
#line 177 "C:\Users\One Piece\Desktop\Tarea-9\Tarea-9\Pages\Index.razor"
                                  
    private void SenMail(String enviar1,String mensajeEnviar){
        try{
            using(MailMessage mail = new MailMessage()){
                mail.From = new MailAddress("calkin440040@gmail.com");
                mail.To.Add(enviar1);
                mail.Subject = "Registro de Vacuna por Casa.";
                mail.Body = (mensajeEnviar);
                mail.IsBodyHtml = true;

                using (SmtpClient smtp = new SmtpClient("smtp.gmail.com",587)){
                    smtp.Credentials = new System.Net.NetworkCredential("calkin440040@gmail.com","And440040");
                    smtp.EnableSsl = true;
                    smtp.Send(mail);
                    Menssage = "Mail Sent";
                    
                }
            }
            
        }catch(Exception ex){
            Menssage = ex.Message;
        }
    }


#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
