using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projet_v1
{
    public partial class Information : MetroFramework.Forms.MetroForm
    {
        public SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-UHKDEM5\SQLEXPRESS;Integrated Security=SSPI;Initial Catalog=projet");
        public static String myuser = Form1.myuser;
        public Information()
        {
            InitializeComponent();
            
             SqlCommand cmd1 = new SqlCommand("select email from client where codec='" + myuser + "';", con);
            con.Open();
             SqlDataReader rd = cmd1.ExecuteReader();
            while (rd.Read())
            {
                metroLabel6.Text = rd.GetString(0);
            }
            con.Close();
        }

        
        public Boolean verifydocuments = false;


        public void cryptengagement()
        {
            int x = metroComboBox13.SelectedIndex ;
            con.Open();
            SqlCommand cmd = new SqlCommand("select  codec from engagement where codec='" + myuser + "';", con);
            SqlDataReader rd = cmd.ExecuteReader();
            if (!rd.HasRows)
            {
                SqlCommand cmd6 = new SqlCommand("insert into engagement (codec,number) values ('" + myuser + "','" + metroComboBox13.SelectedText + "');", con);
                rd.Close();
                cmd6.ExecuteNonQuery();
            }
            rd.Close();
            dateengagement1.Value.ToString();
            dateengagement1.Value.ToString();
            if (x > 0)
            {
                switch (x)
                {
                    case 5:
                      
                        SqlCommand cmd5 = new SqlCommand("update engagement set descriptionengagement5='" + metroTextBox5.Text + "',time5='" + dateengagement5.Value.ToString() + "'where codec='" + myuser + "';", con);
                        cmd5.ExecuteNonQuery();
                        goto case 4;
                    case 4:
                        SqlCommand cmd4 = new SqlCommand("update engagement set descriptionengagement4='" + metroTextBox4.Text + "',time4='" + dateengagement4.Value.ToString() + "'where codec='" + myuser + "';", con);
                        cmd4.ExecuteNonQuery();
                        goto case 3;
                    case 3:
                        SqlCommand cmd3 = new SqlCommand("update engagement set descriptionengagement3='" + metroTextBox3.Text + "',time3='" + dateengagement3.Value.ToString() + "'where codec='" + myuser + "';", con);
                        cmd3.ExecuteNonQuery();
                        goto case 2;
                    case 2:
                        SqlCommand cmd2 = new SqlCommand("update engagement set descriptionengagement2='" + metroTextBox2.Text + "',time2='" + dateengagement2.Value.ToString() + "'where codec='" + myuser + "';", con);
                        cmd2.ExecuteNonQuery();
                        goto case 1;
                    case 1:
                        SqlCommand cmd1 = new SqlCommand("update engagement set descriptionengagement1='" + metroTextBox1.Text + "',time1='" + dateengagement1.Value.ToString() + "'where codec='" + myuser + "';", con);
                        cmd1.ExecuteNonQuery();
                        goto default;
                    default: break;
                }
                con.Close();
            }
            con.Close();
        } // Done
        public Boolean checkcryptengagement()
        {
            return true;
        }
        public String crypttransport()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("select codec from transport where codec='" + myuser + "';", con);
            SqlDataReader rd = cmd.ExecuteReader();
            if (!rd.HasRows)
            {
                SqlCommand cmd6 = new SqlCommand("insert into transport (codec,codetransport) values ('" + myuser + "','" + '0' + "');", con);
                rd.Close();
                cmd6.ExecuteNonQuery();
            }
            rd.Close();
            String trans = "";
            if (metroRadioButton5.Checked)
            { trans = "PT"+metroComboBox3.SelectedIndex.ToString(); }
            else if (metroRadioButton6.Checked)
            { trans = "TT"+metroComboBox3.SelectedIndex.ToString(); }
            SqlCommand cmd0 = new SqlCommand("update transport set codetransport='" +trans + "'where codec='" + myuser + "';", con);
            cmd0.ExecuteNonQuery();


            con.Close();
            return trans;
        }  // DONE
        public Boolean checkcrypttransport()
        {
            return true;
        }
        public String crypttime()
        {
            String job = "";

            if (metroRadioButton1.Checked)
                job = metroRadioButton1.Text;
            else if (metroRadioButton2.Checked)
                job = metroRadioButton2.Text;
            else if (metroRadioButton3.Checked)
                job = metroRadioButton3.Text;
            else if (metroRadioButton4.Checked)
                job = metroRadioButton4.Text;

           
            con.Open();
            SqlCommand cmd = new SqlCommand("select codec from travaille where codec='" + myuser + "';", con);
            SqlDataReader rd = cmd.ExecuteReader();
            if (!rd.HasRows)
            {
                SqlCommand cmd6 = new SqlCommand("insert into travaille (codec,typetravaille) values ('" + myuser + "','"+job+"');", con);
                rd.Close();
                cmd6.ExecuteNonQuery();
            }
            rd.Close();
            String dat = "";
            if (monday.Checked)
            {
                dat = dateTimePicker2.Text.ToString().Substring(0, 2) + dateTimePicker2.Text.ToString().Substring(3, 2) + dateTimePicker3.Text.ToString().Substring(0, 2) + dateTimePicker3.Text.ToString().Substring(3, 2);
                SqlCommand cmd1 = new SqlCommand("update travaille set monday='" +dat+"'where codec='" + myuser + "';", con);
                cmd1.ExecuteNonQuery();
            }
            if (tuesday.Checked)
            {
                dat = dateTimePicker5.Text.ToString().Substring(0, 2) + dateTimePicker5.Text.ToString().Substring(3, 2) + dateTimePicker4.Text.ToString().Substring(0, 2) + dateTimePicker4.Text.ToString().Substring(3, 2);
                SqlCommand cmd2 = new SqlCommand("update travaille set tuesday='" + dat + "'where codec='" + myuser + "';", con);
                cmd2.ExecuteNonQuery();
            }
            if (wednesday.Checked)
            {
                dat = dateTimePicker7.Text.ToString().Substring(0, 2) + dateTimePicker7.Text.ToString().Substring(3, 2) + dateTimePicker6.Text.ToString().Substring(0, 2) + dateTimePicker6.Text.ToString().Substring(3, 2);
                SqlCommand cmd3 = new SqlCommand("update travaille set wednesday='" + dat + "'where codec='" + myuser + "';", con);
                cmd3.ExecuteNonQuery();
            }
            if (thursday.Checked)
            {
                dat = dateTimePicker9.Text.ToString().Substring(0, 2) + dateTimePicker9.Text.ToString().Substring(3, 2) + dateTimePicker8.Text.ToString().Substring(0, 2) + dateTimePicker8.Text.ToString().Substring(3, 2);
                SqlCommand cmd4 = new SqlCommand("update travaille set thirsday='" + dat + "'where codec='" + myuser + "';", con);
                cmd4.ExecuteNonQuery();
            }
            if (friday.Checked)
            {
                dat =  dateTimePicker11.Text.ToString().Substring(0, 2) + dateTimePicker11.Text.ToString().Substring(3, 2) + dateTimePicker10.Text.ToString().Substring(0, 2) + dateTimePicker10.Text.ToString().Substring(3, 2);
                SqlCommand cmd5 = new SqlCommand("update travaille set friday='" + dat + "'where codec='" + myuser + "';", con);
                cmd5.ExecuteNonQuery();
            }
            if (saturday.Checked)
            {
                dat =  dateTimePicker13.Text.ToString().Substring(0, 2) + dateTimePicker13.Text.ToString().Substring(3, 2) + dateTimePicker12.Text.ToString().Substring(0, 2) + dateTimePicker12.Text.ToString().Substring(3, 2);
                SqlCommand cmd6 = new SqlCommand("update travaille set saturday='" + dat + "'where codec='" + myuser + "';", con);
                cmd6.ExecuteNonQuery();
            }
            if (sunday.Checked)
            {
                dat =  dateTimePicker15.Text.ToString().Substring(0, 2) + dateTimePicker15.Text.ToString().Substring(3, 2) + dateTimePicker14.Text.ToString().Substring(0, 2) + dateTimePicker14.Text.ToString().Substring(3, 2);
                SqlCommand cmd7 = new SqlCommand("update travaille set sunday='" + dat + "'where codec='" + myuser + "';", con);
                cmd7.ExecuteNonQuery();
            }
            con.Close();
            return dat;
        }     // DONE
        public Boolean checkcrypttime()
        { return true; }
        public int checkingcurrentselection(ComboBox c)
        {
            int i=0;
            switch (c.SelectedIndex)
            {
                case 0: i = 1;break;
                case 1: i = 7; break;
                case 2: i = 14; break;
                case 3: i = 30; break;
                case 4: i = 120; break;
                case 5: i = 180; break;
                case 6: i = 365; break;

            }

            return i;
        }
        public String crypthealth()
        { int x = Nbr_Maladie.SelectedIndex;
            con.Open();
            String case1="", case2="", case3="", case4="", case5 ="";
            SqlCommand cmd = new SqlCommand("select codec from health where codec='"+myuser+"';", con);
            SqlDataReader rd = cmd.ExecuteReader();
            if (!rd.HasRows)
            {
                SqlCommand cmd6 = new SqlCommand("insert into health (codec,codehealth,number) values ('" + myuser + "','" + '0' + "','" + '0' + "');", con);
                rd.Close();
                cmd6.ExecuteNonQuery();
            }
                rd.Close();
                if (Nbr_Maladie.SelectedIndex > 0)
                {
                    switch (x)
                    {
                        case 5://healthbox5.text // envoie vers le BD
                               // case5 = healthpro5.SelectedIndex.ToString()+"5";
                            case5 = healthpro5.SelectedIndex.ToString() + healthcombo5.SelectedIndex.ToString();
                            label3.Text = lasttohappen5.Value.ToString();
                            SqlCommand cmd5 = new SqlCommand("update health set descriptionmaladie5='" + healthbox5.Text + "',lastdate5='" + lasttohappen5.Value.ToString() + "'where codec='" + myuser + "';", con);
                            cmd5.ExecuteNonQuery();
                                 SqlCommand cmd10 = new SqlCommand("update health set newdate5='" + lasttohappen5.Value.AddDays(checkingcurrentselection(healthcombo5)).ToString() + "',crypt5='"+checkingcurrentselection(healthcombo5).ToString()+"'where codec='" + myuser + "';", con);
                                 cmd10.ExecuteNonQuery();

                        goto case 4;
                        case 4://healthbox5.text // envoie vers le BD
                            case4 = healthpro4.SelectedIndex.ToString() + healthcombo4.SelectedIndex.ToString();
                        SqlCommand cmd4 = new SqlCommand("update health set descriptionmaladie4='" + healthbox4.Text + "',lastdate4='" + lasttohappen4.Value.ToString() + "'where codec='" + myuser + "';", con);
                        cmd4.ExecuteNonQuery();
                        SqlCommand cmd11 = new SqlCommand("update health set newdate4='" + lasttohappen4.Value.AddDays(checkingcurrentselection(healthcombo4)).ToString() + "',crypt4='" + checkingcurrentselection(healthcombo4).ToString() +"' where codec='" + myuser + "';", con);
                        cmd11.ExecuteNonQuery();
                        goto case 3;
                        case 3://healthbox5.text // envoie vers le BD
                            case3 = healthpro3.SelectedIndex.ToString() + healthcombo3.SelectedIndex.ToString();
                        SqlCommand cmd3 = new SqlCommand("update health set descriptionmaladie3='" + healthbox3.Text + "',lastdate3='" + lasttohappen3.Value.ToString() + "',crypt3='" + checkingcurrentselection(healthcombo3).ToString() + "'where codec='" + myuser + "';", con);
                        cmd3.ExecuteNonQuery();
                        SqlCommand cmd12 = new SqlCommand("update health set newdate3='" + lasttohappen3.Value.AddDays(checkingcurrentselection(healthcombo3)).ToString() + "'where codec='" + myuser + "';", con);
                        cmd12.ExecuteNonQuery();
                        goto case 2;
                        case 2://healthbox5.text // envoie vers le BD
                            case2 = healthpro2.SelectedIndex.ToString() + healthcombo2.SelectedIndex.ToString();
                        SqlCommand cmd2 = new SqlCommand("update health set descriptionmaladie2='" + healthbox2.Text + "',lastdate2='" + lasttohappen2.Value.ToString() + "',crypt2='" + checkingcurrentselection(healthcombo2).ToString() + "'where codec='" + myuser + "';", con);
                        cmd2.ExecuteNonQuery();
                        SqlCommand cmd13 = new SqlCommand("update health set newdate2='" + lasttohappen2.Value.AddDays(checkingcurrentselection(healthcombo2)).ToString() + "'where codec='" + myuser + "';", con);
                        cmd13.ExecuteNonQuery();
                        goto case 1;
                        case 1://healthbox5.text // envoie vers le BD
                            case1 = healthpro1.SelectedIndex.ToString() + healthcombo1.SelectedIndex.ToString();
                        SqlCommand cmd1 = new SqlCommand("update health set descriptionmaladie1='" + healthbox1.Text + "',lastdate1='" + lasttohappen1.Value.ToString() + "'where codec='" + myuser + "';", con);
                        cmd1.ExecuteNonQuery();
                        SqlCommand cmd14 = new SqlCommand("update health set newdate1='" + lasttohappen1.Value.AddDays(checkingcurrentselection(healthcombo1)).ToString() + "',crypt1='" + checkingcurrentselection(healthcombo1).ToString() + "'where codec='" + myuser + "';", con);
                        cmd14.ExecuteNonQuery();
                        goto default;
                        default:
                        SqlCommand cmd0 = new SqlCommand("update health set number='"+ Nbr_Maladie.SelectedIndex.ToString()+  "';", con);
                        cmd0.ExecuteNonQuery();

                        break;


                    }
                
            }
            rd.Close();
            con.Close();
            return case1+case2+case3+case4+case5;
        }// cryptage DONE done
        public Boolean checkcrypthealth()
        {
            Boolean check = false;
            SqlCommand cmd = new SqlCommand("select number,codehealth from health where codec='" + myuser + "';", con);
            SqlDataReader rd = cmd.ExecuteReader();
            while (rd.Read())
            {  switch (rd.GetString(0))
                {
                    case "5":    if (rd.GetString(1).Length == 10)
                            check = true;  ; break;
                    case "4":
                        if (rd.GetString(1).Length == 8)
                            check = true; ; break;
                    case "3":
                        if (rd.GetString(1).Length == 6)
                            check = true; ; break;
                    case "2":
                        if (rd.GetString(1).Length == 4)
                            check = true; ; break;
                    case "1":
                        if (rd.GetString(1).Length == 2)
                            check = true; ; break;
                    case "0":
                        if (rd.GetString(1) == "0")
                            check = true; ; break;
                }
            }

            return true;
        }
         public String cryptbulletin()
        {
            int x = nbr_bulletin.SelectedIndex;
            con.Open();
            String case1 = "", case2 = "", case3 = "", case4 = "", case5 = "";
            SqlCommand cmd = new SqlCommand("select codec from bulletin where codec='" + myuser + "';", con);
            SqlDataReader rd = cmd.ExecuteReader();
            if (!rd.HasRows)
            {
                SqlCommand cmd6 = new SqlCommand("insert into bulletin (codec,number) values ('" + myuser + "','" +x.ToString()+"');", con);
                rd.Close();
                cmd6.ExecuteNonQuery();
            }
            rd.Close();

            if (nbr_bulletin.SelectedIndex> 0)
            {
                switch (x)
                {
                    case 5:
                        SqlCommand cmd5 = new SqlCommand("update bulletin set descpriotionbulletin5='" + bulletin5.Text + "',prix5='" +prix5.Text + "',bulletinlastdate5='"+lastknow5.Value.ToString()+ "',bulletinnewdate5='" + lastknow5.Value.AddDays(checkingcurrentselection(Cb5)).ToString()+"',crypt5='"+checkingcurrentselection(Cb5).ToString()+"'where codec='" + myuser + "';", con);
                        cmd5.ExecuteNonQuery();
                        goto case 4;
                    case 4:
                        SqlCommand cmd4 = new SqlCommand("update bulletin set descpriotionbulletin4='" + bulletin4.Text + "',prix4='" + prix4.Text + "',bulletinlastdate4='" + lastknow4.Value.ToString() + "',bulletinnewdate4='" + lastknow4.Value.AddDays(checkingcurrentselection(Cb4)).ToString() + "',crypt4='"+checkingcurrentselection(Cb4).ToString()+"'where codec='" + myuser + "';", con);
                        cmd4.ExecuteNonQuery();
                        goto case 3;
                    case 3:
                        SqlCommand cmd3 = new SqlCommand("update bulletin set descpriotionbulletin3='" + bulletin3.Text + "',prix3='" + prix3.Text + "',bulletinlastdate3='" + lastknow3.Value.ToString() + "',bulletinnewdate3='" + lastknow3.Value.AddDays(checkingcurrentselection(Cb3)).ToString() + "',crypt3='" + checkingcurrentselection(Cb3).ToString() + "'where codec='" + myuser + "';", con);
                        cmd3.ExecuteNonQuery();
                        goto case 2;
                    case 2:
                        SqlCommand cmd2 = new SqlCommand("update bulletin set descpriotionbulletin2='" + bulletin2.Text + "',prix2='" + prix2.Text + "',bulletinlastdate2='" + lastknow2.Value.ToString() + "',bulletinnewdate2='" + lastknow2.Value.AddDays(checkingcurrentselection(Cb2)).ToString() + "',crypt2='" + checkingcurrentselection(Cb2).ToString() + "'where codec='" + myuser + "';", con);
                        cmd2.ExecuteNonQuery();
                        goto case 1;
                    case 1:
                        SqlCommand cmd1 = new SqlCommand("update bulletin set descpriotionbulletin1='" + bulletin1.Text + "',prix1='" + prix1.Text + "',bulletinlastdate1='" + lastknow1.Value.ToString() + "',bulletinnewdate1='" + lastknow1.Value.AddDays(checkingcurrentselection(Cb1)).ToString() + "',crypt1='" + checkingcurrentselection(Cb1).ToString() + "'where codec='" + myuser + "';", con);
                        cmd1.ExecuteNonQuery();
                        goto default;
                    default: break;


                }
                rd.Close();
               
            }
            rd.Close();
            con.Close();
            return case1+nbr_bulletin.SelectedIndex.ToString();
        } // Done
        public Boolean checkcryptbulletin()
        {
            return true;
        }
        public void cryptpersonelle()
        {
            var T = "";
            if ( metroRadioButton7.Checked)
            {
                T = metroRadioButton7.Text;
            }
            if (metroRadioButton8.Checked)
            {
                T = metroRadioButton8.Text;
            }
            con.Open();
            SqlCommand cmd5 = new SqlCommand("update client set nom='" + nom.Text + "',prenom='" + prenom.Text + "',adress='" + address.Text + "',naissance='" + dateTimePicker1.Value.ToString() + "',genre='" +T  + "'where codec='" + myuser + "';", con);
            cmd5.ExecuteNonQuery();
            con.Close();
        }
        


        
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
           //label2.Text=crypthealth();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DateTime D = DateTime.Now;
            label4.Text =D.Month.ToString();
            //  label4.Text=cryptbulletin();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = crypttime();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            cryptengagement();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            label1.Text = crypttransport();
        }

        private void metroTile1_Click(object sender, EventArgs e)
        {
            String variab = "";
            cryptpersonelle();
            variab = cryptbulletin();
            variab = crypthealth();
            cryptengagement();
            variab = crypttransport();
            variab = crypttime();

            MessageBox.Show("Registrerd with success");




        }

        private void button6_Click(object sender, EventArgs e)
        {
            cryptpersonelle();
        }

        private void metroLabel35_Click(object sender, EventArgs e)
        {

        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
           
                Hide();
                using (Form f = new Metro())
                    f.ShowDialog();
                Show();

            
        }
    }
}
