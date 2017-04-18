public class Golpe{
    private String nomeGolpe;
    private int fatorDano;
    
    
    public Golpe(String nomeGolpe, int fatorDano){
        this.nomeGolpe = nomeGolpe;
        this.fatorDano = fatorDano;
    }
    
    public int getFatorDano(){
        return this.fatorDano;
    }
    
    public boolean equals(Object object){
        Golpe outroGolpe = (Golpe)object;
        return this.nomeGolpe.equals(outroGolpe.nomeGolpe)
        && this.fatorDano == outroGolpe.fatorDano;
    }
}