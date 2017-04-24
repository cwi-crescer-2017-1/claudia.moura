import static org.junit.Assert.*;
import org.junit.After;
import org.junit.Before;
import org.junit.Test;

public class BatalhaTest {   
    /*
    Saint seiya = new BronzeSaint("Seiya", "Pégasus");
    Golpe meteoro = new Golpe("Meteoro de Pégasus", 10);
    Golpe cometa = new Golpe("Cometa de Pégasus", 15);
    seiya.aprenderGolpe(meteoro);
    seiya.aprenderGolpe(cometa);

    Saint ikki = new BronzeSaint("Ikki", "Fênix");
    Golpe aveFenix = new Golpe("Ave Fênix", 10);
    Golpe golpeFantasma = new Golpe("Golpe Fantasma de Fênix", 15);
    ikki.aprenderGolpe(aveFenix);
    ikki.aprenderGolpe(golpeFantasma);

    Saint marin = new SilverSaint("Marin", "Águia");
    Golpe meteoro2 = new Golpe("Meteoro", 10);
    Golpe lampejo = new Golpe("Lampejo da Águia", 15);
    marin.aprenderGolpe(meteoro2);
    marin.aprenderGolpe(lampejo);

    Saint shaka = new GoldSaint("Shaka", "Virgem");
    Golpe samsara = new Golpe("Samsara", 10);
    Golpe tesouro = new Golpe("Tesouro do Céu", 15);
    shaka.aprenderGolpe(samsara);
    shaka.aprenderGolpe(tesouro);

    Saint afrodite = new GoldSaint("Afrodite", "Peixes");
    Golpe piranha = new Golpe("Rosas Piranhas", 10);
    Golpe sangrenta = new Golpe("Rosas Sangrentas", 15);
    afrodite.aprenderGolpe(piranha);
    afrodite.aprenderGolpe(sangrenta);
     */

    @Test 
    public void testeBatalhaCategoriaMenorPerde() throws Exception{
        Saint shaka = new GoldSaint("Shaka", "Virgem");
        Golpe samsara = new Golpe("Samsara", 10);
        Golpe tesouro = new Golpe("Tesouro do Céu", 15);
        shaka.aprenderGolpe(samsara);
        shaka.aprenderGolpe(tesouro);

        Saint ikki = new BronzeSaint("Ikki", "Fênix");
        Golpe aveFenix = new Golpe("Ave Fênix", 10);
        Golpe golpeFantasma = new Golpe("Golpe Fantasma de Fênix", 15);
        ikki.aprenderGolpe(aveFenix);
        ikki.aprenderGolpe(golpeFantasma);        

        Movimento vestirArmadura = new VestirArmadura(shaka);
        Movimento golpeSaint1 = new Golpear(shaka, ikki);
        Movimento golpeSaint2 = new Golpear(ikki, shaka);

        shaka.adicionarMovimento(vestirArmadura);
        shaka.adicionarMovimento(golpeSaint1);
        ikki.adicionarMovimento(golpeSaint2);

        Batalha batalha = new Batalha(ikki, shaka);

        batalha.iniciarBatalha();

        assertEquals(Status.MORTO, ikki.getStatus());
        assertEquals(Status.VIVO, shaka.getStatus());
        assertTrue(shaka.getArmaduraVestida());
        assertFalse(ikki.getArmaduraVestida());

    }

    @Test
    public void testeSaintsDeMesmaCategoriaPrimeiroVence() throws Exception{
        Saint shaka = new GoldSaint("Shaka", "Virgem");
        Golpe samsara = new Golpe("Samsara", 10);
        Golpe tesouro = new Golpe("Tesouro do Céu", 15);
        shaka.aprenderGolpe(samsara);
        shaka.aprenderGolpe(tesouro);

        Saint afrodite = new GoldSaint("Afrodite", "Peixes");
        Golpe piranha = new Golpe("Rosas Piranhas", 10);
        Golpe sangrenta = new Golpe("Rosas Sangrentas", 15);
        afrodite.aprenderGolpe(piranha);
        afrodite.aprenderGolpe(sangrenta);

        Movimento vestirArmadura = new VestirArmadura(afrodite);
        Movimento vestirArmadura2 = new VestirArmadura(shaka);
        Movimento golpeSaint1 = new Golpear(shaka, afrodite);
        Movimento golpeSaint2 = new Golpear(afrodite, shaka);

        shaka.adicionarMovimento(vestirArmadura2);
        shaka.adicionarMovimento(golpeSaint1);
        afrodite.adicionarMovimento(vestirArmadura);
        afrodite.adicionarMovimento(golpeSaint2);
        
        
        Batalha batalha = new Batalha(afrodite, shaka);

        batalha.iniciarBatalha();

        assertEquals(Status.VIVO, afrodite.getStatus());
        assertEquals(Status.MORTO, shaka.getStatus());
        assertTrue(shaka.getArmaduraVestida());
        assertTrue(afrodite.getArmaduraVestida());         
        
    }
    
    @Test
    public void testeBatalhaSaintsDeMesmaCategoriaSemArmaduraPerde() throws Exception{
        Saint shaka = new GoldSaint("Shaka", "Virgem");
        Golpe samsara = new Golpe("Samsara", 10);
        Golpe tesouro = new Golpe("Tesouro do Céu", 15);
        shaka.aprenderGolpe(samsara);
        shaka.aprenderGolpe(tesouro);

        Saint afrodite = new GoldSaint("Afrodite", "Peixes");
        Golpe piranha = new Golpe("Rosas Piranhas", 10);
        Golpe sangrenta = new Golpe("Rosas Sangrentas", 15);
        afrodite.aprenderGolpe(piranha);
        afrodite.aprenderGolpe(sangrenta);


        Movimento vestirArmadura2 = new VestirArmadura(shaka);
        Movimento golpeSaint1 = new Golpear(shaka, afrodite);
        Movimento golpeSaint2 = new Golpear(afrodite, shaka);

        shaka.adicionarMovimento(vestirArmadura2);
        shaka.adicionarMovimento(golpeSaint1);
        afrodite.adicionarMovimento(golpeSaint2);
        
        
        Batalha batalha = new Batalha(afrodite, shaka);

        batalha.iniciarBatalha();

        assertEquals(Status.MORTO, afrodite.getStatus());
        assertEquals(Status.VIVO, shaka.getStatus());
        assertTrue(shaka.getArmaduraVestida());
        assertFalse(afrodite.getArmaduraVestida());         
        
    }
    /*
    @Test
    public void casoCavaleirosIguaisSegundoPerdeVidaEPrimeiroMantem()  throws Exception {
    Saint saga = new GoldSaint("Saga", "Gêmeos");
    Saint mm = new GoldSaint("Máscara da Morte", "Gêmeos");

    Batalha batalha = new Batalha(saga, mm);
    batalha.iniciarBatalha();

    assertEquals(0, mm.getVida(),00);  
    assertEquals(10, saga.getVida(),0); 
    }

    @Test
    public void casoCavaleirosDiferentesCategoriaMenorPerdeVidaEMaiorMantem()  throws Exception{
    Saint shiryu = new BronzeSaint("Shiryu", "Dragão");
    Saint shura = new GoldSaint("Shura", "Capricórnio");

    Batalha batalha = new Batalha(shiryu, shura);
    batalha.iniciarBatalha();

    assertEquals(0, shiryu.getVida(),0);        
    assertEquals(10, shura.getVida(),0);
    }*/
}
