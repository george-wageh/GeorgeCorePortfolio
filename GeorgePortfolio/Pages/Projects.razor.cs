using GeorgePortfolio.Shared;

namespace GeorgePortfolio.Pages
{
    public partial class Projects
    {
        public ProjectsEnum? ProjectsEnum_ { get; set; }
        void ShowProjectCardView(ProjectsEnum projectsEnum)
        {
            ProjectsEnum_ = projectsEnum;
        }
        void CloseView() {
            ProjectsEnum_ = null;
            StateHasChanged();
        }
    }
}
