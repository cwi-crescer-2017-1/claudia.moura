import static org.junit.Assert.*;
import org.junit.After;
import org.junit.Before;
import org.junit.Test;

public class CategoriaTest
{
    @Test
    public void armaduraDeOuroRetornaValor3(){
       Armadura virgo = new Armadura(new Constelacao("Virgem"), Categoria.OURO);
       //Saint shaka = new Saint("Shaka", virgo);
       //int valorArmadura = virgo.getCategoria().getValor();
       assertEquals(3, virgo.getCategoria().getValor());
    }
    
    @Test
    public void armaduraDePrataRetornaValor2(){
        Armadura corvo = new Armadura(new Constelacao("Corvo"), Categoria.PRATA);
        assertEquals(2, corvo.getCategoria().getValor());
    }
    
    @Test
    public void armaduraDeBronzeRetornaValor1(){
        Armadura hidra = new Armadura(new Constelacao("Hidra"), Categoria.BRONZE);
        assertEquals(1, hidra.getCategoria().getValor());
    }
}
