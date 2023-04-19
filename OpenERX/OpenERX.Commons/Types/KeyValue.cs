namespace OpenERX.Commons.Types
{
    public class KeyValue
    {
        public string Key { get; set; }
        public string Value { get; set; }
        public IList<KeyValue> Values { get; set; }

        public KeyValue()
        {
            this.Values = new List<KeyValue>();
        }

        public KeyValue(string key, string value)
        {
            this.Values = new List<KeyValue>();
            this.Key = key;
            this.Value = value;
        }

        public KeyValue(string key, string value, IList<KeyValue>? values)
        {
            this.Key = key;
            this.Value = value;
            this.Values = values ?? new List<KeyValue>();
        }
    }
}



