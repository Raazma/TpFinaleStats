using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PfiStatsPartie3
{
    public partial class Form1 : Form
    {
        public int nbSouslaCourbe = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Cb_Fonction.SelectedIndex = 0;
        }

        private void Btn_Calculate_Click(object sender, EventArgs e)
        {
            lancementDesPoints();
        }

        private void lancementDesPoints()
        {
            Random rnd = new Random();
            for (int i = 0; i < 10000; i++)
            {
                Point p = new Point();
                p.X_ = rnd.Next(int.Parse(X_min.Text), int.Parse(X_Max.Text));
                p.Y_ = rnd.Next(0, GetMaxY());

                if (estSousLaCourbe(p))
                    nbSouslaCourbe++;
                
            }

            Rep.Text = nbSouslaCourbe.ToString();
        }
        private int GetMaxY()
        {
            //Seulement verifier quelle fonction a ete choisi pour retourner le bon max y
            int y = 0;

            switch (Cb_Fonction.SelectedItem.ToString())
            {
                case "F1":
                    y = 5;
                     break;
                case "F2":
                    y = 5;
                     break;
                case "F3":
                     y = 12;
                     break;
                case "F4":
                     y = 10;
                     break;
                case "F5":
                     y = 4;
                     break;
                default:
                    break;
            }
            return y;       
        }
        private decimal calculeAire()
        {
            //va chercher le y max calcul la largeur et l'aire du rectangle
            decimal hauteur = GetMaxY();
            decimal largeur = decimal.Parse(X_Max.Text) - decimal.Parse(X_min.Text);
            decimal airB = largeur * hauteur;

            return 1;
        }
     private bool estSousLaCourbe(Point p) 
         {
     
        bool SousLaCourbe = false;

         switch (Cb_Fonction.SelectedItem.ToString())
                {
                    case "F1":
                SousLaCourbe = F1(p);   
                         break;
                    case "F2":
                         F2(p);
                         break;
                    case "F3":
                    
                         break;
                    case "F4":
                   
                         break;
                    case "F5":
                    
                         break;
                    default:
                        break;
                }
     
            return SousLaCourbe ;
         }

     private bool F1(Point p)
     {
        double value = Math.Pow(p.X_, 2);
        value = value - (16 * p.X_) + 63;
        value = Math.Pow(value, (1.0 / 3.0)) + 4;     
        return p.Y_ <= value;
     }

     private bool F2(Point p)
     {
         double value = ((3 * (Math.Pow(((p.X_ - 7) / 5), 5))) - (5 * (Math.Pow(((p.X_ - 7) / 5), 4)))) + 3;
         return p.Y_ <= value;
       
     }






    }
   
    //Structure de point avoir mon x et mon y ensemble
    public struct Point
    {

       public double X_ { get; set; }
        public double Y_ { get; set; }
      
    }
}
