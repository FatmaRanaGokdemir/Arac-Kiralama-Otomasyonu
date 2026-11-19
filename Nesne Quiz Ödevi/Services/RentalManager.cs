using Nesne_Quiz_Odevi.Models; // Modellerimizi (Car, Customer vs.) kullanabilmek için ekledik
using Nesne_Quiz_Ödevi.Models;
using System.Collections.Generic;

namespace Nesne_Quiz_Odevi.Services
{
    public class RentalManager
    {
        // 1. Otoparkımız (İçinde Vehicle yani Araç tutan bir liste)
        public List<Vehicle> Vehicles { get; set; } = new List<Vehicle>();

        // 2. Müşteri Rehberimiz (İçinde Customer tutan bir liste)
        public List<Customer> Customers { get; set; } = new List<Customer>();

        // 3. Sözleşme Dolabımız (İçinde Rental tutan bir liste)
        public List<Rental> Rentals { get; set; } = new List<Rental>();

        // Constructor: Dükkan ilk açıldığında (Program çalıştığında) çalışır
        public RentalManager()
        {
            // Şartnamede "Örnek kayıtlar kullanılabilir" diyor. Ekranımız boş kalmasın diye dükkana 2 araba, 1 müşteri ekleyelim.
            Vehicles.Add(new Car(1, "34 ABC 123", "Toyota", "Corolla", 2022, 1000));
            Vehicles.Add(new Car(2, "06 DEF 456", "Ford", "Focus", 2021, 900));

            Customers.Add(new Customer(1, "Ahmet", "Yılmaz", "05551112233", "A123456"));
        }
    }
}