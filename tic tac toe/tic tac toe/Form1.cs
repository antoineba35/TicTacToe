using System;
using System.Drawing;
using System.Windows.Forms;

namespace tic_tac_toe
{
    partial class Form1 : Form
    {
        #region variable
        // 1 = croix
        // 2 = rond

        // variable
        int test;
        int nbrTour = 1;
        TTT tttBase = new TTT();
        int tour = 1;

        Ia alex = new Ia();
        #endregion

        public Form1()
        {
            InitializeComponent();
            tttBase.ajoutValeur(tttBase.TicTacToe);
        }


        #region dessin jeux
        private void dessinLigne_Paint(object sender, PaintEventArgs e)
        {
            int haut = dessinLigne.Height;
            int larg = dessinLigne.Width;

            // création et remise à zéro de la page
            Graphics go = dessinLigne.CreateGraphics();
            go.Clear(dessinLigne.BackColor);

            // preparation du trait
            Brush br = new SolidBrush(Color.Black);
            Pen pe = new Pen(br, 3);

            // traits vertical
            go.DrawLine(pe, 175, 10, 175, 550);
            go.DrawLine(pe, 375, 10, 375, 550);

            // traits horizontal
            go.DrawLine(pe, 10, 175, 550, 175);
            go.DrawLine(pe, 10, 375, 550, 375);
        }
        #endregion

        #region cliquer
        // carré en haut à gauche
        private void HG_Click(object sender, EventArgs e)
        {
            if(tour == 1 && tttBase.ticTacToe[0] == 0)
            {
                HG_Paint(Int32.Parse(tttBase.valeur(0)));
                verifTour();
            }            
        }

        // carré en haut au millieu
        private void HM_Click(object sender, EventArgs e)
        {
            if (tour == 1 && tttBase.ticTacToe[1] == 0)
            {
                HM_Paint(Int32.Parse(tttBase.valeur(1)));
                verifTour();
            }
        }

        // carré en haut à droite
        private void HD_Click(object sender, EventArgs e)
        {
            if (tour == 1 && tttBase.ticTacToe[2] == 0)
            {
                HD_Paint(Int32.Parse(tttBase.valeur(2)));
                verifTour();
            }
        }

        // carré au millieu a gauche
        private void MG_Click(object sender, EventArgs e)
        {
            if (tour == 1 && tttBase.ticTacToe[3] == 0)
            {
                MG_Paint(Int32.Parse(tttBase.valeur(3)));
                verifTour();
            }
        }

        // carré au millieu au millieu
        private void MM_Click(object sender, EventArgs e)
        {
            if (tour == 1 && tttBase.ticTacToe[4] == 0)
            {
                MM_Paint(Int32.Parse(tttBase.valeur(4)));
                verifTour();
            }
        }

        // carré au millieu à droite
        private void MD_Click(object sender, EventArgs e)
        {
            if (tour == 1 && tttBase.ticTacToe[5] == 0)
            {
                MD_Paint(Int32.Parse(tttBase.valeur(5)));
                verifTour();
            }
        }

        // carré en bas à gauche
        private void BG_Click(object sender, EventArgs e)
        {
            if (tour == 1 && tttBase.ticTacToe[6] == 0)
            {
                BG_Paint(Int32.Parse(tttBase.valeur(6)));
                verifTour();
            }
        }

        // carré en bas au millieu
        private void BM_Click(object sender, EventArgs e)
        {
            if (tour == 1 && tttBase.ticTacToe[7] == 0)
            {
                BM_Paint(Int32.Parse(tttBase.valeur(7)));
                verifTour();
            }
        }

        // carré en bas à droite
        private void BD_Click(object sender, EventArgs e)
        {
            if (tour == 1 && tttBase.ticTacToe[8] == 0)
            {
                BD_Paint(Int32.Parse(tttBase.valeur(8)));
                verifTour();
            }
        }
        #endregion

        #region dessin croix ou rond
        // haut gauche
        private void HG_Paint(int valeur)
        {
            // création et remise à zéro de la page
            Graphics goo = HG.CreateGraphics();
            goo.Clear(HG.BackColor);

            // preparation du trait
            Brush br = new SolidBrush(Color.Black);
            Pen pe = new Pen(br, 3);
            if(valeur == 1)
            {
                // dessin croix
                goo.DrawLine(pe, 25, 25, 150, 150);
                goo.DrawLine(pe, 25, 150, 150, 25);
            }
            else if(valeur == 2)
            {
                // dessin cercle
                goo.DrawEllipse(pe, 15, 15, 150, 150);
            }
            else if(valeur == 0)
            {
                tttBase.ticTacToe[0] = tour;
                HG_Paint(Int32.Parse(tttBase.valeur(0)));
            }
        }

        // haut millieu
        private void HM_Paint(int valeur)
        {
            // création et remise à zéro de la page
            Graphics goo = HM.CreateGraphics();
            goo.Clear(HM.BackColor);

            // preparation du trait
            Brush br = new SolidBrush(Color.Black);
            Pen pe = new Pen(br, 3);
            if (valeur == 1)
            {
                // dessin croix
                goo.DrawLine(pe, 25, 25, 150, 150);
                goo.DrawLine(pe, 25, 150, 150, 25);
            }
            else if (valeur == 2)
            {
                // dessin cercle
                goo.DrawEllipse(pe, 15, 15, 150, 150);
            }
            else if (valeur == 0)
            {
                tttBase.ticTacToe[1] = tour;
                HM_Paint(Int32.Parse(tttBase.valeur(1)));
            }
        }

        // haut droite
        private void HD_Paint(int valeur)
        {
            // création et remise à zéro de la page
            Graphics goo = HD.CreateGraphics();
            goo.Clear(HD.BackColor);

            // preparation du trait
            Brush br = new SolidBrush(Color.Black);
            Pen pe = new Pen(br, 3);
            if (valeur == 1)
            {
                // dessin croix
                goo.DrawLine(pe, 25, 25, 150, 150);
                goo.DrawLine(pe, 25, 150, 150, 25);
            }
            else if (valeur == 2)
            {
                // dessin cercle
                goo.DrawEllipse(pe, 15, 15, 150, 150);
            }
            else if (valeur == 0)
            {
                tttBase.ticTacToe[2] = tour;
                HD_Paint(Int32.Parse(tttBase.valeur(2)));
            }
        }

        // milieu gauche
        private void MG_Paint(int valeur)
        {
            // création et remise à zéro de la page
            Graphics goo = MG.CreateGraphics();
            goo.Clear(MG.BackColor);

            // preparation du trait
            Brush br = new SolidBrush(Color.Black);
            Pen pe = new Pen(br, 3);
            if (valeur == 1)
            {
                // dessin croix
                goo.DrawLine(pe, 25, 25, 150, 150);
                goo.DrawLine(pe, 25, 150, 150, 25);
            }
            else if (valeur == 2)
            {
                // dessin cercle
                goo.DrawEllipse(pe, 15, 15, 150, 150);
            }
            else if (valeur == 0)
            {
                tttBase.ticTacToe[3] = tour;
                MG_Paint(Int32.Parse(tttBase.valeur(3)));
            }
        }

        // milieu milieu
        private void MM_Paint(int valeur)
        {
            // création et remise à zéro de la page
            Graphics goo = MM.CreateGraphics();
            goo.Clear(MM.BackColor);

            // preparation du trait
            Brush br = new SolidBrush(Color.Black);
            Pen pe = new Pen(br, 3);
            if (valeur == 1)
            {
                // dessin croix
                goo.DrawLine(pe, 25, 25, 150, 150);
                goo.DrawLine(pe, 25, 150, 150, 25);
            }
            else if (valeur == 2)
            {
                // dessin cercle
                goo.DrawEllipse(pe, 15, 15, 150, 150);
            }
            else if (valeur == 0)
            {
                tttBase.ticTacToe[4] = tour;
                MM_Paint(Int32.Parse(tttBase.valeur(4)));
            }
        }

        // milieu droite
        private void MD_Paint(int valeur)
        {
            // création et remise à zéro de la page
            Graphics goo = MD.CreateGraphics();
            goo.Clear(MD.BackColor);

            // preparation du trait
            Brush br = new SolidBrush(Color.Black);
            Pen pe = new Pen(br, 3);
            if (valeur == 1)
            {
                // dessin croix
                goo.DrawLine(pe, 25, 25, 150, 150);
                goo.DrawLine(pe, 25, 150, 150, 25);
            }
            else if (valeur == 2)
            {
                // dessin cercle
                goo.DrawEllipse(pe, 15, 15, 150, 150);
            }
            else if (valeur == 0)
            {
                tttBase.ticTacToe[5] = tour;
                MD_Paint(Int32.Parse(tttBase.valeur(5)));
            }
        }

        // bas gauche 
        private void BG_Paint(int valeur)
        {
            // création et remise à zéro de la page
            Graphics goo = BG.CreateGraphics();
            goo.Clear(BG.BackColor);

            // preparation du trait
            Brush br = new SolidBrush(Color.Black);
            Pen pe = new Pen(br, 3);
            if (valeur == 1)
            {
                // dessin croix
                goo.DrawLine(pe, 25, 25, 150, 150);
                goo.DrawLine(pe, 25, 150, 150, 25);
            }
            else if (valeur == 2)
            {
                // dessin cercle
                goo.DrawEllipse(pe, 15, 15, 150, 150);
            }
            else if (valeur == 0)
            {
                tttBase.ticTacToe[6] = tour;
                BG_Paint(Int32.Parse(tttBase.valeur(6)));
            }
        }

        // bas milieu
        private void BM_Paint(int valeur)
        {
            // création et remise à zéro de la page
            Graphics goo = BM.CreateGraphics();
            goo.Clear(BM.BackColor);

            // preparation du trait
            Brush br = new SolidBrush(Color.Black);
            Pen pe = new Pen(br, 3);
            if (valeur == 1)
            {
                // dessin croix
                goo.DrawLine(pe, 25, 25, 150, 150);
                goo.DrawLine(pe, 25, 150, 150, 25);
            }
            else if (valeur == 2)
            {
                // dessin cercle
                goo.DrawEllipse(pe, 15, 15, 150, 150);
            }
            else if (valeur == 0)
            {
                tttBase.ticTacToe[7] = tour;
                BM_Paint(Int32.Parse(tttBase.valeur(7)));
            }
        }

        // bas droit
        private void BD_Paint(int valeur)
        {
            // création et remise à zéro de la page
            Graphics goo = BD.CreateGraphics();
            goo.Clear(BD.BackColor);

            // preparation du trait
            Brush br = new SolidBrush(Color.Black);
            Pen pe = new Pen(br, 3);
            if (valeur == 1)
            {
                // dessin croix
                goo.DrawLine(pe, 25, 25, 150, 150);
                goo.DrawLine(pe, 25, 150, 150, 25);
            }
            else if (valeur == 2)
            {
                // dessin cercle
                goo.DrawEllipse(pe, 15, 15, 150, 150);
            }
            else if (valeur == 0)
            {
                tttBase.ticTacToe[8] = tour;
                BD_Paint(Int32.Parse(tttBase.valeur(8)));
            }
        }
        #endregion

        // verif tour 
        public void verifTour()
        {
            if(nbrTour > 8 || alex.gagner(tttBase.ticTacToe) != 0)
            {
                if (alex.gagner(tttBase.ticTacToe) != 0)
                {
                    if (alex.gagner(tttBase.ticTacToe) == 2)
                    {
                        MessageBox.Show("Fin du jeux, le gagnant est la machine", "Fin", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Close();
                    }
                    else
                    {
                        MessageBox.Show("Fin du jeux, le gagnant est le joueur", "Fin", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Close();
                    }
                }
                else
                {
                    MessageBox.Show("Fin du jeux, pas de gagnant", "Fin", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Close();
                }                                
            }
            else
            {
                if (tour == 1)
                {
                    nbrTour++;
                    tour = 2;
                    jouer();            
                }
                else
                {
                    nbrTour++;
                    tour = 1;
                }
            }               
        }        

        #region IA
        public void jouer()
        {
            test = alex.presqueGagner(tttBase.TicTacToe);
            int i = 0;
            if (test == -1)
            {
                bool a = false;
                Random alea = new Random();
                
                while(a == false)
                {
                    i = alea.Next(0, 9);
                    if(nbrTour == 2 && tttBase.TicTacToe[4] != 1)
                    {
                        i = 4;
                        tttBase.TicTacToe[i] = 2;
                        a = true;
                    }
                    else if(tttBase.TicTacToe[i] == 0)
                    {
                        tttBase.TicTacToe[i] = 2;
                        a = true;
                    }
                }

                #region test case
                switch(i)
                {
                    case 0:
                        HG_Paint(2);
                        break;
                    case 1:
                        HM_Paint(2);
                        break;
                    case 2:
                        HD_Paint(2);
                        break;
                    case 3:
                        MG_Paint(2);
                        break;
                    case 4:
                        MM_Paint(2);
                        break;
                    case 5:
                        MD_Paint(2);
                        break;
                    case 6:
                        BG_Paint(2);
                        break;
                    case 7:
                        BM_Paint(2);
                        break;
                    case 8:
                        BD_Paint(2);
                        break;
                }
                #endregion
            }                
            else
            {
                tttBase.TicTacToe[test] = 2;
                #region test case
                switch (test)
                {
                    case 0:
                        HG_Paint(2);
                        break;
                    case 1:
                        HM_Paint(2);
                        break;
                    case 2:
                        HD_Paint(2);
                        break;
                    case 3:
                        MG_Paint(2);
                        break;
                    case 4:
                        MM_Paint(2);
                        break;
                    case 5:
                        MD_Paint(2);
                        break;
                    case 6:
                        BG_Paint(2);
                        break;
                    case 7:
                        BM_Paint(2);
                        break;
                    case 8:
                        BD_Paint(2);
                        break;
                }
                #endregion
            }
            verifTour();

        }
        #endregion

    }
}
