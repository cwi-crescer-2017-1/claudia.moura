import static org.junit.Assert.*;
import org.junit.After;
import org.junit.Before;
import org.junit.Test;

public class ChanceUmTercoTest
{
    @Test
    public void chanceUm() {
        Sorteador sorteador = new DadoFalso(1);
        ChanceUmTerco sorte = new ChanceUmTerco(sorteador);
        assertFalse(sorte.ChanceUm());
    }

    @Test
    public void chanceDois() {
        Sorteador sorteador = new DadoFalso(2);
        ChanceUmTerco sorte = new ChanceUmTerco(sorteador);
        assertFalse(sorte.ChanceUm());
    }
    
        @Test
    public void chanceTres() {
        Sorteador sorteador = new DadoFalso(3);
        ChanceUmTerco sorte = new ChanceUmTerco(sorteador);
        assertTrue(sorte.ChanceUm());
    }
    
    @Test
    public void chanceQuatro() {
        Sorteador sorteador = new DadoFalso(1);
        ChanceUmTerco sorte = new ChanceUmTerco(sorteador);
        assertFalse(sorte.ChanceUm());
    }

    @Test
    public void chanceCinco() {
        Sorteador sorteador = new DadoFalso(2);
        ChanceUmTerco sorte = new ChanceUmTerco(sorteador);
        assertFalse(sorte.ChanceUm());
    }
    
        @Test
    public void chanceSeis() {
        Sorteador sorteador = new DadoFalso(3);
        ChanceUmTerco sorte = new ChanceUmTerco(sorteador);
        assertTrue(sorte.ChanceUm());
    }
    
}
