namespace Library;

public class AndGate : ILogicGate
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
        int producto = 1;
        foreach (int element in Entrys)
        {
            if (element==0 || element==1)
            {
                producto *= element;
            }
            else
            {
                Console.WriteLine($"Error: Hay un elemento de la lista que tiene valor {element} cuando los unicos valores permitidos son 0 o 1");
            }
        }
        return producto;
    }

    public AndGate(string name)
    {
        this.Name = name;
        this.Entrys = new List<int>();
    }
}