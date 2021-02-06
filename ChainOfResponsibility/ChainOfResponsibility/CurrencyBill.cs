using System;
using System.Collections.Generic;
using System.Text;

namespace ChainOfResponsibility
{
    class CurrencyBill : ICurrencyBill
    {
        private ICurrencyBill next;
        int denomination;
        int quantity;

        public CurrencyBill (int denomination, int  quantity)
        {
            this.denomination = denomination;
            this.quantity = quantity;
        }

        public ICurrencyBill registerNext(ICurrencyBill currencyBill)
        {
            this.next = currencyBill;

            return currencyBill;
        }

        public virtual bool dispenseRequest (int amount)
        {
            int neededQuantity = (int) amount / denomination;
            if (neededQuantity > 0)
            {
                if (quantity > neededQuantity)
                {
                    amount -= denomination * neededQuantity;
                    quantity -= neededQuantity;
                }
                else
                {
                    amount -= denomination * quantity;
                    quantity = 0;
                }
                if (amount == 0)
                    return true;
                else if (next != null)
                    return true && next.dispenseRequest(amount);
            }
            else
            {
                if (this.next != null)
                    return this.next.dispenseRequest(amount);
                else
                    return false;
            }
            return false;
        }  
    }
}
