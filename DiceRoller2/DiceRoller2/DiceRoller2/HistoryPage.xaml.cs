using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace DiceRoller2
{
    public partial class HistoryPage : ContentPage
    {
        public HistoryPage(List<DiceRoll> historyObjects)
        {
            InitializeComponent();
            listView.ItemsSource = historyObjects;
        }
    }
}
