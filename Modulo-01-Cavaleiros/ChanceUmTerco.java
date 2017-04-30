public class ChanceUmTerco{ 
    private Sorteador sorteador;

    public ChanceUmTerco(Sorteador sorteador) {
        this.sorteador = sorteador;
    }

    public boolean ChanceUm() {
        int resultado = this.sorteador.sortear();
        return resultado % 3 == 0;
    }   
}
