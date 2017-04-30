import static org.junit.Assert.*;
import org.junit.After;
import org.junit.Before;
import org.junit.Test;

public class AtaqueDuploTrueTest
{
    @Test
    public void ataqueDuploTrueComArmadura() throws Exception{
        Saint geki = new BronzeSaint("Geki", "Urso");
        Golpe abracoDeUrso = new Golpe("Abraço de Urso", 10);
        geki.aprenderGolpe(abracoDeUrso);
        geki.vestirArmadura(); //multiplica dano por 2. Total: 20

        Saint seiya = new BronzeSaint("Seiya", "Pégasus");

        Movimento golpeDuplo = new AtaqueDuploTrue(geki, seiya); //Multiplica dano por 2. Total: 40
        golpeDuplo.executar();

        assertEquals(60, seiya.getVida(), 0);
        assertEquals(100, geki.getVida(), 0);
    }

    @Test
    public void ataqueDuploTrueSemArmadura() throws Exception{
        Saint geki = new BronzeSaint("Geki", "Urso");
        Golpe abracoDeUrso = new Golpe("Abraço de Urso", 10);
        geki.aprenderGolpe(abracoDeUrso);

        Saint seiya = new BronzeSaint("Seiya", "Pégasus");

        Movimento golpeDuplo = new AtaqueDuploTrue(geki, seiya); //Multiplica dano por 2. Total: 20
        golpeDuplo.executar();

        assertEquals(80, seiya.getVida(), 0);
        assertEquals(100, geki.getVida(), 0);
    }
}
