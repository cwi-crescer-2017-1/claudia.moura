import static org.junit.Assert.*;
import org.junit.After;
import org.junit.Before;
import org.junit.Test;
import java.util.ArrayList;

public class ListaSaintsTest {
    ArrayList<Saint> listaTeste = new ArrayList<>();

    /*Saint shaka = new Saint("Shaka", new Armadura(new Constelacao("Virgem"), Categoria.OURO));
    Saint saga = new Saint("Saga", new Armadura(new Constelacao("Gêmeos"), Categoria.OURO));
    Saint shiryu = new Saint("Shiryu", new Armadura(new Constelacao("Dragão"), Categoria.BRONZE));    
    Saint seiya = new Saint("Seiya", new Armadura(new Constelacao("Pégasus"), Categoria.BRONZE));
    Saint marin = new Saint("Marin", new Armadura(new Constelacao("Águia"), Categoria.PRATA));
    Saint shina = new Saint("Águia", new Armadura(new Constelacao("Cobra"), Categoria.PRATA));
     */
    
   // listaTeste.adicionar(Saint("Águia", new Armadura(new Constelacao("Cobra"), Categoria.PRATA)));
    
    
    @Test
    public void removerSaintRetiraSaintDaLista()  throws Exception{
        Saint shina = new Saint("Águia", new Armadura(new Constelacao("Cobra"), Categoria.PRATA));
        Saint marin = new Saint("Marin", new Armadura(new Constelacao("Águia"), Categoria.PRATA));
        Saint saga = new Saint("Saga", new Armadura(new Constelacao("Gêmeos"), Categoria.OURO));

        listaTeste.add(shina);
        listaTeste.add(marin);
        listaTeste.add(saga);
        
        
        
        
    }

    @Test
    public void buscarPorNomeRetornaSaintCorreto(){

    }

    @Test
    public void buscarPorCategoriaRetornaListaCorreta(){

    }

    @Test
    public void buscarPorStatusRetornaListaCorreta(){

    }

    @Test
    public void getSaintMaiorVidaRetornaSaintComMaiorVida(){

    }

    @Test
    public void getSaintMenorVidaRetornaSaintComMenorVida(){

    }

    @Test
    public void ordenarDeixaAListaOrdenada(){

    }
}
