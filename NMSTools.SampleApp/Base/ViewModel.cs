using System;
using System.Windows;

namespace NMSTools.SampleApp.Base
{
    public abstract class ViewModel : DependencyObject
    {
        internal virtual void Loaded(object sender, RoutedEventArgs e) { }
    }
}
