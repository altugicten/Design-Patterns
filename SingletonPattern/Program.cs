using SingletonPattern;

new SingletonPublic();
new SingletonPublic();
new SingletonPublic();

Console.WriteLine();

Singleton s1 = Singleton.GetInstance;
Singleton s2 = Singleton.GetInstance;
Singleton s3 = Singleton.GetInstance;

Console.WriteLine();

SingletonWithConstructor swc1 = SingletonWithConstructor.GetInstance;
SingletonWithConstructor swc2 = SingletonWithConstructor.GetInstance;
SingletonWithConstructor swc3 = SingletonWithConstructor.GetInstance;

Console.WriteLine();

#region Singleton for showing Async
var t1 = Task.Run(() =>
{
    SingletonAsync.GetInstanceAsyncExample();
});

var t2 = Task.Run(() =>
{
    SingletonAsync.GetInstanceAsyncExample();
});

await Task.WhenAll(t1, t2);

var t3 = Task.Run(() =>
{
    SingletonAsync.GetInstanceAsyncExample();
});

var t4 = Task.Run(() =>
{
    SingletonAsync.GetInstanceAsyncExample();
});

await Task.WhenAll(t3, t4);
#endregion
