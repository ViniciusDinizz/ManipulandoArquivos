using ManipulandoArquivos;

internal class Program
{
    private static void Main(string[] args)
    {
        string name;
        string file;
        char gender;

        Person person1 = CreatePerson();
        Person person2 = CreatePerson();

        WriteFile(person1);
        WriteFile(person2);

        Console.Clear();

        Console.WriteLine("Informe o nome do arquivo a ser lido: ");
        file = Console.ReadLine();

        var texto = ReadFile(file);

        Console.WriteLine(texto);

        string ReadFile(string file)
        {
            string texto;
            if (!File.Exists(file))
            {
                return "Não existe esse arquivo";

            }
            else
            {
                StreamReader sr = new StreamReader(file);

                try
                {


                    texto = sr.ReadToEnd();

                }
                catch
                {
                    throw;
                }
                finally
                {
                    sr.Close();
                }
            }
            return texto;
        }

        void WriteFile(Person person)
        {
            try
            {
                if (File.Exists("backup.txt"))
                {
                    var temp = ReadFile("backup.txt");
                    StreamWriter sw = new("backup.txt");
                    sw.WriteLine(temp + person.ToString());
                    sw.Close();
                }
                else
                {
                    StreamWriter sw = new("backup.txt");
                    sw.WriteLine(person.ToString());
                    sw.Close();
                }
            }
            catch (Exception ex)
            {

                throw;
            }
            finally
            {
                Console.WriteLine("Registro gravado com sucesso.");
                Thread.Sleep(1000);
            }
        }

        Person CreatePerson()
        {
            Console.Write("Informe o nome da pessoa: ");
            name = Console.ReadLine();
            Console.Write("Informe o gênero da pessoa: ");
            gender = char.Parse(Console.ReadLine());

            return new Person(name.ToUpper(), gender);
        }

    }
}