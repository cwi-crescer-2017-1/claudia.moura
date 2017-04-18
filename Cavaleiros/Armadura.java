public class Armadura {
    private Constelacao constelacao;
    private Categoria categoria;
    
    public Armadura(String constelacao, Categoria categoria){
        this.constelacao = constelacao.getConstelacao();
        this.categoria = categoria;
    }
    
    
    
    public Categoria getCategoria(){
        return this.categoria;
    }
}