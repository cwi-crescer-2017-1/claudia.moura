import static org.junit.Assert.*;
import org.junit.After;
import org.junit.Before;
import org.junit.Test;

public class VestirArmaduraTest
{
   @Test 
   public void executarDeixaArmaduraVestida()throws Exception{
    Saint ichi = new BronzeSaint("Ichi", "Hydra");
    Movimento movimento = new VestirArmadura(ichi);
    movimento.executar();
    assertEquals(true, ichi.getArmaduraVestida());    
    }
}