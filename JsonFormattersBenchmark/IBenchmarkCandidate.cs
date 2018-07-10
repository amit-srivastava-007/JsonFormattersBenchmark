namespace JsonFormattersBenchmark
{
    interface IBenchmarkCandidate<T>
    {
        string Serialize();
        T DeSerialize();
    }
}
