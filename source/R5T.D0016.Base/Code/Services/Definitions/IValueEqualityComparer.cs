using System;
using System.Threading.Tasks;

using R5T.D0010;
using R5T.T0064;


namespace R5T.D0016
{
    [ServiceDefinitionMarker]
    public interface IValueEqualityComparer<T> : IServiceDefinition
    {
        Task<bool> Equals(T x, T y, IMessageSink messageSink);
    }
}
