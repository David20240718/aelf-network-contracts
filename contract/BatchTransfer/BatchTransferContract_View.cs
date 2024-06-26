using AElf.Types;
using Google.Protobuf.WellKnownTypes;

namespace AElf.Contracts.BatchTransfer;

public partial class BatchTransferContract
{
    public override Address GetManager(Empty input)
    {
        return State.Manager.Value;
    }
}