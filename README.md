# DisposePattern
When you’re allocating unmanaged resources yourself, then you definitely should use the Dispose pattern. Here’s an example:

https://michaelscodingspot.com/find-fix-and-avoid-memory-leaks-in-c-net-8-best-practices/

The point of this pattern is to allow explicit disposal of resources. But also to add a safeguard that your resources will be disposed during garbage collection (in the Finalizer) if the Dispose() wasn’t called.

The GC.SuppressFinalize(this) is also important. It makes sure the Finalizer isn’t called on garbage collection if the object was already disposed. Objects with Finalizers are freed differently and much more costly. The Finalizer is added to something called the F-Reachable-Queue, which makes the object survive an additional GC generation. 
