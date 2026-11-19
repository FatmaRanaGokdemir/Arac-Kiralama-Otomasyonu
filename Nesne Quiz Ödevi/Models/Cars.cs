
using System;

namespace Nesne_Quiz_Ödevi.Models
{
    public class Car : Vehicle
    {
        // Constructor
        public Car(int id, string plate, string brand,
            string model, int year, decimal dailyPrice)
            : base(id, plate, brand, model, year, dailyPrice)
        {
        }

        // Abstract metodu uyguluyoruz
        public override decimal CalculateRentalPrice(int days)
        {
            if (days <= 0)
            {
                throw new ArgumentException(
                    "Kiralama günü sıfırdan büyük olmalıdır!");
            }

            return DailyPrice * days;
        }
    }
}
