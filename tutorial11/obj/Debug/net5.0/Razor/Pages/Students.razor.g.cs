#pragma checksum "C:\Users\ssinz7fanboy\Desktop\tutorial11\Pages\Students.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ca23ff692aea10c18fec5eda159a862db9e5e21a"
// <auto-generated/>
#pragma warning disable 1591
namespace tutorial11.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\ssinz7fanboy\Desktop\tutorial11\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\ssinz7fanboy\Desktop\tutorial11\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\ssinz7fanboy\Desktop\tutorial11\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\ssinz7fanboy\Desktop\tutorial11\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\ssinz7fanboy\Desktop\tutorial11\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\ssinz7fanboy\Desktop\tutorial11\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\ssinz7fanboy\Desktop\tutorial11\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\ssinz7fanboy\Desktop\tutorial11\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\ssinz7fanboy\Desktop\tutorial11\_Imports.razor"
using tutorial11;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\ssinz7fanboy\Desktop\tutorial11\_Imports.razor"
using tutorial11.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\ssinz7fanboy\Desktop\tutorial11\_Imports.razor"
using tutorial11.Models;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/students")]
    public partial class Students : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<style>\r\n    table, th, td {\r\n        border: 1px solid black;\r\n    }\r\n</style>\r\n\r\n");
            __builder.AddMarkupContent(1, "<h3>Students</h3>\r\n");
            __builder.OpenElement(2, "table");
            __builder.AddAttribute(3, "style", "width:100%");
            __builder.OpenElement(4, "tr");
            __builder.AddMarkupContent(5, "<td>Avatar</td>\r\n        ");
            __builder.OpenElement(6, "td");
            __builder.OpenElement(7, "button");
            __builder.AddAttribute(8, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 16 "C:\Users\ssinz7fanboy\Desktop\tutorial11\Pages\Students.razor"
                              (() => SortByFirstName())

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(9, "FirstName");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(10, "\r\n        ");
            __builder.OpenElement(11, "td");
            __builder.OpenElement(12, "button");
            __builder.AddAttribute(13, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 17 "C:\Users\ssinz7fanboy\Desktop\tutorial11\Pages\Students.razor"
                              (() => SortByLastName())

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(14, "LastName");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(15, "\r\n        ");
            __builder.OpenElement(16, "td");
            __builder.OpenElement(17, "button");
            __builder.AddAttribute(18, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 18 "C:\Users\ssinz7fanboy\Desktop\tutorial11\Pages\Students.razor"
                              (() => SortByBirthDate())

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(19, "BirthDate");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(20, "\r\n        ");
            __builder.OpenElement(21, "td");
            __builder.OpenElement(22, "button");
            __builder.AddAttribute(23, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 19 "C:\Users\ssinz7fanboy\Desktop\tutorial11\Pages\Students.razor"
                              (() => SortByStudies())

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(24, "Studies");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(25, "\r\n        ");
            __builder.AddMarkupContent(26, "<td>Delete Student</td>");
            __builder.CloseElement();
#nullable restore
#line 22 "C:\Users\ssinz7fanboy\Desktop\tutorial11\Pages\Students.razor"
     foreach (var s in students)
    {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(27, "tr");
            __builder.OpenElement(28, "td");
            __builder.OpenElement(29, "button");
            __builder.AddAttribute(30, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 26 "C:\Users\ssinz7fanboy\Desktop\tutorial11\Pages\Students.razor"
                                  (() => CheckStudentDetails(s))

#line default
#line hidden
#nullable disable
            ));
            __builder.OpenElement(31, "img");
            __builder.AddAttribute(32, "src", 
#nullable restore
#line 26 "C:\Users\ssinz7fanboy\Desktop\tutorial11\Pages\Students.razor"
                                                                            s.Avatar

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(33, "width", "100");
            __builder.AddAttribute(34, "height", "100");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(35, "\r\n            ");
            __builder.OpenElement(36, "td");
#nullable restore
#line 29 "C:\Users\ssinz7fanboy\Desktop\tutorial11\Pages\Students.razor"
__builder.AddContent(37, s.FirstName);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(38, "\r\n            ");
            __builder.OpenElement(39, "td");
#nullable restore
#line 32 "C:\Users\ssinz7fanboy\Desktop\tutorial11\Pages\Students.razor"
__builder.AddContent(40, s.LastName);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(41, "\r\n            ");
            __builder.OpenElement(42, "td");
#nullable restore
#line 35 "C:\Users\ssinz7fanboy\Desktop\tutorial11\Pages\Students.razor"
__builder.AddContent(43, s.BirthDate);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(44, "\r\n            ");
            __builder.OpenElement(45, "td");
#nullable restore
#line 38 "C:\Users\ssinz7fanboy\Desktop\tutorial11\Pages\Students.razor"
__builder.AddContent(46, s.Studies);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(47, "\r\n            ");
            __builder.OpenElement(48, "td");
            __builder.OpenElement(49, "button");
            __builder.AddAttribute(50, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 41 "C:\Users\ssinz7fanboy\Desktop\tutorial11\Pages\Students.razor"
                                  (() => DeleteStudent(s))

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(51, "<img src=\"https://upload.wikimedia.org/wikipedia/commons/thumb/5/5f/Red_X.svg/768px-Red_X.svg.png\" width=\"40\" height=\"40\">");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 44 "C:\Users\ssinz7fanboy\Desktop\tutorial11\Pages\Students.razor"
    }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 48 "C:\Users\ssinz7fanboy\Desktop\tutorial11\Pages\Students.razor"
       

    private int FirstNameCounter = 1;
    private int LastNameCounter = 1;
    private int BirthDateCounter = 1;
    private int StudiesCounter = 1;

    public List<Student> students;

    protected override void OnInitialized()
    {
        students = new List<Student>();
        students.Add(new Student
        {
            Id = 1,
            Avatar = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcTabOgeMNrSqYJ4c2-kMg0I_QreIqbVVfgvWQ&usqp=CAU",
            FirstName = "Jan",
            LastName = "Kowalski",
            BirthDate = "5/24/2021",
            Studies = "Informatyka"
        });
        students.Add(new Student
        {
            Id = 2,
            Avatar = "https://cdn.picpng.com/female/user-female-avatar-woman-81396.png",
            FirstName = "Anna",
            LastName = "Malewska",
            BirthDate = "5/25/2021",
            Studies = "Informatyka"
        });
        Helper.setStudents(students);
    }


    private async void DeleteStudent(Student s)
    {
        var confirmed = await js.InvokeAsync<bool>("confirm", "Are you sure you wish to delete a student?");
        students.Remove(s);
        StateHasChanged();                                      //Forces the website to update, actually removing the student from the view
    }

    private void CheckStudentDetails(Student s)
    {
        string NavTo = "/SingleStudent/" + s.Id;
        navigationManager.NavigateTo(NavTo);
    }

    private void SortByFirstName()
    {
        if(FirstNameCounter % 2 == 1)
            students = students.OrderBy(x => x.FirstName).ToList();
        else
            students = students.OrderByDescending(x => x.FirstName).ToList();
        FirstNameCounter++;
    }
    private void SortByLastName()
    {
        if (LastNameCounter % 2 == 1)
            students = students.OrderBy(x => x.LastName).ToList();
        else
            students = students.OrderByDescending(x => x.LastName).ToList();
        LastNameCounter++;
    }
    private void SortByBirthDate()
    {
        if (BirthDateCounter % 2 == 1)
            students = students.OrderBy(x => x.BirthDate).ToList();
        else
            students = students.OrderByDescending(x => x.BirthDate).ToList();
        BirthDateCounter++;
    }
    private void SortByStudies()
    {
        if (StudiesCounter % 2 == 1)
            students = students.OrderBy(x => x.Studies).ToList();
        else
            students = students.OrderByDescending(x => x.Studies).ToList();
        StudiesCounter++;
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager navigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime js { get; set; }
    }
}
#pragma warning restore 1591
