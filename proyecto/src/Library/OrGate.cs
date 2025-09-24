namespace Library;

public class OrGate : ILogicGate
{
    public string Name { get; set; }
    public List<int> Entrys { get; set; }

    public void AddEntry(int value)
    {
        if ((Entrys.Count < 2) && (value == 1 || value == 0))
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
            if (element==0 || element==1)
            {
                if (suma != 1)
                {
                    suma += element;
                }
            }
        }
        return suma;
    }
    
    public OrGate(string name)
    {
        this.Name = name;
        this.Entrys = new List<int>();
    }
}
