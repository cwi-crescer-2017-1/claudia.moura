import static org.junit.Assert.*;
import org.junit.After;
import org.junit.Before;
import org.junit.Test;

public class CategoriaTest
{
    @Test
    public void armaduraDeOuroRetornaValor3(){
       Armadura virgo = new Armadura("Virgem", Categoria.OURO);
       //Saint shaka = new Saint("Shaka", virgo);
       //int valorArmadura = virgo.getCategoria().getValor();
       assertEquals(3, virgo.getCategoria().getValor());
    }
    
    @Test
    public void armaduraDePrataRetornaValor2(){
        Armadura virgo = new Armadura("Virgem", Categoria.PRATA);
        assertEquals(2, virgo.getCategoria().getValor());
    }
    
    @Test
    public void armaduraDeBronzeRetornaValor1(){
        Armadura virgo = new Armadura("Virgem", Categoria.BRONZE);
        assertEquals(1, virgo.getCategoria().getValor());
    }
}
