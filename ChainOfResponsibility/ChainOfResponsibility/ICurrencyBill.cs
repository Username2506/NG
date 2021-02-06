using System;
using System.Collections.Generic;
using System.Text;

namespace ChainOfResponsibility
{
    public interface ICurrencyBill
    {
        ICurrencyBill registerNext(ICurrencyBill currencyBill);
        bool dispenseRequest (int amount);
    }
}
