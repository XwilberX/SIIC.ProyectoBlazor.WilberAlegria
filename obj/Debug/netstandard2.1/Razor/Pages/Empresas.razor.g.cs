#pragma checksum "C:\Practicas\SIIC.ProyectoBlazor.WilberAlegria\Pages\Empresas.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "27233a2938905080826b4f6f5f2bda1394f6a8d0"
// <auto-generated/>
#pragma warning disable 1591
namespace SIIC.ProyectoBlazor.WilberAlegria.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Practicas\SIIC.ProyectoBlazor.WilberAlegria\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Practicas\SIIC.ProyectoBlazor.WilberAlegria\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Practicas\SIIC.ProyectoBlazor.WilberAlegria\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Practicas\SIIC.ProyectoBlazor.WilberAlegria\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Practicas\SIIC.ProyectoBlazor.WilberAlegria\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Practicas\SIIC.ProyectoBlazor.WilberAlegria\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Practicas\SIIC.ProyectoBlazor.WilberAlegria\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Practicas\SIIC.ProyectoBlazor.WilberAlegria\_Imports.razor"
using SIIC.ProyectoBlazor.WilberAlegria;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Practicas\SIIC.ProyectoBlazor.WilberAlegria\_Imports.razor"
using SIIC.ProyectoBlazor.WilberAlegria.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Practicas\SIIC.ProyectoBlazor.WilberAlegria\_Imports.razor"
using Blazored;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Practicas\SIIC.ProyectoBlazor.WilberAlegria\_Imports.razor"
using Blazored.Modal;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Practicas\SIIC.ProyectoBlazor.WilberAlegria\_Imports.razor"
using Blazored.Modal.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Practicas\SIIC.ProyectoBlazor.WilberAlegria\_Imports.razor"
using Feather.Blazor.Icons;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/empresas")]
    public partial class Empresas : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h1>Empresas</h1>\r\n\r\n");
            __builder.OpenElement(1, "button");
            __builder.AddAttribute(2, "type", "button");
            __builder.AddAttribute(3, "class", "btn btn-success");
            __builder.AddAttribute(4, "data-toggle", "modal");
            __builder.AddAttribute(5, "data-target", "#exampleModal");
            __builder.AddAttribute(6, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 5 "C:\Practicas\SIIC.ProyectoBlazor.WilberAlegria\Pages\Empresas.razor"
                                                                                                        NewEmpresa

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(7, "\r\n  Agregar Empresa ");
            __builder.OpenComponent<Feather.Blazor.Icons.FeatherUploadCloud>(8);
            __builder.AddAttribute(9, "Size", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 6 "C:\Practicas\SIIC.ProyectoBlazor.WilberAlegria\Pages\Empresas.razor"
                                            20

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(10, "Color", "#ffffff");
            __builder.AddAttribute(11, "StrokeWidth", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Single>(
#nullable restore
#line 6 "C:\Practicas\SIIC.ProyectoBlazor.WilberAlegria\Pages\Empresas.razor"
                                                                             1.8f

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(12, "\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(13, "\r\n\r\n\r\n");
            __builder.OpenElement(14, "div");
            __builder.AddAttribute(15, "class", "modal fade");
            __builder.AddAttribute(16, "id", "exampleModal");
            __builder.AddAttribute(17, "tabindex", "-1");
            __builder.AddAttribute(18, "aria-labelledby", "exampleModalLabel");
            __builder.AddAttribute(19, "aria-hidden", "true");
            __builder.AddMarkupContent(20, "\r\n  ");
            __builder.OpenElement(21, "div");
            __builder.AddAttribute(22, "class", "modal-dialog");
            __builder.AddMarkupContent(23, "\r\n    ");
            __builder.OpenElement(24, "div");
            __builder.AddAttribute(25, "class", "modal-content");
            __builder.AddMarkupContent(26, "\r\n      ");
            __builder.AddMarkupContent(27, "<div class=\"modal-header\">\r\n        <h5 class=\"modal-title\" id=\"exampleModalLabel\">Agregar Empresa</h5>\r\n      </div>\r\n     ");
            __builder.OpenElement(28, "div");
            __builder.AddAttribute(29, "class", "modal-body");
            __builder.AddMarkupContent(30, "\r\n        ");
            __builder.OpenElement(31, "form");
            __builder.AddMarkupContent(32, "\r\n          ");
            __builder.OpenElement(33, "div");
            __builder.AddAttribute(34, "class", "form-group");
            __builder.AddMarkupContent(35, "\r\n            ");
            __builder.AddMarkupContent(36, "<label for=\"recipient-name\" class=\"col-form-label\">RFC</label>\r\n            ");
            __builder.OpenElement(37, "input");
            __builder.AddAttribute(38, "type", "text");
            __builder.AddAttribute(39, "class", "form-control");
            __builder.AddAttribute(40, "id", "recipient-name");
            __builder.AddAttribute(41, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 20 "C:\Practicas\SIIC.ProyectoBlazor.WilberAlegria\Pages\Empresas.razor"
                                                                               Empresa.rfc

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(42, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => Empresa.rfc = __value, Empresa.rfc));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(43, "\r\n          ");
            __builder.CloseElement();
            __builder.AddMarkupContent(44, "\r\n          ");
            __builder.OpenElement(45, "div");
            __builder.AddAttribute(46, "class", "form-group");
            __builder.AddMarkupContent(47, "\r\n            ");
            __builder.AddMarkupContent(48, "<label for=\"recipient-name\" class=\"col-form-label\">Razon social</label>\r\n            ");
            __builder.OpenElement(49, "input");
            __builder.AddAttribute(50, "type", "text");
            __builder.AddAttribute(51, "class", "form-control");
            __builder.AddAttribute(52, "id", "recipient-name");
            __builder.AddAttribute(53, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 24 "C:\Practicas\SIIC.ProyectoBlazor.WilberAlegria\Pages\Empresas.razor"
                                                                               Empresa.razonSocial

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(54, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => Empresa.razonSocial = __value, Empresa.razonSocial));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(55, "\r\n          ");
            __builder.CloseElement();
            __builder.AddMarkupContent(56, "\r\n          ");
            __builder.OpenElement(57, "div");
            __builder.AddAttribute(58, "class", "form-group");
            __builder.AddMarkupContent(59, "\r\n            ");
            __builder.AddMarkupContent(60, "<label for=\"recipient-name\" class=\"col-form-label\">Nombre comercial</label>\r\n            ");
            __builder.OpenElement(61, "input");
            __builder.AddAttribute(62, "type", "text");
            __builder.AddAttribute(63, "class", "form-control");
            __builder.AddAttribute(64, "id", "recipient-name");
            __builder.AddAttribute(65, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 28 "C:\Practicas\SIIC.ProyectoBlazor.WilberAlegria\Pages\Empresas.razor"
                                                                               Empresa.nombreComercial

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(66, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => Empresa.nombreComercial = __value, Empresa.nombreComercial));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(67, "\r\n          ");
            __builder.CloseElement();
            __builder.AddMarkupContent(68, "\r\n          ");
            __builder.OpenElement(69, "div");
            __builder.AddAttribute(70, "class", "form-group");
            __builder.AddMarkupContent(71, "\r\n            ");
            __builder.AddMarkupContent(72, "<label for=\"recipient-name\" class=\"col-form-label\">Direccion</label>\r\n            ");
            __builder.OpenElement(73, "input");
            __builder.AddAttribute(74, "type", "text");
            __builder.AddAttribute(75, "class", "form-control");
            __builder.AddAttribute(76, "id", "recipient-name");
            __builder.AddAttribute(77, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 32 "C:\Practicas\SIIC.ProyectoBlazor.WilberAlegria\Pages\Empresas.razor"
                                                                               Empresa.direccion

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(78, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => Empresa.direccion = __value, Empresa.direccion));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(79, "\r\n          ");
            __builder.CloseElement();
            __builder.AddMarkupContent(80, "\r\n          ");
            __builder.OpenElement(81, "div");
            __builder.AddAttribute(82, "class", "form-group");
            __builder.AddMarkupContent(83, "\r\n            ");
            __builder.AddMarkupContent(84, "<label for=\"recipient-name\" class=\"col-form-label\">Telefono</label>\r\n            ");
            __builder.OpenElement(85, "input");
            __builder.AddAttribute(86, "type", "text");
            __builder.AddAttribute(87, "class", "form-control");
            __builder.AddAttribute(88, "id", "recipient-name");
            __builder.AddAttribute(89, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 36 "C:\Practicas\SIIC.ProyectoBlazor.WilberAlegria\Pages\Empresas.razor"
                                                                               Empresa.telefono

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(90, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => Empresa.telefono = __value, Empresa.telefono));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(91, "\r\n          ");
            __builder.CloseElement();
            __builder.AddMarkupContent(92, "\r\n          ");
            __builder.OpenElement(93, "div");
            __builder.AddAttribute(94, "class", "form-group");
            __builder.AddMarkupContent(95, "\r\n            ");
            __builder.AddMarkupContent(96, "<label for=\"recipient-name\" class=\"col-form-label\">Correo</label>\r\n            ");
            __builder.OpenElement(97, "input");
            __builder.AddAttribute(98, "type", "text");
            __builder.AddAttribute(99, "class", "form-control");
            __builder.AddAttribute(100, "id", "recipient-name");
            __builder.AddAttribute(101, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 40 "C:\Practicas\SIIC.ProyectoBlazor.WilberAlegria\Pages\Empresas.razor"
                                                                               Empresa.correo

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(102, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => Empresa.correo = __value, Empresa.correo));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(103, "\r\n          ");
            __builder.CloseElement();
            __builder.AddMarkupContent(104, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(105, "\r\n      ");
            __builder.CloseElement();
            __builder.AddMarkupContent(106, "\r\n      ");
            __builder.OpenElement(107, "div");
            __builder.AddAttribute(108, "class", "modal-footer");
            __builder.AddMarkupContent(109, "\r\n        ");
            __builder.AddMarkupContent(110, "<button type=\"button\" class=\"btn btn-secondary\" data-dismiss=\"modal\">Close</button>\r\n        ");
            __builder.OpenElement(111, "button");
            __builder.AddAttribute(112, "type", "button");
            __builder.AddAttribute(113, "class", "btn btn-primary");
            __builder.AddAttribute(114, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 46 "C:\Practicas\SIIC.ProyectoBlazor.WilberAlegria\Pages\Empresas.razor"
                                                                GuardarEmpresa

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(115, "Enviar");
            __builder.CloseElement();
            __builder.AddMarkupContent(116, "\r\n      ");
            __builder.CloseElement();
            __builder.AddMarkupContent(117, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(118, "\r\n  ");
            __builder.CloseElement();
            __builder.AddMarkupContent(119, "\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(120, "\r\n\r\n");
            __builder.OpenElement(121, "table");
            __builder.AddAttribute(122, "class", "table table-striped mt-3");
            __builder.AddMarkupContent(123, "\r\n  ");
            __builder.AddMarkupContent(124, @"<thead>
    <tr>
      <th scope=""col"">id</th>
      <th scope=""col"">idSucursal</th>
      <th scope=""col"">rfc</th>
      <th scope=""col"">Razon social</th>
      <th scope=""col"">Nombre comercial</th>
      <th scope=""col"">Direccion</th>
      <th scope=""col"">Telefono</th>
      <th scope=""col"">Correo</th>
      <th scope=""col"">Operaciones</th>
    </tr>
  </thead>
  ");
            __builder.OpenElement(125, "tbody");
            __builder.AddMarkupContent(126, "\r\n");
#nullable restore
#line 67 "C:\Practicas\SIIC.ProyectoBlazor.WilberAlegria\Pages\Empresas.razor"
     foreach (var item in ListEmpresas)
    {

#line default
#line hidden
#nullable disable
            __builder.AddContent(127, "      ");
            __builder.OpenElement(128, "tr");
            __builder.AddMarkupContent(129, "        \r\n          ");
            __builder.OpenElement(130, "th");
            __builder.AddAttribute(131, "scope", "row");
            __builder.AddContent(132, 
#nullable restore
#line 70 "C:\Practicas\SIIC.ProyectoBlazor.WilberAlegria\Pages\Empresas.razor"
                           item.id

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(133, "\r\n          ");
            __builder.OpenElement(134, "td");
            __builder.AddContent(135, 
#nullable restore
#line 71 "C:\Practicas\SIIC.ProyectoBlazor.WilberAlegria\Pages\Empresas.razor"
               item.idSucursal

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(136, "\r\n          ");
            __builder.OpenElement(137, "td");
            __builder.AddContent(138, 
#nullable restore
#line 72 "C:\Practicas\SIIC.ProyectoBlazor.WilberAlegria\Pages\Empresas.razor"
               item.rfc

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(139, "\r\n          ");
            __builder.OpenElement(140, "td");
            __builder.AddContent(141, 
#nullable restore
#line 73 "C:\Practicas\SIIC.ProyectoBlazor.WilberAlegria\Pages\Empresas.razor"
               item.razonSocial

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(142, "\r\n          ");
            __builder.OpenElement(143, "td");
            __builder.AddContent(144, 
#nullable restore
#line 74 "C:\Practicas\SIIC.ProyectoBlazor.WilberAlegria\Pages\Empresas.razor"
               item.nombreComercial

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(145, "\r\n          ");
            __builder.OpenElement(146, "td");
            __builder.AddContent(147, 
#nullable restore
#line 75 "C:\Practicas\SIIC.ProyectoBlazor.WilberAlegria\Pages\Empresas.razor"
               item.direccion

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(148, "\r\n          ");
            __builder.OpenElement(149, "td");
            __builder.AddContent(150, 
#nullable restore
#line 76 "C:\Practicas\SIIC.ProyectoBlazor.WilberAlegria\Pages\Empresas.razor"
               item.telefono

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(151, "\r\n          ");
            __builder.OpenElement(152, "td");
            __builder.AddContent(153, 
#nullable restore
#line 77 "C:\Practicas\SIIC.ProyectoBlazor.WilberAlegria\Pages\Empresas.razor"
               item.correo

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(154, "        \r\n          ");
            __builder.OpenElement(155, "td");
            __builder.AddMarkupContent(156, "\r\n            ");
            __builder.OpenElement(157, "button");
            __builder.AddAttribute(158, "class", "btn btn-secondary btn-sm btn-block");
            __builder.AddMarkupContent(159, "\r\n                Editar\r\n                ");
            __builder.OpenComponent<Feather.Blazor.Icons.FeatherEdit>(160);
            __builder.AddAttribute(161, "Size", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 81 "C:\Practicas\SIIC.ProyectoBlazor.WilberAlegria\Pages\Empresas.razor"
                                   20

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(162, "Color", "#ffffff");
            __builder.AddAttribute(163, "StrokeWidth", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Single>(
#nullable restore
#line 81 "C:\Practicas\SIIC.ProyectoBlazor.WilberAlegria\Pages\Empresas.razor"
                                                                    1.8f

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(164, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(165, "\r\n            ");
            __builder.OpenElement(166, "button");
            __builder.AddAttribute(167, "class", "btn btn-danger btn-sm btn-block");
            __builder.AddAttribute(168, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 83 "C:\Practicas\SIIC.ProyectoBlazor.WilberAlegria\Pages\Empresas.razor"
                                                                      (()=>EliminarEmpresa(item))

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(169, "\r\n                Eliminar\r\n                ");
            __builder.OpenComponent<Feather.Blazor.Icons.FeatherTrash2>(170);
            __builder.AddAttribute(171, "Size", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 85 "C:\Practicas\SIIC.ProyectoBlazor.WilberAlegria\Pages\Empresas.razor"
                                     20

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(172, "Color", "#ffffff");
            __builder.AddAttribute(173, "StrokeWidth", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Single>(
#nullable restore
#line 85 "C:\Practicas\SIIC.ProyectoBlazor.WilberAlegria\Pages\Empresas.razor"
                                                                      1.8f

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(174, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(175, "\r\n          ");
            __builder.CloseElement();
            __builder.AddMarkupContent(176, "        \r\n      ");
            __builder.CloseElement();
            __builder.AddMarkupContent(177, "\r\n");
#nullable restore
#line 89 "C:\Practicas\SIIC.ProyectoBlazor.WilberAlegria\Pages\Empresas.razor"
    }

#line default
#line hidden
#nullable disable
            __builder.AddContent(178, "  ");
            __builder.CloseElement();
            __builder.AddMarkupContent(179, "\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591