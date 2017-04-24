public class Batalha {
    int contadorBatalha = 0;
    // variáveis de instância
    private Saint saint1, saint2;
    public Batalha(Saint saint1, Saint saint2) throws Exception{
        this.saint1 = saint1;
        this.saint2 = saint2;
    }

    public void iniciarBatalha()  throws Exception  {
        if(saint1.getArmadura().getCategoria().getValor() < saint2.getArmadura().getCategoria().getValor()) {
            contadorBatalha = 1; //nesse caso a batalha começa com o saint2
        }

        do {
            if( contadorBatalha % 2 == 0 ){
                //saint1 ataca
                saint1.getProximoMovimento().executar();
            } else {
                //saint2 ataca
                saint2.getProximoMovimento().executar();
            }
            contadorBatalha += 1;
        } while((saint1.getVida() > 0) && (saint2.getVida() > 0));
    }
}