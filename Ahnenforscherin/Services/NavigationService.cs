using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ahnenforscherin.Services;

class NavigationService
{
    private Window _window;
    private Frame _frame;

    public Window CreateMainWindow()
    {
        _frame = new Frame();
        _window = new MainWindow { Content = _frame };
        return _window;
    }

    public void Navigate<TPage>() where TPage : Page
    {
        _frame.Navigate(typeof(TPage));
    }

}
