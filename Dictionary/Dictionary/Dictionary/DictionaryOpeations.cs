using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace DictionaryTask.Dictionary
{
    public class DictionaryOpeations
    {

    Dictionary<int ,string > store = new Dictionary<int ,string>();

        public void AddElement(int id ,string name)
        {
            if(!store.ContainsKey(id))
            {
            store.Add(id ,name);
            }
            else
            {
                Console.WriteLine("id is already entered");
            }
        }

        public Dictionary<int,string> PrintElement()
        {
            return store;
        }

        public bool RemoveElement(int id) {
            if (store.ContainsKey(id))
            {
           store.Remove(id);
                return true;

            }
            else
            {
                return false;
            }
        }

        public string DisplaySingleElement(int id)
        {
            if (store.TryGetValue(id,out string name))
            {
                return $" id{id} ,Name : {name}";
            }
            else
            {
                return null;
            }

        }

        public List<int> ListOfKeys()
        {
            List<int> keys = new List<int>(store.Keys);
            return keys;
        }
        //The Select() method is used to create an anonymous object that contains the index and the value of each item in the list.This is then used as the input to the ToDictionary() method to create a new dictionary.
        public Dictionary<int, string> ListOfString()
        {
            List<string> lists = new List<string>(store.Values);
            Dictionary<int, string> valuePairs = lists.Select((item, index) => new { Index = index, Value = item }).ToDictionary(x => x.Index, x => x.Value);

            return valuePairs;
        }
       

    }
}
