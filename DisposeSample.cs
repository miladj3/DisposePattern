public class MyClass : IDisposable
{
    private IntPtr _bufferPtr;
    public int BUFFER_SIZE = 1024 * 1024; // 1 MB
    private bool _disposed = false;
 
    public MyClass()
    {
        _bufferPtr =  Marshal.AllocHGlobal(BUFFER_SIZE);
    }
 
    protected virtual void Dispose(bool disposing)
    {
        if (_disposed)
            return;
 
        if (disposing)
        {
            // Free any other managed objects here.
        }
 
        // Free any unmanaged objects here.
        Marshal.FreeHGlobal(_bufferPtr);
        _disposed = true;
    }
 
    public void Dispose()
    {
        Dispose(true);
        GC.SuppressFinalize(this);
    }
 
    ~MyClass()
    {
        Dispose(false);
    }
}
