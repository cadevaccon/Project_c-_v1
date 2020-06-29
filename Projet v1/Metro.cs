using MetroFramework.Controls;
using System;
using System.Collections;
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
    public partial class Metro : MetroFramework.Forms.MetroForm
    {
        public SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-UHKDEM5\SQLEXPRESS;Integrated Security=SSPI;Initial Catalog=projet");
        public static String myuser = Form1.myuser;
        class listevent
        {
            public List<Event> listeevents { get; set; } = new List<Event>();
            public bool Add(Event ad)
            {
                if (listeevents.Contains(ad))
                { return false; }
                listeevents.Add(ad);
                return true;
            }
        }
        listevent LSTevent = new listevent();
        public Metro()
        {
            InitializeComponent();
            decryptbulletin();
            decrypthealth1();
            decryptjob();
            foreach (Event ev in LSTevent.listeevents)
            {
                eventholder(ev);
            }
            metroLabel1.Text += Environment.NewLine + figuretheday();
        }
        public String figuretheday()
        {
            DateTime D = DateTime.Now;
            var codejour = new List<String> { "sunday", "monday", "tuesday", "wednesday", "thirsday", "friday", "saturday" };
            var codemois = new List<int> { 0, 3, 3, 6, 1, 4, 6, 2, 5, 2, 3, 5 };
            var codeanne = int.Parse(D.Year.ToString()) - 2000;
            var x = 0;
            
            var code = 0;
            if (codeanne % 4 == 0)
                x = -1;

            code = D.Day + codemois[D.Month - 1] + codeanne + codeanne / 4 + 6;
           
            code = code % 7;

            return codejour[code];



        }

        public Event decrypttimeStart(String code, String code2)
        {
            Event tt = new Event();

            int L;
            String substring = "";
            L = int.Parse(code.Substring(0, 2));
            int L2 = int.Parse(code.Substring(2, 2));
            L = L * 60;
            L = L2 + L;
            switch (code2.Substring(2, 1))
            {
                case "0": L = L - 10; break;
                case "1": L = L - 20; break;
                case "2": L = L - 40; break;
                case "3": L = L - 60; break;
                case "4": L = L - 90; break;


            }
            L2 = L % 60;
            L = L / 60;
            if (L2 < 30)

                substring = L.ToString() + "00";
            else
                substring = L.ToString() + "30";
            tt.time = int.Parse(substring);
            tt.context = "Travel to work";

            return tt;

        } // done
        public Event decrypttimeEnd(String code, String code2)
        {
            Event tt = new Event();
            int i = 0;
            int L;
            String substring = "";
            L = int.Parse(code.Substring(4, 2));
            int L2 = int.Parse(code.Substring(6, 2));
            L = L * 60;
            L = L2 + L;
            switch (code2.Substring(2, 1))
            {
                case "0": L = L + 10; break;
                case "1": L = L + 20; break;
                case "2": L = L + 40; break;
                case "3": L = L + 60; break;
                case "4": L = L + 90; break;


            }
            L2 = L % 60;
            L = L / 60;
            if (L2 < 30)

                substring = L.ToString() + "00";
            else
                substring = L.ToString() + "30";
            tt.time = int.Parse(substring);
            tt.context = "Reach home";

            return tt;
        } // done
        public Event startjob(String code)
        {
            Event tt = new Event();
            int i = 0;
            int L;
            String substring = "";
            L = int.Parse(code.Substring(2, 2));
            if (L < 30)

                substring = code.Substring(0, 2) + "00";
            else
                substring = code.Substring(0, 2) + "30";
            tt.time = int.Parse(substring);
            tt.context = "Start Job";

            return tt;
        } // done
        public Event Endjob(String code)
        {
            Event tt = new Event();
            int i = 0;
            int L;
            String substring = "";
            L = int.Parse(code.Substring(6, 2));
            if (L < 30)

                substring = code.Substring(4, 2) + "00";
            else
                substring = code.Substring(4, 2) + "30";
            tt.time = int.Parse(substring);
            tt.context = "End Job";

            return tt;
        }  // done

        public void decryptjob()
        {
           String dayoftheweek = figuretheday();
            con.Open();
            SqlCommand cmd = new SqlCommand("select "+dayoftheweek+",codetransport from travaille,transport where travaille.codec='"+myuser+"'and transport.codec='"+myuser+"';", con);
            SqlDataReader rd = cmd.ExecuteReader();
            
            
            while (rd.Read())
            {
                try { eventholder(decrypttimeStart(rd.GetString(0), rd.GetString(1))); } catch {; }
              try {  eventholder(decrypttimeEnd(rd.GetString(0), rd.GetString(1))); } catch {; }
              try{  eventholder(startjob(rd.GetString(0))); } catch {; }
           try{     eventholder(Endjob(rd.GetString(0))); } catch {; }
            } 

            rd.Close();
            con.Close();


        } // done

        public String decrypthealth(String code)
        {

            int i = 0;
            String substring = "";
            String substring2 = "";
            while (i < code.Length)
            {
                switch (code.Substring(i, 1))
                {
                    case "0":
                        switch (code.Substring(i + 1, 1))  //normal
                        {
                            case "0": substring2 = "1"; goto default; // par jour
                            case "1": substring2 = "7"; goto default; // par semaine
                            case "2": substring2 = "14"; goto default; // chaque 2 semaine
                            case "3": substring2 = "30"; goto default; // par mois
                            case "4": substring2 = "120"; goto default; // chaque trimestre
                            case "5": substring2 = "180"; goto default; // chaque semestre 
                            case "6": substring2 = "365"; goto default; // chaque année
                            default:
                                substring = substring + " Normal " + substring2; ;
                                i += 2; break;
                        }
                        break;

                    case "1":
                        switch (code.Substring(i + 1, 1))  //habituelle
                        {
                            case "0": substring2 = "1"; goto default; // par jour
                            case "1": substring2 = "7"; goto default; // par semaine
                            case "2": substring2 = "14"; goto default; // chaque 2 semaine
                            case "3": substring2 = "30"; goto default; // par mois
                            case "4": substring2 = "120"; goto default; // chaque trimestre
                            case "5": substring2 = "180"; goto default; // chaque semestre 
                            case "6": substring2 = "365"; goto default; // chaque année
                            default:
                                substring = substring + " Habituelle " + substring2; ;
                                i += 2; break;
                        }
                        break; // habituelle
                    case "2":
                        switch (code.Substring(i + 1, 1))  //inhabutuelle
                        {
                            case "0": substring2 = "1"; goto default; // par jour
                            case "1": substring2 = "7"; goto default; // par semaine
                            case "2": substring2 = "14"; goto default; // chaque 2 semaine
                            case "3": substring2 = "30"; goto default; // par mois
                            case "4": substring2 = "120"; goto default; // chaque trimestre
                            case "5": substring2 = "180"; goto default; // chaque semestre 
                            case "6": substring2 = "365"; goto default; // chaque année
                            default:
                                substring = substring + " Unhabituelle " + substring2; ;
                                i += 2; break;
                        }
                        break; // inhabituelle
                    case "3":
                        switch (code.Substring(i + 1, 1))  //Urgent
                        {
                            case "0": substring2 = "1"; goto default; // par jour
                            case "1": substring2 = "7"; goto default; // par semaine
                            case "2": substring2 = "14"; goto default; // chaque 2 semaine
                            case "3": substring2 = "30"; goto default; // par mois
                            case "4": substring2 = "120"; goto default; // chaque trimestre
                            case "5": substring2 = "180"; goto default; // chaque semestre 
                            case "6": substring2 = "365"; goto default; // chaque année
                            default:
                                substring = substring + " Urgent " + substring2; ;
                                i += 2; break;
                        }
                        break;   //urgent


                }
            }
            return substring;
        }    /// too dumb as no time to acutlly finish the urgency of the desease
        public void decrypthealth1()
        {

            con.Open();
            SqlCommand cmd = new SqlCommand("select * from health where codec='" + myuser + "';", con);
            SqlDataReader rd = cmd.ExecuteReader();
            DateTime ll;
            DateTime D = DateTime.Now;
            while (rd.Read())
            {
                try
                {
                    Event even = new Event();
                    ll = Convert.ToDateTime(rd.GetString(13));
                    if (D.Date == ll.Date)
                    {
                        SqlCommand cmd14 = new SqlCommand("update health set newdate1='" + ll.AddDays(int.Parse(rd.GetString(19))).ToString() + "'where codec='" + myuser+ "';", con);
                        cmd14.ExecuteNonQuery();
                        even.context = rd.GetString(3);
                        even.time = 800;
                        LSTevent.Add(even);
                    }
                }
                catch {; }
                try
                {
                    Event even = new Event();
                    ll = Convert.ToDateTime(rd.GetString(14));
                    if (D.Date == ll.Date)
                    {
                        SqlCommand cmd14 = new SqlCommand("update health set newdate1='" + ll.AddDays(int.Parse(rd.GetString(20))).ToString() + "'where codec='" + myuser + "';", con);
                        cmd14.ExecuteNonQuery();
                        even.context = rd.GetString(5);
                        even.time = 800;
                        LSTevent.Add(even);
                    }
                }
                catch {; }
                try
                {
                    Event even = new Event();
                    ll = Convert.ToDateTime(rd.GetString(15));
                    if (D.Date == ll.Date)
                    {
                        SqlCommand cmd14 = new SqlCommand("update health set newdate1='" + ll.AddDays(int.Parse(rd.GetString(21))).ToString() + "'where codec='" + myuser + "';", con);
                        cmd14.ExecuteNonQuery();
                        even.context = rd.GetString(7);
                        even.time = 800;
                        LSTevent.Add(even);
                    }
                }
                catch {; }
                try
                {
                    Event even = new Event();
                    ll = Convert.ToDateTime(rd.GetString(16));
                    if (D.Date == ll.Date)
                    {
                        SqlCommand cmd14 = new SqlCommand("update health set newdate1='" + ll.AddDays(int.Parse(rd.GetString(22))).ToString() + "'where codec='" + myuser + "';", con);
                        cmd14.ExecuteNonQuery();
                        even.context = rd.GetString(9);
                        even.time = 800;
                        LSTevent.Add(even);
                    }
                }
                catch {; }
                try
                {
                    Event even = new Event();
                    ll = Convert.ToDateTime(rd.GetString(17));
                    if (D.Date == ll.Date)
                    {
                        SqlCommand cmd14 = new SqlCommand("update health set newdate1='" + ll.AddDays(int.Parse(rd.GetString(23))).ToString() + "'where codec='" + myuser + "';", con);
                        cmd14.ExecuteNonQuery();
                        even.context = rd.GetString(11);
                        even.time = 800;
                        LSTevent.Add(even);
                    }
                }
                catch {; }
            }
            rd.Close();
            con.Close();




        } // done
        public void decryptbulletin()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from bulletin where codec='" + myuser + "';", con);
            SqlDataReader rd = cmd.ExecuteReader();
            DateTime ll;
            DateTime D = DateTime.Now;
            while (rd.Read())
            {
                try
                {
                    Event even = new Event();
                    Event even2 = new Event();
                    ll = Convert.ToDateTime(rd.GetString(4)); // last date
                    if (D.Date == ll.Date)
                    {
                        SqlCommand cmd14 = new SqlCommand("update bulletin set bulletinnewdate1='" + ll.AddDays(int.Parse(rd.GetString(22))).ToString() + "'where codec='" + myuser + "';", con);
                        cmd14.ExecuteNonQuery();
                        even.context = rd.GetString(2);
                        even.time = 900;
                        LSTevent.Add(even);
                        even2.time = 900;
                        even2.context = rd.GetString(5);
                        LSTevent.Add(even2);
                    }
                }
                catch {; }
                try
                {
                    Event even = new Event();
                    Event even2 = new Event();
                    ll = Convert.ToDateTime(rd.GetString(8)); // last date
                    if (D.Date == ll.Date)
                    {
                        SqlCommand cmd14 = new SqlCommand("update bulletin set bulletinnewdate1='" + ll.AddDays(int.Parse(rd.GetString(23))).ToString() + "'where codec='" +myuser + "';", con);
                        cmd14.ExecuteNonQuery();
                        even.context = rd.GetString(6);
                        even.time = 900;
                        LSTevent.Add(even);
                        even2.time = 900;
                        even2.context = rd.GetString(9);
                        LSTevent.Add(even2);
                    }
                }
                catch {; }
                try
                {
                    Event even = new Event();
                    Event even2 = new Event();
                    ll = Convert.ToDateTime(rd.GetString(12)); // last date
                    if (D.Date == ll.Date)
                    {
                        SqlCommand cmd14 = new SqlCommand("update bulletin set bulletinnewdate1='" + ll.AddDays(int.Parse(rd.GetString(24))).ToString() + "'where codec='" + myuser + "';", con);
                        cmd14.ExecuteNonQuery();
                        even.context = rd.GetString(10);
                        even.time = 900;
                        LSTevent.Add(even);
                        even2.time = 900;
                        even2.context = rd.GetString(13);
                        LSTevent.Add(even2);
                    }
                }
                catch {; }
                try
                {
                    Event even = new Event();
                    Event even2 = new Event();
                    ll = Convert.ToDateTime(rd.GetString(16)); // last date
                    if (D.Date == ll.Date)
                    {
                        SqlCommand cmd14 = new SqlCommand("update bulletin set bulletinnewdate1='" + ll.AddDays(int.Parse(rd.GetString(25))).ToString() + "'where codec='" + myuser + "';", con);
                        cmd14.ExecuteNonQuery();
                        even.context = rd.GetString(14);
                        even.time = 900;
                        LSTevent.Add(even);
                        even2.time = 900;
                        even2.context = rd.GetString(17);
                        LSTevent.Add(even2);
                    }
                }
                catch {; }
                try
                {
                    Event even = new Event();
                    Event even2 = new Event();
                    ll = Convert.ToDateTime(rd.GetString(20)); // last date
                    if (D.Date == ll.Date)
                    {
                        SqlCommand cmd14 = new SqlCommand("update bulletin set bulletinnewdate1='" + ll.AddDays(int.Parse(rd.GetString(26))).ToString() + "'where codec='" + myuser + "';", con);
                        cmd14.ExecuteNonQuery();
                        even.context = rd.GetString(18);
                        even.time = 900;
                        LSTevent.Add(even);
                        even2.time = 900;
                        even2.context = rd.GetString(21);
                        LSTevent.Add(even2);
                    }
                }
                catch {; }




            }
            rd.Close();
            con.Close();
        } // Done
        public void eventholder(Event x)  // Done
        { 
          

                switch(x.time)
                {
                    case 400: tile400.Text += Environment.NewLine +x.context; break;
                    case 430: tile430.Text += Environment.NewLine + x.context; break;
                    case 500: tile500.Text += Environment.NewLine +x.context; break;
                    case 530: tile530.Text += Environment.NewLine + x.context; break;
                    case 600: tile600.Text += Environment.NewLine + x.context; break;
                    case 630: tile630.Text += Environment.NewLine + x.context; break;
                    case 700: tile700.Text += Environment.NewLine + x.context; break;
                    case 730: tile730.Text += Environment.NewLine + x.context; break;
                    case 800: tile800.Text += Environment.NewLine + x.context; break;
                    case 830: tile830.Text += Environment.NewLine + x.context; break;
                    case 900: tile900.Text += Environment.NewLine + x.context; break;
                    case 930:  break;    // Time stamp desent exist and way to late to add it
                    case 1000: tile1000.Text += Environment.NewLine + x.context; break;
                    case 1030: tile1030.Text += Environment.NewLine + x.context; break;
                    case 1100: tile1100.Text += Environment.NewLine + x.context; break;
                    case 1130: tile1130.Text += Environment.NewLine + x.context; break;
                    case 1200: tile1200.Text += Environment.NewLine + x.context; break;
                    case 1230: tile1230.Text += Environment.NewLine + x.context; break;
                    case 1300: tile1300.Text += Environment.NewLine + x.context; break;
                    case 1330: tile1330.Text += Environment.NewLine + x.context; break;
                    case 1400: tile1400.Text += Environment.NewLine + x.context; break;
                    case 1430: tile1430.Text += Environment.NewLine + x.context; break;
                    case 1500: tile1500.Text += Environment.NewLine + x.context; break;
                    case 1530: tile1530.Text += Environment.NewLine + x.context; break;
                    case 1600: tile1600.Text += Environment.NewLine + x.context; break;
                    case 1630: tile1630.Text += Environment.NewLine + x.context; break;
                    case 1700: tile1700.Text += Environment.NewLine + x.context; break;
                    case 1730: tile1730.Text += Environment.NewLine + x.context; break;
                    case 1800: tile1800.Text += Environment.NewLine + x.context; break;
                    case 1830: tile1830.Text += Environment.NewLine + x.context; break;
                    case 1900: tile1900.Text += Environment.NewLine + x.context; break;
                    case 1930: tile1930.Text += Environment.NewLine + x.context; break;
                    case 2000: tile2000.Text += Environment.NewLine + x.context; break;
                    case 2030: tile2030.Text += Environment.NewLine + x.context; break;
                    case 2100: tile2100.Text += Environment.NewLine + x.context; break;
                    case 2130: tile2130.Text += Environment.NewLine + x.context; break;
                    case 2200: tile2200.Text += Environment.NewLine + x.context; break;
                    case 2230: tile2230.Text += Environment.NewLine + x.context; break;
                    case 2300: tile2300.Text += Environment.NewLine + x.context; break;
                    case 2330: tile2330.Text += Environment.NewLine + x.context; break;
                    case 0000: tile0000.Text += Environment.NewLine + x.context; break;
                }
                  
              
            }
        public void decryptengagement()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from engagement where codec='" +myuser + "';", con);
            SqlDataReader rd = cmd.ExecuteReader();
            DateTime ll;
            DateTime D = DateTime.Now;
           

            while (rd.Read())
            {
                try
                {   Event even = new Event();
                    ll = Convert.ToDateTime(rd.GetString(3));
                    if (D.Date==ll.Date)
                    {
                        even.context = rd.GetString(2);
                        if (ll.Minute<30)
                        { even.time = ll.Hour * 100 + 30; }
                        else
                        { even.time = ll.Hour * 100; }

                        LSTevent.Add(even);
                    
                    }   }
                catch {; }
                try
                {
                    Event even = new Event();
                    ll = Convert.ToDateTime(rd.GetString(5));
                    if (D.Date == ll.Date)
                    {
                        even.context = rd.GetString(4);
                        if (ll.Minute > 30)
                        { even.time = ll.Hour * 100 + 30; }
                        else
                        { even.time = ll.Hour * 100; }

                        LSTevent.Add(even);

                    }
                }
                catch {; }
                try
                {
                    Event even = new Event();
                    ll = Convert.ToDateTime(rd.GetString(7));
                    if (D.Date == ll.Date)
                    {
                        even.context = rd.GetString(6);
                        if (ll.Minute > 30)
                        { even.time = ll.Hour * 100 + 30; }
                        else
                        { even.time = ll.Hour * 100; }

                        LSTevent.Add(even);

                    }
                }
                catch {; }
                try
                {
                    Event even = new Event();
                    ll = Convert.ToDateTime(rd.GetString(9));
                    if (D.Date == ll.Date)
                    {
                        even.context = rd.GetString(8);
                        if (ll.Minute > 30)
                        { even.time = ll.Hour * 100 + 30; }
                        else
                        { even.time = ll.Hour * 100; }

                        LSTevent.Add(even);

                    }
                }
                catch {; }
                try
                {
                    Event even = new Event();
                    ll = Convert.ToDateTime(rd.GetString(11));
                    if (D.Date == ll.Date)
                    {
                        even.context = rd.GetString(10);
                        if (ll.Minute > 30)
                        { even.time = ll.Hour * 100 + 30; }
                        else
                        { even.time = ll.Hour * 100; }

                        LSTevent.Add(even);

                    }
                }
                catch {; }

            }
            rd.Close();
            con.Close();
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
                    Mt.Height = 150;
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

        public void metroTile43_Click(object sender, EventArgs e) // TO CHANGE
        {   

            Event testobject = new Event();
            testobject.time = 600;
            testobject.context = "habituelle";
            LSTevent.Add(testobject);
             testobject = new Event();

            testobject.time = 700;
            testobject.context = " testing";
            LSTevent.Add(testobject);
            String ch = "";







            foreach (Event ev in LSTevent.listeevents)
                {
                tile2100.Text += Environment.NewLine + ev.context;
            }
          
        }

        private void button1_Click(object sender, EventArgs e)
        {
            eventholder(decrypttimeStart("10001615","TT4")); 
            eventholder(decrypttimeEnd("10001615","TT4"));
            eventholder(startjob("10001615"));
            eventholder(Endjob("10001615"));
            richTextBox1.Text = figuretheday();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            decryptbulletin();
            decrypthealth1();
            decryptjob();
            foreach (Event ev in LSTevent.listeevents)
            {
                eventholder(ev);
            }
            metroLabel1.Text += Environment.NewLine +figuretheday();
        }

        private void metroTile1_Click(object sender, EventArgs e)
        {

        }
    }
}
