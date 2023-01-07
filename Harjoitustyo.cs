using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.Windows.Forms;
using System.Reflection;
using System.Collections;
using System.Text.RegularExpressions;

// TEKIJÄT:
// Kaisa-Mari Salmi & Johanna Pulli
// Ohjelmointi II - Harjoitustyö


namespace Harjoitustyö
{
    public partial class Harjoitustyo : Form
    {

        // LUODAAN LISTA JA DATATABLE:
        private List<Tyontekija> tyontekijat = new List<Tyontekija>();
        public DataTable datatable;

        // MUUTTUJIA:
        int ValittuRivi = 1;
        bool tietojenMuokkaus = false;
        string[] tekstit = { "Muokataan työntekijän tietoja", "Muokataan työntekijän tietoja.", "Muokataan työntekijän tietoja..", "Muokataan työntekijän tietoja..." };
        int kierros = 0;
        string tarkistusmerkki;


        public Harjoitustyo()
        {
            InitializeComponent();

            if (File.Exists("c:\\temp\\tyontekijat.xml"))
            {
                tyontekijat = DeserializeXML();
                dgvTyontekijat.DataSource = tyontekijat;
                Table();
                LajitteluTable();
            }
        }

        // LAJITTELU
        private void Table()
        {
            datatable = new DataTable();
            DataColumn column;

            column = new DataColumn();
            column.DataType = Type.GetType("System.String");
            column.ColumnName = "Etunimet";
            datatable.Columns.Add(column);

            column = new DataColumn();
            column.DataType = Type.GetType("System.String");
            column.ColumnName = "Sukunimi";
            datatable.Columns.Add(column);

            column = new DataColumn();
            column.DataType = Type.GetType("System.String");
            column.ColumnName = "Kutsumanimi";
            datatable.Columns.Add(column);

            column = new DataColumn();
            column.DataType = Type.GetType("System.String");
            column.ColumnName = "Henkilotunnus";
            datatable.Columns.Add(column);

            column = new DataColumn();
            column.DataType = Type.GetType("System.String");
            column.ColumnName = "Katuosoite";
            datatable.Columns.Add(column);

            column = new DataColumn();
            column.DataType = Type.GetType("System.String");
            column.ColumnName = "Postinumero";
            datatable.Columns.Add(column);

            column = new DataColumn();
            column.DataType = Type.GetType("System.String");
            column.ColumnName = "Toimipaikka";
            datatable.Columns.Add(column);

            column = new DataColumn();
            column.DataType = Type.GetType("System.String");
            column.ColumnName = "Tyosuhde";
            datatable.Columns.Add(column);

            column = new DataColumn();
            column.DataType = Type.GetType("System.String");
            column.ColumnName = "Alkamispaiva";
            datatable.Columns.Add(column);

            column = new DataColumn();
            column.DataType = Type.GetType("System.String");
            column.ColumnName = "Paattymispaiva";
            datatable.Columns.Add(column);

            column = new DataColumn();
            column.DataType = Type.GetType("System.String");
            column.ColumnName = "Nimike";
            datatable.Columns.Add(column);
            dgvTyontekijat.DataSource = datatable;

            column = new DataColumn();
            column.DataType = Type.GetType("System.String");
            column.ColumnName = "Yksikko";
            datatable.Columns.Add(column);
        }
        private void LajitteluTable()
        {
            datatable.Rows.Clear();

            for (int i = 0; i < tyontekijat.Count; i++)
            {
                DataRow rivi = datatable.NewRow();
                rivi["Sukunimi"] = tyontekijat[i].sukunimi;
                rivi["Etunimet"] = tyontekijat[i].etunimet;
                rivi["Kutsumanimi"] = tyontekijat[i].kutsumanimi;
                rivi["Henkilotunnus"] = tyontekijat[i].henkilotunnus;
                rivi["Katuosoite"] = tyontekijat[i].katuosoite;
                rivi["Postinumero"] = tyontekijat[i].postinumero;
                rivi["Toimipaikka"] = tyontekijat[i].toimipaikka;
                rivi["Tyosuhde"] = tyontekijat[i].tyosuhde;
                rivi["Alkamispaiva"] = tyontekijat[i].alkamispaiva;
                rivi["Paattymispaiva"] = tyontekijat[i].paattymispaiva;
                rivi["Nimike"] = tyontekijat[i].nimike;
                rivi["Yksikko"] = tyontekijat[i].yksikko;
                datatable.Rows.Add(rivi);
            }

        }
        // TIETUEIDEN LUONTI:
        public struct Tyontekija
        {
            public string etunimet;
            public string sukunimi;
            public string kutsumanimi;
            public string henkilotunnus;
            public string katuosoite;
            public string postinumero;
            public string toimipaikka;

            public string tyosuhde;
            public string alkamispaiva;
            public string paattymispaiva;
            public string nimike;
            public string yksikko;

            public string Nimi { get { return etunimet; } }
            public string Sukunimi { get { return sukunimi; } }
            public string Kutsumanimi { get { return kutsumanimi; } }
            public string Henkilotunnus { get { return henkilotunnus; } }
            public string Katuosoite { get { return katuosoite; } }
            public string Postinumero { get { return postinumero; } }
            public string Toimipaikka { get { return toimipaikka; } }
            public string Tyosuhde { get { return tyosuhde; } }
            public string Alkamispaiva { get { return alkamispaiva; } }
            public string Paattymispaiva { get { return paattymispaiva; } }
            public string Nimike { get { return nimike; } }
            public string Yksikko { get { return yksikko; } }
        }

        // XML-TIEDOSTO:
        public void SerializeXML(List<Tyontekija> input)
        {
            System.Xml.Serialization.XmlSerializer serializer = new System.Xml.Serialization.XmlSerializer(input.GetType());
            StreamWriter sw = new StreamWriter("c:\\temp\\tyontekijat.xml");
            serializer.Serialize(sw, input);
            sw.Close();
        }
        public List<Tyontekija> DeserializeXML()
        {
            if (File.Exists("c:\\temp\\tyontekijat.xml"))
            {
                StreamReader stream = new StreamReader("c:\\temp\\tyontekijat.xml");
                System.Xml.Serialization.XmlSerializer ser = new System.Xml.Serialization.XmlSerializer(typeof(List<Tyontekija>));
                object obj = ser.Deserialize(stream);
                stream.Close();
                return (List<Tyontekija>)obj;
            }
            else
                return null;
        }

        // TYHJENNA -FUNKTIO:
        public void Tyhjenna()
        {
            AutoValidate = AutoValidate.Disable;                    // Mahdollistaa tyhjentämisen, vaikka validointi olisi käynnissä:
            CausesValidation = false;

            tbEtunimet.Text = "";
            tbSukunimi.Text = "";
            tbKutsumanimi.Text = "";
            tbHetu.Text = "";
            tbKatuosoite.Text = "";
            tbPostinumero.Text = "";
            tbToimipaikka.Text = "";
            rbMaaraaikainen.Checked = true;
            rbToistaiseksi.Checked = false;
            dtpAlkamispaiva.Value = DateTime.Now;
            dtpPaattymispaiva.Value = DateTime.Now;
            tbNimike.Text = "";
            tbYksikko.Text = "";

            AutoValidate = AutoValidate.EnableAllowFocusChange;     // Validointi jatkuu, kun lomakkeen kenttiä aletaan täyttää:
            CausesValidation = true;
        }

        // BUTTONIT:
        private void btnTallenna_Click(object sender, EventArgs e)
        {
            {       // Syötetyt tiedot listalle:
                tslTeksti.Text = "Lisää työntekijän tiedot";
                tmrAjastin.Enabled = false;
                tslTallennettu.Text = "Työntekijän tiedot tallennettu";
                Tyontekija t;
                try
                {
                    t.etunimet = tbEtunimet.Text;
                    t.sukunimi = tbSukunimi.Text;
                    t.kutsumanimi = tbKutsumanimi.Text;
                    t.henkilotunnus = tbHetu.Text;
                    t.katuosoite = tbKatuosoite.Text;
                    t.postinumero = tbPostinumero.Text;
                    t.toimipaikka = tbToimipaikka.Text;
                    if (rbToistaiseksi.Checked)
                    {
                        t.tyosuhde = "Toistaiseksi voimassa oleva";
                    }
                    else
                    {
                        t.tyosuhde = "Määräaikainen";
                    }
                    t.alkamispaiva = dtpAlkamispaiva.Text;
                    if (rbToistaiseksi.Checked)
                    {
                        t.paattymispaiva = "Toistaiseksi";
                    }
                    else
                    {
                        t.paattymispaiva = dtpPaattymispaiva.Text;
                    }
                    t.nimike = tbNimike.Text;
                    t.yksikko = tbYksikko.Text;

                    if (tietojenMuokkaus == false)
                    {
                        tyontekijat.Add(t);
                    }
                    else
                    {
                        tyontekijat[ValittuRivi] = t;
                    }
                    Table();
                    LajitteluTable();                                   // Kutsutaan funktiota (Lajittelu)
                    SerializeXML(tyontekijat);
                    tbcLisaaTyontekija.SelectedIndex = 1;               // Siirrytään Työntekijät- sivulle
                    Tyhjenna();                                         // Tyhjennetään tekstikentät lisäyksen jälkeen 
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                using (StreamWriter w = new StreamWriter("c:\\temp\\lokitiedot.txt", true))
                {
                    try
                    {
                        w.WriteLine("[" + DateTime.Now + "]" + " TAPAHTUMA: Käyttäjä {0} tallensi työntekijän tiedot.", Environment.UserName);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }

                    w.Close();
                }
            }
        }

        private void btnTyhjenna_MouseClick(object sender, MouseEventArgs e)
        {
            AutoValidate = AutoValidate.Disable;                    // Mahdollistaa tyhjentämisen, vaikka validointi olisi käynnissä:
            CausesValidation = false;
            Tyhjenna();
            btnTallenna.Enabled = false;
            AutoValidate = AutoValidate.EnableAllowFocusChange;     // Validointi jatkuu, kun lomakkeen kenttiä aletaan täyttää:
            CausesValidation = true;
        }

        private void btnLisaa_Click(object sender, EventArgs e)
        {
            tietojenMuokkaus = false;
            tbcLisaaTyontekija.SelectedIndex = 0;
            Tyhjenna();
            btnTallenna.Enabled = false;
        }


        private void btnPoista_Click(object sender, EventArgs e)
        {
            ValittuRivi = dgvTyontekijat.CurrentCell.RowIndex;                                      // Poistetaan valittu rivi datagridistä sekä xml tiedostosta
            if (ValittuRivi >= 0)
            {
                if ((MessageBox.Show("Haluatko varmasti poistaa valitun työntekijän tiedot?" +
                    tbEtunimet.Text, "", MessageBoxButtons.YesNo) == DialogResult.Yes))
                {
                    tyontekijat.RemoveAt(ValittuRivi);
                    SerializeXML(tyontekijat);
                    dgvTyontekijat.DataSource = null;
                    dgvTyontekijat.DataSource = tyontekijat;
                    tslTallennettu.Text = "Työntekijän tiedot poistettu";
                    using (StreamWriter w = new StreamWriter("c:\\temp\\lokitiedot.txt", true))
                    {
                        try
                        {
                            w.WriteLine("[" + DateTime.Now + "]" + " TAPAHTUMA: Käyttäjä {0} poisti työntekijän tiedot.", Environment.UserName);

                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                        w.Close();
                    }
                }
                else
                {
                    tslTallennettu.Text = "Työntekijän tietoja ei poistettu.";
                }
            }
            }

        private void btnMuokkaa_Click_1(object sender, EventArgs e)
        {
            tmrAjastin.Enabled = true;
            tslTeksti.Text = tekstit[0];
            btnTallenna.Enabled = true;
            ValittuRivi = dgvTyontekijat.CurrentCell.RowIndex;

            Tyontekija t = tyontekijat[ValittuRivi];
            tbEtunimet.Text = t.etunimet;
            tbSukunimi.Text = t.sukunimi;
            tbKutsumanimi.Text = t.kutsumanimi;
            tbHetu.Text = t.henkilotunnus;
            tbKatuosoite.Text = t.katuosoite;
            tbPostinumero.Text = t.postinumero;
            tbToimipaikka.Text = t.toimipaikka;
            if (t.tyosuhde == "Toistaiseksi voimassa oleva")
            {
                rbToistaiseksi.Checked = true;
            }
            else if (t.tyosuhde == "Määräaikainen")
            {
                rbMaaraaikainen.Checked = true;
            }
            dtpAlkamispaiva.Text = t.alkamispaiva;
            if (rbToistaiseksi.Checked)
            {
                t.paattymispaiva = "Toistaiseksi";
                dtpPaattymispaiva.Enabled = false;
            }
            else if (rbMaaraaikainen.Checked)
            {
                dtpPaattymispaiva.Text = t.paattymispaiva;
                dtpPaattymispaiva.Enabled = true;
            }
            tbNimike.Text = t.nimike;
            tbYksikko.Text = t.yksikko;
            tbcLisaaTyontekija.SelectedIndex = 0;
            tietojenMuokkaus = true;
            using (StreamWriter w = new StreamWriter("c:\\temp\\lokitiedot.txt", true))
            {
                try
                {
                    w.WriteLine("[" + DateTime.Now + "]" + " TAPAHTUMA: Käyttäjä {0} siirtyi muokkaamaan työntekijän tietoja.", Environment.UserName);
                }
                catch (Exception)
                {
                }

                w.Close();
            }             
        }

          // RADIOBUTTONIT:        
        
        private void rbToistaiseksi_CheckedChanged_1(object sender, EventArgs e)
        {
            if (rbToistaiseksi.Checked == true)
            { 
                dtpPaattymispaiva.Enabled = false;
            }
        }
            private void rbMaaraaikainen_CheckedChanged(object sender, EventArgs e)
        {
            if (rbMaaraaikainen.Checked == true)
            {
                dtpPaattymispaiva.Enabled = true;
            }
        }

        // KEYPRESS -TAPAHTUMAT
        private void tbPostinumero_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsNumber(e.KeyChar) && !Char.IsControl(e.KeyChar))                        // Tarkistaa, että postinumerossa on vain numeroita
            e.Handled = true;
        }
         private void tbEtunimet_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsNumber(e.KeyChar))                                                       // Tarkistaa, ettei Etunimet, Sukunimi, Kutsumanimi tai Toimipaikka sisällä numeroita
                e.Handled = true;
        }
        private void tbHetu_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            e.KeyChar = Char.ToUpper(e.KeyChar);                                                // Mahdollistaa vain tikkukirjainten kirjoittamisen HETU kenttään
        }

        // TOIMINNUT, KUN AVAUTUU:
        private void Harjoitustyo_Load(object sender, EventArgs e)
        {
            AutoCompleteStringCollection Collection = new AutoCompleteStringCollection();
            Collection.Add("Helsinki");
            Collection.Add("Lahti");
            Collection.Add("Turku");
            Collection.Add("Uusikaupunki");
            Collection.Add("Pori");
            Collection.Add("Forssa");
            Collection.Add("Jyväskylä");
            Collection.Add("Kotka");
            Collection.Add("Mikkeli");
            Collection.Add("Lappeenranta");
            Collection.Add("Savonlinna");
            Collection.Add("Seinäjoki");
            Collection.Add("Vaasa");
            Collection.Add("Kokkola");
            Collection.Add("Kuopio");
            Collection.Add("Pieksämäki");
            Collection.Add("Joensuu");
            Collection.Add("Ylivieska");
            Collection.Add("Kajaani");
            Collection.Add("Oulu");
            Collection.Add("Kemi");
            Collection.Add("Rovaniemi");

            tbToimipaikka.AutoCompleteCustomSource = Collection; 
            tbToimipaikka.AutoCompleteSource = AutoCompleteSource.CustomSource;
            tbToimipaikka.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            
            StreamWriter w = new StreamWriter("c:\\temp\\lokitiedot.txt", true);                    // Lokitiedot: jos ei ole olemassa, ne luodaan. Jos on niin jatketaan perään.
            try
            {
                w.WriteLine("=== Lokitietojen tallennus alkoi : " + DateTime.Now + " ===");
                w.WriteLine("[" + DateTime.Now + "]" + " Projekti: {0}", Environment.CommandLine);
                w.WriteLine("[" + DateTime.Now + "]" + " Käyttäjänimi: {0}", Environment.UserName);
                w.WriteLine("[" + DateTime.Now + "]" + " Laite: {0}", Environment.UserDomainName);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
                    w.Close();
            }

        // VALIDOINTI:
        private void tbEtunimet_Validated(object sender, EventArgs e)
        {
            errorProvider1.SetError((TextBox)sender, "");
        }

        private void tbEtunimet_Validating(object sender, CancelEventArgs e)
        {
            TextBox tb = (TextBox)sender;

            if (tb.Text.Trim() == "")
            {
                e.Cancel = true;
                tb.Text = tb.Text.Trim();
                tb.Select();
                this.errorProvider1.SetError(tb, "Tieto on pakollinen");
            }

        }        
        private void TbPostinumero_Validated(object sender, EventArgs e)
        {
            errorProvider1.SetError(tbPostinumero, "");
        }
        public bool PostinumeroOikein(String postinumero, out string errorMessage)
        {
            bool oikein = true;
            errorMessage = "";
            if (postinumero.Length == 0)
            {
                errorMessage = "Tieto on pakollinen";
                oikein = false;
            }
            else if (postinumero.Length != 5)
            {
                errorMessage = "Postinumero voi olla vain 5 numeroinen";
                oikein = false;
            }
            return oikein;
        }
        private void TbPostinumero_Validating(object sender, CancelEventArgs e)
        {
            string errorMsg;
            if (PostinumeroOikein(tbPostinumero.Text, out errorMsg) == false)
            {
                e.Cancel = true;
                tbPostinumero.Select(0, tbPostinumero.Text.Length);
                errorProvider1.SetError(tbPostinumero, errorMsg);
            }
        }
        private void tbHetu_Validated(object sender, EventArgs e)
        {
            errorProvider1.SetError((TextBox)sender, "");
        }
       
        private void tbHetu_Validating(object sender, CancelEventArgs e)
        {
            List<string> virheviestit = new List<string>();
            string henkilotunnus;
            TextBox tb = (TextBox)sender;
            henkilotunnus = Regex.Replace(tb.Text, @" ", "").ToUpper();                 // Jos ylimääräisiä välilyöntejä
            if (henkilotunnus.Length != 11)                                             // Tarkistetaan pituus
            {
                virheviestit.Add("Henkilötunnuksen tulee olla 11 merkkiä pitkä.");
            }

            if (virheviestit.Count == 0)
            {
                string henknumerotalku = henkilotunnus.Substring(0, 6);
                string henknumerotloppu = henkilotunnus.Substring(7, 3);        
                string henknumerot = henknumerotalku + henknumerotloppu;
                string viimeinenmerkki = henkilotunnus.Substring(10, 1);

                double desimaaliluku = (double.Parse(henknumerot) / 31);

                double xdesimaalit = desimaaliluku - Math.Truncate(desimaaliluku);         // Otetaan desimaaliluvusta vain desimaalit pilkun jälkeen

                decimal value = (decimal)(xdesimaalit * 31);

                decimal kokonaisluku = Decimal.Round(value);                                // Pyöristyy lähimpään kokonaisulukuun
                int verrataan = (int)kokonaisluku;
            
                if (verrataan < 0 || verrataan > 30)                                        // Tarkistetaan, että pyöristetty luku on hetun mahdollisten jakojäännösten piirissä eli 0-30 välillä.
                {
                    virheviestit.Add("Henkilötunnus ei ole tarkistuslaskennan perusteella kelvollinen.");
                }
                else
                {
                    switch (verrataan)
                    {
                        case 0: tarkistusmerkki = "0";
                            break;
                        case 1: tarkistusmerkki = "1";
                            break;
                        case 2: tarkistusmerkki = "2";
                            break;
                        case 3:
                            tarkistusmerkki = "3";
                            break;
                        case 4:
                            tarkistusmerkki = "4";
                            break;
                        case 5:
                            tarkistusmerkki = "5";
                            break;
                        case 6:
                            tarkistusmerkki = "6";
                            break;
                        case 7:
                            tarkistusmerkki = "7";
                            break;
                        case 8:
                            tarkistusmerkki = "8";
                            break;
                        case 9:
                            tarkistusmerkki = "9";
                            break;
                        case 10:
                            tarkistusmerkki = "A";
                            break;
                        case 11:
                            tarkistusmerkki = "B";
                            break;
                        case 12:
                            tarkistusmerkki = "C";
                            break;
                        case 13:
                            tarkistusmerkki = "D";
                            break;
                        case 14:
                            tarkistusmerkki = "E";
                            break;
                        case 15:
                            tarkistusmerkki = "F";
                            break;
                        case 16:
                            tarkistusmerkki = "H";
                            break;
                        case 17:
                            tarkistusmerkki = "J";
                            break;
                        case 18:
                            tarkistusmerkki = "K";
                            break;
                        case 19:
                            tarkistusmerkki = "L";
                            break;
                        case 20:
                            tarkistusmerkki = "M";
                            break;
                        case 21:
                            tarkistusmerkki = "N";
                            break;
                        case 22:
                            tarkistusmerkki = "P";
                            break;
                        case 23:
                            tarkistusmerkki = "R";
                            break;
                        case 24:
                            tarkistusmerkki = "S";
                            break;
                        case 25:
                            tarkistusmerkki = "T";
                            break;
                        case 26:
                            tarkistusmerkki = "U";
                            break;
                        case 27:
                            tarkistusmerkki = "V";
                            break;
                        case 28:
                            tarkistusmerkki = "W";
                            break;
                        case 29:
                            tarkistusmerkki = "X";
                            break;
                        case 30:
                            tarkistusmerkki = "Y";
                            break;
                    }
                }

                if (tarkistusmerkki != viimeinenmerkki)
                {
                    virheviestit.Add("Henkilötunnus ei ole tarkistuslaskennan perusteella kelvollinen.");
                }
            }
            if (virheviestit.Count != 0)                                                // Kerätään virheet:
            {
                e.Cancel = true;
                tb.Text = tb.Text.Trim();
                tb.Select(0, tb.Text.Length);
                this.errorProvider1.SetError(tb, string.Join("\n", virheviestit));
            }
        }
        
        // AJASTIN:
        private void tmrAjastin_Tick(object sender, EventArgs e)
        {
            kierros++;
            if (kierros == 4)
                kierros = 0;
            tslTeksti.Text = tekstit[kierros];
        }

        // LEAVE TAPAHTUMA: Tallenna-buttonin käyttöön ottaminen:        
        
        private void TbLeave(object sender, EventArgs e)
        {
            if (tbEtunimet.Text != "" && tbSukunimi.Text != "" && tbKutsumanimi.Text != "" && tbKatuosoite.Text != "" && tbToimipaikka.Text != "" && tbNimike.Text != "" && tbYksikko.Text != "")
            {
                btnTallenna.Enabled = true;
            }
            else
                btnTallenna.Enabled = false;
        }

        // HARJOITUSTYÖN SULKEMISEN TAPAHTUMAT:
        private void Harjoitustyo_FormClosing(object sender, FormClosingEventArgs e)
        {
            AutoValidate = AutoValidate.Disable;
            CausesValidation = false;

            if (MessageBox.Show("Haluatko varmasti sulkea ohjelman?",
                "Sulje ohjelma", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                this.Activate();
            }
            else
            {
                e.Cancel = true;
                AutoValidate = AutoValidate.EnableAllowFocusChange;             // Validointi jatkuu, kun lomakkeen kenttiä aletaan täyttää:
                CausesValidation = true;
            }
        }

        private void Harjoitustyo_FormClosed(object sender, FormClosedEventArgs e)
        {
            using (StreamWriter w = new StreamWriter("c:\\temp\\lokitiedot.txt", true))
            {
                try
                {
                    w.WriteLine("=== Lokitietojen tallennus päättyi : " + DateTime.Now + " ===");
                    w.WriteLine(" ");

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

                w.Close();
            } 
        }

       
    }
}





        
