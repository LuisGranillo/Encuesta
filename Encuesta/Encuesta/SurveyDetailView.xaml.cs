using Encuesta.Models;
using Encuesta.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Encuesta
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SurveyDetailView : ContentPage
    {
        public SurveyDetailView()
        {
            InitializeComponent();
            MessagingCenter.Subscribe<SurveyDetailsViewModel, Survey>(this, "SaveSurvey", async (a, s) =>
            {
                await Navigation.PopModalAsync();//Para regresarme
            });
        }
        protected override void OnDisappearing()//desinscribirnos
        {
            base.OnDisappearing();
            MessagingCenter.Unsubscribe<SurveyDetailsViewModel, Survey>(this, "SaveSurvey");

        }
    }
}