namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("bytove info");
            Console.WriteLine($" short {sizeof(short)} , unshort {sizeof(ushort)} , int {sizeof(int)} , unint {sizeof(uint)} ," +
                $" long {sizeof(long)} , unlong {sizeof(ulong)} , char {sizeof(char)} , float {sizeof(float)}," +
                $" double {sizeof(double)}, decimal {sizeof(decimal)}, byte {sizeof(byte)} , shortbyte {sizeof(sbyte)}");

        }
    }
}
