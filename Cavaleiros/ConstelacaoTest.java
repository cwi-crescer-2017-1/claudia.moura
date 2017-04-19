import static org.junit.Assert.*;
import org.junit.After;
import org.junit.Before;
import org.junit.Test;
import java.util.ArrayList;

public class ConstelacaoTest {

    @Test
    public void adicionarUmGolpe() {
        Constelacao gemeos = new Constelacao("Gêmeos");
        Golpe outraDimensao = new Golpe("Outra dimensão", 10);
        gemeos.adicionarGolpe(new Golpe("Outra dimensão", 10));
        ArrayList<Golpe> golpes = gemeos.getGolpes();
        assertEquals(outraDimensao, golpes.get(0));
        //assertNull(golpes.get(1));
        //assertNull(golpes.get(2));
        // TODO: assert null
    }

    @Test
    public void adicionarDoisGolpes() {
        Constelacao gemeos = new Constelacao("Gêmeos");
        Golpe outraDimensao = new Golpe("Outra dimensão", 10);
        Golpe explosaoGalatica = new Golpe("Explosão Galáctica", 11);
        gemeos.adicionarGolpe(outraDimensao);
        gemeos.adicionarGolpe(explosaoGalatica);
        ArrayList<Golpe> golpes = gemeos.getGolpes();
        assertEquals(outraDimensao, golpes.get(0));
        assertEquals(explosaoGalatica, golpes.get(1));
        //assertNull(golpes.get(2));
    }

    @Test
    public void adicionarTresGolpes() {
        Constelacao gemeos = new Constelacao("Gêmeos");
        Golpe outraDimensao = new Golpe("Outra dimensão", 10);
        Golpe explosaoGalatica = new Golpe("Explosão Galáctica", 11);
        Golpe sataImperial = new Golpe("Satã Imperial", 60);
        gemeos.adicionarGolpe(outraDimensao);
        gemeos.adicionarGolpe(explosaoGalatica);
        gemeos.adicionarGolpe(sataImperial);
        ArrayList<Golpe> golpes = gemeos.getGolpes();
        assertEquals(outraDimensao, golpes.get(0));
        assertEquals(explosaoGalatica, golpes.get(1));
        assertEquals(sataImperial, golpes.get(2));
    }

    @Test
    public void adicionarSeteGolpes() {
        Constelacao gemeos = new Constelacao("Gêmeos");
        Golpe outraDimensao = new Golpe("Outra dimensão", 10);
        Golpe explosaoGalatica = new Golpe("Explosão Galáctica", 11);
        Golpe sataImperial = new Golpe("Satã Imperial", 30);
        Golpe aliancaGalatica = new Golpe("Corrente De Intervenção Da Aliança Galáctica ", 80);
        Golpe universoEmDesencanto = new Golpe("Universo em desencanto", 100);
        Golpe NGC4414 = new Golpe("NGC 4414", 4414);
        Golpe bigBang = new Golpe("Big Bang", 8001);

        gemeos.adicionarGolpe(outraDimensao);
        gemeos.adicionarGolpe(explosaoGalatica);
        gemeos.adicionarGolpe(sataImperial);
        gemeos.adicionarGolpe(aliancaGalatica);
        gemeos.adicionarGolpe(universoEmDesencanto);
        gemeos.adicionarGolpe(NGC4414);
        gemeos.adicionarGolpe(bigBang);

        ArrayList<Golpe> golpes = gemeos.getGolpes();
        assertEquals(outraDimensao, golpes.get(0));
        assertEquals(explosaoGalatica, golpes.get(1));        
        assertEquals(sataImperial, golpes.get(2));
        assertEquals(aliancaGalatica, golpes.get(3));
        assertEquals(universoEmDesencanto, golpes.get(4));
        assertEquals(NGC4414, golpes.get(5));
        assertEquals(bigBang, golpes.get(6));
    }

}
