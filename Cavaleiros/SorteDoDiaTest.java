import static org.junit.Assert.*;
import org.junit.After;
import org.junit.Before;
import org.junit.Test;

public class SorteDoDiaTest
{
    @Test
    public void deveRetornarTrueOuFalse(){
        Sorteador sorteador = new DadoD6();        
        SorteDoDia sorte = new SorteDoDia(sorteador);         
        assertEquals((true||false), sorte);         
    }  
}
