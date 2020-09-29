using System;
using System.Collections.Generic;

class mail_accounts{
  string nome = null, endereco = null;
  double storage;
  List<string> inbox = new List<string>();

  public void setNome(string nomeUser) => nome = nomeUser;

  public void setEndereco(string enderecoUser) => endereco = enderecoUser;

  public void setStorage(double armazenamento) => storage = armazenamento;

  public void addMail(string mailAddress) => inbox.Add(mailAddress);

  public List<string> GetList(){ return inbox; }

  public string getNome(){ return nome;}

  public string getEndereco(){ return endereco; }

  public double getStorage(){ return storage; }

  public int getQtdEmls(){ return inbox.Count; }      
}