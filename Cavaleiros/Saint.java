import java.security.InvalidParameterException;
import java.util.ArrayList;

public abstract class Saint
{
    private String nome;
    private Armadura armadura;
    private boolean armaduraVestida;
    private Genero genero = Genero.NAO_INFORMADO;
    private Status status = Status.VIVO;
    private double vida = 100.0;
    protected int qtdSentidosDespertados;
    private int acumuladorProximoGolpe = 0;

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

    public Status getStatus(){
        return this.status;
    }

    public double getVida(){
        return this.vida;
    }

    public void perderVida(double dano){

        if(dano < 0){
            throw new InvalidParameterException("dano");
        }else if (this.vida - dano <= 0){
            this.vida = 0;
            this.status = Status.MORTO;
        }else{
            this.vida = this.vida -= dano; 
        }

    }

    public Armadura getArmadura() {
        return this.armadura;
    }

    public int getQtdSentidosDespertados(){
        return this.qtdSentidosDespertados;
    }

    private Constelacao getConstelacao(){
        return this.armadura.getConstelacao();
    }

    public ArrayList<Golpe> getGolpes(){
        return getConstelacao().getGolpes();
    }

    public void aprenderGolpe(Golpe golpe){
        getConstelacao().adicionarGolpe(golpe);
    }

    public String getNome() {
        return this.nome;
    }

    public Golpe getProximoGolpe(){
        ArrayList<Golpe> golpes = getGolpes();
        int posicao = this.acumuladorProximoGolpe % golpes.size();
        this.acumuladorProximoGolpe++;
        return golpes.get(posicao);
    }

    public String getCSV() {

        // Interpolação de Strings: return `${nome},${vida},${status}`;
        return String.format(
            "%s,%s,%s,%s,%s,%s,%s",
            this.nome,
            this.vida,
            this.getConstelacao().getNome(),
            this.armadura.getCategoria(),
            this.status,
            this.genero,
            this.armaduraVestida
        );
    }

}