using System;

//ATRIBUTO NOME (GET E SET)
//INSERIR CONSTRUTOR NÃO VAZIO (COMPLETO)
class vendedor{
  double salario,comissao;

  string nome;
  public void setNome(string n){
    nome = n;
  }
  public string getNome(){
    return nome;
  }

  public double receber_relatorio(double valor_vendas){
    return (salario + comissao*valor_vendas);
  }

  public vendedor (string n, double s, double c){
    nome = n;
    salario = s;
    comissao = c;
  }

}