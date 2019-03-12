using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharpPaint.src.paintElements
{
    interface IPaintObject
    {
        Graphics Graphics { get; set; }
        void Draw();
        void StartMove(Point point);
        void EndMove(Point point);
        void Move(Point point);

        bool BackAndNeedDelete();
    }
}
