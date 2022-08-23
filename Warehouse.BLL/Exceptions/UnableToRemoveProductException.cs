using System;
using System.Collections.Generic;
using System.Text;

namespace Warehouse.BLL.Exceptions
{
    public class UnableToRemoveProductException : BaseException
    {
        public UnableToRemoveProductException(ReasonType reason)
        {
            Reason = reason;
        }

        public ReasonType Reason { get; set; }

        public enum ReasonType
        {
            NonZeroQuantity,
            ProductDoesntExist
        }
    }
}
