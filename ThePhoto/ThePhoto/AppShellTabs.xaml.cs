using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ThePhoto
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AppShellTabs : Shell
    {
        public AppShellTabs()
        {
            InitializeComponent();
        }
    }
}