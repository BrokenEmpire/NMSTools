using System;
using System.Windows;
using System.Windows.Input;

namespace NMSTools.SampleApp.Base
{
    public abstract class WindowView : Window { }

    public abstract class WindowView<T> : WindowView where T : ViewModel, new()
    {
        private void WindowView_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
            => DragMove();

        private void WindowView_Loaded(object s, RoutedEventArgs e)
        {
            Loaded -= WindowView_Loaded;

            if (DataContext is ViewModel obj)
                obj.Loaded(s, e);
        }

        protected WindowView(T viewModel = default)
        {
            DataContext = viewModel ?? new T();

            Loaded += WindowView_Loaded;
            MouseLeftButtonDown += WindowView_MouseLeftButtonDown;
        }
    }
}
