using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RestaurantSystemUI
{
    class TimeSlotFlowPanel : FlowLayoutPanel
    {
        public DateTime Date { get; set; }
        public DateTime BeginTime { get; set; }
        public DateTime EndTime { get; set; }

        public TimeSlotFlowPanel()
        {
            ColorTheme theme = ThemeProvider.GetTheme();
            BackColor = theme.TimeSlotBackground;
        }
    }
}
