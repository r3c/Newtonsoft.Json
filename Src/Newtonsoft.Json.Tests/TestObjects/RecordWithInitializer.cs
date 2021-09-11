namespace Newtonsoft.Json.Tests.TestObjects
{
    record RecordWithInitializer(int Value)
    {
        public static readonly RecordWithInitializer Default = new RecordWithInitializer(0);
    }

    class ContainerForRecordWithInitializer
    {
        [JsonProperty]
        public RecordWithInitializer Field { get; set; } = RecordWithInitializer.Default;
    }
}
