// See https://aka.ms/new-console-template for more information
//solução do sistema de estacionamento para o bootcamp xp fullstack na DIO

Estacionamento estacionamento = new Estacionamento(1.5f);
estacionamento.adicionarVeiculo();
Thread.Sleep(60000);
estacionamento.adicionarVeiculo();
Thread.Sleep(60000);
estacionamento.verQuantidadeDeVeiculosEstacionados();
estacionamento.retirarVeiculo(1);
class Estacionamento
{
    private float taxa = 0.50f; //taxa por minuto

    List<DateTime> lista = new List<DateTime>();
    public void adicionarVeiculo() {
        lista.Add(DateTime.Now);
    }
    public void retirarVeiculo(int idx) {
        DateTime? data = lista[idx];
        if (data == null) throw new Exception("Veículo não encontrado");
        float taxaCobrada = DateTime.Now.Subtract(data.Value).Minutes * taxa;
        Console.WriteLine($"Veículo removido, taxa: {taxaCobrada:C}");
     }

    public void verQuantidadeDeVeiculosEstacionados()
    {
        foreach (var item in lista)
        {
           Console.WriteLine($"Veiculo estacionado em: { item.ToLongDateString() }");
        }
    }
   public Estacionamento() { }
    public Estacionamento(float taxa)
    {
        this.taxa = taxa;        
    }

 
}

