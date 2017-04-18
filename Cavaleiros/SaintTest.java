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
        Saint shaka = new Saint("Shaka", new Armadura(new Constelacao("Virgem"), Categoria.OURO));
        // 2. Act - invocar ação a ser testada
        shaka.vestirArmadura();
        // 3. Assert - verificação dos resultados do teste
        boolean resultado = shaka.getArmaduraVestida();
        assertEquals(true, resultado);
    }

    @Test
    public void naoVestirArmaduraDeixaArmaduraNaoVestida() throws Exception{
        Saint saga = new Saint("Saga", new Armadura(new Constelacao("Gêmeos"), Categoria.OURO));
        assertEquals(false, saga.getArmaduraVestida());

    }

    @Test
    public void aoCriarSaintGeneroENaoInformado()throws Exception{
        Saint mm = new Saint("Máscara da Morte", new Armadura(new Constelacao("Câncer"), Categoria.OURO));
        assertEquals(Genero.NAO_INFORMADO, mm.getGenero());

    }

    @Test   
    public void deveSerPossivelMudarOGenero()throws Exception{
        Armadura unicornio = new Armadura(new Constelacao("Unicórnio"), Categoria.BRONZE);
        BronzeSaint jabu = new BronzeSaint("Jabu", unicornio);
        jabu.setGenero(Genero.MASCULINO);
        assertEquals(Genero.MASCULINO, jabu.getGenero());
    }

    @Test
    public void cavaleiroECriadoComVida()throws Exception{
        Armadura aries = new Armadura(new Constelacao("Áries"), Categoria.OURO);
        Saint mu = new Saint("Mu", aries);
        assertEquals(Status.VIVO, mu.getStatus());

    }

    @Test
    public void cavaleiroECriadoComVidaIgualA100()throws Exception{
        Armadura aries = new Armadura(new Constelacao("Áries"), Categoria.OURO);
        GoldSaint mu = new GoldSaint("Mu", aries);
        assertEquals(100.0, mu.getVida(), 0);
    }

    @Test   
    public void perderVidaFazVidaDiminuirNaQuantidadeIndicada()throws Exception{
        Armadura unicornio = new Armadura(new Constelacao("Unicórnio"), Categoria.BRONZE);
        BronzeSaint jabu = new BronzeSaint("Jabu", unicornio);
        jabu.perderVida(15);
        assertEquals(85.0, jabu.getVida(), 0);
    }

    @Test
    public void aoCriarSaintPossui5Sentidos()throws Exception{
        BronzeSaint shun = new BronzeSaint("Shun", new Armadura(new Constelacao("Andrômeda"), Categoria.BRONZE));
        assertEquals(5, shun.getQtdSentidosDespertados());

    }
    
    @Test
    public void saintPrataPossui6Sentidos()throws Exception{
        SilverSaint marin = new SilverSaint("Marin", new Armadura(new Constelacao("Águia"), Categoria.PRATA));
        assertEquals(6, marin.getQtdSentidosDespertados());
    }

    @Test
    public void SaintOuroPossui7Sentidos()throws Exception{
        GoldSaint shion = new GoldSaint("Shion", new Armadura(new Constelacao("Áries"), Categoria.OURO));
        assertEquals(7, shion.getQtdSentidosDespertados());
    }

    @Test
    public void CavaleiroComVida0MudaStatusParaMorto()throws Exception{
        BronzeSaint ikki = new BronzeSaint("Ikki", new Armadura(new Constelacao("Fênix"), Categoria.BRONZE));
        ikki.perderVida(100);
        assertEquals(ikki.getStatus(), Status.MORTO);
    }
}
