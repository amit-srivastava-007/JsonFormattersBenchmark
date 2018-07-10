using System.IO;

namespace JsonFormattersBenchmark
{
    public abstract class BenchmarkCandidateBase<T>
    {
        protected readonly string _raw;
        protected T _decerialized;
        public BenchmarkCandidateBase(string sourceFile)
        {
            using (StreamReader r = new StreamReader(sourceFile))
            {
                _raw = r.ReadToEnd();
            }
        }
    }
}
