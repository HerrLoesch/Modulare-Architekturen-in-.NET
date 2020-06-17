using System;

namespace Infrastructure.Interfaces
{

    public interface INavigationRegistry
    {
        void RegisterNavigationStep(Type moduleType, Type stepView);
    }
}
