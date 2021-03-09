using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace LayoutsDemo
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DemoAbsoluteLayout : ContentPage
    {
        public DemoAbsoluteLayout()
        {
            InitializeComponent();
        }

        bool animate;

        
        protected  override void OnAppearing()
        {
            base.OnAppearing();
            animate = false;
            chkStart.IsChecked = false;
            UpdatePos();
        }

        private void UpdatePos()
        {
            Rectangle r1 = AbsoluteLayout.GetLayoutBounds(text1);
            Rectangle r2 = AbsoluteLayout.GetLayoutBounds(text2);
            txtPos.Text = $"T1:{Math.Round(r1.Top,2)}x{Math.Round(r1.Left,2)}, T2:{Math.Round(r2.Top, 2)}x{Math.Round(r2.Left, 2)}";
        }

        protected override void OnDisappearing()
        {
            base.OnDisappearing();
            animate = false;
            chkStart.IsChecked = false;
        }

        private void chkStart_CheckedChanged(object sender, CheckedChangedEventArgs e)
        {
            animate = chkStart.IsChecked;

            if (animate)
            {
                DateTime beginTime = DateTime.Now;

                Device.StartTimer(TimeSpan.FromSeconds(1.0 / 30), () =>
                {
                    double seconds = (DateTime.Now - beginTime).TotalSeconds;
                    double offset = 1 - Math.Abs((seconds % 2) - 1);

                    AbsoluteLayout.SetLayoutBounds(text1,
                        new Rectangle(offset, offset,
                            AbsoluteLayout.AutoSize, AbsoluteLayout.AutoSize));

                    AbsoluteLayout.SetLayoutBounds(text2,
                        new Rectangle(1 - offset, offset,
                            AbsoluteLayout.AutoSize, AbsoluteLayout.AutoSize));
                    UpdatePos();
                    return animate;
                });
            }
        }
    }
}