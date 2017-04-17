public class Saint
{
    private String nome;
    private Armadura armadura;
    private boolean armaduraVestida;
    private Genero genero = Genero.NAO_INFORMADO;
    private Status status = Status.VIVO;
    private double vida = 100.0;
    private int qtdSentidos = 5;
    
    public Saint(String nome, Armadura armadura) {
        this.nome = nome;  
        this.armadura = armadura;
    }
    
    public void vestirArmadura(){
        this.armaduraVestida = true;
    }
    
    public boolean getArmaduraVestida() {
        return this.armaduraVestida;
    }
    
    public Genero getGenero(){
        return this.genero;
    }
    
    public void setGenero(Genero genero){
        this.genero = genero;
    }
    
    public void setStatus(Status status){
        this.status = status;
    }    
    
    public Status getStatus(){
        return this.status;
    }

    public double getVida(){
        return this.vida;
    }
    
    public double perderVida(double vidaPerdida){
       vida = this.vida -= vidaPerdida;
       return vida;
    }
         
    public Armadura getArmadura() {
       return this.armadura;
    }
    
    public int getQtdSentidosDespertados(){
        return this.qtdSentidos;
    }
}

