namespace deneme1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBox1.Text = listBox1.SelectedItem?.ToString();

            if (textBox1.Text == "Osman Gazi")
            {
                listBox2.Items.Clear();
                listBox2.Items.Add("Koyunhisar (Bapheus) Savaşı");
                listBox2.Items.Add("Dimbos Savaşı");
                listBox2.Items.Add("Karahisar (Trikokiya) Kuşatması");
            }
            if (textBox1.Text == "Orhan Gazi")
            {
                listBox2.Items.Clear();
                listBox2.Items.Add("Bursa Kuşatması");
                listBox2.Items.Add("Eskihisar (Palekanon) Savaşı");
                listBox2.Items.Add("Nicea Kuşatması");
                listBox2.Items.Add("İzmit Kuşatması");
                listBox2.Items.Add("I. ve II. Gelibolu Savaşları");
                listBox2.Items.Add("Sazlıdere Savaşı");
            }
            if (textBox1.Text == "I. Murad (Hüdavendigar)")
            {
                listBox2.Items.Clear();
                listBox2.Items.Add("Sırpsındığı Savaşı");
                listBox2.Items.Add("Çirmen Savaşı");
                listBox2.Items.Add("Ploşnik Muharebesi");
                listBox2.Items.Add("Bileća Muharebesi");
                listBox2.Items.Add("I. Kosova Muharebesi");
            }
            if (textBox1.Text == "I. Bayezid (Yıldırım)")
            {
                listBox2.Items.Clear();
                listBox2.Items.Add("Alaşehir Kuşatması");
                listBox2.Items.Add("I. İstanbul Kuşatması");
                listBox2.Items.Add("II. İstanbul Kuşatması");
                listBox2.Items.Add("Niğbolu Muharebesi");
                listBox2.Items.Add("III. İstanbul Kuşatması");
                listBox2.Items.Add("Karamanoğulları Seferi");
                listBox2.Items.Add("Ankara Muharebesi");

            }
            if (textBox1.Text == "I. Mehmed (Çelebi)")
            {
                listBox2.Items.Clear();
                listBox2.Items.Add("Osmanlı-Venedik deniz savaşı");
                listBox2.Items.Add("Rumeli Seferi");
                listBox2.Items.Add("Anadolu Seferi");
                listBox2.Items.Add("Şeyh Bedreddin İsyanı");
                listBox2.Items.Add("II. Anadolu Seferi");

            }
            if (textBox1.Text == "II. Murad")
            {
                listBox2.Items.Clear();
                listBox2.Items.Add("Isparta ve Burdur Kuşatması");
                listBox2.Items.Add("Samsun ve Ordu Kuşatması");
                listBox2.Items.Add("V. İstanbul Kuşatması");
                listBox2.Items.Add("Karamanoğulları Seferi");
                listBox2.Items.Add("II. Selanik Kuşatması");
                listBox2.Items.Add("Osmanlı-Macar Savaşı 1");
                listBox2.Items.Add("Kubatoğulları'nın İlhakı");
                listBox2.Items.Add("Germiyanoğulları'nın İlhakı");
                listBox2.Items.Add("Arnavut İsyanları");
                listBox2.Items.Add("Karamanoğulları ile Savaş 1");
                listBox2.Items.Add("Karamanoğulları ile Savaş 2");
                listBox2.Items.Add("Osmanlı-Macar Savaşı 2");
                listBox2.Items.Add("Osmanlı-Arnavut Savaşları");
                listBox2.Items.Add("Varna Savaşı");
                listBox2.Items.Add("Karamanoğulları Seferi");
                listBox2.Items.Add("Buçuktepe İsyanı");
                listBox2.Items.Add("II. Kosova Savaşı");

            }
            if (textBox1.Text == "II. Mehmed (Fatih)")
            {
                listBox2.Items.Clear();
                listBox2.Items.Add("VI. İstanbul Kuşatması");
                listBox2.Items.Add("Boğdan Seferi");
                listBox2.Items.Add("Sırbistan Seferi");
                listBox2.Items.Add("Semendire Kuşatması");
                listBox2.Items.Add("Mora Seferi");
                listBox2.Items.Add("İsfanidyaroğulları'nın İlhakı");
                listBox2.Items.Add("Trabzon Kuşatması");
                listBox2.Items.Add("Eflak Seferi");
                listBox2.Items.Add("Osmanlı-Venedik Savaşı");
                listBox2.Items.Add("Bosna Seferleri");
                listBox2.Items.Add("Konya Seferi");
                listBox2.Items.Add("Otlukbeli Muharebesi");
                listBox2.Items.Add("İçel Seferi");
                listBox2.Items.Add("Kırım Seferi");
                listBox2.Items.Add("Arnavutluk Seferi");
                listBox2.Items.Add("İtalya Seferi");

            }
            if (textBox1.Text == "II. Bayezid")
            {
                listBox2.Items.Clear();
                listBox2.Items.Add("Akkirman Seferi");
                listBox2.Items.Add("Osmanlı-Memlük Savaşı");
                listBox2.Items.Add("Krbava Muharebesi");
                listBox2.Items.Add("Osmanlı-Venedik Savaşı");
                listBox2.Items.Add("Şahkulu İsyanı");
            }
            if (textBox1.Text == "I. Selim (Yavuz)")
            {
                listBox2.Items.Clear();
                listBox2.Items.Add("Çaldıran Muharebesi");
                listBox2.Items.Add("Turnadağ Muharebesi");
                listBox2.Items.Add("Koçhisar Muharebesi");
                listBox2.Items.Add("Mercidabık Muharebesi");
                listBox2.Items.Add("Ridaniye Muharebesi");

            }
            if (textBox1.Text == "I. Süleyman (Kanuni)")
            {
                listBox2.Items.Clear();
                listBox2.Items.Add("Mastaba Muharebesi (İsyanı)");
                listBox2.Items.Add("I. Macar Seferi (Belgrad Seferi)");
                listBox2.Items.Add("Rodos Kuşatması");
                listBox2.Items.Add("Hain Ahmed Paşa İsyanı");
                listBox2.Items.Add("II. Macar Seferi (Mohaç Meydan Muharebesi)");
                listBox2.Items.Add("Baba Zünnun İsyanı");
                listBox2.Items.Add("Kalender Çelebi İsyanı");
                listBox2.Items.Add("I. Osmanlı-Habsburg Savaşı");
                listBox2.Items.Add("Büyük Alman Seferi");
                listBox2.Items.Add("Irakeyn Seferi");
                listBox2.Items.Add("Tunus'un İlhakı");
                listBox2.Items.Add("Osmanlı-Venedik Savaşı");
                listBox2.Items.Add("Karaboğdan Seferi");
                listBox2.Items.Add("Osmanlı-Portekiz Çatışmaları");
                listBox2.Items.Add("II. Osmanlı-Habsburg Savaşı");
                listBox2.Items.Add("İran Seferi");
                listBox2.Items.Add("III. Osmanlı-Habsburg Savaşı");
                listBox2.Items.Add("II. İran Seferi");
                listBox2.Items.Add("Sudan Seferleri");
                listBox2.Items.Add("II. Malta Kuşatması");
                listBox2.Items.Add("Zigetvar Kuşatması");

            }
        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBox2.Text = listBox2.SelectedItem?.ToString();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox2.Text == "Koyunhisar (Bapheus) Savaşı")
            {
                textBox3.Text = "1302";
                textBox4.Text = "Osmanlı Zaferi";
            }
            if (textBox2.Text == "Dimbos Savaşı")
            {
                textBox3.Text = "1303";
                textBox4.Text = "Osmanlı Zaferi";
            }
            if (textBox2.Text == "Karahisar (Trikokiya) Kuşatması")
            {
                textBox3.Text = "1308";
                textBox4.Text = "Osmanlı Zaferi";
            }
            if (textBox2.Text == "Bursa Kuşatması")
            {
                textBox3.Text = "1326";
                textBox4.Text = "Osmanlı Zaferi";
            }
            if (textBox2.Text == "Eskihisar (Palekanon) Savaşı")
            {
                textBox3.Text = "1329";
                textBox4.Text = "Osmanlı Zaferi";
            }
            if (textBox2.Text == "Nicea Kuşatması")
            {
                textBox3.Text = "1331";
                textBox4.Text = "Osmanlı Zaferi";
            }
            if (textBox2.Text == "İzmit Kuşatması")
            {
                textBox3.Text = "1337";
                textBox4.Text = "Osmanlı Zaferi";
            }
            if (textBox2.Text == "I. ve II. Gelibolu Savaşları")
            {
                textBox3.Text = "1353";
                textBox4.Text = "Osmanlı Zaferi";
            }
            if (textBox2.Text == "Sazlıdere Savaşı")
            {
                textBox3.Text = "1361";
                textBox4.Text = "Osmanlı Zaferi";
            }
            if (textBox2.Text == "Sırpsındığı Savaşı")
            {
                textBox3.Text = "1364";
                textBox4.Text = "Osmanlı Zaferi";
            }
            if (textBox2.Text == "Çirmen Savaşı")
            {
                textBox3.Text = "1371";
                textBox4.Text = "Osmanlı Zaferi";
            }
            if (textBox2.Text == "Ploşnik Muharebesi")
            {
                textBox3.Text = "1386";
                textBox4.Text = "Sırp-Boşnak Zaferi";
            }
            if (textBox2.Text == "Bileća Muharebesi")
            {
                textBox3.Text = "1388";
                textBox4.Text = "Boşnak Zaferi";
            }
            if (textBox2.Text == "I. Kosova Muharebesi")
            {
                textBox3.Text = "1389";
                textBox4.Text = "Osmanlı Zaferi";
            }
            if (textBox2.Text == "Alaşehir Kuşatması")
            {
                textBox3.Text = "1390";
                textBox4.Text = "Osmanlı Zaferi";
            }
            if (textBox2.Text == "I. İstanbul Kuşatması")
            {
                textBox3.Text = "1391";
                textBox4.Text = "Sonuçsuz";
            }
            if (textBox2.Text == "II. İstanbul Kuşatması")
            {
                textBox3.Text = "1394";
                textBox4.Text = "Sonuçsuz";
            }
            if (textBox2.Text == "Niğbolu Muharebesi")
            {
                textBox3.Text = "1395";
                textBox4.Text = "Osmanlı Zaferi";
            }
            if (textBox2.Text == "III. İstanbul Kuşatması")
            {
                textBox3.Text = "1397";
                textBox4.Text = "Sonuçsuz";
            }
            if (textBox2.Text == "Karamanoğulları Seferi")
            {
                textBox3.Text = "1397";
                textBox4.Text = "Osmanlı Zaferi";
            }
            if (textBox2.Text == "Ankara Muharebesi")
            {
                textBox3.Text = "1402";
                textBox4.Text = "Timurlular Zaferi";
            }
            if (textBox2.Text == "Osmanlı-Venedik deniz savaşı")
            {
                textBox3.Text = "1416";
                textBox4.Text = "Venedik Zaferi";
            }
            if (textBox2.Text == "Rumeli Seferi")
            {
                textBox3.Text = "1416";
                textBox4.Text = "Osmanlı Zaferi";
            }
            if (textBox2.Text == "Anadolu Seferi")
            {
                textBox3.Text = "1416";
                textBox4.Text = "Osmanlı Zaferi";
            }
            if (textBox2.Text == "Şeyh Bedreddin İsyanı")
            {
                textBox3.Text = "1416";
                textBox4.Text = "İsyan Bastırıldı";
            }
            if (textBox2.Text == "II. Anadolu Seferi")
            {
                textBox3.Text = "1420";
                textBox4.Text = "Osmanlı Zaferi";
            }
            if (textBox2.Text == "Isparta ve Burdur Kuşatması")
            {
                textBox3.Text = "1421";
                textBox4.Text = "Karamanoğulları Zaferi";
            }
            if (textBox2.Text == "Samsun ve Ordu Kuşatması")
            {
                textBox3.Text = "1421";
                textBox4.Text = "Kubadoğulları Zaferi";
            }
            if (textBox2.Text == "V. İstanbul Kuşatması")
            {
                textBox3.Text = "1422";
                textBox4.Text = "Sonuçsuz";
            }
            if (textBox2.Text == "Karamanoğulları Seferi")
            {
                textBox3.Text = "1423";
                textBox4.Text = "Osmanlı Zaferi";
            }
            if (textBox2.Text == "II. Selanik Kuşatması")
            {
                textBox3.Text = "1422";
                textBox4.Text = "Osmanlı Zaferi";
            }
            if (textBox2.Text == "Osmanlı-Macar Savaşı 1")
            {
                textBox3.Text = "1426";
                textBox4.Text = "Osmanlı Zaferi";
            }
            if (textBox2.Text == "Kubatoğulları'nın İlhakı")
            {
                textBox3.Text = "1428";
                textBox4.Text = "Osmanlı Zaferi";
            }
            if (textBox2.Text == "Germiyanoğulları'nın İlhakı")
            {
                textBox3.Text = "1430";
                textBox4.Text = "Osmanlı Zaferi";
            }
            if (textBox2.Text == "Arnavut İsyanları")
            {
                textBox3.Text = "1432";
                textBox4.Text = "Osmanlı Zaferi";
            }
            if (textBox2.Text == "Karamanoğulları ile Savaş 1")
            {
                textBox3.Text = "1433";
                textBox4.Text = "Osmanlı Zaferi";
            }
            if (textBox2.Text == "Karamanoğulları ile Savaş 2")
            {
                textBox3.Text = "1437";
                textBox4.Text = "Osmanlı Zaferi";
            }
            if (textBox2.Text == "Osmanlı-Macar Savaşı 2")
            {
                textBox3.Text = "1437";
                textBox4.Text = "Avrupa İttifakı Zaferi";
            }
            if (textBox2.Text == "Osmanlı-Arnavut Savaşları")
            {
                textBox3.Text = "1443";
                textBox4.Text = "Arnavut Zaferi";
            }
            if (textBox2.Text == "Varna Savaşı")
            {
                textBox3.Text = "1444";
                textBox4.Text = "Osmanlı Zaferi";
            }
            if (textBox2.Text == "Karamanoğulları Seferi")
            {
                textBox3.Text = "1444";
                textBox4.Text = "Osmanlı Zaferi";
            }
            if (textBox2.Text == "Buçuktepe İsyanı")
            {
                textBox3.Text = "1446";
                textBox4.Text = "İsyan Bastırıldı";
            }
            if (textBox2.Text == "II. Kosova Savaşı")
            {
                textBox3.Text = "1448";
                textBox4.Text = "Osmanlı Zaferi";
            }
            if (textBox2.Text == "VI. İstanbul Kuşatması")
            {
                textBox3.Text = "1453";
                textBox4.Text = "Osmanlı Zaferi";
            }
            if (textBox2.Text == "Boğdan Seferi")
            {
                textBox3.Text = "1455";
                textBox4.Text = "Osmanlı Zaferi";
            }
            if (textBox2.Text == "Sırbistan Seferi")
            {
                textBox3.Text = "1457";
                textBox4.Text = "Osmanlı Zaferi";
            }
            if (textBox2.Text == "Semendire Kuşatması")
            {
                textBox3.Text = "1459";
                textBox4.Text = "Osmanlı Zaferi";
            }
            if (textBox2.Text == "Mora Seferi")
            {
                textBox3.Text = "1460";
                textBox4.Text = "Osmanlı Zaferi";
            }
            if (textBox2.Text == "İsfanidyaroğulları'nın İlhakı")
            {
                textBox3.Text = "1461";
                textBox4.Text = "Osmanlı Zaferi";
            }
            if (textBox2.Text == "Trabzon Kuşatması")
            {
                textBox3.Text = "1461";
                textBox4.Text = "Osmanlı Zaferi";
            }
            if (textBox2.Text == "Eflak Seferi")
            {
                textBox3.Text = "1462";
                textBox4.Text = "Osmanlı Zaferi";
            }
            if (textBox2.Text == "Osmanlı-Venedik Savaşı")
            {
                textBox3.Text = "1463";
                textBox4.Text = "Osmanlı Zaferi";
            }
            if (textBox2.Text == "Bosna Seferleri")
            {
                textBox3.Text = "1463";
                textBox4.Text = "Osmanlı Zaferi";
            }
            if (textBox2.Text == "Konya Seferi")
            {
                textBox3.Text = "1466";
                textBox4.Text = "Osmanlı Zaferi";
            }
            if (textBox2.Text == "Otlukbeli Muharebesi")
            {
                textBox3.Text = "1473";
                textBox4.Text = "Osmanlı Zaferi";
            }
            if (textBox2.Text == "İçel Seferi")
            {
                textBox3.Text = "1474";
                textBox4.Text = "Osmanlı Zaferi";
            }
            if (textBox2.Text == "Kırım Seferi")
            {
                textBox3.Text = "1475";
                textBox4.Text = "Osmanlı Zaferi";
            }
            if (textBox2.Text == "Arnavutluk Seferi")
            {
                textBox3.Text = "1478";
                textBox4.Text = "Osmanlı Zaferi";
            }
            if (textBox2.Text == "İtalya Seferi")
            {
                textBox3.Text = "1480";
                textBox4.Text = "Sonuçsuz";
            }
            if (textBox2.Text == "Akkirman Seferi")
            {
                textBox3.Text = "1484";
                textBox4.Text = "Osmanlı Zaferi";
            }
            if (textBox2.Text == "Osmanlı-Memlük Savaşı")
            {
                textBox3.Text = "1485";
                textBox4.Text = "Sonuçsuz";
            }
            if (textBox2.Text == "Krbava Muharebesi")
            {
                textBox3.Text = "1493";
                textBox4.Text = "Osmanlı Zaferi";
            }
            if (textBox2.Text == "Osmanlı-Venedik Savaşı")
            {
                textBox3.Text = "1499";
                textBox4.Text = "Osmanlı Zaferi";
            }
            if (textBox2.Text == "Şahkulu İsyanı")
            {
                textBox3.Text = "1511";
                textBox4.Text = "İsyan Bastırıldı";
            }
            if (textBox2.Text == "Çaldıran Muharebesi")
            {
                textBox3.Text = "1514";
                textBox4.Text = "Osmanlı Zaferi";
            }
            if (textBox2.Text == "Turnadağ Muharebesi")
            {
                textBox3.Text = "1515";
                textBox4.Text = "Osmanlı Zaferi";
            }
            if (textBox2.Text == "Koçhisar Muharebesi")
            {
                textBox3.Text = "1516";
                textBox4.Text = "Osmanlı Zaferi";
            }
            if (textBox2.Text == "Mercidabık Muharebesi")
            {
                textBox3.Text = "1516";
                textBox4.Text = "Osmanlı Zaferi";
            }
            if (textBox2.Text == "Ridaniye Muharebesi")
            {
                textBox3.Text = "1517";
                textBox4.Text = "Osmanlı Zaferi";
            }
            if (textBox2.Text == "Mastaba Muharebesi (İsyanı)")
            {
                textBox3.Text = "1521";
                textBox4.Text = "Osmanlı Zaferi";
            }
            if (textBox2.Text == "I. Macar Seferi (Belgrad Seferi)")
            {
                textBox3.Text = "1521";
                textBox4.Text = "Osmanlı Zaferi";
            }
            if (textBox2.Text == "Rodos Kuşatması")
            {
                textBox3.Text = "1522";
                textBox4.Text = "Osmanlı Zaferi";
            }
            if (textBox2.Text == "Hain Ahmed Paşa İsyanı")
            {
                textBox3.Text = "1524";
                textBox4.Text = "İsyan Bastırıldı";
            }
            if (textBox2.Text == "II. Macar Seferi (Mohaç Meydan Muharebesi)")
            {
                textBox3.Text = "1526";
                textBox4.Text = "Osmanlı Zaferi";
            }
            if (textBox2.Text == "Baba Zünnun İsyanı")
            {
                textBox3.Text = "1526";
                textBox4.Text = "İsyan Bastırıldı";
            }
            if (textBox2.Text == "Kalender Çelebi İsyanı")
            {
                textBox3.Text = "1527";
                textBox4.Text = "İsyan Bastırıldı";
            }
            if (textBox2.Text == "I. Osmanlı-Habsburg Savaşı")
            {
                textBox3.Text = "1529";
                textBox4.Text = "Sonuçsuz";
            }
            if (textBox2.Text == "Büyük Alman Seferi")
            {
                textBox3.Text = "1533";
                textBox4.Text = "Osmanlı Zaferi";
            }
            if (textBox2.Text == "Irakeyn Seferi")
            {
                textBox3.Text = "1533";
                textBox4.Text = "Osmanlı Zaferi";
            }
            if (textBox2.Text == "Tunus'un İlhakı")
            {
                textBox3.Text = "1534";
                textBox4.Text = "Osmanlı Zaferi";
            }
            if (textBox2.Text == "Osmanlı-Venedik Savaşı")
            {
                textBox3.Text = "1537";
                textBox4.Text = "Osmanlı Zaferi";
            }
            if (textBox2.Text == "Karaboğdan Seferi")
            {
                textBox3.Text = "1538";
                textBox4.Text = "Osmanlı Zaferi";
            }
            if (textBox2.Text == "Osmanlı-Portekiz Çatışmaları")
            {
                textBox3.Text = "1538";
                textBox4.Text = "Osmanlı Zaferi";
            }
            if (textBox2.Text == "II. Osmanlı-Habsburg Savaşı")
            {
                textBox3.Text = "1340";
                textBox4.Text = "Osmanlı Zaferi";
            }
            if (textBox2.Text == "İran Seferi")
            {
                textBox3.Text = "1548";
                textBox4.Text = "Osmanlı Zaferi";
            }
            if (textBox2.Text == "III. Osmanlı-Habsburg Savaşı")
            {
                textBox3.Text = "1551";
                textBox4.Text = "Osmanlı Zaferi";
            }
            if (textBox2.Text == "II. İran Seferi")
            {
                textBox3.Text = "1553";
                textBox4.Text = "Osmanlı Zaferi";
            }
            if (textBox2.Text == "Sudan Seferleri")
            {
                textBox3.Text = "1555";
                textBox4.Text = "Osmanlı Zaferi";
            }
            if (textBox2.Text == "II. Malta Kuşatması")
            {
                textBox3.Text = "1565";
                textBox4.Text = "Sonuçsuz";
            }
            if (textBox2.Text == "Zigetvar Kuşatması")
            {
                textBox3.Text = "1566";
                textBox4.Text = "Osmanlı Zaferi";
            }









        }
    }
}