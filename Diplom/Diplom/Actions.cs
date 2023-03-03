using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diplom
{
    public class Actions<T>
    {
        private T model;
        private ObservableCollection<T> collection;

        public Actions(T model)
        {
            this.model = model;
        }

        public Actions()
        {

        }

        public void Add(T item)
        {
            if (model == null) return;
            T i = item;
            collection.Add(i);
        }

        public void Edit()
        {
            if (model == null) return;
        }

        public void Delete()
        {
            if (model == null) return;
        }
    }
}
