using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment01AdvancedC_
{
    #region Q18
    //internal class Counter<T>
    //{

    //    public static int Count = 0;

    //    public Counter()
    //    {
    //        Count++;
    //    }

    //} 
    #endregion

    #region Q19

    //class Base<T>
    //{
    //    public T Value { get; set; }
    //}

    //class Child : Base<int>
    //{
    //}

    #endregion

    #region Q20

    //class CacheItem<T>
    //{
    //    public T Value { get; set; }
    //    public DateTime Expiration { get; set; }
    //}

    //class Cache<T>
    //{
    //    private Dictionary<string, CacheItem<T>> items =
    //        new Dictionary<string, CacheItem<T>>();

    //    public void Add(string key, T value, int seconds)
    //    {
    //        items[key] = new CacheItem<T>
    //        {
    //            Value = value,
    //            Expiration = DateTime.Now.AddSeconds(seconds)
    //        };
    //    }

    //    public T Get(string key)
    //    {
    //        if (!items.ContainsKey(key))
    //            return default(T);

    //        if (DateTime.Now > items[key].Expiration)
    //        {
    //            items.Remove(key);
    //            return default(T);
    //        }

    //        return items[key].Value;
    //    }

    //    public bool Contains(string key)
    //    {
    //        if (!items.ContainsKey(key))
    //            return false;

    //        if (DateTime.Now > items[key].Expiration)
    //        {
    //            items.Remove(key);
    //            return false;
    //        }

    //        return true;
    //    }

    //    public void Remove(string key)
    //    {
    //        items.Remove(key);
    //    }
    //}

    #endregion

}
