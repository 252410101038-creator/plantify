namespace plantify.Models
{
    public class Admin : User //inherit dari User, karena Admin adalah jenis User
    {
        public Admin()
        {
        }

        public override string GetRole() //polymorphism untuk mendapatkan role user, nanti bisa digunakan untuk membedakan akses antara Admin dan Customer
        {
            return "Admin";
        }
    }
}