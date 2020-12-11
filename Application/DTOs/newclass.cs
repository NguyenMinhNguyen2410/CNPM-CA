using System.Reflection;  // reflection namespace

namespace Application.DTOs
{
    public class newclass
    {
        public void AA(){
            // get all public static properties of MyClass type
            // PropertyInfo[] propertyInfos;
            var propertyInfos = typeof(ThuongHieuDTO).GetProperties();
            // write property names
        }
    }
}