public class Golpear implements Movimento{   

    Saint golpeador, golpeado;
    private Categoria categoria;
    private int fatorDano;

    public Golpear(Saint golpeador, Saint golpeado)
    {
        this.golpeador = golpeador;
        this.golpeado = golpeado;
        this.fatorDano = golpeador.getProximoGolpe().getFatorDano();

    } 

    public void executar(){
        if(this.golpeador.getArmaduraVestida()){
            fatorDano *= (1 + golpeador.getArmadura().getCategoria().getValor());        
        }
         this.golpeado.perderVida(fatorDano);

    }
}
