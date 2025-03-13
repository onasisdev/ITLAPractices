namespace FourthTask
{
    public class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Libro libro = new Libro("", "", "", "", "");
                libro.FuncionPrestamo();
                libro.FuncionDevolucion();
                libro.ToString();
            }
            catch (FormatException)
            {
                Console.WriteLine("El formato que ha ingresado no es válido.");
            } 
        }
    }

    public class Libro
    {
        public int WantToBorrowOrReturnABook { get; set; }
        public string BorrowedBook { get; set; }
        public string ReturnedBook { get; set; }
        public string IsBorrowed { get; set; }
        
        public string IsReturned { get; set; }

        public string BookTitle { get; set; }
     

        public Libro()
        {
            WantToBorrowOrReturnABook = 0;
        }

        public Libro(string borrowedBook, string returnedBook, string isBorrowed, string isReturned, string bookTitle)
        {
            this.BorrowedBook = borrowedBook;
            this.ReturnedBook = returnedBook;
            this.IsBorrowed = isBorrowed;
            this.IsReturned = isReturned;
            this.BookTitle = bookTitle;
        }

        public void FuncionPrestamo()
        {
            Console.WriteLine("¿Desea tomar un libro prestado? 1.Sí 2.No");
            WantToBorrowOrReturnABook = Convert.ToInt32(Console.ReadLine());

            if (WantToBorrowOrReturnABook == 1)
            {
                Console.WriteLine("Por favor ingrese el nombre del libro que desea tomar prestado:");
                BorrowedBook = Convert.ToString(Console.ReadLine());
                IsBorrowed = "Sí";
                BookTitle = BorrowedBook;

            } else
            {
                IsBorrowed = "No ha tomado un libro prestado.";
            } 
        }

        public void FuncionDevolucion()
        {
            Console.WriteLine("¿Desea devolver un libro? 1.Sí 2.No");
            WantToBorrowOrReturnABook = Convert.ToInt32(Console.ReadLine());

            if (WantToBorrowOrReturnABook == 1)
            {
                Console.WriteLine("Por favor ingrese el nombre del libro que desea devolver:");
                ReturnedBook = Convert.ToString(Console.ReadLine());
                IsReturned = "Sí";
                BookTitle = ReturnedBook;

            } else
            {
                IsReturned = "No ha devuelto un libro.";
            }

            if (ReturnedBook.ToLower() == BorrowedBook.ToLower())
            {
                BorrowedBook = string.Empty;
                IsBorrowed = "No";
                IsReturned = "Sí";
            }

            if (ReturnedBook == string.Empty && BorrowedBook == string.Empty)
            {
                IsBorrowed = "No ha tomado un libro prestado.";
                IsReturned = "No ha devuelto un libro.";
            }
        }

        public void ToString()
        {
            Console.WriteLine($"""
                Titulo del libro: {BookTitle} 
                ¿Esta Prestado? {IsBorrowed}
                ¿Esta devuelto? {IsReturned}
                """);
        }
    }
}
