using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace fibonacci
{
    public class FibonacciManager
    {
        float ort = 0;
        public float fiboArrAdd(List<int>list, int depth){
        for(int i = 2 ; i < depth; i++){
            list.Add(list[list.Count-1]+list[list.Count-2]);
        }
        foreach(int item in list){
            ort += item;
        }
        return ort / depth;
        }
    }
}