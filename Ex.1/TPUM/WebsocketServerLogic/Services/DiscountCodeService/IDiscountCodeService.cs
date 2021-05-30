using System;
using System.Collections;
using System.Collections.Generic;
using WebsocketServerLogic.DTOs;

namespace WebsocketServerLogic.Services.DiscountCodeService
{
    public interface IDiscountCodeService
    {
        DiscountCodeDTO AddDiscountCode(DiscountCodeDTO dto);

        IEnumerable<DiscountCodeDTO> GetAllDiscountCodes();

        void RemoveDiscountCode(Guid discountCodeId);
    }
}