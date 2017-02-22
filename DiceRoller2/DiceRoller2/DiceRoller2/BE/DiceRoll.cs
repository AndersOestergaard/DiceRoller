using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiceRoller2
{
    public class DiceRoll
    {
        private DateTime timestamp;
        private string dies;

        public DiceRoll(DateTime time, List<string> dies)
        {
            this.timestamp = time;
            this.dies = string.Join(" - ", dies.ToArray());
        }

        public DateTime TimeStamp { get { return timestamp; } }
        public string Dies { get { return dies; } }
    }
}
