import static org.junit.Assert.*;
import org.junit.After;
import org.junit.Before;
import org.junit.Test;

public class SaintTest
{
   @Test   
   public void vestirArmaduraDeixaArmaduraVestida()throws Exception{
       // AAA
       // 1. Arrange - montagem dos dados de teste
       Armadura virgo = new Armadura("Virgem", Categoria.OURO);
       Saint shaka = new GoldSaint("Shaka", virgo);
       // 2. Act - invocar ação a ser testada
       shaka.vestirArmadura();
       // 3. Assert - verificação dos resultados do teste
       boolean resultado = shaka.getArmaduraVestida();
       assertEquals(true, resultado);
    }
    
    @Test
    public void naoVestirArmaduraDeixaArmaduraNaoVestida() throws Exception{
        Saint saga = new GoldSaint("Saga", new Armadura("Gêmeos", Categoria.OURO));
        assertEquals(false, saga.getArmaduraVestida());
        
    }
    
    @Test
    public void aoCriarSaintGeneroENaoInformado()throws Exception{
        Armadura cancer = new Armadura("Câncer", Categoria.OURO);
        Saint mm = new GoldSaint("Máscara da Morte", cancer);
        assertEquals(Genero.NAO_INFORMADO, mm.getGenero());
        
    }
    
     @Test   
     public void deveSerPossivelMudarOGenero()throws Exception{
       Armadura unicornio = new Armadura("Unicórnio", Categoria.BRONZE);
       Saint jabu = new BronzeSaint("Jabu", unicornio);
       jabu.setGenero(Genero.MASCULINO);
       assertEquals(Genero.MASCULINO, jabu.getGenero());
    }
    
    @Test
    public void cavaleiroECriadoComVida()throws Exception{
        Armadura aries = new Armadura("Áries", Categoria.OURO);
        Saint mu = new Saint("Mu", aries);
        assertEquals(Status.VIVO, mu.getStatus());
        
    }
    
    @Test
    public void cavaleiroECriadoComVidaIgualA100()throws Exception{
        Armadura aries = new Armadura("Áries", Categoria.OURO);
        Saint mu = new GoldSaint("Mu", aries);
        assertEquals(100.0, mu.getVida(), 0);
    }
   
    @Test   
     public void perderVidaFazVidaDiminuirNaQuantidadeIndicada()throws Exception{
       Armadura unicornio = new Armadura("Unicórnio", Categoria.BRONZE);
       Saint jabu = new BronzeSaint("Jabu", unicornio);
       jabu.perderVida(15);
       assertEquals(85.0, jabu.getVida(), 0);
    }
    
    @Test
    public void aoCriarSaintPossui5Sentidos()throws Exception{
        Saint shun = new BronzeSaint("Shun", new Armadura("Andrômeda", Categoria.BRONZE));
        assertEquals(5, shun.getQtdSentidosDespertados());
        
    
    }
    
    @Test
    public void saintPrataPossui6Sentidos()throws Exception{
        Saint marin = new SilverSaint("Marin", new Armadura("Águia", Categoria.PRATA));
        assertEquals(6, marin.getQtdSentidosDespertados());
    }
    
    @Test
    public void SaintOuroPossui7Sentidos()throws Exception{
        Saint shion = new GoldSaint("Shion", new Armadura("Áries", Categoria.OURO));
        assertEquals(7, shion.getQtdSentidosDespertados());
    }
}
