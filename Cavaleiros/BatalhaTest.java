

import static org.junit.Assert.*;
import org.junit.After;
import org.junit.Before;
import org.junit.Test;

/**
 * A classe de teste BatalhaTest.
 *
 * @author  (seu nome)
 * @version (um número de versão ou data)
 */
public class BatalhaTest
{
    @Test
    public void casoCavaleirosIguaisSegundoPerdeVidaEPrimeiroMantem()  throws Exception {
        Saint saga = new GoldSaint("Saga", new Armadura(new Constelacao("Gêmeos"), Categoria.OURO));
        Saint mm = new GoldSaint("Máscara da Morte", new Armadura(new Constelacao("Gêmeos"), Categoria.OURO));
                
        Batalha batalha = new Batalha(saga, mm);
        batalha.iniciarBatalha();
        
        assertEquals(90, mm.getVida(),0);  
        assertEquals(100, saga.getVida(),0); 
    }
    
    @Test
    public void casoCavaleirosDiferentesCategoriaMenorPerdeVidaEMaiorMantem()  throws Exception{
        Saint shiryu = new BronzeSaint("Shiryu", new Armadura(new Constelacao("Dragão"), Categoria.BRONZE));
        Saint shura = new GoldSaint("Shura", new Armadura(new Constelacao("Capricórnio"), Categoria.OURO));
        
        Batalha batalha = new Batalha(shiryu, shura);
        batalha.iniciarBatalha();
        
        assertEquals(90, shiryu.getVida(),0);        
        assertEquals(100, shura.getVida(),0);
    }
    
}
