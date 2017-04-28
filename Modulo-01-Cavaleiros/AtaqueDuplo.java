import java.util.Random;

public class AtaqueDuplo implements Movimento{

    Saint golpeador, golpeado;
    private int danoDuplo;
    int min = 1, max = 3;

    public AtaqueDuplo(Saint golpeador, Saint golpeado)
    {
        this.golpeador = golpeador;
        this.golpeado = golpeado;
        //this.danoDuplo = golpeador.getProximoGolpe().getFatorDano();
    }

    public void executar(){
       
    }
}