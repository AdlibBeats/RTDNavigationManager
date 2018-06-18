using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

namespace RTDNavigationManager.UI.Controls
{
    public class FloppyFrame : Control
    {
        public FloppyFrame()
        {
            DefaultStyleKey = typeof(FloppyFrame);
        }

        public object Content
        {
            get => GetValue(ContentProperty);
            set => SetValue(ContentProperty, value);
        }

        public static readonly DependencyProperty ContentProperty =
            DependencyProperty.Register(nameof(Content), typeof(object), typeof(FloppyFrame),
                new PropertyMetadata(default));
    }
}
