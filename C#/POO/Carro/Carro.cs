namespace Carro
{
    class Carro{

        int ano;
        string placa;
        string marca;
        string cor;
        bool motorLigado;

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

    }
    
}