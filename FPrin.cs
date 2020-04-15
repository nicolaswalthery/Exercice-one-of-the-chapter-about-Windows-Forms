using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chap10Ex1
{
    public enum FormeFigure { Rectangle, Triangle, Ellipse }

    public partial class FPrin : Form
    {
        //INSTANCE VARIABLES
        private Brush couleur; //Variable where the inner color of the rectangle, triangle or ellipse is stored.
        private FormeFigure forme;

        //CONSTRUCTOR
        public FPrin()
        {
            InitializeComponent();

            //CentreToi() & SynchroniserBoutons() are here tocenter the shape in pnHaut.
            this.CentreToi();
            this.SynchroniserBoutons();

            //Managing the movement of pnFigure.
            //"Tag" is a generic property where it can be store any type of object.
            this.buttonGauche.Tag = new Point(-5, 0);
            this.buttonDroit.Tag  = new Point(5, 0);
            this.buttonHaut.Tag   = new Point(0, -5);
            this.buttonBas.Tag    = new Point(0, 5);
            this.buttonHautGauche.Tag = new Point (-5, -5);

            this.Couleur  = Brushes.Red;
            this.Forme    = FormeFigure.Rectangle;
            
        }
        
        private void groupBox1_Enter(object sender, EventArgs e)
        {
            
        }

        private void pnFigure_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void pnHaut_Paint(object sender, PaintEventArgs e)
        {
            this.DessineToi();
        }

        #region Color Buttons
        public Brush Couleur
        {
            set
            {
                this.couleur = value;
                this.DessineToi();
            }
        }
        private void radioButtonRouge_CheckedChanged(object sender, EventArgs e)
        {
            this.Couleur = Brushes.Red;
        }

        private void radioButtonVert_CheckedChanged(object sender, EventArgs e)
        {
            this.Couleur = Brushes.Green;
        }

        private void radioButtonBleu_CheckedChanged(object sender, EventArgs e)
        {
            this.Couleur = Brushes.Blue;
        }
        
        #endregion

        #region Activer/desactiver Button
        private void buttonActDesact_Click(object sender, EventArgs e)
        {
            this.buttonActDesact.Text = (this.buttonActDesact.Text == "Activer" ?
                this.buttonActDesact.Text = "Desactiver" : this.buttonActDesact.Text = "Activer");
            this.SynchroniserBoutons();
            this.DessineToi();
        }
        #endregion

        #region Controler

        public bool DeplaceToi(int distanceX, int distanceY)
        {
            bool retVal = false;
            if (PeutSedéplacer(distanceX, distanceY))
            {
                this.pnFigure.Location =
                    new System.Drawing.Point(this.pnFigure.Left + distanceX,
                                             this.pnFigure.Top + distanceY);
                retVal = true;
            }
            return retVal;
        }
        public bool PeutSedéplacer(int distanceX, int distanceY)
        {
            return (this.pnFigure.Left + distanceX > 0
                    && this.pnFigure.Left + this.pnFigure.Width + distanceX < this.pnHaut.Width
                    && this.pnFigure.Top + distanceY > 0
                    && this.pnFigure.Top + this.pnFigure.Height + distanceY < this.pnHaut.Height);
        }
        public void SynchroniserBoutons()
        {
            this.buttonCentre.Enabled  = !this.EstCentré && this.buttonActDesact.Text != "Activer";
            this.buttonBas.Enabled     = this.buttonActDesact.Text != "Activer" && this.PeutSedéplacer(0, 5);
            this.buttonHaut.Enabled    = this.buttonActDesact.Text != "Activer" && this.PeutSedéplacer(0, -5);
            this.buttonDroit.Enabled   = this.buttonActDesact.Text != "Activer" && this.PeutSedéplacer(5, 0);
            this.buttonGauche.Enabled  = this.buttonActDesact.Text != "Activer" && this.PeutSedéplacer(-5, 0);

            this.buttonHautGauche.Enabled = this.buttonActDesact.Text != "Activer" && this.PeutSedéplacer(-5, -5);
        }

        //Will located the polygon int the center of the panel.
        public void CentreToi()
        {
            this.pnFigure.Location =
                new Point((this.pnHaut.Width - pnFigure.Width) / 2, (this.pnHaut.Height - this.pnFigure.Height) / 2);
        }
        //Check if the polygon is in the center of the panel.
        public bool EstCentré
        {
            get
            {
                return (this.pnFigure.Location.X == (this.pnHaut.Width - pnFigure.Width) / 2
                    && this.pnFigure.Location.Y  == (this.pnHaut.Height - this.pnFigure.Height) / 2);
            }
        }
        //Button that will center the polygon if it is clicked.
        private void buttonCentre_Click(object sender, EventArgs e)
        {
            this.CentreToi();
            this.SynchroniserBoutons();
        }
        //In button_Click, there are the lines of code that allows us to move the polygon on screen by clicking on the control buttons. 
        private void button_Click(object sender, EventArgs e)
        {
            Point deplacement = (Point)((Button)sender).Tag;
            this.DeplaceToi(deplacement.X, deplacement.Y);
            this.SynchroniserBoutons();
        }
        //Move the polygon 5 pixels down.
        private void buttonBas_Click(object sender, EventArgs e)
        {
            this.button_Click(sender, e);
        }
        //Move the polygon 5 pixels up.
        private void buttonHaut_Click(object sender, EventArgs e)
        {
            this.button_Click(sender, e);
        }
        //Move the polygon 5 pixels to the right.
        private void buttonDroit_Click(object sender, EventArgs e)
        {
            this.button_Click(sender, e);
        }
        //Move the polygon 5 pixels to the left.
        private void buttonGauche_Click(object sender, EventArgs e)
        {
            this.button_Click(sender, e);
        }
        private void buttonHautGauche_Click(object sender, EventArgs e)
        {
            this.button_Click(sender, e);
        }
        #endregion

        #region Code that Display colored polygon on screen
        public void DessineToi() 
        //Method that draw a rectangle, triangle or an ellipse and then that fill it with color (red, green or blue).
        {
            //Allow us to draw divers polygons
            Graphics graphics = this.pnFigure.CreateGraphics();
            graphics.Clear(this.pnFigure.BackColor);

            switch(this.forme)
            {
                case FormeFigure.Ellipse:
                    graphics.FillEllipse(this.couleur, 1, 1, this.pnFigure.Width - 2, this.pnFigure.Height - 2);
                    break;
                case FormeFigure.Rectangle:
                    graphics.FillRectangle(this.couleur, 1, 1, this.pnFigure.Width - 2, this.pnFigure.Height - 2);
                    break;
                case FormeFigure.Triangle:
                    Point[] tab = { new Point(this.pnFigure.Width/2, 3),
                                    new Point(3,this.pnFigure.Height-3),
                                    new Point(this.pnFigure.Width-3,this.pnFigure.Height-3) };
                    graphics.FillPolygon(this.couleur, tab);
                    break;
            }
        }
        #endregion

        public FormeFigure Forme
        {
            set
            {
                this.forme = value;
                this.DessineToi();
            }
        }

        #region Blinking of the polygon
        private void timer1_Tick(object sender, EventArgs e)
        {
            this.pnFigure.Visible = !this.pnFigure.Visible;
            this.DessineToi();
        }

        private void buttonClignoter_Click(object sender, EventArgs e)
        {
            this.timer1.Enabled = !this.timer1.Enabled;
            this.buttonClignoter.Text = (this.timer1.Enabled) ? "Arrêter" : "Démarrer";
            if (this.timer1.Enabled)
                this.pnFigure.Visible = true;

        }

        private void trackBarCligno_Scroll(object sender, EventArgs e)
        {
            
            trackBarCligno.Minimum = 1;
            trackBarCligno.Maximum = 10;
            
            this.timer1.Interval = trackBarCligno.Value * 1000;
        }
        #endregion
        
        #region Menu Change Shape
        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }
        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void rectangleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Forme = FormeFigure.Rectangle;
        }

        private void triToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Forme = FormeFigure.Triangle;
        }

        private void ellipseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Forme = FormeFigure.Ellipse;
        }
        #endregion


    }
}
