namespace plantify.Models
{
    // Customer mewarisi semua atribut dan method dari User
    // (Inheritance)
    public class Customer : User
    {
        // Private Fields

        // Data khusus Customer
        private string nama;
        private string alamat;
        private string noHp;

        // Properties (Encapsulation)

        // Mengakses data nama melalui getter dan setter
        public string Nama
        {
            get { return nama; }
            set
            {
                if (!string.IsNullOrWhiteSpace(value))
                {
                    nama = value;
                }
            }
        }

        // Mengakses data alamat melalui getter dan setter
        public string Alamat
        {
            get { return alamat; }
            set
            {
                if (!string.IsNullOrWhiteSpace(value))
                {
                    alamat = value;
                }
            }
        }

        // Mengakses data nomor HP melalui getter dan setter
        public string NoHp
        {
            get { return noHp; }
            set
            {
                // Nomor HP minimal 10 digit
                if (!string.IsNullOrWhiteSpace(value) && value.Length >= 10)
                {
                    noHp = value;
                }
            }
        }

        // Constructor

        public Customer()
        {

        }

        // Constructor untuk mengisi data Customer
        public Customer(
            int id,
            string nama,
            string email,
            string username,
            string password,
            string alamat,
            string noHp)
        {
            // Property yang diwarisi dari class User
            Id = id;
            Email = email;
            Username = username;
            Password = password;

            // Property milik Customer
            Nama = nama;
            Alamat = alamat;
            NoHp = noHp;
        }

        // Polymorphism

        // Override method abstrak dari class User
        // untuk mengembalikan role Customer
        public override string GetRole()
        {
            return "Customer";
        }
    }
}