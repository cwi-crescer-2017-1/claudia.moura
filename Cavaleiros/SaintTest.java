import static org.junit.Assert.*;
import org.junit.After;
import org.junit.Before;
import org.junit.Test;
import java.util.ArrayList;

public class SaintTest
{
    @Test   
    public void vestirArmaduraDeixaArmaduraVestida()throws Exception{
        // AAA
        // 1. Arrange - montagem dos dados de teste
        Saint shaka = new GoldSaint("Shaka", new Armadura(new Constelacao("Virgem"), Categoria.OURO));
        // 2. Act - invocar ação a ser testada
        shaka.vestirArmadura();
        // 3. Assert - verificação dos resultados do teste
        boolean resultado = shaka.getArmaduraVestida();
        assertEquals(true, resultado);
    }

    @Test
    public void naoVestirArmaduraDeixaArmaduraNaoVestida() throws Exception{
        Saint saga = new GoldSaint("Saga", new Armadura(new Constelacao("Gêmeos"), Categoria.OURO));
        assertEquals(false, saga.getArmaduraVestida());

    }

    @Test
    public void aoCriarSaintGeneroENaoInformado()throws Exception{
        Saint mm = new GoldSaint("Máscara da Morte", new Armadura(new Constelacao("Câncer"), Categoria.OURO));
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
        Saint mu = new GoldSaint("Mu", new Armadura(new Constelacao("Áries"), Categoria.OURO));
        assertEquals(Status.VIVO, mu.getStatus());

    }

    @Test
    public void cavaleiroECriadoComVidaIgualA100()throws Exception{
        Saint mu = new GoldSaint("Mu", new Armadura(new Constelacao("Áries"), Categoria.OURO));
        assertEquals(100.0, mu.getVida(), 0);
    }

    @Test   
    public void perderVidaFazVidaDiminuirNaQuantidadeIndicada()throws Exception{
        Armadura unicornio = new Armadura(new Constelacao("Unicórnio"), Categoria.BRONZE);
        BronzeSaint jabu = new BronzeSaint("Jabu", unicornio);
        jabu.perderVida(15);
        assertEquals(85.0, jabu.getVida(), 0);
        jabu.perderVida(50);
        assertEquals(35.0, jabu.getVida(), 0);
        jabu.perderVida(35);
        assertEquals(0.0, jabu.getVida(), 0);
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

    @Test
    public void criarSaintOuroNasceCom7SentidosDespertados() throws Exception {
        GoldSaint afrodite = new GoldSaint("Afrodite", new Armadura(new Constelacao("Peixes"), Categoria.OURO));
        assertEquals(7, afrodite.getQtdSentidosDespertados());
    }

    @Test(expected=Exception.class)
    public void constelacaoInvalidaDeOuroDeveLancarErro() throws Exception {
        new GoldSaint("Bernardo", new Armadura(new Constelacao("Café"), Categoria.OURO));
    }

    @Test
    public void aprenderUmGolpe() throws Exception {
        Saint saga = new GoldSaint("Saga", new Armadura(new Constelacao("Gêmeos"), Categoria.OURO));
        Golpe outraDimensao = new Golpe("Outra dimensão", 10);
        saga.aprenderGolpe(new Golpe("Outra dimensão", 10));
        ArrayList<Golpe> golpes = saga.getGolpes();
        assertEquals(outraDimensao, golpes.get(0));
        assertEquals(1, golpes.size());

        // TODO: assert null
    }

    @Test
    public void aprenderDoisGolpes() throws Exception {
        Saint saga = new GoldSaint("Saga", new Armadura(new Constelacao("Gêmeos"), Categoria.OURO));
        Golpe outraDimensao = new Golpe("Outra dimensão", 10);
        Golpe explosaoGalatica = new Golpe("Explosão Galáctica", 11);
        saga.aprenderGolpe(outraDimensao);
        saga.aprenderGolpe(explosaoGalatica);
        ArrayList<Golpe> golpes = saga.getGolpes();
        assertEquals(outraDimensao, golpes.get(0));
        assertEquals(explosaoGalatica, golpes.get(1));
    }

    @Test //(expected=ArrayIndexOutOfBoundsException.class)
    public void aprenderQuatroGolpesNaoLancaMaisErro() throws Exception {
        Saint saga = new GoldSaint("Saga", new Armadura(new Constelacao("Gêmeos"), Categoria.OURO));
        Golpe outraDimensao = new Golpe("Outra dimensão", 10);
        Golpe explosaoGalatica = new Golpe("Explosão Galáctica", 11);
        Golpe sataImperial = new Golpe("Satã Imperial", 42);
        Golpe rasteira = new Golpe("Rasteira", 2);
        saga.aprenderGolpe(outraDimensao);
        saga.aprenderGolpe(explosaoGalatica);
        saga.aprenderGolpe(sataImperial);
        saga.aprenderGolpe(rasteira);
        ArrayList<Golpe> golpes = saga.getGolpes();
        assertEquals(outraDimensao, golpes.get(0));
        assertEquals(explosaoGalatica, golpes.get(1));
        assertEquals(sataImperial, golpes.get(2));
        assertEquals(rasteira, golpes.get(3));
    }

    @Test
    public void getProximoGolpeComUm() throws Exception {
        Saint saga = new GoldSaint("Saga", new Armadura(new Constelacao("Gêmeos"), Categoria.OURO));
        Golpe outraDimensao = new Golpe("Outra dimensão", 10);
        saga.aprenderGolpe(new Golpe("Outra dimensão", 10));
        assertEquals(outraDimensao, saga.getProximoGolpe());
    }

    @Test
    public void getProximoGolpeComDois() throws Exception {
        Saint saga = new GoldSaint("Saga", new Armadura(new Constelacao("Gêmeos"), Categoria.OURO));
        Golpe outraDimensao = new Golpe("Outra dimensão", 10);
        Golpe explosaoGalatica = new Golpe("Explosão Galáctica", 11);
        saga.aprenderGolpe(outraDimensao);
        saga.aprenderGolpe(explosaoGalatica);
        assertEquals(outraDimensao, saga.getProximoGolpe());
        assertEquals(explosaoGalatica, saga.getProximoGolpe());
    }

    @Test
    public void getProximoGolpeComTres() throws Exception {
        Saint saga = new GoldSaint("Saga", new Armadura(new Constelacao("Gêmeos"), Categoria.OURO));
        Golpe outraDimensao = new Golpe("Outra dimensão", 10);
        Golpe explosaoGalatica = new Golpe("Explosão Galáctica", 11);
        Golpe sataImperial = new Golpe("Satã Imperial", 42);
        saga.aprenderGolpe(outraDimensao);
        saga.aprenderGolpe(explosaoGalatica);
        saga.aprenderGolpe(sataImperial);
        assertEquals(outraDimensao, saga.getProximoGolpe());
        assertEquals(explosaoGalatica, saga.getProximoGolpe());
        assertEquals(sataImperial, saga.getProximoGolpe());
    }
    
    @Test
    public void getProximoGolpeComQuatroChamadas() throws Exception {
        Saint saga = new GoldSaint("Saga", new Armadura(new Constelacao("Gêmeos"), Categoria.OURO));
        Golpe outraDimensao = new Golpe("Outra dimensão", 10);
        Golpe explosaoGalatica = new Golpe("Explosão Galáctica", 11);
        Golpe sataImperial = new Golpe("Satã Imperial", 42);
        saga.aprenderGolpe(outraDimensao);
        saga.aprenderGolpe(explosaoGalatica);
        saga.aprenderGolpe(sataImperial);
        assertEquals(outraDimensao, saga.getProximoGolpe());
        assertEquals(explosaoGalatica, saga.getProximoGolpe());
        assertEquals(sataImperial, saga.getProximoGolpe());
        assertEquals(outraDimensao, saga.getProximoGolpe());
    }

}



