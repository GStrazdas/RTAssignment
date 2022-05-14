using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clock
{
    internal class ClocksFace
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="time"></param>
        public ClocksFace(string time)
        {
            string[] hoursMinutes = time.Split(':');
            if (CheckTimeFormat(hoursMinutes))
            {
                var hours = int.Parse(hoursMinutes[0]);
                var minutes = int.Parse(hoursMinutes[1]);
                var angleBetweenArrows = CalculateAngleBetweenArrows(hours, minutes);
                Console.WriteLine($"The lesser angle between clock hours and minutes arows is {angleBetweenArrows} degrees");
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="hoursMinutes"></param>
        /// <returns></returns>
        private bool CheckTimeFormat(string[] hoursMinutes)
        {
            if (hoursMinutes.Length != 2)
            {
                Console.WriteLine("Time is in the wrong format! Try again.");
                return false;
            }
            if (int.Parse(hoursMinutes[0]) < 0 || int.Parse(hoursMinutes[0]) > 23)
            {
                Console.WriteLine("Hours should be between 0 and 23! Try again");
                return false;
            }
            if (int.Parse(hoursMinutes[1]) < 0 || int.Parse(hoursMinutes[1]) > 60)
            {
                Console.WriteLine("Minutes should be between 0 and 60! Try again");
                return false;
            }
            return true;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        private int CalculateAngleBetweenArrows(int hours, int minutes)
        {
            int hoursArrowPosition = 30 * (hours % 12) + minutes / 2;
            int minutesArrowPosition = minutes * 6;
            int angleBetweenArrows = Math.Abs(hoursArrowPosition - minutesArrowPosition);
            return angleBetweenArrows <= 180 ? angleBetweenArrows : 360 - angleBetweenArrows;
        }
    }
}