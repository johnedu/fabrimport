namespace Project
{
    /// <summary>
    /// Some general constants for the application.
    /// </summary>
    public class ProjectConsts
    {
        public const string LocalizationSourceName = "Project";

        public const bool MultiTenancyEnabled = true;

        /**************************************************
         * Lambda expression operators
         **************************************************/
        public const string LAMBDA_EXPRESSION_EQUAL_OPERATOR = "=";
        public const string LAMBDA_EXPRESSION_NOTEQUAL_OPERATOR = "!=";

        /**************************************************
         * Phone Types
         **************************************************/
        public const string PHONE_TYPE_CATEGORY = "PHONE_TYPE";
        public const string LANDLINE_PHONE_TYPE = "LANDLINE_PHONE";
        public const string CELL_PHONE_TYPE = "CELL_PHONE";

        /**************************************************
         * Person document Types
         **************************************************/
        public const string PERSON_DOCUMENT_TYPE_CATEGORY = "PERSON_DOCUMENT_TYPE";
        public const string CEDULA_PERSON_DOCUMENT_TYPE = "CEDULA_DOCUMENT_TYPE";

        /**************************************************
         * Company document Types
         **************************************************/
        public const string COMPANY_DOCUMENT_TYPE_CATEGORY = "COMPANY_DOCUMENT_TYPE";
        public const string NIT_COMPANY_DOCUMENT_TYPE = "NIT_DOCUMENT_TYPE";

        /**************************************************
         * Spending Types
         **************************************************/
        public const string SPENDING_TYPE_CATEGORY = "SPENDING_TYPE";
        public const string SPENDING_EXPENSE_FOR_SALE_TYPE = "SPENDING_EXPENSE_FOR_SALE";
        public const string SPENDING_EXPENSE_FOR_PURCHASE_TYPE = "SPENDING_EXPENSE_FOR_PURCHASE";
        public const string SPENDING_OTHER_TYPE = "SPENDING_OTHER";

        /**************************************************
         * State Types
         **************************************************/
        public const string STATE_TYPE_CATEGORY = "STATE_TYPE";
        public const string INVOICE_STATE_TYPE = "INVOICE_STATE";
        public const string INVOICE_PAYMENT_STATE_TYPE = "INVOICE_PAYMENT_STATE";
        public const string INVENTORY_INPUT_STATE_TYPE = "INVENTORY_INPUT_STATE";
        public const string ORDER_STATE_TYPE = "ORDER_STATE";
        public const string SALE_INVOICE_STATE_TYPE = "SALE_INVOICE_STATE";
        public const string SALE_INVOICE_PAYMENT_STATE_TYPE = "SALE_INVOICE_PAYMENT_STATE";
        public const string SPENDING_STATE_TYPE = "SPENDING_STATE";
        public const string SPENDING_PAYMENT_STATE_TYPE = "SPENDING_PAYMENT_STATE";

        /**************************************************
         * States
         **************************************************/
        public const string ALL_IN_STOCK_STATE = "ALL_IN_STOCK";
        public const string IN_STOCK_STATE = "IN_STOCK";
        public const string ALL_SOLD_STATE = "ALL_SOLD";
        public const string SAVED_STATE = "SAVED";
        public const string INVENTORIED_STATE = "INVENTORIED";
        public const string INVENTORIED_STATE_WITH_MISSING_PRODUCTS_STATE = "INVENTORIED_STATE_WITH_MISSING_PRODUCTS";
        public const string PAID_STATE = "PAID";
        public const string CANCELLED_STATE = "CANCELLED";
        public const string PACKED_STATE = "PACKED";
        public const string INVOICED_STATE = "INVOICED";
        public const string DELIVERED_STATE = "DELIVERED";
        public const string ACTIVE_STATE = "ACTIVE";
        public const string INACTIVE_STATE = "INACTIVE";
    }
}