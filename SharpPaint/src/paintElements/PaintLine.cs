using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharpPaint.src.paintElements
{
    class PaintLine : IPaintObject
    {
        public PaintLine() {
            throw new NotImplementedException();
        }

        public Graphics Graphics { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public void Draw()
        {
            throw new NotImplementedException();
        }

        public void EndMove(Point point)
        {
            throw new NotImplementedException();
        }

        public void Move(Point point)
        {
            throw new NotImplementedException();
        }

        public bool BackAndNeedDelete()
        {
            throw new NotImplementedException();
        }

        public void StartMove(Point point)
        {
            throw new NotImplementedException();
        }
    }
}
