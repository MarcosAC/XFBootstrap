using Android.Graphics;
using Android.Views;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;
using XFBootstrap.Controls;
using XFBootstrap.Droid.Effects;

[assembly: ExportEffect(typeof(CornerRadiusEffectAndroid), nameof(CornerRadiusEffect))]
namespace XFBootstrap.Droid.Effects
{
    public class CornerRadiusEffectAndroid : PlatformEffect
    {
        protected override void OnAttached()
        {
            try
            {
                PrepararContainer();
                SetarRaio();
            }
            catch
            {
            }
        }

        protected override void OnDetached()
        {
            try
            {
                Container.OutlineProvider = ViewOutlineProvider.Background;
            }
            catch
            {
            }
        }

        private void PrepararContainer()
        {
            Container.ClipToOutline = true;
        }

        private void SetarRaio()
        {
            Container.OutlineProvider = new RoundedOutilineProvider(5);
        }

        private class RoundedOutilineProvider : ViewOutlineProvider
        {
            private readonly float _raio;

            public RoundedOutilineProvider(float raio) => _raio = raio;

            public override void GetOutline(Android.Views.View view, Outline outline) => outline?.SetRoundRect(0, 0, view.Width, view.Height, _raio);
        }
    }
}