using System;
using System.Collections.Generic;
using System.Text;

namespace Zadanie3
{
    internal class Skin
    {
        private string _rarity;
        private string _name;
        private decimal _price;
        public virtual string Rarity
        {
            get
            {
                return _rarity;
            }
            set
            {
                _rarity = value;
            }
        }
        public virtual string Name
        {
            get
            {
                return _name;
            }
            set 
            { 
                _name = value; 
            }
        }
        public virtual decimal Price
        {
            get
            {
                return _price;
            }
        }
        public Skin(string rarity, decimal price)
        {
            _rarity = rarity;
            _price = price;
        }
    }
}
