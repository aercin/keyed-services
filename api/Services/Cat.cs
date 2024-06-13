using api.Abstractions;

namespace api.Services
{
    public class Cat : IAnimal
    {
        public string MakeSound()
        {
            return "Meow Meow Meow";
        }
    }
}
