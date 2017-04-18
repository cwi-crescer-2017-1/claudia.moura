import java.security.InvalidParameterException;

public class Saint
{
    private String nome;
    private Armadura armadura;
    private boolean armaduraVestida;
    private Genero genero = Genero.NAO_INFORMADO;
    private Status status = Status.VIVO;
    private double vida = 100.0;
    protected int qtdSentidosDespertados;
    private Golpe golpe;

    public Saint(String nome, Armadura armadura) throws Exception{
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
        if(this.vida < 1){
            this.status = Status.MORTO;
        }
        return this.status;
    }

    public double getVida(){
        return this.vida;
    }

    public double perderVida(double vidaPerdida){

        if(vidaPerdida < 0){
            throw new InvalidParameterException("vidaPerdida");
        }else{
            this.vida = this.vida -= vidaPerdida; 
        }

        if (this.vida < 0){
            this.vida = 0;
            this.status = Status.MORTO;
        }        
        return this.vida;        
    }

    public Armadura getArmadura() {
        return this.armadura;
    }

    public int getQtdSentidosDespertados(){
        return this.qtdSentidosDespertados;
    }

    public Golpe[] getGolpes(){
        return this.armadura.getConstelacao().getGolpes();
    }
    
    public void aprenderGolpe(Golpe golpe){
        this.armadura.getConstelacao().adicionarGolpe(golpe);
    }

    // public Golpe(String nome, int fator dano) {};

}