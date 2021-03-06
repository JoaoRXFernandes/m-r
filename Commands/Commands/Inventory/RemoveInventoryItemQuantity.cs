using System;
using Infrastructure.CQRS.Commands;

namespace Commands.Inventory
{
    public class RemoveInventoryItemQuantity : Command {
        public Guid InventoryItemId { get; set; }
        public int OriginalVersion { get; set; }
        public int Quantity { get; set; }
    }
}
