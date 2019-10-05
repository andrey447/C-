using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class Cat
    {
        public float Age;
        public BreedEnum Breed;
        private string _name;
        public string Name {get; set;}

        public Cat(string name, float age, BreedEnum breed = BreedEnum.Brit)
        {
            this.Name = name;
            this.Age = age;
            this.Breed = breed;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(this.Name);
            sb.AppendLine(this.Age.ToString());
            sb.AppendLine(this.Breed.ToString());

            return sb.ToString();
        }

        
    }
}
