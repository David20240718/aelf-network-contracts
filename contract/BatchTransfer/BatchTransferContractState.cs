using AElf.Sdk.CSharp.State;
using AElf.Types;

namespace AElf.Contracts.BatchTransfer;

public partial class BatchTransferContractState : ContractState
{
    public SingletonState<bool> Initialized { get; set; }
    public SingletonState<Address> Manager { get; set; }
}