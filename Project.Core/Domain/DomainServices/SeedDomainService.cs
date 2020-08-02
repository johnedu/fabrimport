using Project.Domain.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Project.Domain.DomainServices
{
    public class SeedDomainService : ProjectDomainServiceBase, ISeedDomainService
    {
        #region Repositorios
        private readonly ITypeRepository _typeRepository;
        private readonly IStateRepository _stateRepository;
        private readonly IParameterRepository _parameterRepository;
        #endregion

        public SeedDomainService(ITypeRepository typeRepository,
                                 IStateRepository stateRepository,
                                 IParameterRepository parameterRepository)
        {
            _typeRepository = typeRepository;
            _stateRepository = stateRepository;
            _parameterRepository = parameterRepository;
        }

        public async Task CargarSeed(int tenantId)
        {
            await SavePhoneTypes(tenantId);
            await SaveCompanyDocumentTypes(tenantId);
            await SavePersonDocumentTypes(tenantId);
            await SaveSpendingTypes(tenantId);
            await SaveStateTypes(tenantId);

            await SaveInvoiceStates(tenantId);
            await SaveInvoicePaymentStates(tenantId);
            await SaveInventoryInputStates(tenantId);
            await SaveOrderStates(tenantId);
            await SaveSaleInvoiceStates(tenantId);
            await SaveSaleInvoicePaymentStates(tenantId);
            await SaveSpendingStates(tenantId);
            await SaveSpendingPaymentStates(tenantId);
        }

        private async Task SavePhoneTypes(int tenantId)
        {
            List<string> phoneTypes = new List<string>
            {
                ProjectConsts.LANDLINE_PHONE_TYPE,
                ProjectConsts.CELL_PHONE_TYPE
            };

            await SaveTypes(phoneTypes, ProjectConsts.PHONE_TYPE_CATEGORY, tenantId, true);
        }

        private async Task SavePersonDocumentTypes(int tenantId)
        {
            List<string> personDocumentTypes = new List<string>
            {
                ProjectConsts.CEDULA_PERSON_DOCUMENT_TYPE
            };

            await SaveTypes(personDocumentTypes, ProjectConsts.PERSON_DOCUMENT_TYPE_CATEGORY, tenantId, false);
        }

        private async Task SaveCompanyDocumentTypes(int tenantId)
        {
            List<string> companyDocumentTypes = new List<string>
            {
                ProjectConsts.NIT_COMPANY_DOCUMENT_TYPE
            };

            await SaveTypes(companyDocumentTypes, ProjectConsts.COMPANY_DOCUMENT_TYPE_CATEGORY, tenantId, false);
        }

        private async Task SaveSpendingTypes(int tenantId)
        {
            List<string> spendingTypes = new List<string>
            {
                ProjectConsts.SPENDING_EXPENSE_FOR_SALE_TYPE,
                ProjectConsts.SPENDING_EXPENSE_FOR_PURCHASE_TYPE,
                ProjectConsts.SPENDING_OTHER_TYPE
            };

            await SaveTypes(spendingTypes, ProjectConsts.SPENDING_TYPE_CATEGORY, tenantId, true);
        }

        private async Task SaveStateTypes(int tenantId)
        {
            List<string> productPriceTypes = new List<string>
            {
                ProjectConsts.INVOICE_STATE_TYPE,
                ProjectConsts.INVOICE_PAYMENT_STATE_TYPE,
                ProjectConsts.INVENTORY_INPUT_STATE_TYPE,
                ProjectConsts.ORDER_STATE_TYPE,
                ProjectConsts.SALE_INVOICE_STATE_TYPE,
                ProjectConsts.SALE_INVOICE_PAYMENT_STATE_TYPE,
                ProjectConsts.SPENDING_STATE_TYPE,
                ProjectConsts.SPENDING_PAYMENT_STATE_TYPE
            };

            await SaveTypes(productPriceTypes, ProjectConsts.STATE_TYPE_CATEGORY, tenantId, true);
        }

        private async Task SaveInvoiceStates(int tenantId)
        {
            Type orderInvoiceType = await _typeRepository.FirstOrDefaultAsync(x => x.Name == ProjectConsts.INVOICE_STATE_TYPE && x.TenantId == tenantId);

            List<string> invoiceStates = new List<string>
            {
                ProjectConsts.SAVED_STATE,
                ProjectConsts.INVENTORIED_STATE,
                ProjectConsts.INVENTORIED_STATE_WITH_MISSING_PRODUCTS_STATE,
                ProjectConsts.PAID_STATE,
                ProjectConsts.CANCELLED_STATE
            };

            await SaveStates(invoiceStates, orderInvoiceType.Id, tenantId);
        }

        private async Task SaveInvoicePaymentStates(int tenantId)
        {
            Type invoicePaymentStates = await _typeRepository.FirstOrDefaultAsync(x => x.Name == ProjectConsts.INVOICE_PAYMENT_STATE_TYPE && x.TenantId == tenantId);

            List<string> paymentStates = new List<string>
            {
                ProjectConsts.SAVED_STATE,
                ProjectConsts.PAID_STATE,
                ProjectConsts.CANCELLED_STATE
            };

            await SaveStates(paymentStates, invoicePaymentStates.Id, tenantId);
        }

        private async Task SaveInventoryInputStates(int tenantId)
        {
            Type inventoryInputStateType = await _typeRepository.FirstOrDefaultAsync(x => x.Name == ProjectConsts.INVENTORY_INPUT_STATE_TYPE && x.TenantId == tenantId);

            List<string> inventoryInputStates = new List<string>
            {
                ProjectConsts.ALL_IN_STOCK_STATE,
                ProjectConsts.IN_STOCK_STATE,
                ProjectConsts.ALL_SOLD_STATE
            };

            await SaveStates(inventoryInputStates, inventoryInputStateType.Id, tenantId);
        }

        private async Task SaveOrderStates(int tenantId)
        {
            Type orderStateType = await _typeRepository.FirstOrDefaultAsync(x => x.Name == ProjectConsts.ORDER_STATE_TYPE && x.TenantId == tenantId);

            List<string> orderStates = new List<string>
            {
                ProjectConsts.SAVED_STATE,
                ProjectConsts.PACKED_STATE,
                ProjectConsts.INVOICED_STATE,
                ProjectConsts.CANCELLED_STATE
            };

            await SaveStates(orderStates, orderStateType.Id, tenantId);
        }

        private async Task SaveSaleInvoiceStates(int tenantId)
        {
            Type saleInvoiceType = await _typeRepository.FirstOrDefaultAsync(x => x.Name == ProjectConsts.SALE_INVOICE_STATE_TYPE && x.TenantId == tenantId);

            List<string> saleInvoiceStates = new List<string>
            {
                ProjectConsts.SAVED_STATE,
                ProjectConsts.DELIVERED_STATE,
                ProjectConsts.PAID_STATE,
                ProjectConsts.CANCELLED_STATE
            };

            await SaveStates(saleInvoiceStates, saleInvoiceType.Id, tenantId);
        }

        private async Task SaveSaleInvoicePaymentStates(int tenantId)
        {
            Type saleInvoicePaymentStates = await _typeRepository.FirstOrDefaultAsync(x => x.Name == ProjectConsts.SALE_INVOICE_PAYMENT_STATE_TYPE && x.TenantId == tenantId);

            List<string> paymentStates = new List<string>
            {
                ProjectConsts.SAVED_STATE,
                ProjectConsts.PAID_STATE,
                ProjectConsts.CANCELLED_STATE
            };

            await SaveStates(paymentStates, saleInvoicePaymentStates.Id, tenantId);
        }

        private async Task SaveSpendingStates(int tenantId)
        {
            Type spendingStateType = await _typeRepository.FirstOrDefaultAsync(x => x.Name == ProjectConsts.SPENDING_STATE_TYPE && x.TenantId == tenantId);

            List<string> spendingStates = new List<string>
            {
                ProjectConsts.SAVED_STATE,
                ProjectConsts.PAID_STATE,
                ProjectConsts.CANCELLED_STATE
            };

            await SaveStates(spendingStates, spendingStateType.Id, tenantId);
        }

        private async Task SaveSpendingPaymentStates(int tenantId)
        {
            Type spendingPaymentStatesType = await _typeRepository.FirstOrDefaultAsync(x => x.Name == ProjectConsts.SPENDING_PAYMENT_STATE_TYPE && x.TenantId == tenantId);

            List<string> spendingPaymentStates = new List<string>
            {
                ProjectConsts.SAVED_STATE,
                ProjectConsts.PAID_STATE,
                ProjectConsts.CANCELLED_STATE
            };

            await SaveStates(spendingPaymentStates, spendingPaymentStatesType.Id, tenantId);
        }

        private async Task SaveTypes(List<string> typeNames, string category, int tenantId, bool locked)
        {
            bool thereAreSaves = false;
            foreach (string typeName in typeNames)
            {
                Type TypeExists = await _typeRepository.FirstOrDefaultAsync(x => x.Name == typeName && x.TenantId == tenantId);
                if (TypeExists == null)
                {
                    thereAreSaves = true;
                    int parameterId = await GetCategory(category, tenantId);
                    await _typeRepository.InsertAsync(new Type { Name = typeName, ParameterId = parameterId, Locked = locked, TenantId = tenantId });
                }
            }

            if (thereAreSaves)
            {
                await CurrentUnitOfWork.SaveChangesAsync();
            }
        }

        private async Task SaveStates(List<string> stateNames, int typeId, int tenantId)
        {
            bool thereAreSaves = false;
            foreach (string stateName in stateNames)
            {
                State stateExists = await _stateRepository.FirstOrDefaultAsync(x => x.Name == stateName && x.StateTypeId == typeId && x.TenantId == tenantId);
                if (stateExists == null)
                {
                    thereAreSaves = true;
                    await _stateRepository.InsertAsync(new State { Name = stateName, StateTypeId = typeId, Locked = true, TenantId = tenantId });
                }
            }

            if (thereAreSaves)
            {
                await CurrentUnitOfWork.SaveChangesAsync();
            }
        }

        private async Task<int> GetCategory(string categoryName, int tenantId)
        {
            Parameter parameterExists = await _parameterRepository.FirstOrDefaultAsync(p => p.Name == categoryName && p.TenantId == tenantId);
            if (parameterExists == null)
            {
                parameterExists = new Parameter
                {
                    Name = categoryName,
                    TenantId = tenantId
                };
                await _parameterRepository.InsertOrUpdateAndGetIdAsync(parameterExists);
                CurrentUnitOfWork.SaveChanges();
            }

            return parameterExists.Id;
        }
    }
}