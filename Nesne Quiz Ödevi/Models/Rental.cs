using Nesne_Quiz_Ödevi.Models;
using System;

namespace Nesne_Quiz_Odevi.Models
{
    public class Rental
    {
        // 1. Gizli alanlarımız (Sözleşme detayları)
        private int _rentalId;
        private Customer _customer = null!; // Söz veriyorum dolacak!
        private Vehicle _vehicle = null!;   // Söz veriyorum dolacak!
        private DateTime _startDate;
        private DateTime _endDate;
        private string _status = string.Empty;
        private decimal _totalPrice;

        // 2. Güvenli kapılar (Property'ler)
        public int RentalId { get { return _rentalId; } set { _rentalId = value; } }
        public Customer Customer { get { return _customer; } set { _customer = value; } }
        public Vehicle Vehicle { get { return _vehicle; } set { _vehicle = value; } }
        public DateTime StartDate { get { return _startDate; } set { _startDate = value; } }
        public DateTime EndDate { get { return _endDate; } set { _endDate = value; } }
        public string Status { get { return _status; } set { _status = value; } }
        public decimal TotalPrice { get { return _totalPrice; } set { _totalPrice = value; } }

        // Toplam günü otomatik hesaplayan akıllı kapı (Sadece okunabilir)
        public int TotalDays
        {
            get
            {
                // İki tarih arasındaki farkı buluyoruz
                TimeSpan fark = EndDate - StartDate;
                int gun = fark.Days;

                // Eğer adam aynı gün iade ediyorsa (0 gün çıkarsa), en az 1 günlük para alalım
                if (gun <= 0) gun = 1;

                return gun;
            }
        }

        // 3. Sözleşme oluşturma makinesi (Constructor)
        public Rental(int rentalId, Customer customer, Vehicle vehicle, DateTime startDate, DateTime endDate)
        {
            RentalId = rentalId;
            Customer = customer;
            Vehicle = vehicle;
            StartDate = startDate;
            EndDate = endDate;

            // Sözleşme ilk imzalandığında durumu "Aktif" (Kirada) olur
            Status = "Aktif";

            // Ücreti, aracın (Vehicle) kendi hesaplama metoduna gün sayısını yollayarak buluyoruz!
            TotalPrice = vehicle.CalculateRentalPrice(TotalDays);
        }
    }
}