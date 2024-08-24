using Bookstore;

namespace Program
{
    public class Exercises
    {
        public static void Main()
        {
            //Products
            var book_1 = new Product("A Rainha Vermelha - Vol 1.", 59.90f);
            var book_2 = new Product("A Rainha Vermelha - Espada de Vidro Vol 2.", 59.90f);
            var book_3 = new Product("A Rainha Vermelha - A Prisão do Rei Vol 3.", 59.90f);
            var book_4 = new Product("A Rainha Vermelha - Tempestade de Guerra Vol 4.", 59.90f);
            var book_5 = new Product("A Rainha Vermelha - Coroa Cruel Contos", 59.90f);
            var book_6 = new Product("A Rainha Vermelha - Trono Destruido Coletanea Completa", 39.90f);
            var book_7 = new Product("O Pequeno Principe", 34.90f);
            var book_8 = new Product("O Homem do Castelo Alto", 54.90f);

            //Clients
            var luiz = new Client("Luiz Miguel Cardoso Mroczko", "Luizc.mroczko@gmail.com");

            //Cart
            var myCart = new Cart(luiz);

            myCart.AddProduct(book_1);
            myCart.AddProduct(book_3);
            myCart.AddProduct(book_4);
            myCart.AddProduct(book_6);
            myCart.AddProduct(book_7);

            //Show info
            Console.WriteLine($"Order #1785\n------------------------------\n");
            luiz.ShowInfo();
            Console.WriteLine("\n------------------------------\n");
            foreach (var item in myCart.Products)
            {
                Console.WriteLine($"Name: {item.Name} - Price: R$ {item.Price}");
            }
        }
    }
}