using Benchmark;

public class MyBenchmark
{
    private readonly MyMethods _methods = new MyMethods();

    [Benchmark]
    public void BenchmarkMethod1()
    {
        _methods.Method1();
    }
}