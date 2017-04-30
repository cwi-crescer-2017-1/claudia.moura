public class AtaqueDuploFalse implements Movimento{    

    Saint golpeador, golpeado;
    private Sorteador sorteador;
    private Golpear golpe;

    public AtaqueDuploFalse(Saint golpeador, Saint golpeado)
    {
        this.golpeador = golpeador;
        this.golpeado = golpeado;
    }

    private boolean danoDuploFalse() {
        Sorteador sorteador = new DadoFalso(2);
        ChanceUmTerco sorte = new ChanceUmTerco(sorteador);
        return sorte.ChanceUm();
    }  

    public void executar(){
        Movimento golpe = new Golpear(golpeador, golpeado);
        golpe.executar(); //golpe é executado
        if (danoDuploFalse()){  
            golpe.executar(); //golpe é executado novamente              
        }else{
            double cincoPorCento = this.golpeador.getVida() * 0.05;
            this.golpeador.perderVida(cincoPorCento); 
        }
    }

}