using System;
using System.Net.Http.Headers;



 Console.WriteLine(Min<int>(3,2));
 Max<int>(2,5);
T Min<T>(T val1, T val2) where T : IComparable<T>{

    if(val1.CompareTo(val2) < 0)
        return val1;
    else 
        return val2;
}

T Max<T>(T val1, T val2) where T : IComparable<T>{
    return val2;
}
