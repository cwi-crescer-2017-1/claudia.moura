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
    private int acumuladorProximoDaLista = 0;
    private ArrayList<Movimento> movimentos = new ArrayList<>();

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
        if (golpes.isEmpty()){
            return null;
        }
        int posicao = this.acumuladorProximoDaLista % golpes.size();
        this.acumuladorProximoDaLista++;
        return golpes.get(posicao);
    }

    //Adiciona o movimento na lista de movimentos
    public void adicionarMovimento(Movimento movimentos){
        this.movimentos.add(movimentos);
    }

    //Obtém o próximo movimento a ser executado sempre de maneira circular, similar à lógica de getProximoGolpe.
    public Movimento getProximoMovimento(){
        if (movimentos.isEmpty()){
            return null;
        }
        int posicao = this.acumuladorProximoDaLista % movimentos.size();
        this.acumuladorProximoDaLista++;
        return movimentos.get(posicao);
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