using Microsoft.AspNetCore.Components;
using Shared.DTO;

namespace webassembly.Componentes.componentescs
{
    public class PerfilPersonalBase : ComponentBase
    {
        [Parameter]
        public PersonalProfileDto profle { get; set; }
        [CascadingParameter(Name = "border")]
        public string BorderColour { get; set; }

        [CascadingParameter(Name = "fondo")]
        public string BackgroundColor { get; set; }

    }
}
