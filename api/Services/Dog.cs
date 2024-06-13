using api.Abstractions;

namespace api.Services
{
    public class Dog : IAnimal
    {
        public string MakeSound()
        {
            return "Hav Hav Hav";
        }
    }
}
