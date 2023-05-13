using System;
using System.Threading.Tasks;

namespace  DotnetTuplaTernarioObjeto.Models
{
    /// <summary>
    /// 
    /// </summary>
    public class Pessoa
    {
        //Construtor sem parametros
        public Pessoa(){

        }

        //Construtor com parametros
        public Pessoa(string nome,string sobrenome){
            Nome = nome;
            Sobrenome = sobrenome;
        }

        private string _nome;
        
        public string Nome { 
            
            get => _nome.ToUpper();

            set {

                if(value =="")
                    throw new ArgumentException("O nome não pode ser vazio");

                _nome = value;
            } 

        }

        private int _idade ;
        public int Idade { 
            get => _idade;
            set{
                if(value <0)
                    throw new ArgumentException("A idade não pode ser menor que zero");

                _idade=value;
            }
        }

        private string _sobrenome;
        public string Sobrenome { 
            
            get => _sobrenome.ToUpper();

            set {

                if(value =="")
                    throw new ArgumentException("O sobrenome não pode ser vazio");

                _sobrenome = value;
            } 
        }

        public string NomeCompleto { get => Nome + " " + Sobrenome; }
        
        public void Apresentar(){
            Console.WriteLine($"Nome: {Nome} , Idade {Idade}");
            Console.WriteLine($"Nome Completo: {NomeCompleto}, Idade {Idade}");
        }

        public void Deconstruct( out string nome, out string sobrenome){
            nome = Nome;
            sobrenome  = Sobrenome;
        }
    }
}
