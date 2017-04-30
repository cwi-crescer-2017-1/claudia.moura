import java.util.Random;

public class AtaqueDuplo implements Movimento{

    Saint golpeador, golpeado;
    private Sorteador sorteador;
    private Golpear golpe;

    public AtaqueDuplo(Saint golpeador, Saint golpeado)
    {
        this.golpeador = golpeador;
        this.golpeado = golpeado;
    }

    private boolean danoDuplo() {
        Sorteador sorteador = new DadoD6();
        ChanceUmTerco sorte = new ChanceUmTerco(sorteador);
        return sorte.ChanceUm();
    }  

    public void executar(){
        Movimento golpe = new Golpear(golpeador, golpeado);
        golpe.executar(); //golpe é executado
        if(danoDuplo()){  
            golpe.executar(); //golpe é executado novamente              
        }else{
           double cincoPorCento = this.golpeador.getVida() * 0.05;
            this.golpeador.perderVida(cincoPorCento); 
        }
    }
}
/*Implemente um Movimento de ataque duplo que siga a regra abaixo:
 * 
O movimento recebe um golpeador e um golpeado (assim como é no golpear atual) no construtor.
O golpeador tem 33.3% de chance de desferir um ataque com o dobro do dano (que deve seguir as regras normais de dano, já implementadas previamente).
Caso o golpeador não consiga desferir o ataque duplo (ou seja, estiver fora dos 33.3%), ele deve desferir um ataque normalmente mas perde 5% de vida. 
Quando o Saint tiver menos que 1 de vida ele morre (exemplo: 0.99 de vida já é considerado morto).
 */