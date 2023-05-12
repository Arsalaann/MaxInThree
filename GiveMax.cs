namespace FindMax{
    public class GiveMax<T> where T : IComparable{
        public static T MaxNum(T a,T b,T c){
            if(a.CompareTo(b)>=0 && a.CompareTo(c)>=0)
                return a;
            else if(b.CompareTo(c)>=0)
                return b;
            else 
                return c;
        }
    }
}