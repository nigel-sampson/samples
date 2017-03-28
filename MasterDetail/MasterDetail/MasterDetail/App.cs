using System;
using Caliburn.Micro;
using Caliburn.Micro.Xamarin.Forms;
using MasterDetail.ViewModels;
using MasterDetail.Views;
using Xamarin.Forms;

namespace MasterDetail
{
    public class App : FormsApplication
    {
        private readonly SimpleContainer container;

        public App(SimpleContainer container)
        {
            this.container = container;

            container
                .PerRequest<ShellViewModel>();

            DisplayRootView<ShellView>();
        }

        protected override void PrepareViewFirst(NavigationPage navigationPage)
        {
            container.Instance<INavigationService>(new NavigationPageAdapter(navigationPage));
        }
    }
}
