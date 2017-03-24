using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Inventario
{
    public string name;
    public Inventario next = null;

    public Inventario(string name)
    {
        this.name = name;
    }
}

namespace ListaEncadeada
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Inventario item1 = new Inventario("Elmo");
            Inventario item2 = new Inventario("Meia");
            Inventario item3 = new Inventario("Bermuda");
            Inventario item4 = new Inventario("Oculos");
            Inventario item5 = new Inventario("Ovo de dragao");
            Inventario item6 = new Inventario("Bigode");
            Inventario item7 = new Inventario("Fone de ouvido");
            Inventario item8 = new Inventario("Mochila de hamburguer");
            Inventario item9 = new Inventario("Caixa de pizza");
            Inventario item10 = new Inventario("Açai");

            item1.next = item2;
            item2.next = item3;
            item3.next = item4;
            item4.next = item5;
            item5.next = item6;
            item6.next = item7;
            item7.next = item8;
            item8.next = item9;
            item9.next = item10;

            Console.WriteLine("Digite o item que você deseja usar");
            string usuarioTxt = Console.ReadLine();
            int i = 0;

            Inventario currentElement = item1;
            while (currentElement != null)
            {
                if (currentElement.name == usuarioTxt)
                {
                    Console.WriteLine("A posição do item é {0}", i);
                    break;
                }
                currentElement = currentElement.next;
                i++;
            }

            if(currentElement == null)
                Console.WriteLine("Esse item não está no inventario");

            Console.ReadKey();
        }
    }
}
