using Android.Content;
using Android.Graphics.Drawables;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;
using XFBootstrap.Controls;
using XFBootstrap.Droid.Renderers;

[assembly: ExportRenderer(typeof(CustonEntry), typeof(CustonEntryRenderer))]
namespace XFBootstrap.Droid.Renderers
{
    class CustonEntryRenderer : EntryRenderer
    {
        public CustonEntryRenderer(Context context) : base(context)
        {
        }

        protected override void OnElementChanged(ElementChangedEventArgs<Entry> e)
        {
            base.OnElementChanged(e);

            base.OnElementChanged(e);
            if (e.NewElement != null)
            {                
                var gradientBackground = new GradientDrawable();

                gradientBackground.SetShape(ShapeType.Rectangle);
                gradientBackground.SetColor(Color.White.ToAndroid());                                
                gradientBackground.SetStroke(2, Color.FromHex("#ccc").ToAndroid());               
                gradientBackground.SetCornerRadius(10);
                
                Control.SetBackground(gradientBackground);
                Control.SetPadding(20, 20, 20, 20);
            }
        }
    }
}