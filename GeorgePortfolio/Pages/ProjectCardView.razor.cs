using GeorgePortfolio.Shared;
using Microsoft.AspNetCore.Components;

namespace GeorgePortfolio.Pages
{
    public partial class ProjectCardView
    {
        int? Count { get; set; }
        [Parameter]
        public ProjectsEnum  ProjectsEnum { get; set; }

        [Parameter]
        public EventCallback Onclose { get; set; }
        public int Idx { get; set; } = 1;
        void Next() {
            Idx++;
            StateHasChanged();
        }
        void Previous() {
            Idx--;
            StateHasChanged();
        }
        void ReceiveCount(int count) {
            this.Count = count;
        }
        void CloseView() {
            this.Onclose.InvokeAsync();
        }
    }
}
