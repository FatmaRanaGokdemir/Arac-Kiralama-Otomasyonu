# Nesne Quiz Ödevi# Araç Kiralama Otomasyonu

Bu proje, **Nesne Tabanlı Programlama (OOP)** dersi kapsamında C# ve .NET Windows Forms (WinForms) kullanılarak geliştirilmiş bir masaüstü araç kiralama yönetim uygulamasıdır.

##  Özellikler

Uygulama 3 ana modülden oluşmaktadır:

* **Araç Yönetimi:** Sisteme yeni araç ekleme, mevcut araç bilgilerini güncelleme ve silme (CRUD).
<img width="852" height="418" alt="image" src="https://github.com/user-attachments/assets/d44f14c3-ad1b-4d9a-ba59-081cce20b842" />
* **Müşteri Yönetimi:** Müşteri kaydı oluşturma, boş alan doğrulaması (validation), bilgi güncelleme ve kayıt silme.
<img width="765" height="352" alt="image" src="https://github.com/user-attachments/assets/fca2e6dc-9bd7-44d7-8629-ccbc9114ae3d" />
* **Kiralama İşlemleri:** Kayıtlı müşteri ve araç ID'leri ile kiralama oluşturma, gün sayısına göre otomatik başlangıç/bitiş tarihi hesaplama ve araç iade alma.
<img width="968" height="236" alt="image" src="https://github.com/user-attachments/assets/0eeaf73b-6b9a-43bd-9b32-d6b92916f174" />





<img width="471" height="287" alt="image" src="https://github.com/user-attachments/assets/086f6d29-29a5-43d2-9415-3f413e9aa647" />



##  Proje Mimarisi ve OOP Kullanımı

* **Models:** `Vehicle`, `Car` (Kalıtım/Inheritance), `Customer` ve `Rental` sınıfları.
* **Services:** Tüm listeleri ve başlangıç test verilerini yöneten merkezi `RentalManager` sınıfı.
* **Polimorfizm:** `DataGridView` tablolarında nesnelerin okunabilir görünmesi için `Customer` ve `Vehicle` sınıflarında `ToString()` metodu `override` edilmiştir.
<img width="598" height="621" alt="image" src="https://github.com/user-attachments/assets/9381e50e-08ff-4ac9-91aa-00670cf9cc29" />


## Kullanılan Teknolojiler

* **Dil:** C#
* **Arayüz:** Windows Forms (WinForms)
* **IDE:** Visual Studio



