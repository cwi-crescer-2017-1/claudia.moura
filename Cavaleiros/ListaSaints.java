import java.util.ArrayList;
import java.util.stream.Collectors;

public class ListaSaints {

    private ArrayList<Saint> listaSaints = new ArrayList<>();

    //adicionar(Saint): adiciona Saint ao final da lista
    public void adicionar(Saint saint) {
        this.listaSaints.add(saint);         
    }

    //get(indice): busca o Saint na posição informada por parâmetro
    public Saint getSaint(int indice){
        return this.listaSaints.get(indice);

    }

    //todos(): retorna toda lista de Saint.
    public ArrayList<Saint> todos(){
        return this.listaSaints;
    }

    //remover(Saint): retira o Saint informado da lista
    public void remover(Saint saint){
        this.listaSaints.remove(saint);            
    }

    //buscarPorNome(String): retorna o primeiro Saint que encontrar com o mesmo nome informado no parâmetro
    public Saint buscarPorNome(String nome){
        return this.listaSaints.stream()
        .filter(s -> s.getNome().equals(nome))
        .findFirst()
        .orElse(null); 

        /*for (Saint saint : this.listaSaints) {
        if (saint.getNome().equals(nome)) {
        return saint;
        } 
        }
        return null;   */
    }
    //buscarPorCategoria(Categoria): retorna uma sub-lista de Saint que tenham armadura na categoria nformada
    public ArrayList<Saint> buscarPorCategoria(Categoria categoria){
        ArrayList<Saint> subLista = new ArrayList<Saint>();
        for (Saint saint : this.listaSaints) {
            if (saint.getArmadura().getCategoria().equals(categoria)){
                subLista.add(saint);
            }
        }
        return subLista;
    }

    //buscarPorStatus(Status): retorna uma sub-lista de Saint que tenham o status informado por parâmetro
    public ArrayList<Saint> buscarPorStatus(Status status){
        /*ArrayList<Saint> subLista = new ArrayList<Saint>();
        for (Saint saint : this.listaSaints) {
            if (saint.getStatus().equals(status)){
                subLista.add(saint);
            }
        }
        return subLista;*/
			        return (ArrayList<Saint>)this.listaSaints.stream()
            .filter(s -> s.getStatus().equals(status))
            .collect(Collectors.toList());       


    }		

    //getSaintMaiorVida(): retorna o Saint com maior vida da lista. Caso existam um ou mais Saint com a mesma maior quantidade de vida, retorne o primeiro.
    public Saint getSaintMaiorVida(){
		if(listaSaints.isEmpty()){
			return null;
		}

		Saint maiorVida = this.listaSaints.get(0);

        for (int i = 1; i < this.listaSaints.size(); i++) {
			Saint saint = this.listaSaints.get(i);
			boolean encontreiMaior = saint.getVida() > maiorVida.getVida();
			if(encontreiMaior){
				maiorVida = saint;
			 }
		}
		return maiorVida;        	  
    }
         
    //getSaintMenorVida(): retorna o Saint com menor vida da lista. Caso existam um ou mais Saint com a mesma menor quantidade de vida, retorne o primeiro.
    public Saint getSaintMenorVida(){
		if(listaSaints.isEmpty()){
			return null;
		}

		Saint menorVida = this.listaSaints.get(0);

        for (int i = 1; i < this.listaSaints.size(); i++) {
			Saint saint = this.listaSaints.get(i);
			boolean encontreiMenor = saint.getVida() < menorVida.getVida();
			if(encontreiMenor){
				menorVida = saint;
			 }
		}
		return menorVida; 
    }

    //ordenar(): ordena os Saints de acordo com sua vida (ascendente, do menor ao maior). Importante: esta operação APENAS ordena a lista de Saints e não a retorna.
    public void ordenar(){

		boolean posicoesSendoTrocadas = false;
		do {
			for (int i = 0; i< this.listaSaints.size() - 1; i++){
				Saint atual = this.listaSaints.get(i);
				Saint proximo = this.listaSaints.get(i+ 1);
				boolean precisaTrocar = atual.getVida() > proximo.getVida();
				if(precisaTrocar){
					Saint troca = atual;
					this.listaSaints.set(i, proximo);
					this.listaSaints.set(i + 1, troca);
					posicoesSendoTrocadas = true;
				}
			}
		} while (posicoesSendoTrocadas);
		
    }
}

