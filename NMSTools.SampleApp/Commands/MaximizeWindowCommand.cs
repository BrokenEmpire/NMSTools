using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Input;

namespace NMSTools.SampleApp.Commands
{
    public class MaximizeWindowCommand : ICommand
    {
        public event EventHandler CanExecuteChanged;

        public void Execute(object parameter)
        {
            if (parameter is Window window)
            {
                window.WindowState = window.WindowState == WindowState.Maximized ? WindowState.Normal : WindowState.Maximized;
            }
        }

        public bool CanExecute(object parameter) => true;

        protected void OnCanExecuteChanged([CallerMemberName] string propertyName = "")
            => CanExecuteChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }
}
