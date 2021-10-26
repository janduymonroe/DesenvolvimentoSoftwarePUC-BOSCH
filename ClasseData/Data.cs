using System;
using System.Linq;
namespace ClasseData
{
    public class Data
    {
        string dia = DateTime.Now.ToString("dd");
        string mes = DateTime.Now.ToString("MM");
        string ano = DateTime.Now.ToString("yyyy");
        
        

        public void DefineFormato(string rawData)
        {
           string retorno = "";
           int qtDia = 2, qtMes = 2, qtAno = 4;
           for (int i = rawData.Length-1; i>=0; i--){
               if (rawData[i]=='d'){
                   if (qtDia == 2){
                       retorno += dia[1]; 
                       qtDia--;
                   } else if (qtDia == 1){
                       retorno += dia[0];
                       qtDia--;
                   } else {
                       retorno += '0';
                   }
               } else if (rawData[i]=='m'){
                   if (qtMes== 2){
                       retorno += mes[1];
                       qtMes--; 
                   } else if (qtMes == 1){
                       retorno += mes[0];
                       qtMes--;
                   } else {
                       retorno += '0';
                   }
               } else if (rawData[i]=='a'){
                   if (qtAno == 4){
                       retorno += ano[3];
                       qtAno--;
                   } else if (qtAno==3){
                       retorno += ano[2];
                       qtAno--;
                   } else if (qtAno==2){
                       retorno += ano[1];
                       qtAno--;
                   } else if (qtAno==1){
                       retorno += ano[0];
                       qtAno--;
                   } else {
                       retorno += '0';
                   }
               } else {
                   retorno += rawData[i];
               }
           }
           string retornoCorreto = new string(retorno.Reverse().ToArray());

           

           Console.WriteLine(retornoCorreto);

        }

    }

    

}