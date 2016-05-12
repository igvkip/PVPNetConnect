namespace PvpLib
{
    using System.Threading;

    internal sealed class StateObject
    {
        private readonly ManualResetEvent _done = new ManualResetEvent(false);

        public int BytesRead { get; set; }
        public ManualResetEvent Done { get { return _done; } }
    }
}
