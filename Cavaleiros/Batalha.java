public class Batalha
{
    // variáveis de instância
    private Saint saint1, saint2;


        public Batalha(Saint saint1, Saint saint2){
        this.saint1 = saint1;
        this.saint2 = saint2;
       
    }

       public void iniciarBatalha()    {
         
       if(saint1.getArmadura().getCategoria().getValor() < saint2.getArmadura().getCategoria().getValor()) {
            saint1.perderVida(10);
        } else {
            saint2.perderVida(10);
        }      
        
    }
}