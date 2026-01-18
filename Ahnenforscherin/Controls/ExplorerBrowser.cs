using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using Microsoft.UI.Xaml.Data;
using Microsoft.UI.Xaml.Documents;
using Microsoft.UI.Xaml.Input;
using Microsoft.UI.Xaml.Media;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;

// To learn more about WinUI, the WinUI project structure,
// and more about our project templates, see: http://aka.ms/winui-project-info.

namespace Ahnenforscherin.Controls;

public sealed partial class ExplorerBrowser : Control
{
    public ExplorerBrowser()
    {
        /* WARN: CA1416 This call site is reachable on all platforms. 'Control.DefaultStyleKey' is only supported on: 'Windows' 10.0.17763.0 and later. */
        DefaultStyleKey = typeof(ExplorerBrowser);
    }
}
