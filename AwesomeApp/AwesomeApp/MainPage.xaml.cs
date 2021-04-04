  using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using AwesomeApp.Utility;

namespace AwesomeApp
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {


        int noClicks = 0;

        public MainPage()
        {
            InitializeComponent();
        }
        void OnImageNameTapped(object sender, EventArgs args)
        {
            try
            {

                AudioUtil.PlayAudio("ohyeah.wav");

                noClicks++;
                lblCount.Text = noClicks.ToString();
                if(noClicks == 10)
                {
                    Image.Source = "doublechoccookie";
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
