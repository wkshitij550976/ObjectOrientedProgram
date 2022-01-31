using System;

namespace CarSaleman
{
    class Program
    {
        static void Main(string[] args)
        {
            caresaleman ktj = new caresaleman ("kshitij", "wankhade");
            Console.WriteLine(ktj.fullname);
            ktj.sell();

            webdeveloper webclass = new webdeveloper ("angular6");
            webclass.code();
            webclass.develop();

            // softwaredeveloper softclass= new softwaredeveloper ("java");
            // softclass.code();
            // softclass.develop();

        }
    }
}
