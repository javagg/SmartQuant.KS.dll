using System;

namespace SmartQuant.KS
{
    public class Kingstar : Provider, IExecutionProvider, IHistoricalDataProvider, IInstrumentProvider, IDataProvider
    {
        public Kingstar(Framework framework)
            : base(framework)
        {
        }

        void IHistoricalDataProvider.Cancel(string requestId)
        {
        }

        void IInstrumentProvider.Cancel(string requestId)
        {
        }

        public override void Subscribe(Instrument instrument)
        {
        }

        public override void Unsubscribe(Instrument instrument)
        {
        }

        public override void Connect()
        {
        }

        public override void Disconnect()
        {
        }
    }
}

