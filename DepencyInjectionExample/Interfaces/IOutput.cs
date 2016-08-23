
namespace DepencyInjectionExample.Interfaces
{
    /// <summary>
    /// This interface helps decouple the concept of
    /// "writing output" from the Console class. We
    /// don't really "care" how the Write operation
    /// happens, just that we can write.
    /// </summary>
    public interface IOutput
    {
        void Write(string contect);
    }
}
