using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Windows.UI.Xaml.Controls;

namespace CrossPlatformLibrary1
{
    public partial class Class1 : ContentControl
    {
        public void Build()
        {
            Content = new TextBlock { Text = "ANDROID" };
        }
    }
}
