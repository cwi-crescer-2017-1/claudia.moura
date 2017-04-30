import static org.junit.Assert.*;
import org.junit.After;
import org.junit.Before;
import org.junit.Test;

public class AtaqueDuploFalseTest{

    @Test
    public void ataqueDuploTrueComArmaduraGolpeado() throws Exception{
        Saint shaka = new GoldSaint("Shaka", "Virgem");
        Golpe samsara = new Golpe("Samsara", 10);
        shaka.aprenderGolpe(samsara);
        shaka.vestirArmadura(); //multiplica dano por 4. Total: 40

        Saint aioria = new GoldSaint("Aioria", "Leão");

        Movimento golpeDuplo = new AtaqueDuploFalse(shaka, aioria); //não multiplica por motivos de:false
        golpeDuplo.executar();
        
        assertEquals(60, aioria.getVida(), 0);        
    }
    
        @Test
    public void ataqueDuploTrueComArmaduraGolpeador() throws Exception{
        Saint shaka = new GoldSaint("Shaka", "Virgem");
        Golpe samsara = new Golpe("Samsara", 20);
        shaka.aprenderGolpe(samsara);
        shaka.vestirArmadura(); //multiplica dano por 4. Total: 80

        Saint aioria = new GoldSaint("Aioria", "Leão");

        Movimento golpeDuplo = new AtaqueDuploFalse(shaka, aioria); //não multiplica por motivos de:false
        golpeDuplo.executar();
        
        assertEquals(95, shaka.getVida(), 0);        
    }
    
    @Test
    public void ataqueDuploTrueSemArmaduraGolpeado() throws Exception{
        Saint shaka = new GoldSaint("Shaka", "Virgem");
        Golpe samsara = new Golpe("Samsara", 10);
        shaka.aprenderGolpe(samsara);

        Saint aioria = new GoldSaint("Aioria", "Leão");

        Movimento golpeDuplo = new AtaqueDuploFalse(shaka, aioria); //não multiplica por motivos de:false
        golpeDuplo.executar();
        
        assertEquals(90, aioria.getVida(), 0);        
    }
    
        @Test
    public void ataqueDuploTrueSemArmaduraGolpeador() throws Exception{
        Saint shaka = new GoldSaint("Shaka", "Virgem");
        Golpe samsara = new Golpe("Samsara", 20);
        shaka.aprenderGolpe(samsara);

        Saint aioria = new GoldSaint("Aioria", "Leão");

        Movimento golpeDuplo = new AtaqueDuploFalse(shaka, aioria); //não multiplica por motivos de:false
        golpeDuplo.executar();
        
        assertEquals(95, shaka.getVida(), 0);        
    }
    
    
    
    
}
