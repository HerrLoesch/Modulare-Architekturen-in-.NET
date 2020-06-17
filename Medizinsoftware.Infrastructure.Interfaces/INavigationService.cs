using System;

namespace Infrastructure.Interfaces
{
    public interface INavigationService
    {
        void Next();
        
        void Back();

        void NavigateTo(Type moduleType);
    }
}