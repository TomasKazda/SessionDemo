using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SessionDemo.Models;

namespace SessionDemo.Services
{
    public class DataManipulator: IEnumerable<Basket>
    {
        private List<Basket> _listOfBaskets;

        public DataManipulator()
        {
            _listOfBaskets = new List<Basket>();
        }

        public void AddItem(Basket basket)
        {
            _listOfBaskets.Add(basket);
        }

        public IEnumerator<Basket> GetEnumerator()
        {
            return ((IEnumerable<Basket>)_listOfBaskets).GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return ((IEnumerable<Basket>)_listOfBaskets).GetEnumerator();
        }
    }
}
