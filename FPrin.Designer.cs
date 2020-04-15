namespace Chap10Ex1
{
    partial class FPrin
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.pnHaut = new System.Windows.Forms.Panel();
            this.pnFigure = new System.Windows.Forms.Panel();
            this.menuStripModShape = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.rectangleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.triToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ellipseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pnBas = new System.Windows.Forms.Panel();
            this.groupBoxClignotement = new System.Windows.Forms.GroupBox();
            this.labelClign10Sec = new System.Windows.Forms.Label();
            this.labelClign1Sec = new System.Windows.Forms.Label();
            this.trackBarCligno = new System.Windows.Forms.TrackBar();
            this.buttonClignoter = new System.Windows.Forms.Button();
            this.groupBoxCouleurs = new System.Windows.Forms.GroupBox();
            this.radioButtonBleu = new System.Windows.Forms.RadioButton();
            this.radioButtonVert = new System.Windows.Forms.RadioButton();
            this.radioButtonRouge = new System.Windows.Forms.RadioButton();
            this.groupBoxPosition = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.buttonBas = new System.Windows.Forms.Button();
            this.buttonDroit = new System.Windows.Forms.Button();
            this.buttonCentre = new System.Windows.Forms.Button();
            this.buttonHaut = new System.Windows.Forms.Button();
            this.buttonGauche = new System.Windows.Forms.Button();
            this.buttonActDesact = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.buttonHautGauche = new System.Windows.Forms.Button();
            this.pnHaut.SuspendLayout();
            this.menuStripModShape.SuspendLayout();
            this.pnBas.SuspendLayout();
            this.groupBoxClignotement.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarCligno)).BeginInit();
            this.groupBoxCouleurs.SuspendLayout();
            this.groupBoxPosition.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnHaut
            // 
            this.pnHaut.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pnHaut.Controls.Add(this.pnFigure);
            this.pnHaut.Controls.Add(this.menuStripModShape);
            this.pnHaut.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnHaut.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.pnHaut.Location = new System.Drawing.Point(0, 0);
            this.pnHaut.Name = "pnHaut";
            this.pnHaut.Size = new System.Drawing.Size(989, 342);
            this.pnHaut.TabIndex = 0;
            this.pnHaut.Paint += new System.Windows.Forms.PaintEventHandler(this.pnHaut_Paint);
            // 
            // pnFigure
            // 
            this.pnFigure.BackColor = System.Drawing.Color.White;
            this.pnFigure.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pnFigure.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.pnFigure.Location = new System.Drawing.Point(408, 112);
            this.pnFigure.Margin = new System.Windows.Forms.Padding(0);
            this.pnFigure.Name = "pnFigure";
            this.pnFigure.Size = new System.Drawing.Size(229, 167);
            this.pnFigure.TabIndex = 0;
            this.pnFigure.Paint += new System.Windows.Forms.PaintEventHandler(this.pnFigure_Paint);
            // 
            // menuStripModShape
            // 
            this.menuStripModShape.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStripModShape.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1});
            this.menuStripModShape.Location = new System.Drawing.Point(0, 0);
            this.menuStripModShape.Name = "menuStripModShape";
            this.menuStripModShape.Size = new System.Drawing.Size(989, 28);
            this.menuStripModShape.TabIndex = 1;
            this.menuStripModShape.Text = "Changer la forme";
            this.menuStripModShape.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.rectangleToolStripMenuItem,
            this.triToolStripMenuItem,
            this.ellipseToolStripMenuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(136, 24);
            this.toolStripMenuItem1.Text = "Changer la forme";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // rectangleToolStripMenuItem
            // 
            this.rectangleToolStripMenuItem.Name = "rectangleToolStripMenuItem";
            this.rectangleToolStripMenuItem.Size = new System.Drawing.Size(150, 26);
            this.rectangleToolStripMenuItem.Text = "Rectangle";
            this.rectangleToolStripMenuItem.Click += new System.EventHandler(this.rectangleToolStripMenuItem_Click);
            // 
            // triToolStripMenuItem
            // 
            this.triToolStripMenuItem.Name = "triToolStripMenuItem";
            this.triToolStripMenuItem.Size = new System.Drawing.Size(150, 26);
            this.triToolStripMenuItem.Text = "Triangle";
            this.triToolStripMenuItem.Click += new System.EventHandler(this.triToolStripMenuItem_Click);
            // 
            // ellipseToolStripMenuItem
            // 
            this.ellipseToolStripMenuItem.Name = "ellipseToolStripMenuItem";
            this.ellipseToolStripMenuItem.Size = new System.Drawing.Size(150, 26);
            this.ellipseToolStripMenuItem.Text = "Ellipse";
            this.ellipseToolStripMenuItem.Click += new System.EventHandler(this.ellipseToolStripMenuItem_Click);
            // 
            // pnBas
            // 
            this.pnBas.Controls.Add(this.groupBoxClignotement);
            this.pnBas.Controls.Add(this.groupBoxCouleurs);
            this.pnBas.Controls.Add(this.groupBoxPosition);
            this.pnBas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnBas.Location = new System.Drawing.Point(0, 342);
            this.pnBas.Name = "pnBas";
            this.pnBas.Size = new System.Drawing.Size(989, 212);
            this.pnBas.TabIndex = 1;
            // 
            // groupBoxClignotement
            // 
            this.groupBoxClignotement.Controls.Add(this.labelClign10Sec);
            this.groupBoxClignotement.Controls.Add(this.labelClign1Sec);
            this.groupBoxClignotement.Controls.Add(this.trackBarCligno);
            this.groupBoxClignotement.Controls.Add(this.buttonClignoter);
            this.groupBoxClignotement.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxClignotement.Location = new System.Drawing.Point(401, 0);
            this.groupBoxClignotement.Name = "groupBoxClignotement";
            this.groupBoxClignotement.Size = new System.Drawing.Size(294, 212);
            this.groupBoxClignotement.TabIndex = 4;
            this.groupBoxClignotement.TabStop = false;
            this.groupBoxClignotement.Text = "Clignotement";
            // 
            // labelClign10Sec
            // 
            this.labelClign10Sec.AutoSize = true;
            this.labelClign10Sec.Location = new System.Drawing.Point(244, 42);
            this.labelClign10Sec.Name = "labelClign10Sec";
            this.labelClign10Sec.Size = new System.Drawing.Size(50, 17);
            this.labelClign10Sec.TabIndex = 3;
            this.labelClign10Sec.Text = "10 sec";
            // 
            // labelClign1Sec
            // 
            this.labelClign1Sec.AutoSize = true;
            this.labelClign1Sec.Location = new System.Drawing.Point(244, 184);
            this.labelClign1Sec.Name = "labelClign1Sec";
            this.labelClign1Sec.Size = new System.Drawing.Size(42, 17);
            this.labelClign1Sec.TabIndex = 2;
            this.labelClign1Sec.Text = "1 sec";
            // 
            // trackBarCligno
            // 
            this.trackBarCligno.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.trackBarCligno.Location = new System.Drawing.Point(181, 40);
            this.trackBarCligno.Name = "trackBarCligno";
            this.trackBarCligno.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trackBarCligno.Size = new System.Drawing.Size(56, 167);
            this.trackBarCligno.TabIndex = 1;
            this.trackBarCligno.Scroll += new System.EventHandler(this.trackBarCligno_Scroll);
            // 
            // buttonClignoter
            // 
            this.buttonClignoter.ForeColor = System.Drawing.SystemColors.Desktop;
            this.buttonClignoter.Location = new System.Drawing.Point(7, 162);
            this.buttonClignoter.Name = "buttonClignoter";
            this.buttonClignoter.Size = new System.Drawing.Size(168, 45);
            this.buttonClignoter.TabIndex = 0;
            this.buttonClignoter.Text = "Clignoter";
            this.buttonClignoter.UseVisualStyleBackColor = true;
            this.buttonClignoter.Click += new System.EventHandler(this.buttonClignoter_Click);
            // 
            // groupBoxCouleurs
            // 
            this.groupBoxCouleurs.Controls.Add(this.radioButtonBleu);
            this.groupBoxCouleurs.Controls.Add(this.radioButtonVert);
            this.groupBoxCouleurs.Controls.Add(this.radioButtonRouge);
            this.groupBoxCouleurs.Dock = System.Windows.Forms.DockStyle.Right;
            this.groupBoxCouleurs.ForeColor = System.Drawing.Color.Black;
            this.groupBoxCouleurs.Location = new System.Drawing.Point(695, 0);
            this.groupBoxCouleurs.Name = "groupBoxCouleurs";
            this.groupBoxCouleurs.Size = new System.Drawing.Size(294, 212);
            this.groupBoxCouleurs.TabIndex = 3;
            this.groupBoxCouleurs.TabStop = false;
            this.groupBoxCouleurs.Text = "Couleur Intérieure";
            // 
            // radioButtonBleu
            // 
            this.radioButtonBleu.AutoSize = true;
            this.radioButtonBleu.Location = new System.Drawing.Point(18, 109);
            this.radioButtonBleu.Name = "radioButtonBleu";
            this.radioButtonBleu.Size = new System.Drawing.Size(57, 21);
            this.radioButtonBleu.TabIndex = 2;
            this.radioButtonBleu.TabStop = true;
            this.radioButtonBleu.Text = "Bleu";
            this.radioButtonBleu.UseVisualStyleBackColor = true;
            this.radioButtonBleu.CheckedChanged += new System.EventHandler(this.radioButtonBleu_CheckedChanged);
            // 
            // radioButtonVert
            // 
            this.radioButtonVert.AutoSize = true;
            this.radioButtonVert.Location = new System.Drawing.Point(18, 74);
            this.radioButtonVert.Name = "radioButtonVert";
            this.radioButtonVert.Size = new System.Drawing.Size(55, 21);
            this.radioButtonVert.TabIndex = 1;
            this.radioButtonVert.TabStop = true;
            this.radioButtonVert.Text = "Vert";
            this.radioButtonVert.UseVisualStyleBackColor = true;
            this.radioButtonVert.CheckedChanged += new System.EventHandler(this.radioButtonVert_CheckedChanged);
            // 
            // radioButtonRouge
            // 
            this.radioButtonRouge.AutoSize = true;
            this.radioButtonRouge.Checked = true;
            this.radioButtonRouge.Location = new System.Drawing.Point(18, 37);
            this.radioButtonRouge.Name = "radioButtonRouge";
            this.radioButtonRouge.Size = new System.Drawing.Size(71, 21);
            this.radioButtonRouge.TabIndex = 0;
            this.radioButtonRouge.TabStop = true;
            this.radioButtonRouge.Text = "Rouge";
            this.radioButtonRouge.UseVisualStyleBackColor = true;
            this.radioButtonRouge.CheckedChanged += new System.EventHandler(this.radioButtonRouge_CheckedChanged);
            // 
            // groupBoxPosition
            // 
            this.groupBoxPosition.Controls.Add(this.tableLayoutPanel1);
            this.groupBoxPosition.Controls.Add(this.buttonActDesact);
            this.groupBoxPosition.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBoxPosition.ForeColor = System.Drawing.SystemColors.ControlText;
            this.groupBoxPosition.Location = new System.Drawing.Point(0, 0);
            this.groupBoxPosition.Name = "groupBoxPosition";
            this.groupBoxPosition.Size = new System.Drawing.Size(401, 212);
            this.groupBoxPosition.TabIndex = 2;
            this.groupBoxPosition.TabStop = false;
            this.groupBoxPosition.Text = "Position";
            this.groupBoxPosition.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Controls.Add(this.buttonHautGauche, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.buttonBas, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.buttonDroit, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.buttonCentre, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.buttonHaut, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.buttonGauche, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 18);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(395, 135);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // buttonBas
            // 
            this.buttonBas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonBas.ForeColor = System.Drawing.SystemColors.Desktop;
            this.buttonBas.Location = new System.Drawing.Point(134, 93);
            this.buttonBas.Name = "buttonBas";
            this.buttonBas.Size = new System.Drawing.Size(125, 39);
            this.buttonBas.TabIndex = 7;
            this.buttonBas.Text = "Bas";
            this.buttonBas.UseVisualStyleBackColor = true;
            this.buttonBas.Click += new System.EventHandler(this.buttonBas_Click);
            // 
            // buttonDroit
            // 
            this.buttonDroit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonDroit.ForeColor = System.Drawing.SystemColors.Desktop;
            this.buttonDroit.Location = new System.Drawing.Point(265, 48);
            this.buttonDroit.Name = "buttonDroit";
            this.buttonDroit.Size = new System.Drawing.Size(127, 39);
            this.buttonDroit.TabIndex = 5;
            this.buttonDroit.Text = "Droit";
            this.buttonDroit.UseVisualStyleBackColor = true;
            this.buttonDroit.Click += new System.EventHandler(this.buttonDroit_Click);
            // 
            // buttonCentre
            // 
            this.buttonCentre.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonCentre.ForeColor = System.Drawing.SystemColors.Desktop;
            this.buttonCentre.Location = new System.Drawing.Point(134, 48);
            this.buttonCentre.Name = "buttonCentre";
            this.buttonCentre.Size = new System.Drawing.Size(125, 39);
            this.buttonCentre.TabIndex = 4;
            this.buttonCentre.Text = "Centre";
            this.buttonCentre.UseVisualStyleBackColor = true;
            this.buttonCentre.Click += new System.EventHandler(this.buttonCentre_Click);
            // 
            // buttonHaut
            // 
            this.buttonHaut.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonHaut.ForeColor = System.Drawing.SystemColors.Desktop;
            this.buttonHaut.Location = new System.Drawing.Point(134, 3);
            this.buttonHaut.Name = "buttonHaut";
            this.buttonHaut.Size = new System.Drawing.Size(125, 39);
            this.buttonHaut.TabIndex = 2;
            this.buttonHaut.Text = "Haut";
            this.buttonHaut.UseVisualStyleBackColor = true;
            this.buttonHaut.Click += new System.EventHandler(this.buttonHaut_Click);
            // 
            // buttonGauche
            // 
            this.buttonGauche.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonGauche.ForeColor = System.Drawing.SystemColors.Desktop;
            this.buttonGauche.Location = new System.Drawing.Point(3, 48);
            this.buttonGauche.Name = "buttonGauche";
            this.buttonGauche.Size = new System.Drawing.Size(125, 39);
            this.buttonGauche.TabIndex = 0;
            this.buttonGauche.Text = "Gauche";
            this.buttonGauche.UseVisualStyleBackColor = true;
            this.buttonGauche.Click += new System.EventHandler(this.buttonGauche_Click);
            // 
            // buttonActDesact
            // 
            this.buttonActDesact.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.buttonActDesact.ForeColor = System.Drawing.SystemColors.Desktop;
            this.buttonActDesact.Location = new System.Drawing.Point(3, 164);
            this.buttonActDesact.Name = "buttonActDesact";
            this.buttonActDesact.Size = new System.Drawing.Size(395, 45);
            this.buttonActDesact.TabIndex = 1;
            this.buttonActDesact.Text = "Activer";
            this.buttonActDesact.UseVisualStyleBackColor = true;
            this.buttonActDesact.Click += new System.EventHandler(this.buttonActDesact_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // buttonHautGauche
            // 
            this.buttonHautGauche.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonHautGauche.ForeColor = System.Drawing.SystemColors.Desktop;
            this.buttonHautGauche.Location = new System.Drawing.Point(3, 3);
            this.buttonHautGauche.Name = "buttonHautGauche";
            this.buttonHautGauche.Size = new System.Drawing.Size(125, 39);
            this.buttonHautGauche.TabIndex = 8;
            this.buttonHautGauche.Text = "Haut / Gauche";
            this.buttonHautGauche.UseVisualStyleBackColor = true;
            this.buttonHautGauche.Click += new System.EventHandler(this.buttonHautGauche_Click);
            // 
            // FPrin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(989, 554);
            this.Controls.Add(this.pnBas);
            this.Controls.Add(this.pnHaut);
            this.MainMenuStrip = this.menuStripModShape;
            this.Name = "FPrin";
            this.Text = "Chap10Ex1";
            this.pnHaut.ResumeLayout(false);
            this.pnHaut.PerformLayout();
            this.menuStripModShape.ResumeLayout(false);
            this.menuStripModShape.PerformLayout();
            this.pnBas.ResumeLayout(false);
            this.groupBoxClignotement.ResumeLayout(false);
            this.groupBoxClignotement.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarCligno)).EndInit();
            this.groupBoxCouleurs.ResumeLayout(false);
            this.groupBoxCouleurs.PerformLayout();
            this.groupBoxPosition.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnHaut;
        private System.Windows.Forms.Panel pnBas;
        private System.Windows.Forms.Panel pnFigure;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button buttonBas;
        private System.Windows.Forms.Button buttonDroit;
        private System.Windows.Forms.Button buttonCentre;
        private System.Windows.Forms.Button buttonHaut;
        private System.Windows.Forms.Button buttonGauche;
        private System.Windows.Forms.Button buttonActDesact;
        private System.Windows.Forms.GroupBox groupBoxPosition;
        private System.Windows.Forms.GroupBox groupBoxClignotement;
        private System.Windows.Forms.GroupBox groupBoxCouleurs;
        private System.Windows.Forms.RadioButton radioButtonBleu;
        private System.Windows.Forms.RadioButton radioButtonVert;
        private System.Windows.Forms.RadioButton radioButtonRouge;
        private System.Windows.Forms.Label labelClign10Sec;
        private System.Windows.Forms.Label labelClign1Sec;
        private System.Windows.Forms.TrackBar trackBarCligno;
        private System.Windows.Forms.Button buttonClignoter;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.MenuStrip menuStripModShape;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem rectangleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem triToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ellipseToolStripMenuItem;
        private System.Windows.Forms.Button buttonHautGauche;
    }
}

