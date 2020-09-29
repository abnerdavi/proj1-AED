using System;

class MainClass{

    public static void Main(){
        mail_accounts conta = new mail_accounts();
        mail_functions assist = new mail_functions();
        
        string emailPrioritario = "marlonferrari@ucl.br"; 

        conta.setNome("Davi Miranda");
        conta.setEndereco("davi.miranda@timenow.com.br");
        conta.setStorage(10);
        
        conta.addMail("jebediah@vale.com");
        conta.addMail("marlonferrari@ucl.br");
        conta.addMail("abner_davi@ucl.br");
        conta.addMail("erickdavi@gmail.com");
        conta.addMail("marlonferrari@ucl.br");
        conta.addMail("contoso@outlook.com");
        
        Console.WriteLine("nome: {0}", conta.getNome());
        Console.WriteLine("{0}% usado", assist.getStorageUse(conta.getStorage(),conta.getQtdEmls()));
        
        Console.WriteLine("Há {0} emails prioritarios em sua caixa", assist.getQtdPrioritario(emailPrioritario,conta.GetList()));

    }
}
