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
        public double nbSouslaCourbe = 0;
		float IntervalMin;
		float IntervalMax;
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
            if (int.Parse(X_min.Text) <= int.Parse(X_Max.Text))
            {
                lancementDesPoints();
                IntervalConfiance();
            }
            else
                MessageBox.Show("a doit etre plus petit que b merci!");

        }

        private void lancementDesPoints()
        {
            //genere 10000 point aleatoir entre les bornes voulue
            Random rnd = new Random();
            for (int i = 0; i < 10000; i++)
            {
                Point p = new Point();
                p.X_ = rnd.Next(int.Parse(X_min.Text), int.Parse(X_Max.Text));
                p.Y_ = rnd.Next(0, GetMaxY());

                if (estSousLaCourbe(p))
                    nbSouslaCourbe++;	                 
            }

            Rep.Text = (calculeAire() * (nbSouslaCourbe / 10000)).ToString();
            CalculProbabilité((calculeAire() * (nbSouslaCourbe / 10000)));

            nbSouslaCourbe = 0; //remet a 0 le compteur de point sous la courbe pouvoir recommencer les calcules
        }
		private void IntervalConfiance()
		{

			float Z = 1.96f;
            float MargeErreur =  1 - (float.Parse(Rep.Text)/100);
            MargeErreur =( (float.Parse(Rep.Text) / 100) * MargeErreur) / 10000;
            MargeErreur = Z * float.Parse(Math.Sqrt(float.Parse(MargeErreur.ToString())).ToString());
			IntervalMin = float.Parse(Rep.Text) / 100 - MargeErreur;
			IntervalMax = float.Parse(Rep.Text) / 100 + MargeErreur;
			Tb_MargeErreur.Text = (Math.Round(MargeErreur ,4)* 100).ToString() + "%";
			Tb_IntervalMin.Text = (Math.Round(IntervalMin,4) * 100).ToString() + "%";
			Tb_IntervalMax.Text = (Math.Round(IntervalMax ,4)* 100).ToString() + "%";

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
        private double calculeAire()
        {
            //va chercher le y max calcul la largeur et l'aire du rectangle avec les bornes
           double hauteur = GetMaxY();
           double largeur = double.Parse(X_Max.Text) - double.Parse(X_min.Text);
           double airB = largeur * hauteur;

            return airB;
        }
     private bool estSousLaCourbe(Point p) 
         {
     
         //appele la fonction choisi par l'utilisateur et renvoie vrai si le point est sous la courbe
        bool SousLaCourbe = false;

         switch (Cb_Fonction.SelectedItem.ToString())
                {
                    case "F1":
                SousLaCourbe = F1(p);   
                         break;
                    case "F2":
                SousLaCourbe = F2(p);
                         break;
                    case "F3":
				SousLaCourbe = F3(p);
                         break;
                    case "F4":
                SousLaCourbe = F4(p);
                         break;
                    case "F5":
                 SousLaCourbe = F5(p);
                         break;
                    default:
                        break;
                }
     
            return SousLaCourbe ;
         }

        //les 5 fonctions fournis retourne vrai si le point est sous la courbe
     private bool F1(Point p)
     {
        double value = Math.Pow(p.X_, 2);
        value = value - (16 * p.X_) + 63;
        value = (-Math.Pow(value, (1.0 / 3.0))) + 4;     
        return p.Y_ <= value;
     }
   
     private bool F2(Point p)
     {
         double value = (3 * (Math.Pow(((p.X_ - 7.0) / 5.0), 5))) ;
           value = value  + (- 5 * (Math.Pow(((p.X_ - 7.0) / 5.0), 3))) + 3;
         return p.Y_ <= value;
       
     }

     private bool F3(Point p)
     {
		 float value = -(1.0f/ 3.0f);
		 value = value * float.Parse(Math.Pow((p.X_ - 6), 2).ToString());
	     value += 12;  
		 return float.Parse(p.Y_.ToString()) <= value;
     }
     private bool F4(Point p)
     {
         double value = p.X_ + Math.Sin(p.X_);
         return p.Y_ <= value;
     }
     private bool F5(Point p)
     {
         double value = Math.Cos(p.X_) + 3;
         return p.Y_ <= value;

     }

     private void CalculProbabilité(double air)
     {
        //depasse le 100% lorsque les bornes son atteinte normal vue que nous estimon l,air sous la courbe et que nous avons pas la valeur exacte
         //prend l'air sous la courbe des bornes et la divise par l'air total
         switch (Cb_Fonction.SelectedItem.ToString())
         {
             case "F1":
                 Tb_prob.Text = ((Math.Round((air / 24.9026), 4)) * 100).ToString() + "%"; 
                 break;
             case "F2":
                 Tb_prob.Text = ((Math.Round(air / 36.2815, 4)) * 100).ToString() + "%";
                 break;
             case "F3":
                 Tb_prob.Text = ((Math.Round(air / 94.1111, 4)) * 100).ToString() + "%";        
                 break;
             case "F4":
                 Tb_prob.Text = ((Math.Round(air / 61.4956, 4)) * 100).ToString() + "%";     
                 break;
             case "F5":
         Tb_prob.Text = ((Math.Round(air / 32.0,4)) * 100).ToString() + "%"; 
                 break;
             default:
                 break;
         }
     
     }

     private void X_min_TextChanged(object sender, EventArgs e)
     {
         if (!Isdigit(X_min.Text))
             X_min.Text = "";

     }

     private bool Isdigit(String x)
     { 
         String[] a = new String[] {"0","1", "2"," 3", "4", "5",  "6", "7", "8", "9", "10", "11"};
         bool In = false;
         for (int i = 0; i < a.Length; i++)
         {
             In |= (x == a[i]);
             
         }
         return In;
     }

     private void X_Max_TextChanged(object sender, EventArgs e)
     {
         if (!Isdigit(X_Max.Text))
             X_Max.Text = "";
     }
   
    }
   
    //Structure de point avoir mon x et mon y ensemble
    public struct Point
    {

       public double X_ { get; set; }
        public double Y_ { get; set; }     
    }
    
    
}
