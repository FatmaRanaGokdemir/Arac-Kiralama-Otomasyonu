using Nesne_Quiz_Odevi.Models;
using Nesne_Quiz_Ödevi.Models;
using Nesne_Quiz_Odevi.Services;
using System;
using System.Windows.Forms;

namespace Nesne_Quiz_Ödevi
{
    public partial class Form1 : Form
    {
        // 1. DÜKKAN MÜDÜRÜNÜ ÇAĞIRIYORUZ
        RentalManager dukkanMuduru = new RentalManager();

        public Form1()
        {
            InitializeComponent();

            // Program açıldığında araçları vitrine koyuyoruz
            dgvAraclar.DataSource = dukkanMuduru.Vehicles;

            // Program açıldığında müşterileri de kendi vitrinine koyuyoruz!
            dgvMusteriListesi.DataSource = dukkanMuduru.Customers;
        }

        // 2. EKLE BUTONU TIKLANDIĞINDA ÇALIŞACAK KODLAR
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string plaka = txtPlaka.Text;
                string marka = txtMarka.Text;
                string model = txtModel.Text;

                int yil = Convert.ToInt32(txtYil.Text);
                decimal fiyat = Convert.ToDecimal(txtFiyat.Text);

                int yeniId = dukkanMuduru.Vehicles.Count + 1;
                Car yeniAraba = new Car(yeniId, plaka, marka, model, yil, fiyat);

                dukkanMuduru.Vehicles.Add(yeniAraba);

                dgvAraclar.DataSource = null;
                dgvAraclar.DataSource = dukkanMuduru.Vehicles;

                txtPlaka.Text = "";
                txtMarka.Text = "";
                txtModel.Text = "";
                txtYil.Text = "";
                txtFiyat.Text = "";

                MessageBox.Show("Araç başarıyla eklendi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception)
            {
                MessageBox.Show("Lütfen yıl ve fiyat kutularına sadece rakam giriniz!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // 3. YANLIŞLIKLA TIKLANAN BOŞ BAĞLANTILAR (Hata vermemesi için buradalar, içleri boş kalacak)
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e) { }
        private void label1_Click(object sender, EventArgs e) { }
        private void label5_Click(object sender, EventArgs e) { }

        private void button3_Click(object sender, EventArgs e)
        {
            // Tablodan (DataGridView) bir satır seçilmiş mi kontrol ediyoruz
            if (dgvAraclar.CurrentRow != null)
            {
                // Seçili satırdaki ilk hücreyi (Id) alıyoruz
                int secilenId = Convert.ToInt32(dgvAraclar.CurrentRow.Cells[0].Value);

                // Otoparkta (listede) bu ID'ye sahip arabayı bulup siliyoruz
                for (int i = 0; i < dukkanMuduru.Vehicles.Count; i++)
                {
                    if (dukkanMuduru.Vehicles[i].Id == secilenId)
                    {
                        dukkanMuduru.Vehicles.RemoveAt(i);
                        break; // Arabayı bulup sildik, aramayı bırakıyoruz
                    }
                }

                // Tabloyu yeniliyoruz ki silindiği ekrana yansısın
                dgvAraclar.DataSource = null;
                dgvAraclar.DataSource = dukkanMuduru.Vehicles;

                MessageBox.Show("Araç başarıyla silindi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Lütfen silmek için tablodan bir araç seçin!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                // Önce tablodan bir satır seçilmiş mi diye bakıyoruz
                if (dgvAraclar.CurrentRow != null)
                {
                    // Seçilen satırdaki arabanın ID'sini alıyoruz
                    int secilenId = Convert.ToInt32(dgvAraclar.CurrentRow.Cells[0].Value);

                    // Otoparkta (listede) bu ID'ye sahip arabayı buluyoruz
                    foreach (var arac in dukkanMuduru.Vehicles)
                    {
                        if (arac.Id == secilenId)
                        {
                            // Arabayı bulduk! Şimdi kutulardaki yeni bilgileri arabanın üzerine yazıyoruz
                            arac.Plate = txtPlaka.Text;
                            arac.Brand = txtMarka.Text;
                            arac.Model = txtModel.Text;
                            arac.Year = Convert.ToInt32(txtYil.Text);
                            arac.DailyPrice = Convert.ToDecimal(txtFiyat.Text);
                            break; // Güncelledik, aramayı bırakıyoruz
                        }
                    }

                    // Tabloyu yeniliyoruz ki değişiklik ekranda görünsün
                    dgvAraclar.DataSource = null;
                    dgvAraclar.DataSource = dukkanMuduru.Vehicles;
                    dgvAraclar.Refresh();

                    MessageBox.Show("Araç bilgileri başarıyla güncellendi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Lütfen güncellemek için tablodan bir araç seçin!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Lütfen bilgileri (Özellikle Yıl ve Fiyat kutularını) doğru formatta girdiğinizden emin olun!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                // 1. Kutulardaki yazıları alıyoruz
                string ad = txtAd.Text;
                string soyad = txtSoyad.Text;
                string telefon = txtTelefon.Text;
                string ehliyet = txtEhliyet.Text;

                // 2. Şartname Kuralı: Alanların boş bırakılmasını engelliyoruz
                if (string.IsNullOrWhiteSpace(ad) || string.IsNullOrWhiteSpace(soyad) || string.IsNullOrWhiteSpace(telefon))
                {
                    MessageBox.Show("Lütfen Ad, Soyad ve Telefon alanlarını boş bırakmayınız!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return; // Boşsa işlemi burada kes, aşağıya geçme
                }

                // 3. Yeni Müşteri ID'sini otomatik belirliyoruz
                int yeniId = dukkanMuduru.Customers.Count + 1;

                // 4. Müşteri kalıbımızla yeni müşteriyi üretiyoruz
                Customer yeniMusteri = new Customer(yeniId, ad, soyad, telefon, ehliyet);

                // 5. Müşteriyi dükkan müdürünün rehberine ekliyoruz
                dukkanMuduru.Customers.Add(yeniMusteri);

                // 6. Sağdaki yeni isimli tablomuzu güncelliyoruz
                dgvMusteriListesi.DataSource = null;
                dgvMusteriListesi.DataSource = dukkanMuduru.Customers;

                // 7. Kutuların içini temizliyoruz
                txtAd.Text = "";
                txtSoyad.Text = "";
                txtTelefon.Text = "";
                txtEhliyet.Text = "";

                MessageBox.Show("Müşteri başarıyla eklendi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception)
            {
                MessageBox.Show("Müşteri eklenirken bir hata oluştu!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvMusteriListesi.CurrentRow != null)
                {
                    int secilenId = Convert.ToInt32(dgvMusteriListesi.CurrentRow.Cells[0].Value);

                    for (int i = 0; i < dukkanMuduru.Customers.Count; i++)
                    {
                        if (dukkanMuduru.Customers[i].Id == secilenId)
                        {
                            dukkanMuduru.Customers.RemoveAt(i);
                            break;
                        }
                    }

                    dgvMusteriListesi.DataSource = null;
                    dgvMusteriListesi.DataSource = dukkanMuduru.Customers;

                    MessageBox.Show("Müşteri başarıyla silindi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Lütfen silmek için tablodan bir müşteri seçin!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Müşteri silinirken bir hata oluştu!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvMusteriListesi.CurrentRow != null)
                {
                    int secilenId = Convert.ToInt32(dgvMusteriListesi.CurrentRow.Cells[0].Value);

                    foreach (var musteri in dukkanMuduru.Customers)
                    {
                        if (musteri.Id == secilenId)
                        {
                            musteri.FirstName = txtAd.Text;
                            musteri.LastName = txtSoyad.Text;
                            musteri.Phone = txtTelefon.Text;
                            musteri.LicenseNumber = txtEhliyet.Text;
                            break;
                        }
                    }

                    dgvMusteriListesi.DataSource = null;
                    dgvMusteriListesi.DataSource = dukkanMuduru.Customers;
                    dgvMusteriListesi.Refresh();

                    MessageBox.Show("Müşteri bilgileri başarıyla güncellendi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Lütfen güncellemek için tablodan bir müşteri seçin!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Lütfen bilgileri doğru girdiğinizden emin olun!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            try
            {
                int musteriId = Convert.ToInt32(txtMusteriId.Text);
                int aracId = Convert.ToInt32(txtAracId.Text);
                int gun = Convert.ToInt32(txtGunSayisi.Text);

                // Müşteriyi ve Aracı listeden buluyoruz (Sarı uyarıları önlemek için '?' ekledik)
                Customer? secilenMusteri = null;
                foreach (var m in dukkanMuduru.Customers) { if (m.Id == musteriId) secilenMusteri = m; }

                Vehicle? secilenArac = null;
                foreach (var a in dukkanMuduru.Vehicles) { if (a.Id == aracId) secilenArac = a; }

                // Eğer müşteri veya araç bulunamazsa uyarı ver
                if (secilenMusteri == null || secilenArac == null)
                {
                    MessageBox.Show("Hatalı Müşteri veya Araç ID girdiniz!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // TARİH HESAPLAMA: Başlangıç bugün, bitiş ise girilen gün sayısı kadar sonrası
                DateTime baslangic = DateTime.Now;
                DateTime bitis = baslangic.AddDays(gun);

                // Yeni kiralama kaydını oluşturuyoruz (Sıralama: Id, Müşteri, Araç, Başlangıç, Bitiş)
                int yeniKiraId = dukkanMuduru.Rentals.Count + 1;
                Rental yeniKiralama = new Rental(yeniKiraId, secilenMusteri, secilenArac, baslangic, bitis);

                // Kiralama listesine ekle ve tabloyu güncelle
                dukkanMuduru.Rentals.Add(yeniKiralama);

                dgvKiralamalar.DataSource = null;
                dgvKiralamalar.DataSource = dukkanMuduru.Rentals;

                MessageBox.Show("Kiralama işlemi başarıyla tamamlandı!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception)
            {
                MessageBox.Show("Lütfen tüm kutulara sadece sayısal değerler giriniz!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void button8_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvKiralamalar.CurrentRow != null)
                {
                    int secilenId = Convert.ToInt32(dgvKiralamalar.CurrentRow.Cells[0].Value);

                    for (int i = 0; i < dukkanMuduru.Rentals.Count; i++)
                    {
                        if (dukkanMuduru.Rentals[i].RentalId == secilenId)
                        {
                            dukkanMuduru.Rentals.RemoveAt(i);
                            break;
                        }
                    }

                    dgvKiralamalar.DataSource = null;
                    dgvKiralamalar.DataSource = dukkanMuduru.Rentals;

                    MessageBox.Show("Araç iade alındı ve kiralama kaydı silindi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("İşlem sırasında bir hata oluştu.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}