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
        public String cryptengagement()
        { var x=2; String case1, case2, case3, case4, case5;
            dateengagement1.Value.ToString();
            dateengagement1.Value.ToString();
            if (Nbr_Maladie.SelectedIndex > 0)
            {
                switch (x)
                {
                    case 5://healthbox5.text // envoie vers le BD
                           // case5 = healthpro5.SelectedIndex.ToString()+"5";
                        case5 = dateengagement5.Value.ToString();
                        goto case 4;
                    case 4://healthbox5.text // envoie vers le BD
                        case4 = dateengagement4.Value.ToString();
                        goto case 3;
                    case 3://healthbox5.text // envoie vers le BD
                        case3 = dateengagement3.Value.ToString();
                        goto case 2;
                    case 2://healthbox5.text // envoie vers le BD
                        case2 = dateengagement2.Value.ToString();
                        goto case 1;
                    case 1://healthbox5.text // envoie vers le BD
                        case1 = dateengagement1.Value.ToString();
                        goto default;
                    default: break;
                }
            }       return "ch";
                } // encore
        public String crypttransport()
        {
            String trans = "";
            if (metroRadioButton5.Checked)
            { trans = "PT"+metroComboBox3.SelectedIndex; }
            else if (metroRadioButton6.Checked)
            { trans = "TT"+metroComboBox3.SelectedIndex; }
            return trans;
        }  // encore
        public String crypttime()
        {
            String dat = "";
            if (monday.Checked)
            { 
                dat += "1" + dateTimePicker2.Text.ToString().Substring(0, 2)+ dateTimePicker2.Text.ToString().Substring(3, 2) + dateTimePicker3.Text.ToString().Substring(0, 2)+ dateTimePicker3.Text.ToString().Substring(3, 2);
            }
            if (tuesday.Checked)
            {
                dat += "2" + dateTimePicker5.Text.ToString().Substring(0, 2) + dateTimePicker5.Text.ToString().Substring(3, 2) + dateTimePicker4.Text.ToString().Substring(0, 2) + dateTimePicker4.Text.ToString().Substring(3, 2);
            }
            if (wednesday.Checked)
            {
                dat += "3" + dateTimePicker7.Text.ToString().Substring(0, 2) + dateTimePicker7.Text.ToString().Substring(3, 2) + dateTimePicker6.Text.ToString().Substring(0, 2) + dateTimePicker6.Text.ToString().Substring(3, 2);
            }
            if (thursday.Checked)
            {
                dat += "4" + dateTimePicker9.Text.ToString().Substring(0, 2) + dateTimePicker9.Text.ToString().Substring(3, 2) + dateTimePicker8.Text.ToString().Substring(0, 2) + dateTimePicker8.Text.ToString().Substring(3, 2);
            }
            if (friday.Checked)
            {
                dat += "5" + dateTimePicker11.Text.ToString().Substring(0, 2) + dateTimePicker11.Text.ToString().Substring(3, 2) + dateTimePicker10.Text.ToString().Substring(0, 2) + dateTimePicker10.Text.ToString().Substring(3, 2);
            }
            if (saturday.Checked)
            {
                dat += "6" + dateTimePicker13.Text.ToString().Substring(0, 2) + dateTimePicker13.Text.ToString().Substring(3, 2) + dateTimePicker12.Text.ToString().Substring(0, 2) + dateTimePicker12.Text.ToString().Substring(3, 2);
            }
            if (sunday.Checked)
            {
                dat += "7" + dateTimePicker15.Text.ToString().Substring(0, 2) + dateTimePicker15.Text.ToString().Substring(3, 2) + dateTimePicker14.Text.ToString().Substring(0, 2) + dateTimePicker14.Text.ToString().Substring(3, 2);
            }
            return dat;
        }     // encore
        public String crypthealth()
        { int x = Nbr_Maladie.SelectedIndex;
            
            String case1="", case2="", case3="", case4="", case5 ="";
            if (Nbr_Maladie.SelectedIndex>0)
            { switch (x)
                {
                    case 5://healthbox5.text // envoie vers le BD
                       // case5 = healthpro5.SelectedIndex.ToString()+"5";
                        case5= healthpro5.SelectedIndex.ToString() + healthcombo5.SelectedIndex.ToString();
                        label3.Text = lasttohappen5.Value.AddDays(365).ToString();
                        goto case 4;
                    case 4://healthbox5.text // envoie vers le BD
                        case4 =  healthpro4.SelectedIndex.ToString()+ healthcombo4.SelectedIndex.ToString();
                        goto case 3;
                    case 3://healthbox5.text // envoie vers le BD
                       case3 =  healthpro3.SelectedIndex.ToString()+ healthcombo3.SelectedIndex.ToString();
                        goto case 2;
                    case 2://healthbox5.text // envoie vers le BD
                       case2=  healthpro2.SelectedIndex.ToString()+ healthcombo2.SelectedIndex.ToString();
                        goto case 1;
                    case 1://healthbox5.text // envoie vers le BD
                        case1=  healthpro1.SelectedIndex.ToString()+healthcombo1.SelectedIndex.ToString();
                        goto default;
                    default: break;


                } }
            return case1+case2+case3+case4+case5;
        }// cryptage DONE

        public String cryptbulletin()
        {
            int x = nbr_bulletin.SelectedIndex;

            String case1 = "";
            if (nbr_bulletin.SelectedIndex> 0)
            {
                switch (x)
                {
                    case 5://healthbox5.text // envoie vers le BD
                           // case5 = healthpro5.SelectedIndex.ToString()+"5";
                        case1 += prix5.Text.ToString() +Cb5.SelectedIndex.ToString()+",";
                        goto case 4;
                    case 4://healthbox5.text // envoie vers le BD
                        case1 += prix4.Text.ToString() + Cb4.SelectedIndex.ToString()+ ",";
                        goto case 3;
                    case 3://healthbox5.text // envoie vers le BD
                        case1 += prix3.Text.ToString() + Cb3.SelectedIndex.ToString()+ ",";
                        goto case 2;
                    case 2://healthbox5.text // envoie vers le BD
                        case1 += prix2.Text.ToString() + Cb2.SelectedIndex.ToString()+ ",";
                        goto case 1;
                    case 1://healthbox5.text // envoie vers le BD
                        case1 += prix1.Text.ToString() + Cb1.SelectedIndex.ToString();
                        goto default;
                    default: break;


                }
            }
            return case1+nbr_bulletin.SelectedIndex.ToString();
        } // encore


        
        private void metroComboBox5_TabIndexChanged(object sender, EventArgs e)
        {
            metroLabel14.Visible = false;
            metroLabel19.Visible = false;
            prix1.Visible = false;
            Cb1.Visible = false;
            bulletin1.Visible= false;

            metroLabel14.Visible = false;
            metroLabel19.Visible = false;
            prix1.Visible = false;
            Cb1.Visible = false;
            bulletin1.Visible = false;

            metroLabel15.Visible = false;
            metroLabel20.Visible = false;
            prix2.Visible = false;
            Cb2.Visible = false;
            bulletin2.Visible = false;

            metroLabel16.Visible = false;
            metroLabel21.Visible = false;
            prix3.Visible = false;
            Cb3.Visible = false;
            bulletin3.Visible = false;

            metroLabel17.Visible = false;
            metroLabel22.Visible = false;
            prix4.Visible = false;
            Cb4.Visible = false;
            bulletin4.Visible = false;

            metroLabel18.Visible = false;
            metroLabel23.Visible = false;
            prix5.Visible = false;
            Cb5.Visible = false;
            bulletin5.Visible = false;

            switch(nbr_bulletin.SelectedIndex)
            {
                case 1:
                    metroLabel14.Visible = true;
                    metroLabel19.Visible = true;
                    prix1.Visible = true;
                    Cb1.Visible = true;
                    bulletin1.Visible = true;
                    break;
                case 2:
                    metroLabel14.Visible = true;
                    metroLabel19.Visible = true;
                    prix1.Visible = true;
                    Cb1.Visible = true;
                    bulletin1.Visible = true;
                    metroLabel15.Visible = true;
                    metroLabel20.Visible = true;
                    prix2.Visible = true;
                    Cb2.Visible = true;
                    bulletin2.Visible = true;
                    break;
                case 3:
                    metroLabel14.Visible = true;
                    metroLabel19.Visible = true;
                    prix1.Visible = true;
                    Cb1.Visible = true;
                    bulletin1.Visible = true;
                    metroLabel15.Visible = true;
                    metroLabel20.Visible = true;
                    prix2.Visible = true;
                    Cb2.Visible = true;
                    bulletin2.Visible = true;
                    metroLabel16.Visible = true;
                    metroLabel21.Visible = true;
                    prix3.Visible = true;
                    Cb3.Visible = true;
                    bulletin3.Visible = true;
                    break;
                case 4:
                    metroLabel14.Visible = true;
                    metroLabel19.Visible = true;
                    prix1.Visible = true;
                    Cb1.Visible = true;
                    bulletin1.Visible = true;
                    metroLabel15.Visible = true;
                    metroLabel20.Visible = true;
                    prix2.Visible = true;
                    Cb2.Visible = true;
                    bulletin2.Visible = true;
                    metroLabel16.Visible = true;
                    metroLabel21.Visible = true;
                    prix3.Visible = true;
                    Cb3.Visible = true;
                    bulletin3.Visible = true;
                    metroLabel17.Visible = true;
                    metroLabel22.Visible = true;
                    prix4.Visible = true;
                    Cb4.Visible = true;
                    bulletin4.Visible = true;
                    break;
                case 5:
                    metroLabel14.Visible = true;
                    metroLabel19.Visible = true;
                    prix1.Visible = true;
                    Cb1.Visible = true;
                    bulletin1.Visible = true;
                    metroLabel15.Visible = true;
                    metroLabel20.Visible = true;
                    prix2.Visible = true;
                    Cb2.Visible = true;
                    bulletin2.Visible = true;
                    metroLabel16.Visible = true;
                    metroLabel21.Visible = true;
                    prix3.Visible = true;
                    Cb3.Visible = true;
                    bulletin3.Visible = true;
                    metroLabel17.Visible = true;
                    metroLabel22.Visible = true;
                    prix4.Visible = true;
                    Cb4.Visible = true;
                    bulletin4.Visible = true;
                    metroLabel18.Visible = true;
                    metroLabel23.Visible = true;
                    prix5.Visible = true;
                    Cb5.Visible = true;
                    bulletin5.Visible = true;
                    break;








            }
                
            /*  metroLabel14.Visible = true;
                metroLabel19.Visible = true;
                Prix1.Visible = true;
                Cb1.Visible = true;
                Bulletin1.Visible = true;*/
            
        }

    

        

           
        private void Nbr_Maladie_SelectedIndexChanged(object sender, EventArgs e)
        {
            metroLabel34.Visible = false;
            healthbox1.Visible = false;
            metroLabel29.Visible = false;
            healthcombo1.Visible = false;
            healthpro1.Visible = false;


            metroLabel33.Visible = false;
            healthbox2.Visible = false;
            metroLabel28.Visible = false;
            healthpro2.Visible = false;
            healthcombo2.Visible = false;


            metroLabel32.Visible = false;
            healthbox3.Visible = false;
            metroLabel27.Visible = false;
            healthpro3.Visible = false;
            healthcombo3.Visible = false;

            metroLabel31.Visible = false;
            healthbox4.Visible = false;
            metroLabel26.Visible = false;
            healthcombo4.Visible = false;
            healthpro4.Visible = false;

            metroLabel30.Visible = false;
            healthbox5.Visible = false;
            metroLabel25.Visible = false;
            healthcombo5.Visible = false;
            healthpro5.Visible = false;


            switch (Nbr_Maladie.SelectedIndex)
            { case 1:metroLabel34.Visible = true;
                    healthbox1.Visible = true;
                    metroLabel29.Visible = true;
                    healthcombo1.Visible = true;
                    healthpro1.Visible = true;
                    break;
                case 2:
                    metroLabel34.Visible = true;
                    healthbox1.Visible = true;
                    metroLabel29.Visible = true;
                    healthcombo1.Visible = true;
                    healthpro1.Visible = true;
                    metroLabel33.Visible =true;
                    healthbox2.Visible = true;
                    metroLabel28.Visible = true;
                    healthcombo2.Visible = true;
                    healthpro2.Visible = true;
                    break;
                case 3:
                    metroLabel34.Visible = true;
                    healthbox1.Visible = true;
                    metroLabel29.Visible = true;
                    healthcombo1.Visible = true;
                    healthpro1.Visible = true;
                    metroLabel33.Visible = true;
                    healthbox2.Visible = true;
                    metroLabel28.Visible = true;
                    healthcombo2.Visible = true;
                    healthpro2.Visible = true;
                    metroLabel32.Visible = true;
                    healthbox3.Visible = true;
                    metroLabel27.Visible =true;
                    healthpro3.Visible = true;
                    healthcombo3.Visible = true;

                    break;
                case 4:
                    metroLabel34.Visible = true;
                    healthbox1.Visible = true;
                    metroLabel29.Visible = true;
                    healthcombo1.Visible = true;
                    healthpro1.Visible = true;
                    metroLabel33.Visible = true;
                    healthbox2.Visible = true;
                    metroLabel28.Visible = true;
                    healthpro2.Visible = true;
                    healthcombo2.Visible = true;
                    metroLabel32.Visible = true;
                    healthbox3.Visible = true;
                    metroLabel27.Visible = true;
                    healthcombo3.Visible = true;
                    healthpro3.Visible = true;
                    metroLabel31.Visible = true;
                    healthbox4.Visible = true;
                    metroLabel26.Visible = true;
                    healthcombo4.Visible = true;
                    healthpro4.Visible = true;
                    break;
                case 5:
                    metroLabel34.Visible = true;
                    healthbox1.Visible = true;
                    metroLabel29.Visible = true;
                    healthcombo1.Visible = true;
                    healthpro1.Visible = true;
                    metroLabel33.Visible = true;
                    healthbox2.Visible = true;
                    metroLabel28.Visible = true;
                    healthpro2.Visible = true;
                    healthcombo2.Visible = true;
                    metroLabel32.Visible = true;
                    healthbox3.Visible = true;
                    metroLabel27.Visible = true;
                    healthpro3.Visible = true;
                    healthcombo3.Visible = true;
                    metroLabel31.Visible = true;
                    healthbox4.Visible = true;
                    metroLabel26.Visible = true;
                    healthcombo4.Visible = true;
                    healthpro4.Visible = true;
                    metroLabel30.Visible = true;
                    healthbox5.Visible = true;
                    metroLabel25.Visible = true;
                    healthcombo5.Visible = true;
                    healthpro5.Visible = true;
                    break;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
           label2.Text= crypthealth();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            label4.Text=cryptbulletin();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = crypttime();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            metroLabel5.Text = cryptengagement();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            label1.Text = crypttransport();
        }
    }
}
