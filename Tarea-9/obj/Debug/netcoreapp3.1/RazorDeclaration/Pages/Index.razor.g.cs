// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace Tarea_9.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
<<<<<<< HEAD
#line 1 "C:\2021\Tarea-9\Tarea-9\_Imports.razor"
=======
#line 1 "C:\Users\User\Desktop\Programacion 3\Tarea-9\Tarea-9\_Imports.razor"
>>>>>>> 757a033339ab5219600ed7223377cb3ac303ada9
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
<<<<<<< HEAD
#line 2 "C:\2021\Tarea-9\Tarea-9\_Imports.razor"
=======
#line 2 "C:\Users\User\Desktop\Programacion 3\Tarea-9\Tarea-9\_Imports.razor"
>>>>>>> 757a033339ab5219600ed7223377cb3ac303ada9
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
<<<<<<< HEAD
#line 3 "C:\2021\Tarea-9\Tarea-9\_Imports.razor"
=======
#line 3 "C:\Users\User\Desktop\Programacion 3\Tarea-9\Tarea-9\_Imports.razor"
>>>>>>> 757a033339ab5219600ed7223377cb3ac303ada9
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
<<<<<<< HEAD
#line 4 "C:\2021\Tarea-9\Tarea-9\_Imports.razor"
=======
#line 4 "C:\Users\User\Desktop\Programacion 3\Tarea-9\Tarea-9\_Imports.razor"
>>>>>>> 757a033339ab5219600ed7223377cb3ac303ada9
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
<<<<<<< HEAD
#line 5 "C:\2021\Tarea-9\Tarea-9\_Imports.razor"
=======
#line 5 "C:\Users\User\Desktop\Programacion 3\Tarea-9\Tarea-9\_Imports.razor"
>>>>>>> 757a033339ab5219600ed7223377cb3ac303ada9
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
<<<<<<< HEAD
#line 6 "C:\2021\Tarea-9\Tarea-9\_Imports.razor"
=======
#line 6 "C:\Users\User\Desktop\Programacion 3\Tarea-9\Tarea-9\_Imports.razor"
>>>>>>> 757a033339ab5219600ed7223377cb3ac303ada9
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
<<<<<<< HEAD
#line 7 "C:\2021\Tarea-9\Tarea-9\_Imports.razor"
=======
#line 7 "C:\Users\User\Desktop\Programacion 3\Tarea-9\Tarea-9\_Imports.razor"
>>>>>>> 757a033339ab5219600ed7223377cb3ac303ada9
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
<<<<<<< HEAD
#line 8 "C:\2021\Tarea-9\Tarea-9\_Imports.razor"
=======
#line 8 "C:\Users\User\Desktop\Programacion 3\Tarea-9\Tarea-9\_Imports.razor"
>>>>>>> 757a033339ab5219600ed7223377cb3ac303ada9
using Tarea_9;

#line default
#line hidden
#nullable disable
#nullable restore
<<<<<<< HEAD
#line 9 "C:\2021\Tarea-9\Tarea-9\_Imports.razor"
=======
#line 9 "C:\Users\User\Desktop\Programacion 3\Tarea-9\Tarea-9\_Imports.razor"
>>>>>>> 757a033339ab5219600ed7223377cb3ac303ada9
using Tarea_9.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
<<<<<<< HEAD
#line 2 "C:\2021\Tarea-9\Tarea-9\Pages\Index.razor"
=======
#line 2 "C:\Users\User\Desktop\Programacion 3\Tarea-9\Tarea-9\Pages\Index.razor"
>>>>>>> 757a033339ab5219600ed7223377cb3ac303ada9
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
        }
        #pragma warning restore 1998
#nullable restore
<<<<<<< HEAD
#line 46 "C:\2021\Tarea-9\Tarea-9\Pages\Index.razor"
      
    string cedula = "", nombre = "", apellido = "", telefono = "", correo = "",
        fecha_nacimiento = "", tipo_sangre = "", provincia = "", direccion = "", lat = "", lon = "";

    int covid, mensaje = 0, mensaje_error = 0, mensaje_vacio = 0;
=======
#line 53 "C:\Users\User\Desktop\Programacion 3\Tarea-9\Tarea-9\Pages\Index.razor"
      
    string cedula = "", nombre = "", apellido = "", telefono = "", correo = "",
        fecha_nacimiento = "", tipo_sangre = "", provincia = "", direccion = "", lat = "", lon = "", covid = "";

    int mensaje = 0, mensaje_error = 0, mensaje_vacio = 0;
>>>>>>> 757a033339ab5219600ed7223377cb3ac303ada9
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
<<<<<<< HEAD
                //vacu.LeHaDadoCovid = Convert.ToBoolean(covid);
                vacu.Justifique = justificacion;

                if (vacu.Cedula == "" || vacu.Nombre == "" || vacu.Apellido == "" || vacu.Teléfono == "" || vacu.CorreoElectronico == "")
                /*vacu.FechaDeNacimiento == "" || vacu.TipoDeSangre == "" || vacu.Provincia == "" || vacu.Direccion == "" || vacu.Latitud == "" || vacu.Longitud == "" || vacu.Justifique == ""*/
=======
                vacu.LeHaDadoCovid = covid;
                vacu.Justifique = justificacion;

                if (vacu.Cedula == "" || vacu.Nombre == "" || vacu.Apellido == "" || vacu.Teléfono == "" || vacu.CorreoElectronico == "" ||
                    vacu.FechaDeNacimiento == "" || vacu.TipoDeSangre == "" || vacu.Provincia == "" || vacu.Direccion == "" || vacu.Latitud == "" ||
                    vacu.Longitud == "" || vacu.LeHaDadoCovid == "" || vacu.Justifique == "")
>>>>>>> 757a033339ab5219600ed7223377cb3ac303ada9
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
