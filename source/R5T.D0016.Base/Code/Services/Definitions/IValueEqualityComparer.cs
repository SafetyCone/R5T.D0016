using System;
using System.Threading.Tasks;

using R5T.D0010;


namespace R5T.D0016
{
    public interface IValueEqualityComparer<T>
    {
        Task<bool> Equals(T x, T y, IMessageSink messageSink);
    }
}
