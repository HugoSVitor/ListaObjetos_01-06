using System;
using System.Collections.Generic;
using ListaObjetos0106.Classes;

namespace ListaObjetos0106
{
    class Program
    {
        static void Main(string[] args)
        {
            // Criando a Lista
            List<Produto> produtos = new List<Produto>();

            // Adicionamos produtos através de instâncias com construtores
            produtos.Add(new Produto(1, "Apple Watch", 3522.56f));
            produtos.Add(new Produto(2, "Xiaomi Watch", 1522.45f));
            produtos.Add(new Produto(3, "Zenfone ASUS", 2522.87f));
            produtos.Add(new Produto(4, "Samsung", 2522.87f));
            produtos.Add(new Produto(5, "Motorola GB", 2522.87f));

            // Ou através de instância básicas e suas atribuições
            Produto iphone = new Produto();
            iphone.Codigo = 6;
            iphone.Nome = "Iphone XII";
            iphone.Preco = 8952.45f;

            produtos.Add(iphone);

            // Podemos mostrar tudo no foreach
            foreach (Produto p in produtos)
            {
                Console.WriteLine($"Nome do Produto = {p.Nome} - Preço do Produto = R${p.Preco}");
            }

            // Podemos remover itens através de seu indice de array:
            // Linha removida na posição 3 do array: Produto(4, "Samsung", 2522.87f);
            produtos.RemoveAt(3);

            // Também podemos remover um produto de lista usando expressão lambda e o método removeAll:
            // Linha removida Produto(1, "Apple Watch", 3522.56f);
            produtos.RemoveAll(x => x.Nome == "Apple Watch");

            Console.WriteLine("\nLista alterada: ");

            // Checamos se realmente foi removido
            foreach (Produto p in produtos)
            {
                Console.WriteLine($"Nome do Produto = {p.Nome} - Preço do Produto = R${p.Preco}");
            }
        }
    }
}
