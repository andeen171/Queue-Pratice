Queue pedido = new Queue(100);
Queue pagamento = new Queue(100);
Queue encomenda = new Queue(100);
bool run = true;
string input;
int code = 0;
Console.WriteLine(@"
1 - Inserção de cliente na fila de pedidos
2 - Remoção de cliente da fila de pedidos
3 - Remoção de cliente da fila de pagamentos
4 - Remoção de cliente da fila de encomendas
5 - Sair");
while (run)
{
    int _code;
    input = Console.ReadLine() ?? "";
    switch (input)
    {
        case "1":
            if (pedido.IsFull())
                Console.WriteLine("A fila de pedidos está cheia");
            else
            {
                pedido.Enqueue(code);
                Console.WriteLine($"O Cliente {code} entrou na fila de pedidos!");
                code++;
            }
            break;
        case "2":
            if (pedido.IsEmpty())
                Console.WriteLine("A fila de pedidos está vazia!");
            else if (pagamento.IsFull())
                Console.WriteLine("A fila de pagamentos está cheia!");
            else
            {
                _code = pedido.Dequeue();
                pagamento.Enqueue(_code);
                Console.WriteLine($"O Cliente {_code} saiu da fila de pedidos e foi para a fila de pagamentos!");
            }
            break;
        case "3":
            if (pagamento.IsEmpty())
                Console.WriteLine("A fila de pagamentos está vazia!");
            else if (encomenda.IsFull())
                Console.WriteLine("A fila de encomendas está cheia!");
            else
            {
                _code = pagamento.Dequeue();
                encomenda.Enqueue(_code);
                Console.WriteLine($"O Cliente {_code} saiu da fila de pagamentos e foi para a fila de encomendas!");
            }
            break;
        case "4":
            if (encomenda.IsEmpty())
                Console.WriteLine("A fila de pagamentos está vazia!");
            else
            {
                _code = encomenda.Dequeue();
                Console.WriteLine($"O Cliente {_code} saiu da fila de encomendas!");
            }
            break;
        case "5":
            run = false;
            break;
        case "help":
        case "menu":
            Console.WriteLine(@"
1 - Inserção de cliente na fila de pedidos
2 - Remoção de cliente da fila de pedidos
3 - Remoção de cliente da fila de pagamentos
4 - Remoção de cliente da fila de encomendas
5 - Sair");
            break;
        default:
            Console.WriteLine("Digite uma das opções!");
            break;
    }
}