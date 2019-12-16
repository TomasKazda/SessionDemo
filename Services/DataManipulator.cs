using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using SessionDemo.Models;

namespace SessionDemo.Services
{
    public class DataManipulator: IEnumerable<Basket>
    {
        private List<Basket> _listOfBaskets;
        private readonly ISession _session;

        public DataManipulator(IHttpContextAccessor contextAccessor)
        {
            _listOfBaskets = new List<Basket>();
            this._session = contextAccessor.HttpContext.Session;
        }

        public void SaveData()
        {
            _session.Set<List<Basket>>("datakosik", _listOfBaskets);
        }

        public void LoadData()
        {
            if (_listOfBaskets.Count > 0) return;

            _listOfBaskets = _session.Get<List<Basket>>("datakosik");

            if (_listOfBaskets == null) _listOfBaskets = new List<Basket>();
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
