using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace XnO.classes
{
    class clsGameEvents
    {
        readonly Bitmap bgX;
        readonly Bitmap bgO;
        clsGameLogic gameLogic;
        public clsGameEvents(List<Panel> _panels, Bitmap bgX, Bitmap bgO) : this(bgX,bgO)
        {
            gameLogic = new clsGameLogic(_panels, bgX, bgO);
        }
        public clsGameEvents(Bitmap bgX, Bitmap bgO)
        {
            this.bgX = bgX;
            this.bgO = bgO;

        }
        public void OnPanelClicked(object sender, MouseEventArgs args)
        {
            Panel pnl = sender as Panel;
            pnl.BackgroundImage = bgX;
            //gameLogic.onPanelClicked(sender, args);            

        }
    }
}
