using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using gameFood.Classes; 

namespace gameFood
{
    public partial class FiledGame : Form
    {
        private Panel panel;
        private Graphics grahics;
        
        public float width, height;
        public GameField gameField = new GameField();
        public GameWork gameWork = new GameWork();
        public Bitmap image;

        public FiledGame()
        {
            InitializeComponent();
        }

        private void newGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            width = this.Width / 2;
            height = this.Height / 2;

            menuStrip1.Visible = false;

            this.MinimizeBox = false;
            this.MaximizeBox = false;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;

            panel = new Panel();
            panel.Size = new Size(1920, 1080);

            Controls.Add(panel);

            grahics = panel.CreateGraphics();

            image = new Bitmap("C:\\Users\\temka\\source\\repos\\gameFood\\gameFood\\Icon\\Hero.png");

            grahics.DrawImage(image, width, height);
        }

        private void tableRecordToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void FiledGame_KeyDown(object sender, KeyEventArgs e)
        {            
            if(e.KeyCode == Keys.Up || e.KeyCode == Keys.W)
            {
                grahics.Clear(Color.DarkGray);
                height -= 3;
                grahics.DrawImage(image, width, height);
            }
            else if (e.KeyCode == Keys.Down || e.KeyCode == Keys.S)
            {
                grahics.Clear(Color.DarkGray);
                height += 3;
                grahics.DrawImage(image, width, height);
            }
            else if (e.KeyCode == Keys.Left || e.KeyCode == Keys.A)
            {
                grahics.Clear(Color.DarkGray);
                width -= 3;
                grahics.DrawImage(image, width, height);
            }
            else if (e.KeyCode == Keys.Right || e.KeyCode == Keys.D)
            {
                grahics.Clear(Color.DarkGray);
                width += 3;
                grahics.DrawImage(image, width, height);
            }
        }
    }

}
