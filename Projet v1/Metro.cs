using MetroFramework.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projet_v1
{
    public partial class Metro : MetroFramework.Forms.MetroForm
    {   
        public Metro()
        {
            InitializeComponent();
        }
        public void PB()
        { metroProgressBar1.Value = 0;
            metroProgressBar2.Value = 0;
            metroProgressBar3.Value = 0;
            metroProgressBar4.Value = 0;
            metroProgressBar5.Value = 0;
            DateTime D = DateTime.Now;
            
            if (D.Hour>=4 && D.Hour<8)
            { metroProgressBar2.Value = (D.Hour - 4) * 2 ;
                if (D.Minute > 30)

                    metroProgressBar2.Value += 1;


            }

                if (D.Hour > 8 && D.Hour <= 12)
            {
                metroProgressBar2.Value = 8;
                metroProgressBar3.Value = (D.Hour - 8) * 2 ;
                if ( D.Minute>30)
                    metroProgressBar3.Value +=1;
            }

            if (D.Hour >= 12 && D.Hour < 16)
            {
                metroProgressBar2.Value = 8;
                metroProgressBar3.Value = 8;
                metroProgressBar4.Value = (D.Hour - 12) * 2 ;
                if (D.Minute > 30)
                    metroProgressBar4.Value += 1;

                    }
            if (D.Hour > 16 && D.Hour <= 20)
            {
                metroProgressBar2.Value = 8;
                metroProgressBar3.Value = 8;
                metroProgressBar4.Value = 8;
                metroProgressBar5.Value = (D.Hour - 16) * 2 ;
                if (D.Minute > 30)
                    metroProgressBar5.Value += 1;

                    }
            if (D.Hour >= 20)
            {
                metroProgressBar2.Value = 8;
                metroProgressBar3.Value = 8;
                metroProgressBar4.Value = 8;
                metroProgressBar5.Value = 8;
                metroProgressBar1.Value = (D.Hour - 20) * 2 ;
                if (D.Minute > 30)
                    metroProgressBar1.Value += 1;
                    }

        }
        MetroTile Mate = new MetroTile();
        public void Clik(Object sender , EventArgs e)
        {
            MetroTile Mt = (MetroTile)sender;

            if (Mate != Mt)
            {
                Mate.Width = 92;
                Mate.Height = 42;
                Mate.Style = MetroFramework.MetroColorStyle.Magenta;
                Mate.Left += 15;
                Mt.Style = MetroFramework.MetroColorStyle.Red;
                Mt.CausesValidation = true;
                Mt.BringToFront();
                Mate = Mt;

            }
            else
            {
                Mate.BringToFront(); }
            
            
        }
        
            public void focuser(object sender ,EventArgs e)
        {   
                DateTime D = DateTime.Now;
            metroLabel1.Text = D.ToString();
            PB();
                MetroTile Mt = (MetroTile)sender;
                if (Mt!=Mate)
                { if (Mt.Style != MetroFramework.MetroColorStyle.Magenta)
                {
                    Mt.Width = 118;
                   
                    Mt.Style = MetroFramework.MetroColorStyle.Green;
                    Mt.Left -= 15;
                    Mt.BringToFront();
                    Mt.Refresh();
                }
            }

        }
        public void defocuser(object sender,EventArgs e)
        {

            MetroTile Mt = (MetroTile)sender;
            if (Mt!=Mate)
            {
                if (Mt.Style != MetroFramework.MetroColorStyle.Magenta)
                {
                    Mt.Width = 92;
                    Mt.Height = 42;
                    Mt.Style = MetroFramework.MetroColorStyle.Blue;
                    Mt.Left += 15;
                    Mt.BringToFront();
                    Mt.Refresh();
                    metroProgressBar2.BringToFront();
                    metroProgressBar1.BringToFront();
                    metroProgressBar3.BringToFront();
                    metroProgressBar4.BringToFront();
                    metroProgressBar5.BringToFront();
                }
            }
        }
       
    }
}
