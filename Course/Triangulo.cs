using System; // importação de dependências

namespace Course // Namespace da clase
{  
    // Os nomes das Classes devem começar com letra maisculas
    class Triangulo // Nome da classe
    {
        // Os nomes dos atributos dentro da classe começam também comletra mauiscula
        // o public indica que essa classe poe ser acessada por outras classes e arquvos com no caso do main.

        public double A; // atributo
        public double B; // atributo
        public double C; // atributo


        // quando você cria uma classse e depois vai usar a mesma você faz uma isntanciação na memoria daquele objeto que será utilizado 
        // por uma classe para promover determinada solução;
        // quando a classe é somente criada ela fica numa area chamaa stack
        // quando a classe é instanciada ela vai para um area chamada HEAP ( QUE É UMA ÁREA DE ALOCAÇAO DINÂMICA ) NESSE PONTO O OBJETO É CRIADO 
        // E HÁ UMA APONTAMENTO PARA A ÁREA DO HEAP.


    // #### Agora vamos criar alguns métodos para a clase triangulo #####

    // O mome do metodo deve começa com maisculo também assim como o nome da Classe e mesma deve ser public pois irá ser acessado por outras
    // classe.
        
        // A classe não terá nenhum paramêtro de entrada pois os paramentros já se encontram na propria classe com o A,B e C
        public double Area() 
        {
            double p = (A + B + C) / 2.0;

            double raiz = Math.Sqrt(p * (p - A) * (p - B) * (p - C));
            return raiz;

        }




    }



       
}
