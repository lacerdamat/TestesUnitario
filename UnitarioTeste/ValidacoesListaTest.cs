using UnitarioConsole.Classes;

namespace UnitarioTeste;

public class ValidacoesListaTests{

    private ValidacoesLista _val = new ValidacoesLista();

    [Fact]
    public void TirarNegativos()
    {
        var list = new List<int>{2,5,-1,9,-5};
        var listOk = new List<int>{2,5,9};
        Assert.Equal(listOk,_val.SemNegativos(list));
    }

    [Fact]
    public void TemNove(){
        int numb = 9;
        var list = new List<int>{1,2,9};

        Assert.Equal(true,_val.AcharNumeroX(list,numb));
    }

    [Fact]
    public void NaoTemDez(){
        int numb = 10;
        var list = new List<int>{1,2,9};
        Assert.Equal(false,_val.AcharNumeroX(list,numb));
    }

    [Fact]
    public void MultiplicaPorDois()
    {
        int numb = 2;
        var list = new List<int>{1,2,9};
        var list2 = new List<int>{2,4,18};
        Assert.Equal(list2,_val.MultiplicarPorX(list,numb));
    }

    [Fact]
    public void NoveMaior(){
        int numb = 9;
        var list = new List<int>{1,2,9};
        Assert.Equal(numb,_val.MaiorX(list));
    }

    [Fact]
    public void OitoNegativoMenor(){
        int numb = -8;
        var list = new List<int>{1,2,-8};
        Assert.Equal(numb,_val.MenorX(list));

    }

}