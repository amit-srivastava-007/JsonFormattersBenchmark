using System;
using NetJSON;

namespace JsonFormattersBenchmark.Candidate
{
    public class NetJson<T> : BenchmarkCandidateBase<T>, IBenchmarkCandidate<T>
    {
        public NetJson(string sourceFile)
            :base(sourceFile){ }
        public T DeSerialize()
        {
            _decerialized = NetJSON.NetJSON.Deserialize<T>(_raw);
            return _decerialized;
        }

        public string Serialize()
        {
            return NetJSON.NetJSON.Serialize<T>(_decerialized);
        }
    }
}
