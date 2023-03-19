using System;

namespace _Code.Services.Interfaces
{
    public interface IElectroService
    {
       Action<bool> electrified { get; set; }
    }
}