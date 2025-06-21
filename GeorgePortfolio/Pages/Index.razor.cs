namespace GeorgePortfolio.Pages
{
    public partial class Index
    {
        string[] Jobs = { "Software-Engineer", "Dot Net Developer" };
        public string JobAnimated { set; get; } = "";
        int CurrChar = 0;
        int CurrTitle = 0;
        Timer timer;
        protected override void OnInitialized()
        {
            timer = new Timer(ChangeLatter,null, dueTime: 0 , period:100);
            base.OnInitialized();
        }
        async void ChangeLatter(object state) {
            if (CurrChar >= Jobs[CurrTitle].Length)
            {
                timer.Dispose();
                await Task.Delay(2000);
                timer = new Timer(ChangeLatter, null, dueTime: 0, period: 100);
                CurrChar = 0;
                CurrTitle = (CurrTitle + 1) % Jobs.Length;
                StateHasChanged();
                JobAnimated = "";
            }
            JobAnimated += Jobs[CurrTitle][CurrChar];
            CurrChar++;
            StateHasChanged();
        }

    }
}
