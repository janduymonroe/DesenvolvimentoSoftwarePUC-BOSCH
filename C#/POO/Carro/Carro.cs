namespace Carro
{
    class Carro{

        public int ano {get;set;}
        public string placa {get; set;}
        public string marca {get;set;}
        public string cor {get;set;}
        bool motorLigado{get;set;}

        public void ligarMotor(){
            motorLigado = true;
        }
        public void acelerar(){
            if (motorLigado == true){
            System.Console.WriteLine("VRUMMMM!");
            } else {
                System.Console.WriteLine("Carro não está ligado.");
            }
        } 
        public void desligarMotor(){
            motorLigado = false;
        }

        public override string ToString()
        {
            var motor = motorLigado ? "ligado" : "desligado";
            return $"O seu carro {marca}, ano {ano}, cor {cor}, placa {placa} está {motor}.";
        }

    }
    
}