public class Golpear implements Movimento{   

    Saint golpeador, golpeado;
    private Categoria categoria;
    private int danoTotal;

    public Golpear(Saint golpeador, Saint golpeado)
    {
        this.golpeador = golpeador;
        this.golpeado = golpeado;
        danoTotal = this.danoTotal;
    } 
    
    public int getDanoTotal(){        
        this.danoTotal = golpeador.getProximoGolpe().getFatorDano();

        if(this.golpeador.getArmaduraVestida()){
            danoTotal *= (1 + golpeador.getArmadura().getCategoria().getValor());        
        } 
        return danoTotal;
    }

    public void executar(){
        this.golpeado.perderVida(getDanoTotal());
    }
}
