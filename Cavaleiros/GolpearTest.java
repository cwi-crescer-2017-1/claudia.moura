
import static org.junit.Assert.*;
import org.junit.After;
import org.junit.Before;
import org.junit.Test;

public class GolpearTest
{
    @Test
    public void saintSemArmaduraNaoAlteraFatorDano() throws Exception {
        Saint geki = new BronzeSaint("Geki", "Urso");
        Golpe abracoDeUrso = new Golpe("Abraço de Urso", 10);
        geki.aprenderGolpe(abracoDeUrso);
        
        Saint aioria = new GoldSaint("Aioria", "Leão");

        Movimento golpe = new Golpear(geki, aioria);
        golpe.executar();

        assertEquals(90, aioria.getVida(), 0);

    }
    
    @Test
    public void vestirArmaduraDeBronzeAumentaFatorDanoEmDois() throws Exception{
        Saint geki = new BronzeSaint("Geki", "Urso");
        Golpe abracoDeUrso = new Golpe("Abraço de Urso", 10);
        geki.aprenderGolpe(abracoDeUrso);
        geki.vestirArmadura();

        Saint seiya = new BronzeSaint("Seiya", "Pégasus");

        Movimento golpe = new Golpear(geki, seiya);
        golpe.executar();

        assertEquals(80, seiya.getVida(), 0);
    }

    @Test
    public void vestirArmaduraDeOuroAumentaFatorDanoEmQuatro()throws Exception{

        Saint kiki = new GoldSaint("Kiki", "Áries");
        Golpe extincaoEstelar = new Golpe("Extinção Estelar", 15);
        kiki.aprenderGolpe(extincaoEstelar);
        kiki.vestirArmadura();

        Saint aioria = new GoldSaint("Aioria", "Leão");

        Movimento golpe = new Golpear(kiki, aioria);
        golpe.executar();

        assertEquals(40, aioria.getVida(), 0);

    }
}
