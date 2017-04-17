

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
        Saint saga = new Saint("Saga", new Armadura("Gêmeos", Categoria.OURO));
        Saint mm = new Saint("Máscara da Morte", new Armadura("Gêmeos", Categoria.OURO));
                
        Batalha batalha = new Batalha(saga, mm);
        batalha.iniciarBatalha();
        
        assertEquals(90, mm.getVida(),0);  
        assertEquals(100, saga.getVida(),0); 
    }
    
    @Test
    public void casoCavaleirosDiferentesCategoriaMenorPerdeVidaEMaiorMantem()  throws Exception{
        Saint shiryu = new Saint("Shiryu", new Armadura("Dragão", Categoria.BRONZE));
        Saint shura = new Saint("Shura", new Armadura("Capricórnio", Categoria.OURO));
        
        Batalha batalha = new Batalha(shiryu, shura);
        batalha.iniciarBatalha();
        
        assertEquals(90, shiryu.getVida(),0);        
        assertEquals(100, shura.getVida(),0);
    }
    
}
