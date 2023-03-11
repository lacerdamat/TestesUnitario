using UnitarioConsole.Classes;

namespace UnitarioTeste;

public class UnitTest1
{
    private ValidacoesString _val = new ValidacoesString();

    [Fact]
    public void Tamanho6()
    {
        string palavra = "Matrix";
        Assert.Equal(palavra.Length,_val.QuantidadeDeCaractere(palavra));
    }

    [Fact]
    public void DeveConter(){
        string palavra = "qualquer";
        string texto = "Este é um texto qualquer";
        Assert.True(_val.ContemCaractere(texto,palavra));
    }
    
    [Fact]
    public void NaoDeveConter(){
        string palavra = "Uai";
        string texto = "Este é um texto qualqer";
        Assert.False(_val.ContemCaractere(texto,palavra));
    }
    public void TerminaCom(){
        string palavra = "procurado";
        string texto = "Esse cara é um procurado";
        Assert.True(_val.TerminaCom(texto,palavra));

    }

    
}