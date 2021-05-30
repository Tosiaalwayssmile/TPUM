using System;
using System.Collections.Generic;
using System.Linq;
using WebsocketServerData;
using WebsocketServerData.Model;
using WebsocketServerData.Repositories.DiscountCodes;
using WebsocketServerLogic.DTOs;

namespace WebsocketServerLogic.Services.DiscountCodeService
{
    public class DiscountCodeService : IDiscountCodeService
    {
        private readonly IDiscountCodeRepository _discountCodeRepository;

        public DiscountCodeService()
        {
            _discountCodeRepository = new DiscountCodeRepository(DataStore.Instance.State.DiscountCodes);
        }

        public DiscountCodeService(IDiscountCodeRepository discountCodeRepository)
        {
            _discountCodeRepository = discountCodeRepository;
        }

        public DiscountCodeDTO AddDiscountCode(DiscountCodeDTO dto)
        {
            DiscountCode discountCode = DTOMapper.DTO2DiscountCode(dto);
            DiscountCode created = _discountCodeRepository.Create(discountCode);
            return DTOMapper.DiscountCode2DTO(created);
        }

        public IEnumerable<DiscountCodeDTO> GetAllDiscountCodes()
        {
            return _discountCodeRepository.Items.Select( item => DTOMapper.DiscountCode2DTO(item));
        }

        public void RemoveDiscountCode(Guid discountCodeId)
        {
            _discountCodeRepository.Delete(discountCodeId);
        }
    }
}
