using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantSystemUI
{
    interface IOOBEPage
    {
        bool LeaveCheck();
        void BeforeMount();
    }
}