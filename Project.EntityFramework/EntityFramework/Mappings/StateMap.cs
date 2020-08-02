using Project.Domain.Entities;

namespace Project.EntityFramework.Mappings
{
    public class StateMap : MultiTenantMap<State>
    {
        public StateMap()
        {
            //  FOREIGN KEYS
            HasMany(state => state.InvoiceStates)
              .WithRequired(invoice => invoice.State)
              .HasForeignKey(invoice => invoice.StateId)
              .WillCascadeOnDelete(false);

            HasMany(state => state.InvoicePaymentStates)
              .WithRequired(invoicePayment => invoicePayment.State)
              .HasForeignKey(invoicePayment => invoicePayment.StateId)
              .WillCascadeOnDelete(false);

            HasMany(state => state.InventoryInputStates)
              .WithRequired(inventoryInput => inventoryInput.State)
              .HasForeignKey(inventoryInput => inventoryInput.StateId)
              .WillCascadeOnDelete(false); 

            HasMany(state => state.OrderStates)
              .WithRequired(order => order.OrderState)
              .HasForeignKey(order => order.OrderStateId)
              .WillCascadeOnDelete(false);

            HasMany(state => state.SaleInvoiceStates)
              .WithRequired(saleInvoice => saleInvoice.State)
              .HasForeignKey(saleInvoice => saleInvoice.StateId)
              .WillCascadeOnDelete(false);

            HasMany(state => state.SaleInvoicePaymentStates)
              .WithRequired(saleInvoicePayment => saleInvoicePayment.State)
              .HasForeignKey(saleInvoicePayment => saleInvoicePayment.StateId)
              .WillCascadeOnDelete(false);

            HasMany(state => state.SpendingStates)
              .WithRequired(spending => spending.State)
              .HasForeignKey(spending => spending.StateId)
              .WillCascadeOnDelete(false);

            HasMany(state => state.SpendingPaymentStates)
              .WithRequired(spendingPayment => spendingPayment.State)
              .HasForeignKey(spendingPayment => spendingPayment.StateId)
              .WillCascadeOnDelete(false);

            //  TABLE NAME
            ToTable("state");
        }
    }
}