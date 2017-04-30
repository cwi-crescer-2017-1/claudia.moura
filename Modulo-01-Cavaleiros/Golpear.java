public class Golpear implements Movimento{   

    Saint golpeador, golpeado;
    private Categoria categoria;
    private int danoTotal = 1;

    public Golpear(Saint golpeador, Saint golpeado)
    {
        this.golpeador = golpeador;
        this.golpeado = golpeado;
        this.danoTotal = danoTotal;
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
