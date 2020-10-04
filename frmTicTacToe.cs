using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using XnO.classes;

namespace XnO
{
    public partial class FrmTicTacToe : Form
    {
        public Bitmap bgX;
        public Bitmap bgO;
        //private Dictionary<Panel, int> _panels;
        private List<Panel> _panels;

        public delegate void PanelClickedEventHandler(object sender, MouseEventArgs args);
        public event PanelClickedEventHandler PanelClicked;

        public FrmTicTacToe()
        {
            InitializeComponent();
            InitializeResources();

        }

        private void InitializeResources()
        {
            //_panels = new Dictionary<Panel, int>() { { pnl1, 1 }, { pnl2, 2 }, { pnl3, 3 }, { pnl4, 5 }, { pnl5, 6 }, { pnl6, 6 }, { pnl7, 7 }, { pnl8, 8 }, { pnl9, 9 } };
            _panels = new List<Panel>() { pnl1, pnl2, pnl3, pnl4, pnl5, pnl6, pnl7, pnl8, pnl9 };

            SetXnOImage();
            SubscribeEvents();

        }

        private void SubscribeEvents()
        {
            try
            {
                pnl1.MouseClick += OnPanelClicked;
                pnl2.MouseClick += OnPanelClicked;
                pnl3.MouseClick += OnPanelClicked;
                pnl4.MouseClick += OnPanelClicked;
                pnl5.MouseClick += OnPanelClicked;
                pnl6.MouseClick += OnPanelClicked;
                pnl7.MouseClick += OnPanelClicked;
                pnl8.MouseClick += OnPanelClicked;
                pnl9.MouseClick += OnPanelClicked;
                //clsGameEvents gameEvents = new clsGameEvents(_panels,bgX, bgO);
                clsGameEvents gameEvents = new clsGameEvents(bgX, bgO);
                clsGameLogic gameLogic = new clsGameLogic(_panels, bgX, bgO);
                PanelClicked += gameEvents.OnPanelClicked;
                PanelClicked += gameLogic.OnPanelClicked;
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void OnPanelClicked(object sender, MouseEventArgs e)
        {
            try
            {
                Panel pnl = sender as Panel;
                if (pnl.BackgroundImage == null && PanelClicked != null)
                {
                    PanelClicked(sender, e);
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void SetXnOImage()
        {
            bgX = new Bitmap(new Bitmap(Environment.CurrentDirectory + @"\Assets\X.png"), 100, 100);
            bgO = new Bitmap(new Bitmap(Environment.CurrentDirectory + @"\Assets\O.png"), 100, 100);
        }

        public void ResetGame()
        {
            InitializeComponent();
            InitializeResources();
            foreach (Panel panel in _panels)
            {
                if (panel.BackgroundImage != null)
                    panel.BackgroundImage = null;                
            }
        }
    }
}
