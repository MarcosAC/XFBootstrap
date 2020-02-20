using System.Runtime.CompilerServices;
using Xamarin.Forms;

namespace XFBootstrap.Controls
{
    public class ButtonBootstrap : Button
    {
        public static readonly BindableProperty StyleButtonProperty = BindableProperty.Create(
            propertyName: "StyleButton",
            returnType: typeof(string),
            declaringType: typeof(ButtonBootstrap));

        public string StyleButton
        {
            get { return (string)GetValue(StyleButtonProperty); }
            set => SetValue(StyleButtonProperty, value);
        }

        protected override void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            base.OnPropertyChanged(propertyName);

            if (propertyName != StyleButton)
            {
                switch (StyleButton)
                {
                    case "Default":
                        CornerRadius = 5;
                        BorderWidth = 1;
                        BorderColor = Color.FromHex("#ccc");
                        BackgroundColor = Color.White;
                        TextColor = Color.FromHex("#333");
                        break;

                    case "Primary":
                        CornerRadius = 5;
                        BorderWidth = 1;
                        BorderColor = Color.FromHex("#337ab7");                        
                        BackgroundColor = Color.FromHex("#337ab7");
                        TextColor = Color.White;
                        break;

                    case "Success":
                        CornerRadius = 5;
                        BorderWidth = 1;
                        BorderColor = Color.FromHex("#4cae4c");
                        BackgroundColor = Color.FromHex("#5cb85c");
                        TextColor = Color.White;
                        break;

                    case "Info":
                        CornerRadius = 5;
                        BorderWidth = 1;
                        BorderColor = Color.FromHex("#46b8da");
                        BackgroundColor = Color.FromHex("#5bc0de");
                        TextColor = Color.White;
                        break;

                    case "Warning":
                        CornerRadius = 5;
                        BorderWidth = 1;
                        BorderColor = Color.FromHex("#eea236");
                        BackgroundColor = Color.FromHex("#f0ad4e");
                        TextColor = Color.White;
                        break;

                    case "Danger":
                        CornerRadius = 5;
                        BorderWidth = 1;
                        BorderColor = Color.FromHex("#d43f3a");
                        BackgroundColor = Color.FromHex("#d9534f");
                        TextColor = Color.White;
                        break;

                    //case "Link":
                    //    BackgroundColor = Color.White;
                    //    TextColor = Color.FromHex("#333");
                    //    break;
                }
            }
        }
    }
}
