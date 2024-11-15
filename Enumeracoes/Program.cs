using Enumeracoes.Entities;
using Enumeracoes.Entities.Enuns;


namespace Enumeracoes
{
    class Program
    {
        public static void Main(string[] args)
        {
            Order order = new Order
            {
                Id = 1080,
                Moment = DateTime.Now,
                Status = OrderStatus.PendingPayment 
            };
            Console.WriteLine(order);

            string txt = OrderStatus.PendingPayment.ToString(); // converter para string um enum
            Console.WriteLine(txt);

            OrderStatus os = Enum.Parse<OrderStatus>("Delivered");// converter para Enum
            Console.WriteLine(os);

            OrderStatus us = (OrderStatus)Enum.Parse(typeof(OrderStatus), "Delivered"); // outras formas de converter tbm
            Console.WriteLine(us);

            OrderStatus ts;
            Enum.TryParse("Delivered", out ts);

            Console.WriteLine(ts);


        }
    }

}
