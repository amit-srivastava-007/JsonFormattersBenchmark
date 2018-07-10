using Newtonsoft.Json;

namespace JsonFormattersBenchmark.Candidate
{
    public class NewtonSoft<T> : BenchmarkCandidateBase<T>, IBenchmarkCandidate<T>
    {        
        public NewtonSoft(string sourceFile)
            :base(sourceFile){ }

        public T DeSerialize()
        {
            _decerialized = JsonConvert.DeserializeObject<T>(_raw);
            return _decerialized;
        }

        public string Serialize()
        {
            return JsonConvert.SerializeObject(_decerialized);
        }
    }
}
