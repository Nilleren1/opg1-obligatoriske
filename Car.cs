using System;
using System.Threading;

namespace opg1obl
{
    public class Car
    {
        private string _model;
        private double _price;
        private string _licenseplate;
        private static int _nextId = 1;
        public int Id { get; set; }
        public string Model
        {
            get => _model;
            set
            {
                if (value.Length <= 4) throw new ArgumentException("String must be larger then 3 characters");
                if (string.IsNullOrWhiteSpace(value)) throw new ArgumentNullException();
                _model = value;
            }
        }
        public double Price
        {
            get => _price;
            set
            {
                if (value < 0) throw new ArgumentOutOfRangeException();
                _price = value;
            }
        }
        public string LicensePlate
        {
            get => _licenseplate; set
            {
                if (value.Length <= 1 || value.Length >= 8) throw new ArgumentException("Length of string must be between 2 - 7");
                if (string.IsNullOrWhiteSpace(value)) throw new ArgumentNullException();
                _licenseplate = value;
            }
        }

        public Car(string model, double price, string licensePlate)
        {
            Model = model;
            Price = price;
            LicensePlate = licensePlate;
            Id = Interlocked.Increment(ref _nextId);
            //Id = _nextId++;
        }


        public override string ToString()
        {
            return $"Id: {Id}, Model: {Model}, Price: {Price}, License plate: {LicensePlate}.";
        }
    }
}
