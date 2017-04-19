import static org.junit.Assert.*;
import org.junit.After;
import org.junit.Before;
import org.junit.Test;
import java.util.ArrayList;

public class ListaSaintsTest {

    @Test public void buscarSaintExistentePorNome() throws Exception {
        ListaSaints lista = new ListaSaints();
        Saint june = new Saint("June", new Armadura(new Constelacao("Camaleão"), Categoria.BRONZE));
        Saint shina = new Saint("Águia", new Armadura(new Constelacao("Cobra"), Categoria.PRATA));
        Saint marin = new Saint("Marin", new Armadura(new Constelacao("Águia"), Categoria.PRATA));
        Saint saga = new Saint("Saga", new Armadura(new Constelacao("Gêmeos"), Categoria.OURO));

        lista.adicionar(shina);
        lista.adicionar(marin);
        lista.adicionar(saga);
        lista.adicionar(june);

        assertEquals(june, lista.buscarPorNome("June"));
    }

    @Test public void buscarSaintExistenteComRepeticaoDeNomes() throws Exception {
        ListaSaints lista = new ListaSaints();
        Saint june = new Saint("June", new Armadura(new Constelacao("Camaleão"), Categoria.BRONZE));
        Saint june2 = new SilverSaint("June", new Armadura(new Constelacao("Camaleão 2"), Categoria.PRATA));
        lista.adicionar(june2);
        lista.adicionar(june);
        assertEquals(june2, lista.buscarPorNome("June"));
    }

    @Test public void buscarSaintInexistente() throws Exception {
        ListaSaints lista = new ListaSaints();
        Saint june = new Saint("June", new Armadura(new Constelacao("Camaleão"), Categoria.BRONZE));
        Saint june2 = new SilverSaint("June", new Armadura(new Constelacao("Camaleão 2"), Categoria.PRATA));
        lista.adicionar(june2);
        lista.adicionar(june);
        assertNull(lista.buscarPorNome("San Junipero"));
    }

    @Test public void buscarSaintComListaVazia() {
        assertNull(new ListaSaints().buscarPorNome("Seiya"));
    }

    @Test
    public void buscarPorCategoriaListaVazia() {
        ListaSaints listaSaints = new ListaSaints();
        ArrayList<Saint> resultadoBusca = listaSaints.buscarPorCategoria(Categoria.BRONZE);
        assertEquals(new ArrayList<Saint>(), resultadoBusca);
    }

    @Test
    public void buscarPorCategoriaInexistente() throws Exception {
        ListaSaints listaSaints = new ListaSaints();
        Saint june = new Saint("June", new Armadura(new Constelacao("Camaleão"), Categoria.BRONZE));
        listaSaints.adicionar(june);
        ArrayList<Saint> resultadoBusca = listaSaints.buscarPorCategoria(Categoria.PRATA);
        assertEquals(new ArrayList<Saint>(), resultadoBusca);
    }

    @Test
    public void buscarPorCategoriaExistente() throws Exception {
        ListaSaints listaSaints = new ListaSaints();
        Saint june = new Saint("June", new Armadura(new Constelacao("Camaleão"), Categoria.BRONZE));
        Saint misty = new SilverSaint("Misty", new Armadura(new Constelacao("Lagarto"), Categoria.PRATA));
        listaSaints.adicionar(misty);
        listaSaints.adicionar(june);
        ArrayList<Saint> resultadoBusca = listaSaints.buscarPorCategoria(Categoria.BRONZE);
        assertEquals(june, resultadoBusca.get(0));
        assertEquals(1, resultadoBusca.size());
    }

    @Test
    public void buscarPorCategoriaComMaisDeUmExistenteNaCategoria() throws Exception {
        ListaSaints listaSaints = new ListaSaints();
        Saint june = new Saint("June", new Armadura(new Constelacao("Camaleão"), Categoria.BRONZE));
        Saint misty = new SilverSaint("Misty", new Armadura(new Constelacao("Lagarto"), Categoria.PRATA));
        Saint shun = new Saint("June", new Armadura(new Constelacao("Andrômeda"), Categoria.BRONZE));
        listaSaints.adicionar(shun);
        listaSaints.adicionar(misty);
        listaSaints.adicionar(june);
        ArrayList<Saint> resultadoBusca = listaSaints.buscarPorCategoria(Categoria.BRONZE);
        assertEquals(shun, resultadoBusca.get(0));
        assertEquals(june, resultadoBusca.get(1));
        assertEquals(2, resultadoBusca.size());
    }    

    /*Saint shaka = new Saint("Shaka", new Armadura(new Constelacao("Virgem"), Categoria.OURO));
    Saint saga = new Saint("Saga", new Armadura(new Constelacao("Gêmeos"), Categoria.OURO));
    Saint shiryu = new Saint("Shiryu", new Armadura(new Constelacao("Dragão"), Categoria.BRONZE));    
    Saint seiya = new Saint("Seiya", new Armadura(new Constelacao("Pégasus"), Categoria.BRONZE));
    Saint marin = new Saint("Marin", new Armadura(new Constelacao("Águia"), Categoria.PRATA));
    Saint shina = new Saint("Águia", new Armadura(new Constelacao("Cobra"), Categoria.PRATA));
     */

    // listaTeste.adicionar(Saint("Águia", new Armadura(new Constelacao("Cobra"), Categoria.PRATA)));

    @Test
    public void getSaintMenorVidaComApenasUm()throws Exception{
		ListaSaints listaSaints = new ListaSaints();
        Saint june = new BronzeSaint("June", new Armadura(new Constelacao("Camaleão"), Categoria.BRONZE));
        listaSaints.adicionar(june);      
		assertEquals(june, listaSaints.getSaintMaiorVida());
    }

	@Test
	public void getSaintMenorVidaComLista3() throws Exception{
        ListaSaints lista = new ListaSaints();
        Saint june = new Saint("June", new Armadura(new Constelacao("Camaleão"), Categoria.BRONZE));
        Saint marin = new Saint("Marin", new Armadura(new Constelacao("Águia"), Categoria.PRATA));
        Saint saga = new Saint("Saga", new Armadura(new Constelacao("Gêmeos"), Categoria.OURO));

        lista.adicionar(marin);
        lista.adicionar(saga);
        lista.adicionar(june); 

		june.perderVida(20);
		saga.perderVida(50);
 
		assertEquals(marin, lista.getSaintMaiorVida());
	}

        @Test
    public void getSaintMaiorVidaComListaVazia() {
        ListaSaints listaSaints = new ListaSaints();
        Saint maiorVida = listaSaints.getSaintMaiorVida();
        assertNull(maiorVida);
    }

    @Test
    public void getSaintMenorVidaComApenasTres() throws Exception {
        ListaSaints listaSaints = new ListaSaints();
        Saint june = new Saint("June", new Armadura(new Constelacao("Camaleão"), Categoria.BRONZE));
        Saint misty = new SilverSaint("Misty", new Armadura(new Constelacao("Lagarto"), Categoria.PRATA));
        Saint shun = new Saint("June", new Armadura(new Constelacao("Andrômeda"), Categoria.BRONZE));
        listaSaints.adicionar(shun);
        listaSaints.adicionar(misty);
        listaSaints.adicionar(june);
        shun.perderVida(10);
        june.perderVida(20);
        assertEquals(june, listaSaints.getSaintMenorVida());
    }

    @Test
    public void getSaintMenorVidaComListaVazia() {
        ListaSaints listaSaints = new ListaSaints();
        Saint menorVida = listaSaints.getSaintMenorVida();
        assertNull(menorVida);
    }

    /*@Test
    public void ordenarComListaTotalmenteDesordenada() throws Exception {
        ListaSaints listaSaints = new ListaSaints();
        Saint june = new Saint("June", new Armadura(new Constelacao("Camaleão"), Categoria.BRONZE));
        Saint misty = new SilverSaint("Misty", new Armadura(new Constelacao("Lagarto"), Categoria.PRATA));
        Saint shun = new Saint("Shun", new Armadura(new Constelacao("Andrômeda"), Categoria.BRONZE));
        listaSaints.adicionar(shun);
        listaSaints.adicionar(misty);
        listaSaints.adicionar(june);
        shun.perderVida(10);
        misty.perderVida(20);
        june.perderVida(30);
        listaSaints.ordenar();
        ArrayList<Saint> resultado = listaSaints.todos();
        assertEquals(june, resultado.get(0));
        assertEquals(misty, resultado.get(1));
        assertEquals(shun, resultado.get(2));
    }*/
    
    @Test
    public void ordenarComListaTotalmenteOrdenada() throws Exception {
        ListaSaints listaSaints = new ListaSaints();
        Saint june = new Saint("June", new Armadura(new Constelacao("Camaleão"), Categoria.BRONZE));
        Saint misty = new SilverSaint("Misty", new Armadura(new Constelacao("Lagarto"), Categoria.PRATA));
        Saint shun = new Saint("Shun", new Armadura(new Constelacao("Andrômeda"), Categoria.BRONZE));
        listaSaints.adicionar(shun);
        listaSaints.adicionar(misty);
        listaSaints.adicionar(june);
        shun.perderVida(30);
        misty.perderVida(20);
        june.perderVida(10);
        listaSaints.ordenar();
        ArrayList<Saint> resultado = listaSaints.todos();
        assertEquals(shun, resultado.get(0));
        assertEquals(misty, resultado.get(1));
        assertEquals(june, resultado.get(2));
    }
    
    @Test
    public void ordenarComListaVazia() throws Exception {
        ListaSaints listaSaints = new ListaSaints();
        listaSaints.ordenar();
        ArrayList<Saint> resultado = listaSaints.todos();
        assertEquals(new ArrayList<Saint>(), resultado);
    }
    
    @Test
    public void ordenarComListaApenasUm() throws Exception {
        ListaSaints listaSaints = new ListaSaints();
        Saint june = new Saint("June", new Armadura(new Constelacao("Camaleão"), Categoria.BRONZE));
        Saint misty = new SilverSaint("Misty", new Armadura(new Constelacao("Lagarto"), Categoria.PRATA));
        Saint shun = new Saint("Shun", new Armadura(new Constelacao("Andrômeda"), Categoria.BRONZE));
        listaSaints.adicionar(shun);
        shun.perderVida(30);
        listaSaints.ordenar();
        ArrayList<Saint> resultado = listaSaints.todos();
        assertEquals(shun, resultado.get(0));
        assertEquals(1, resultado.size());
    }
    
    @Test
    public void ordenarComListaDeValoresIguais() throws Exception {
        ListaSaints listaSaints = new ListaSaints();
        Saint june = new Saint("June", new Armadura(new Constelacao("Camaleão"), Categoria.BRONZE));
        Saint misty = new SilverSaint("Misty", new Armadura(new Constelacao("Lagarto"), Categoria.PRATA));
        Saint shun = new Saint("Shun", new Armadura(new Constelacao("Andrômeda"), Categoria.BRONZE));
        listaSaints.adicionar(shun);
        listaSaints.adicionar(misty);
        listaSaints.adicionar(june);
        listaSaints.ordenar();
        ArrayList<Saint> resultado = listaSaints.todos();
        assertEquals(shun, resultado.get(0));
        assertEquals(misty, resultado.get(1));
        assertEquals(june, resultado.get(2));
    }   
    
    @Test 
    public void ordenarComListaDeValoresIguaisComTipoOrdenacaoDescendente() throws Exception { 
        ListaSaints listaSaints = new ListaSaints(); 
        Saint june = new Saint("June", new Armadura(new Constelacao("Camaleão"), Categoria.BRONZE)); 
        Saint misty = new SilverSaint("Misty", new Armadura(new Constelacao("Lagarto"), Categoria.PRATA)); 
        Saint shun = new Saint("Shun", new Armadura(new Constelacao("Andrômeda"), Categoria.BRONZE)); 
        listaSaints.adicionar(shun); 
        listaSaints.adicionar(misty); 
        listaSaints.adicionar(june); 
        listaSaints.ordenar(TipoOrdenacao.DESCENDENTE); 
        ArrayList<Saint> resultado = listaSaints.todos(); 
        assertEquals(shun, resultado.get(0)); 
        assertEquals(misty, resultado.get(1)); 
        assertEquals(june, resultado.get(2)); 
    } 
}