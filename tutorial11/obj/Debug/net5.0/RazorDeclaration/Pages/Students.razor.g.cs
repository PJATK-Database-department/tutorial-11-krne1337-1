// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

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