using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class Position
    {
        public static int PositionID { get; set; }
        public static string PositionTitle { get; set; }
        public Position(int positionID, string positionTitle)
        {
            PositionID = positionID;
            PositionTitle = positionTitle;
        }

    }
}
