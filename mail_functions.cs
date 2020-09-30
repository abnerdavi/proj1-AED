using System;
using System.Linq;
using System.Collections.Generic;

class mail_functions{

  public double getStorageUse(double tamanhoCaixa, int qtdAtual){ 
    return ((qtdAtual*100)/tamanhoCaixa);
  }

  public int getQtdPrioritario(string prioridade, List<string> mailBox){
    return (mailBox.Count(x => x.Contains(prioridade)));
  }
  
}