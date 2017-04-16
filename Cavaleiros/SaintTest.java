import static org.junit.Assert.*;
import org.junit.After;
import org.junit.Before;
import org.junit.Test;

public class SaintTest
{
   @Test   
   public void vestirArmaduraDeixaArmaduraVestida(){
       // AAA
       // 1. Arrange - montagem dos dados de teste
       Armadura virgo = new Armadura("Virgem", Categoria.OURO);
       Saint shaka = new Saint("Shaka", virgo);
       // 2. Act - invocar ação a ser testada
       shaka.vestirArmadura();
       // 3. Assert - verificação dos resultados do teste
       boolean resultado = shaka.getArmaduraVestida();
       assertEquals(true, resultado);
    }
    
    @Test
    public void naoVestirArmaduraDeixaArmaduraNaoVestida() {
        Saint saga = new Saint("Saga", new Armadura("Gêmeos", Categoria.BRONZE));
        assertEquals(false, saga.getArmaduraVestida());
        
    }
    
    @Test
    public void aoCriarSaintGeneroENaoInformado(){
        Armadura cancer = new Armadura("Câncer", Categoria.OURO);
        Saint mm = new Saint("Máscara da Morte", cancer);
        assertEquals(Genero.NAO_INFORMADO, mm.getGenero());
        
    }
    
    @Test
    public void cavaleiroECriadoComVida(){
        Armadura aries = new Armadura("Áries", Categoria.OURO);
        Saint mu = new Saint("Mu", aries);
        assertEquals(Status.VIVO, mu.getStatus());
        
    }
    
    @Test
    public void cavaleiroECriadoComVidaIgualACem(){
        Armadura aries = new Armadura("Áries", Categoria.OURO);
        Saint mu = new Saint("Mu", aries);
        assertEquals(100.0, mu.getVida(), 0);
    }
   
    @Test   
     public void perderVidaFazVidaDiminuirNaQuantidadeIndicada(){
       Armadura unicornio = new Armadura("Unicórnio", Categoria.BRONZE);
       Saint jabu = new Saint("Jabu", unicornio);
       jabu.perderVida(15);
       assertEquals(85.0, jabu.getVida(), 0);

    }
}
