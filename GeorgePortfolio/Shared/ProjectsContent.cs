using Microsoft.AspNetCore.Components;

namespace GeorgePortfolio.Shared
{
    public class ProjectsContent:ComponentBase
    {
        public int idxCounter = 1;

        [Parameter]
        public int Idx { get; set; } = 0;
        [Parameter]
        public EventCallback<int> SendCount { get; set; }
        protected override void OnParametersSet()
        {
            idxCounter = 1;
            StateHasChanged();
        }
        protected override void OnAfterRender(bool firstRender)
        {
            if (firstRender)
            {
                SendCount.InvokeAsync(idxCounter);
            }
        }
    }
}
