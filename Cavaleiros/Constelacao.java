public class Constelacao{    
    private String nome;
    private String[] golpes = new String[3];
    int nrLista = 0;

    public Constelacao(String nome){
        this.nome = nome;
        this.golpes = golpes;
    }

    public String getNomeConstelacao(){
        return this.nome;
    }

    public void adicionarGolpe(String golpe) throws Exception
    {
        if(golpes.length <= 3){
            this.golpes[nrLista] = golpe;
            nrLista++;
        }else{
            throw new Exception ("Quantidade de golpes excedida");
        }
    }
    
    public String[] getGolpes(){
        return this.golpes;
    }

}