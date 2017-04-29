import java.util.Random;

public class AtaqueDuplo implements Movimento{

    Saint golpeador, golpeado;
    private int sorteador;
    private int danoDuplo = 1;
    private Golpear golpe;
    private int min = 1, max = 3;

    public AtaqueDuplo(Saint golpeador, Saint golpeado)
    {
        this.golpeador = golpeador;
        this.golpeado = golpeado;
        this.sorteador = sorteador;
        this.golpe = golpe;
    }

    private int danoDuplo() {
        Random random = new Random();
        sorteador = random.nextInt(max - min + 1) + min;
        if (sorteador < 3){
            this.danoDuplo = 2;
        } 
        return danoDuplo;
    }  

    public void executar(){
        int dano = this.danoDuplo();
        
        if (dano == 1){            
            golpeador.perderVida(golpeador.getVida()*5/100); // golpeador perde 5% de vida        
        }else{
            golpeado.perderVida(golpe.getDanoTotal());
        }
    }
}
/*Implemente um Movimento de ataque duplo que siga a regra abaixo:
 * 
O movimento recebe um golpeador e um golpeado (assim como é no golpear atual) no construtor.
O golpeador tem 33.3% de chance de desferir um ataque com o dobro do dano (que deve seguir as regras normais de dano, já implementadas previamente).
Caso o golpeador não consiga desferir o ataque duplo (ou seja, estiver fora dos 33.3%), ele deve desferir um ataque normalmente mas perde 5% de vida. 
Quando o Saint tiver menos que 1 de vida ele morre (exemplo: 0.99 de vida já é considerado morto).

public void executar(){
if(this.golpeador.getArmaduraVestida()){
fatorDano *= (1 + golpeador.getArmadura().getCategoria().getValor());        
}
this.golpeado.perderVida(fatorDano);
 */