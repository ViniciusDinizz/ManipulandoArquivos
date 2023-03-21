using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManipulandoArquivos
{
    internal class Person
    {
        public string Name { get; set; }
        public char Gender { get; set; }

        public Person(string name, char gender)
        {
            this.Name = name;
            this.Gender = gender;   
        }

        public override string ToString()
        {
            return $"Nome: {Name} | Genero: {Gender}";
        }
    }
}
