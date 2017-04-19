import java.util.ArrayList;
public class ListaSaints {
    
    ArrayList<Saint> listaSaints = new ArrayList<>();
    
    //adicionar(Saint): adiciona Saint ao final da lista
    public void adicionar(Saint saint) {
        this.listaSaints.add(saint);         
    }

    //get(indice): busca o Saint na posição informada por parâmetro
    public Saint getSaint(int indice){
        return this.listaSaints.get(indice);

    }

    //todos(): retorna toda lista de Saint.
    public ArrayList todos(){
        return this.listaSaints;
    }

    //remover(Saint): retira o Saint informado da lista
    public void remover(Saint saint){
        int posicao = this.listaSaints.indexOf(saint);
        if (posicao > 0){
            this.listaSaints.remove(posicao);            
        }

    }
    
    //buscarPorNome(String): retorna o primeiro Saint que encontrar com o mesmo nome informado no parâmetro
    public Saint buscarPorNome(Saint saint){
        int posicao = this.listaSaints.indexOf(saint);
        return null;    
    }
    
    //buscarPorCategoria(Categoria): retorna uma sub-lista de Saint que tenham armadura na categoria nformada
    public ArrayList buscarPorCategoria(Categoria categoria){
        for (Saint saint : this.listaSaints) {
                     
        }
        return null;    
    }
    
    //buscarPorStatus(Status): retorna uma sub-lista de Saint que tenham o status informado por parâmetro
    public ArrayList buscarPorStatus(Status status){
        for (Saint saint : this.listaSaints) {}
        return null;    
    }
    
    //getSaintMaiorVida(): retorna o Saint com maior vida da lista. Caso existam um ou mais Saint com a mesma maior quantidade de vida, retorne o primeiro.
    public String getSaintMaiorVida(){
        for (Saint saint : this.listaSaints) {}
        return null;    
    }
    
    //getSaintMenorVida(): retorna o Saint com menor vida da lista. Caso existam um ou mais Saint com a mesma menor quantidade de vida, retorne o primeiro.
    public Saint getSaintMenorVida(){
        for (Saint saint : this.listaSaints) {}
        return null;
    }

    //ordenar(): ordena os Saints de acordo com sua vida (ascendente, do menor ao maior). Importante: esta operação APENAS ordena a lista de Saints e não a retorna.
    public void ordenar(){
    
    }
}
    

    

    
    



