using System;

namespace Infrastructure.Interfaces
{
    public interface INavigationService
    {
        void Next(int id);
        
        void Back();

        void NavigateTo(Type moduleType, int? id = null);
    }
}