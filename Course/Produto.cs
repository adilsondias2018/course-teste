using System;
using System.Globalization;

namespace Course
{
    class Produto
    { 

        // Até esse momento não trabalhamos com o conceito de encapsulamento, pois ainda não foi necessário o uso privativo das variáveis
        // Nesse o programador pode acessar e alterar o valor de um variável e vários pontos do progrma. 
        // Como impedir que isso aconteça?

        public string Nome;
        public double Preco;
        public int Quantidade;

        /* ############## ENCAPSULAMENTO ######################
         * Para trazer mais segurança para nosso código e impedir que ele sofra alterações indesejadas
         * vamos trabalhar vamos " encapsular nossos objetoss
         *
         * ### CONVENÇAO### Geralmente sempre utilizamos o _ seguindos de minusculo para definir os nomes dos atributos
         * 
         */
         // O # PRIVATE  faz com que os arquivos fiquem protegidos

         private string _nome;
         private double _preco;
         private int _quantidade;

        // para que esse atributos possam ser acessados é necessário usar o Get e Set para permitir que esse procedimento ocorra.




       /* ############## CONSTRUTORES ######################
        * É uma operaçao especial da classe, que executa no momento da instanciação do objeto
        * Uso comuns para os constrututores
        * # iniciar valores dos atributos
        * # Permitir ou obrigar que o objeto receba dados/dependência no momento de sua instatnciação(Injeção de dependência)
        * 
        * # ser não for criado um construtor ele começa com valores padrões.
        * 
        * # É possível especificar mais um de um construtor na mesma classe são chamados os ## SOBRECARGA##
        *   ### CONVENÇAO### Geralmente veem sempre após os atriuboS
        *   ### CONVENÇAO### E O NOME DEVE SER O MESMO DA CLASSE
        */

       // GERANDO OS CONSTRUTORES

       // Gerando um construtor padrão com a opção de sobre carga.

       // abaixo temos um construtor normal igual ao do outro exercicios

       // ==== ocultando o código temporariamente ====
       /*
       public Produto (string nome,double preco, int quantidade)
        {
            Nome = nome;
            Preco = preco;
            Quantidade = quantidade;


        }
        */
        // vamos fazer aqui um construtor recebendo os atriubos que estão encapsulados

            public Produto ( string nome, double preco, int quantidade)
        {
            _nome = nome;
            _preco = preco;
            _quantidade = quantidade;
        }

        // agora quqe criamos o construtor vamos fazer com eles sejam acessado pelo meto Get e Set

        //## GET

        public string GetNome()
        {
            return _nome;
        }

        // ### SET == COM O SET INFORMO QUE QUERO ALTERAR  O NOME EXISTENTE 
        public void SetNome(string nome)
        {  
            // Por quê fazer iso, uma coisa boa é que se quiser criar uma lógica especifica para entrada do valor você pode po exemplo.

            if(nome != null && nome.Length> 1 )
            _nome = nome;

        }

        // ## IMPORTANTE: Perceba que abaixo temo os metodo Get para preço e quantida, porém não tempos o o metodo Set.
        // Isso quer dizer que se quisermos acessarmos o valor quantidade e preço podemos, PORÉM NÃO podemos alterar os valores 
        // PARA ISSO IRIAMOS PRECISAR TER O  METODOS SET PARA O PREÇO E QUANTIDADE. 
        // lEGAL NÉ.
        public double GetPreco()
        {
            return _preco;
        }
        
        public int GetQuantidade()
        {
            return _quantidade;
        }

        // ===================
        /*#### PROPRIEDADES OU PROPERTIES #########
         * Na implementação acima dos encapssulamento foi possível perceber que a segurança aumenta muito, porém fica cansativo ter 
         * que criar um metodo set e get para cada atributo da classe para que esse possa ser acessado ou alterado e alem da formada 
         * de passar os dados que fica mais dificil. 
         * 
         *  ## COMO RESOLVER ISSO!?####
         * 
         * PARA ISSO SURGIRAM A PROPRIEDADES OU PAS PROPERTIES #### ALELUIA
         *   
         */

          // Os atributos das classes continuam declarados do mesmo jeito. A grande mudança acontece na de declar os metodos
          // ## CONFIRA ####

          public string NomeProprieties
        {
            get { return _nome; }
            set {
                // obser ser que antes faziamos a logica ulizando _nome da classe e um outro parametro nome agora mudou
                //if (nome != null && nome.Length > 1)
                //    _nome = nome;
                // ===== NO LUGAR DO PARAMENTRO NOME COLOCA-SE O VALUE

                if(value != null && value.Length > 1){
                    _nome = value;
                }

                // LEGAL NÉ E DETALHE AGORA TENHO COM UM ÚNICO METODO O GET E SET.

                // COMO ISSO ELIMINO A NECESSIDADE DO METODO GET E SET. ACIMA 

            }

        }

        // VAMOS FAZER A MESMA COISA PARA OS OUTROS 

           public double PrecoPropertiess
        {
            get { return _preco; }
        }
        public int QuantidadeProperties
        {
            get { return _quantidade; }
        }
         
        // perceba que temos a mesma coisa porém muito mais fácil com as properties;         

        // ## Realizando uma sobrecarga no construtor Produto

        public Produto()
        {

        }

            public Produto(string nome, double preco)
        {
            Nome = nome;
            Preco = preco;
            Quantidade = 0; // Nesse caso é opcional poderia não colorar e quantidade iria assumir o valor zero.

           
        }




        // Metódo para verficar o valor em estoque
        public double ValorTotalEmEstoque()
        {
            return Quantidade * Preco;
            

            
        }

        // os parametros de entrada são escrito em minusculo como pode ser observdo no caso abaixo
        public void AdcionarProduto(int quantidade )
        {
            Quantidade = Quantidade + quantidade;
        }
          
        public void RemoverProdutos(int quantidade)
        {
            Quantidade = Quantidade - quantidade;
        }

        // vamos utilizar o método toString para converter um objeto em string, pois é um dos principais papeis dessa classe.

        public override string ToString()
        {
            return Nome
                + ",$ "
                + Preco.ToString("F2", CultureInfo.InvariantCulture)
                + Quantidade
                + "unidades, Total: $"
                + ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture);

        }       
    }
}
