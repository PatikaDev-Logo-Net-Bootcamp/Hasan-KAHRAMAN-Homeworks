using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework1.Core
{
    public interface IDuck
    {
        public void Swim();

    }

    public interface IDuckFlyable : IDuck
    {
        public void Fly();
    }

    public class MallarDuck : IDuckFlyable
    {
        public void Fly()
        {
            throw new NotImplementedException();
        }

        public void Swim()
        {
            throw new NotImplementedException();
        }
    }

    public class RubberDuck : IDuck
    {
        public void Swim()
        {
            //Yüzebilir ama uçamaz
        }
    }


}
