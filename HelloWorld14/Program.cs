using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld14
{
    class Program
    {
        //Class: ou classes são tipos referencia, ou seja, não funcionam como caixas, ao instancionar o objeto ele aponta para o lugar onde estão os valores na memória e não cria uma caixa.
        //Structs: ou estruturas são do tipo valor, funcionam como caixas que armazena os valores dentro dela na memória, diferente do ponteiro que aponta para os valores. Ex: declaração de variáveis basicas (double x = 10).
        // também é posível criar o próprio struct, se comporta parecido como uma classe, porém não tem alguns recursos da classe.
        static void Main(string[] args)
        {
            Point p; // Para inicializar a váriavel do tipo point(Struct) não é preciso ser instanciada igual uma classe, 
            p.X = 10;  // pois declarar os valores já criam as caixas direto no stack da memória.
            p.Y = 20;
            Console.WriteLine(p);

            p = new Point(); // Mas também é possível inicializar instanciando
            Console.WriteLine(p);

            // Quando alocamos 'new' em qualquer tipo estruturado (class, struct, array), são atribuiídos valores padrão aos seus elementos:
            // Números: 0
            // bool: false
            // char: caractere com o código '0'
            // objeto: null

            //ps: uma variável apenas declarada (Ex: Point p;) mas não instanciada, inicia em estado "não atribuída" e o próprio compilador não permite que ela seja acessada.
        }
    }
}
