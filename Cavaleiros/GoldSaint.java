public class GoldSaint extends Saint {
    
    public GoldSaint(String nome, Armadura armadura) throws Exception {
        super(nome,armadura);
        this.qtdSentidosDespertados = 7;

        
        Constelacao constelacao = armadura.getConstelacao();
        if ( !constelacao.getNomeConstelacao().equals("Áries") 
        && !constelacao.getNomeConstelacao().equals("Touro")
        && !constelacao.getNomeConstelacao().equals("Gêmeos")
        && !constelacao.getNomeConstelacao().equals("Câncer")
        && !constelacao.getNomeConstelacao().equals("Virgem")
        && !constelacao.getNomeConstelacao().equals("Leão")
        && !constelacao.getNomeConstelacao().equals("Libra")
        && !constelacao.getNomeConstelacao().equals("Escorpião")
        && !constelacao.getNomeConstelacao().equals("Sagitário")
        && !constelacao.getNomeConstelacao().equals("Capricórnio")
        && !constelacao.getNomeConstelacao().equals("Aquário")
        && !constelacao.getNomeConstelacao().equals("Peixes")) {
            // dar erro
            throw new Exception("Constelação inválida");
        }
    }
}
