using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demos.Day4.ConsoleApp.Collections
{

    // arraylist
   
    public class NewList<T> : IEnumerable<T>
    {
        private T[] _objects;

        public NewList()
        {
            _objects = new T[0];

        }
        public NewList(int count)
        {
            _objects = new T[count];
        }

        public void Add(T newItem)
        {
            
            // nieuwe array aanmaken
            var length = _objects.Length;
            var newArray = new T[length + 1];

            // kopieer alle items uit oude array naar nieuwe
            for (var i = 0; i < length; i++)
            {
                newArray[i] = _objects[i];
            }
            newArray[length] = newItem;

            // wissel de arrays
            _objects = newArray;

        }

        public T Get(int index)
        {
            return _objects[index];
        }

        public void Clear()
        {

        }
        // public IEnumerator GetEnumerator()
        // public IEnumerator<T> GetEnumerator()
        public IEnumerator GetEnumerator()
        {
            return _objects.GetEnumerator();
        }

        IEnumerator<T> IEnumerable<T>.GetEnumerator()
        {
            return ((IEnumerable<T>)_objects).GetEnumerator();
        }

    }

    public class Werknemer
    {
        public string Id { get; set; }

        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string Address3 { get; set; }

        public IEnumerable GetAddresses()
        {
            if (Address1 != null)
                yield return Address1;

            if (Address2 != null)
                yield return Address2;

            if (Address3 != null)
                yield return Address3;
        }

    }


    internal static class CollectionsDemos
    {
        public static void DoYieldDemo()
        {
            var werknemer = new Werknemer();
            werknemer.Address1 = "kerkstraat";
            werknemer.Address3 = "dorpsstraat";

            foreach (var address in werknemer.GetAddresses())
            {
                Console.WriteLine(address);

                break;
            }

            return;
        }

        public static void DoListDemo()
        {
            var list = new List<int>();
            var dict = new Dictionary<string, Werknemer>();
            var set = new HashSet<string>();

            // lijst van ints
            var myList = new NewList<int>();
            myList.Add(5);
            int firstValue = myList.Get(0);

            // lijst van strings
            var myStringList = new NewList<string>();
            myStringList.Add("abc");
            //myStringList.Add(true);
            string firstString = myStringList.Get(0);


            //myList.Add("abc");
            //myList.Add(true);

            foreach (var item in myList)
            {
                Console.WriteLine(item);

            }

            return;
        }

        public static void DoDictionaryDemo()
        {
            Dictionary<string, Werknemer> dic = new Dictionary<string, Werknemer>();

            var werknemer = new Werknemer();
            werknemer.Id = "Erik";

            dic.Add("Erik", werknemer);
        }
    }
}


// array
// list
// linkedlist
// stack // LIFO
// queue // FIFO
// hashset // makkelijk kijken of object al bestaat
// hashmap/map/dictionary // key value pairs

