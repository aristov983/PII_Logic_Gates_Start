namespace Library;

public class NotGate : ILogicGate
{
    
    public string Name { get; set; }
    public List<int> Entrys { get; set; }

    public void AddEntry(int value)
    {
        if ((Entrys.Count < 1) && (value == 1 || value == 0))
        {
            Entrys.Add(value); 
        }
        else
        {
            Console.WriteLine($"Error, la lista de la compueta ya está llena o el valor {value} es invalido.");
        }
    }

    public int Calculate()
    {
        int suma = 0;
        foreach (int element in Entrys)
        {
            if (element==0)
            {
                suma += 1;
            }
            else
            {
                suma += 0;
            }
        }
        return suma;
    }
    
    public NotGate(string name)
    {
        this.Name = name;
        this.Entrys = new List<int>();
    }
}