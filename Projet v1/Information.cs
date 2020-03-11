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
    public partial class Information : MetroFramework.Forms.MetroForm
    {

        public Information()
        {
            InitializeComponent();
        }

        
        private void metroComboBox5_TabIndexChanged(object sender, EventArgs e)
        {
            metroLabel14.Visible = false;
            metroLabel19.Visible = false;
            Prix1.Visible = false;
            Cb1.Visible = false;
            Bulletin1.Visible= false;

            metroLabel14.Visible = false;
            metroLabel19.Visible = false;
            Prix1.Visible = false;
            Cb1.Visible = false;
            Bulletin1.Visible = false;

            metroLabel15.Visible = false;
            metroLabel20.Visible = false;
            Prix2.Visible = false;
            Cb2.Visible = false;
            Bulletin2.Visible = false;

            metroLabel16.Visible = false;
            metroLabel21.Visible = false;
            Prix3.Visible = false;
            Cb3.Visible = false;
            Bulletin3.Visible = false;

            metroLabel17.Visible = false;
            metroLabel22.Visible = false;
            Prix4.Visible = false;
            Cb4.Visible = false;
            Bulletin4.Visible = false;

            metroLabel18.Visible = false;
            metroLabel23.Visible = false;
            Prix5.Visible = false;
            Cb5.Visible = false;
            Bulletin5.Visible = false;

            switch(metroComboBox5.SelectedIndex)
            {
                case 1:
                    metroLabel14.Visible = true;
                    metroLabel19.Visible = true;
                    Prix1.Visible = true;
                    Cb1.Visible = true;
                    Bulletin1.Visible = true;
                    break;
                case 2:
                    metroLabel14.Visible = true;
                    metroLabel19.Visible = true;
                    Prix1.Visible = true;
                    Cb1.Visible = true;
                    Bulletin1.Visible = true;
                    metroLabel15.Visible = true;
                    metroLabel20.Visible = true;
                    Prix2.Visible = true;
                    Cb2.Visible = true;
                    Bulletin2.Visible = true;
                    break;
                case 3:
                    metroLabel14.Visible = true;
                    metroLabel19.Visible = true;
                    Prix1.Visible = true;
                    Cb1.Visible = true;
                    Bulletin1.Visible = true;
                    metroLabel15.Visible = true;
                    metroLabel20.Visible = true;
                    Prix2.Visible = true;
                    Cb2.Visible = true;
                    Bulletin2.Visible = true;
                    metroLabel16.Visible = true;
                    metroLabel21.Visible = true;
                    Prix3.Visible = true;
                    Cb3.Visible = true;
                    Bulletin3.Visible = true;
                    break;
                case 4:
                    metroLabel14.Visible = true;
                    metroLabel19.Visible = true;
                    Prix1.Visible = true;
                    Cb1.Visible = true;
                    Bulletin1.Visible = true;
                    metroLabel15.Visible = true;
                    metroLabel20.Visible = true;
                    Prix2.Visible = true;
                    Cb2.Visible = true;
                    Bulletin2.Visible = true;
                    metroLabel16.Visible = true;
                    metroLabel21.Visible = true;
                    Prix3.Visible = true;
                    Cb3.Visible = true;
                    Bulletin3.Visible = true;
                    metroLabel17.Visible = true;
                    metroLabel22.Visible = true;
                    Prix4.Visible = true;
                    Cb4.Visible = true;
                    Bulletin4.Visible = true;
                    break;
                case 5:
                    metroLabel14.Visible = true;
                    metroLabel19.Visible = true;
                    Prix1.Visible = true;
                    Cb1.Visible = true;
                    Bulletin1.Visible = true;
                    metroLabel15.Visible = true;
                    metroLabel20.Visible = true;
                    Prix2.Visible = true;
                    Cb2.Visible = true;
                    Bulletin2.Visible = true;
                    metroLabel16.Visible = true;
                    metroLabel21.Visible = true;
                    Prix3.Visible = true;
                    Cb3.Visible = true;
                    Bulletin3.Visible = true;
                    metroLabel17.Visible = true;
                    metroLabel22.Visible = true;
                    Prix4.Visible = true;
                    Cb4.Visible = true;
                    Bulletin4.Visible = true;
                    metroLabel18.Visible = true;
                    metroLabel23.Visible = true;
                    Prix5.Visible = true;
                    Cb5.Visible = true;
                    Bulletin5.Visible = true;
                    break;








            }
                
            /*  metroLabel14.Visible = true;
                metroLabel19.Visible = true;
                Prix1.Visible = true;
                Cb1.Visible = true;
                Bulletin1.Visible = true;*/
            
        }

        private void metroComboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch(metroComboBox4.SelectedIndex)
            {
                case 0:
                    break;
                case 1:     
                    break;
                case 2:
                    break;
                case 3:
                    break;
                case 4:
                    break;
                case 5:
                    break;




            }
        }

        

           
        private void Nbr_Maladie_SelectedIndexChanged(object sender, EventArgs e)
        {
            metroLabel34.Visible = false;
            metroTextBox21.Visible = false;
            metroLabel29.Visible = false;
            metroComboBox11.Visible = false;
            metroComboBox16.Visible = false;


            metroLabel33.Visible = false;
            metroTextBox20.Visible = false;
            metroLabel28.Visible = false;
            metroComboBox17.Visible = false;
            metroComboBox12.Visible = false;


            metroLabel32.Visible = false;
            metroTextBox19.Visible = false;
            metroLabel27.Visible = false;
            metroComboBox18.Visible = false;
            metroComboBox13.Visible = false;

            metroLabel31.Visible = false;
            metroTextBox18.Visible = false;
            metroLabel26.Visible = false;
            metroComboBox14.Visible = false;
            metroComboBox19.Visible = false;

            metroLabel30.Visible = false;
            metroTextBox17.Visible = false;
            metroLabel25.Visible = false;
            metroComboBox15.Visible = false;
            metroComboBox20.Visible = false;


            switch (Nbr_Maladie.SelectedIndex)
            { case 1:metroLabel34.Visible = true;
                    metroTextBox21.Visible = true;
                    metroLabel29.Visible = true;
                    metroComboBox11.Visible = true;
                    metroComboBox16.Visible = true;
                    break;
                case 2:
                    metroLabel34.Visible = true;
                    metroTextBox21.Visible = true;
                    metroLabel29.Visible = true;
                    metroComboBox11.Visible = true;
                    metroComboBox16.Visible = true;
                    metroLabel33.Visible =true;
                    metroTextBox20.Visible = true;
                    metroLabel28.Visible = true;
                    metroComboBox12.Visible = true;
                    metroComboBox17.Visible = true;
                    break;
                case 3:
                    metroLabel34.Visible = true;
                    metroTextBox21.Visible = true;
                    metroLabel29.Visible = true;
                    metroComboBox11.Visible = true;
                    metroComboBox16.Visible = true;
                    metroLabel33.Visible = true;
                    metroTextBox20.Visible = true;
                    metroLabel28.Visible = true;
                    metroComboBox12.Visible = true;
                    metroComboBox17.Visible = true;
                    metroLabel32.Visible = true;
                    metroTextBox19.Visible = true;
                    metroLabel27.Visible =true;
                    metroComboBox18.Visible = true;
                    metroComboBox13.Visible = true;

                    break;
                case 4:
                    metroLabel34.Visible = true;
                    metroTextBox21.Visible = true;
                    metroLabel29.Visible = true;
                    metroComboBox11.Visible = true;
                    metroComboBox16.Visible = true;
                    metroLabel33.Visible = true;
                    metroTextBox20.Visible = true;
                    metroLabel28.Visible = true;
                    metroComboBox17.Visible = true;
                    metroComboBox12.Visible = true;
                    metroLabel32.Visible = true;
                    metroTextBox19.Visible = true;
                    metroLabel27.Visible = true;
                    metroComboBox13.Visible = true;
                    metroComboBox18.Visible = true;
                    metroLabel31.Visible = true;
                    metroTextBox18.Visible = true;
                    metroLabel26.Visible = true;
                    metroComboBox14.Visible = true;
                    metroComboBox19.Visible = true;
                    break;
                case 5:
                    metroLabel34.Visible = true;
                    metroTextBox21.Visible = true;
                    metroLabel29.Visible = true;
                    metroComboBox11.Visible = true;
                    metroComboBox16.Visible = true;
                    metroLabel33.Visible = true;
                    metroTextBox20.Visible = true;
                    metroLabel28.Visible = true;
                    metroComboBox17.Visible = true;
                    metroComboBox12.Visible = true;
                    metroLabel32.Visible = true;
                    metroTextBox19.Visible = true;
                    metroLabel27.Visible = true;
                    metroComboBox18.Visible = true;
                    metroComboBox13.Visible = true;
                    metroLabel31.Visible = true;
                    metroTextBox18.Visible = true;
                    metroLabel26.Visible = true;
                    metroComboBox14.Visible = true;
                    metroComboBox19.Visible = true;
                    metroLabel30.Visible = true;
                    metroTextBox17.Visible = true;
                    metroLabel25.Visible = true;
                    metroComboBox15.Visible = true;
                    metroComboBox20.Visible = true;
                    break;
            }
        }
    }
}
