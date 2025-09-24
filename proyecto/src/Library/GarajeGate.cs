namespace Library;

public class GarajeGate
{
    public AndGate And1 = new AndGate("and1");
    public AndGate And2 = new AndGate("and2");
    public AndGate And3 = new AndGate("and3");
    public OrGate  Or1 = new OrGate("or1");
    public NotGate Not1 = new NotGate("not2");
    public NotGate Not2 = new NotGate("not3");
    
    
    public int OpenGate(int A, int B, int C)
    {
        And1.AddEntry(A);
        And1.AddEntry(B);
        
        Not1.AddEntry(A);
        Not2.AddEntry(B);

        And2.AddEntry(Not1.Calculate());
        And2.AddEntry(Not2.Calculate());
        
        Or1.AddEntry(And1.Calculate());
        Or1.AddEntry(And2.Calculate());
        
        And3.AddEntry(Or1.Calculate());
        And3.AddEntry(C);

        return And3.Calculate();
    }

    public GarajeGate()
    {
    }
}