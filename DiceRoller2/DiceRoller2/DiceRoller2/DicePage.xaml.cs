
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace DiceRoller2
{
    public partial class DicePage : ContentPage
    {
        List<DiceRoll> listHistory = new List<DiceRoll>();
        int d = 1;

        public DicePage()
        {
            InitializeComponent();
            stpCount.Value = 1;
            diceAmount.Text = String.Format("Amount of Dies: {0}", d);

            stpCount.ValueChanged += (sender, e) => ChangeAmount();
            btnRoll.Clicked += (sender, e) => RollDice();
            btnHistory.Clicked += (sender, e) => HistoryPage();
        }

        void RollDice()
        {
            Random r = new Random();
            List<string> rolls = new List<string>();
            for (int i = 1; i <= d; i++)
            {
                int roll = (r.Next() % 6) + 1;
                rolls.Add(String.Format("{0}", roll));
            }
            diceRolls.Text = string.Join(" - ", rolls.ToArray());
            DiceRoll totalRoll = new DiceRoll(DateTime.Now, rolls);
            listHistory.Add(totalRoll);
        }

        void ChangeAmount()
        {
            d = (int)stpCount.Value;
            diceAmount.Text = String.Format("Amount of Dies: {0}", d);
        }


        public async void HistoryPage()
        {
            await Navigation.PushAsync(new HistoryPage(listHistory));
        }
    }
}
