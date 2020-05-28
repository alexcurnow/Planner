using System;

namespace Planner
{
    public class Building
    {
        private string _designer = "Alexander R. Curnow";
        private DateTime _dateConstructed;
        private string _address;
        private string _owner;
        public int Stories { get; set; }
        public double Width { get; set; }
        public double Depth { get; set; }
        public double Volume
        {
            get
            {
                return Width * Depth * (3 * Stories);
            }
        }

        public Building(string address)
        {
            _address = address;
        }

        public void Construct()
        {
            _dateConstructed = DateTime.Now;
        }

        public void Purchase(string purchaser)
        {
            _owner = purchaser;
        }

        public string GetAddress()
        {
            return _address;
        }

        public string GetDateConstructed()
        {
            return $"Constructed on {_dateConstructed}";
        }

        public string GetDesigner() => $"Designed by {_designer}";

        public string GetOwner() => $"Owned by {_owner}";

        public string GetVolume() => $"{Volume} cubic meters of space";
    }
}