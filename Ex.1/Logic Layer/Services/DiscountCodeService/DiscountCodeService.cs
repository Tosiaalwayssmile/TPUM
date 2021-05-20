using System;
using System.Collections.Generic;
using System.Linq;
using DataLayer;
using DataLayer.Model;
using DataLayer.Repositories.DiscountCodes;
using LogicLayer.DTOs;

namespace LogicLayer.Services.DiscountCodeService
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
