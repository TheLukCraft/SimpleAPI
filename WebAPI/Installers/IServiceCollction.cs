using AutoMapper;
using System;

namespace WebAPI.Installers
{
    public interface IServiceCollction
    {
        void AddControllers();
        void AddSingleton(IMapper mapper);
        void AddScoped<T1, T2>();
        void AddSwaggerGen(Action<object> p);
    }
}