
using System;

namespace Nesne_Quiz_Ödevi.Models
{
    public abstract class Vehicle
    {
        // 1. Private alanlar
        private int _id;
        private string _plate = string.Empty;
        private string _brand = string.Empty;
        private string _model = string.Empty;
        private int _year;
        private decimal _dailyPrice;
        private bool _isAvailable;

        // 2. Property yapıları
        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }

        public string Plate
        {
            get { return _plate; }
            set { _plate = value; }
        }

        public string Brand
        {
            get { return _brand; }
            set { _brand = value; }
        }

        public string Model
        {
            get { return _model; }
            set { _model = value; }
        }

        public int Year
        {
            get { return _year; }
            set { _year = value; }
        }

        public decimal DailyPrice
        {
            get { return _dailyPrice; }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException(
                        "Günlük kira ücreti sıfırdan büyük olmalıdır!");
                }

                _dailyPrice = value;
            }
        }

        public bool IsAvailable
        {
            get { return _isAvailable; }
            set { _isAvailable = value; }
        }

        // 3. Constructor
        protected Vehicle(int id, string plate, string brand,
            string model, int year, decimal dailyPrice)
        {
            Id = id;
            Plate = plate;
            Brand = brand;
            Model = model;
            Year = year;
            DailyPrice = dailyPrice;
            IsAvailable = true;
        }

        // 4. Abstract metot
        public abstract decimal CalculateRentalPrice(int days);
    
public override string ToString()
        {
            return Brand + " " + Model + " (" + Plate + ")";
        }
    } }
