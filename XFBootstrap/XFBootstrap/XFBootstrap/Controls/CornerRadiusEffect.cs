using System.Linq;
using Xamarin.Forms;

namespace XFBootstrap.Controls
{
    public class CornerRadiusEffect : RoutingEffect
    {
        public CornerRadiusEffect() : base("MarcosAurelio.CornerRadiusEffect")
        {
        }

        public static void OnPropertyChanged(BindableObject bindable, object oldValue, object newValue)
        {
            if (!(bindable is View view))
                return;

            var cornerRadius = (int)newValue;
            var effect = view.Effects.OfType<CornerRadiusEffect>().FirstOrDefault();

            if (cornerRadius > 0 && effect == null)
                view.Effects.Add(new CornerRadiusEffect());

            if (cornerRadius == 0 && effect != null)
                view.Effects.Remove(effect);
        }
    }
}
