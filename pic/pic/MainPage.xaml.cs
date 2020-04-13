using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace pic
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        

        void OnSwiped(object sender, SwipedEventArgs e)
        {
            var match = false;

            if (e.Direction.ToString()=="Right")
            {
                match = false;
                SwipeViewModel.falseMatch++;
                if (SwipeViewModel.Pics[SwipeViewModel.count].dinotype.Equals("carn")) 
                    { SwipeViewModel.carntotal--; SwipeViewModel.herbtotal++;SwipeViewModel.omnitotal++; }
                if (SwipeViewModel.Pics[SwipeViewModel.count].dinotype.Equals("herb"))
                    { SwipeViewModel.carntotal++; SwipeViewModel.herbtotal--; SwipeViewModel.omnitotal++; }
                if (SwipeViewModel.Pics[SwipeViewModel.count].dinotype.Equals("omni"))
                    { SwipeViewModel.carntotal++; SwipeViewModel.herbtotal++; SwipeViewModel.omnitotal--; }
                if (SwipeViewModel.Pics[SwipeViewModel.count].dinosize.Equals("large"))
                    { SwipeViewModel.largetotal--; SwipeViewModel.medtotal++; SwipeViewModel.smalltotal++; }
                if (SwipeViewModel.Pics[SwipeViewModel.count].dinosize.Equals("med"))
                    { SwipeViewModel.largetotal++; SwipeViewModel.medtotal--; SwipeViewModel.smalltotal++; }
                if (SwipeViewModel.Pics[SwipeViewModel.count].dinosize.Equals("small"))
                    { SwipeViewModel.largetotal++; SwipeViewModel.medtotal++; SwipeViewModel.smalltotal--; }
            }
            else if(e.Direction.ToString() == "Left")
            {
                match = true;
                SwipeViewModel.trueMatch++;
                if (SwipeViewModel.Pics[SwipeViewModel.count].dinotype.Equals("carn"))
                    { SwipeViewModel.carntotal++; SwipeViewModel.herbtotal--; SwipeViewModel.omnitotal--; }
                if (SwipeViewModel.Pics[SwipeViewModel.count].dinotype.Equals("herb"))
                    { SwipeViewModel.carntotal--; SwipeViewModel.herbtotal++; SwipeViewModel.omnitotal--; }
                if (SwipeViewModel.Pics[SwipeViewModel.count].dinotype.Equals("omni"))
                    { SwipeViewModel.carntotal--; SwipeViewModel.herbtotal--; SwipeViewModel.omnitotal++; }
                if (SwipeViewModel.Pics[SwipeViewModel.count].dinosize.Equals("large"))
                    { SwipeViewModel.largetotal++; SwipeViewModel.medtotal--; SwipeViewModel.smalltotal--; }
                if (SwipeViewModel.Pics[SwipeViewModel.count].dinosize.Equals("med"))
                    { SwipeViewModel.largetotal--; SwipeViewModel.medtotal++; SwipeViewModel.smalltotal--; }
                if (SwipeViewModel.Pics[SwipeViewModel.count].dinosize.Equals("small"))
                    { SwipeViewModel.largetotal--; SwipeViewModel.medtotal--; SwipeViewModel.smalltotal++; }
            }
            if (match)
            {
                _label.Text = $"Matched: True";
            }
            else { _label.Text = $"Matched: False"; }

            _f_match_label.Text = $"Non Matches: " + SwipeViewModel.falseMatch;
            _t_match_label.Text = $"Matches: " + SwipeViewModel.trueMatch;


            if (SwipeViewModel.count<SwipeViewModel.Pics.Count-1)
            {
                SwipeViewModel.count++;
                picElement.Source = SwipeViewModel.Pics[SwipeViewModel.count].url;
            }
            else {
                picElement.Source = "";

                ResPage resultPage = new ResPage();
                this.Navigation.PushModalAsync(resultPage);
            

        }
    }
}
