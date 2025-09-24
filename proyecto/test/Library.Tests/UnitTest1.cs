using System.Runtime.InteropServices.JavaScript;

namespace Library.Tests;

public class Tests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void AndAddEntry_Calculate_Return0or1()
    {
        AndGate and1 = new AndGate("And1");
        AndGate and2 = new AndGate("And2");
        AndGate and3 = new AndGate("And3");
        AndGate and4 = new AndGate("And4");

        and1.AddEntry(1);
        and1.AddEntry(0);
        
        and2.AddEntry(0);
        and2.AddEntry(1);
        
        and3.AddEntry(0);
        and3.AddEntry(0);
        
        and4.AddEntry(1);
        and4.AddEntry(1);
        
        Assert.That(and1.Calculate(), Is.EqualTo(0));
        Assert.That(and2.Calculate(), Is.EqualTo(0));
        Assert.That(and3.Calculate(), Is.EqualTo(0));
        Assert.That(and4.Calculate(), Is.EqualTo(1));
    }

    [Test]
    public void OrAddEntry_Calculate_Return0or1()
    {
        OrGate or1 = new OrGate("or1");
        OrGate or2 = new OrGate("or2");
        OrGate or3 = new OrGate("or3");
        OrGate or4 = new OrGate("or4");

        or1.AddEntry(1);
        or1.AddEntry(0);
        
        or2.AddEntry(0);
        or2.AddEntry(1);
        
        or3.AddEntry(0);
        or3.AddEntry(0);
        
        or4.AddEntry(1);
        or4.AddEntry(1);
        
        Assert.That(or1.Calculate(), Is.EqualTo(1));
        Assert.That(or2.Calculate(), Is.EqualTo(1));
        Assert.That(or3.Calculate(), Is.EqualTo(0));
        Assert.That(or4.Calculate(), Is.EqualTo(1));
    }

    [Test]
    public void NotAddEntry_Calculate_Return0or1()
    {
        NotGate not1 = new NotGate("not1");
        NotGate not2 = new NotGate("not2");
        
        not1.AddEntry(1);
        not2.AddEntry(0);
        
        Assert.That(not1.Calculate(), Is.EqualTo(0));
        Assert.That(not2.Calculate(), Is.EqualTo(1));
    }

    [Test]
    public void AndEntry_WrongAssign_EntrysReturnEmpty()
    {
        AndGate and1 = new AndGate("And1");
        and1.AddEntry(9);
        and1.AddEntry(1391931);
        Assert.That(and1.Entrys, Is.Empty);
    }

    [Test]
    public void OrEntry_WrongAssign_CalculateReturnEmpty()
    {
        OrGate or1 = new OrGate("Or1");
        or1.AddEntry(9);
        or1.AddEntry(1391931);
        Assert.That(or1.Entrys, Is.Empty);
    }

    [Test]
    public void NotEntry_WrongAssign_CalculateReturnEmpty()
    {
        NotGate not1 = new NotGate("not1");
        not1.AddEntry(19919319);
        Assert.That(not1.Entrys, Is.Empty);
    }

    [Test]
    public void NotEntry_WrongAssign_EntrysCount1()
    {
        NotGate not1 = new NotGate("not1");
        not1.AddEntry(1);
        not1.AddEntry(2);
        Assert.That(not1.Entrys.Count, Is.EqualTo(1));
    }

    [Test]
    public void GarajeGate_OpenGateABCPressed_1()
    {
        GarajeGate garajeGate = new GarajeGate();
        int resultado = garajeGate.OpenGate(1, 1, 1);
        
        Assert.That(resultado, Is.EqualTo(1));
    }

    [Test]
    public void GarajeGate_OpenGateCPressed_1()
    {
        GarajeGate garajeGate = new GarajeGate();
        int resultado = garajeGate.OpenGate(0, 0, 1);
        
        Assert.That(resultado, Is.EqualTo(1));
    }

    [Test]
    public void GarajeGate_OpenGate_0()
    {
        GarajeGate garajeGate = new GarajeGate();
        int resultado = garajeGate.OpenGate(1, 1, 0);
        
        Assert.That(resultado, Is.EqualTo(0));
    }

    [Test]
    public void GarajeGate_OpenGate2_0()
    {
        GarajeGate garajeGate = new GarajeGate();
        int resultado = garajeGate.OpenGate(0, 0, 0);
        
        Assert.That(resultado, Is.EqualTo(0));
    }
}