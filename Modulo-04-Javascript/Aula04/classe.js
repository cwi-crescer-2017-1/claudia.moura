class serieDeTV{
  constructor(nome, anoEstreia){
    this.nome = nome || "NI";
    this.anoEstreia = anoEstreia;
  }

  static verificarClassificacaoIndicativa(){
    console.log(this);
    return this.nome;
  }

  get nomeSerie(){
    return this.nome;
  }

  set nomeSerie(valor) {
    this.nome = valor.toUpperCase();
  }

  imprimirNome(){
    console.log.(this.nome.toUpperCase());
  }

  html(){
    return `<h2>${ this.nome } </h2><br><h3>${ this.anoEstreia }</h3>`
  }

}
