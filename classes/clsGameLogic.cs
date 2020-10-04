using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace XnO.classes
{
    class clsGameLogic
    {
        //private readonly Dictionary<Panel, int> _panels;
        private readonly List<Panel> _panelsTracker;
        private readonly List<Panel> _panels;
        private readonly Bitmap bgX;
        private readonly Bitmap bgO;
        public clsGameLogic(List<Panel> panels, Bitmap bgX, Bitmap bgO)
        {
            this._panels = panels;
            this._panelsTracker = new List<Panel>(panels);
            this.bgX = bgX;
            this.bgO = bgO;
        }
        public void OnPanelClicked(object sender, MouseEventArgs args)
        {
            Panel pnl = sender as Panel;
            Random rnd = new Random();

            if (_panels.Contains(pnl))
                _panels.Remove(pnl);

            int position = rnd.Next(_panels.Count);

            if (_panels.Count > 0)
            {
                Panel pnlAI = _panels[position];                
                pnlAI.BackgroundImage = bgO;
                _panels.RemoveAt(position);
            }

            if (_panels.Count < _panelsTracker.Count - 3)
            {
                WinnerCheck();
            }

        }

        private void WinnerCheck()
        {
            bool win = false;
            if ((_panelsTracker[0].BackgroundImage == _panelsTracker[1].BackgroundImage) && (_panelsTracker[1].BackgroundImage == _panelsTracker[2].BackgroundImage) && _panelsTracker[0].BackgroundImage != null
                || (_panelsTracker[3].BackgroundImage == _panelsTracker[4].BackgroundImage) && (_panelsTracker[4].BackgroundImage == _panelsTracker[5].BackgroundImage) && _panelsTracker[3].BackgroundImage != null
                || (_panelsTracker[6].BackgroundImage == _panelsTracker[7].BackgroundImage) && (_panelsTracker[7].BackgroundImage == _panelsTracker[8].BackgroundImage) && _panelsTracker[6].BackgroundImage != null
                || (_panelsTracker[0].BackgroundImage == _panelsTracker[3].BackgroundImage) && (_panelsTracker[3].BackgroundImage == _panelsTracker[6].BackgroundImage) && _panelsTracker[0].BackgroundImage != null
                || (_panelsTracker[1].BackgroundImage == _panelsTracker[4].BackgroundImage) && (_panelsTracker[4].BackgroundImage == _panelsTracker[7].BackgroundImage) && _panelsTracker[1].BackgroundImage != null
                || (_panelsTracker[2].BackgroundImage == _panelsTracker[5].BackgroundImage) && (_panelsTracker[5].BackgroundImage == _panelsTracker[8].BackgroundImage) && _panelsTracker[2].BackgroundImage != null
                || (_panelsTracker[0].BackgroundImage == _panelsTracker[4].BackgroundImage) && (_panelsTracker[4].BackgroundImage == _panelsTracker[8].BackgroundImage) && _panelsTracker[0].BackgroundImage != null
                || (_panelsTracker[6].BackgroundImage == _panelsTracker[4].BackgroundImage) && (_panelsTracker[4].BackgroundImage == _panelsTracker[2].BackgroundImage) && _panelsTracker[6].BackgroundImage != null)
            {
                DialogResult result = MessageBox.Show("We have a Winner!\nStart again?", "Game Over",MessageBoxButtons.YesNo);
                if (result.Equals(DialogResult.No))
                {
                    Application.Exit();
                }
                else
                {
                    FrmTicTacToe ticTacToe = new FrmTicTacToe();
                    ticTacToe.ResetGame();
                    //foreach (Panel panel in _panelsTracker)
                    //{
                    //    panel.BackgroundImage = null;
                    //}
                }
            }
        }        
    }
}
