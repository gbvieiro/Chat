using Chat.Application.DTOs;
using Chat.Domain.Models;

namespace Chat.Application.Mappers
{
    /// <summary>
    /// A class that defines auto mappers from DTO to Entity.
    /// </summary>
    public class DtoToEntityProfile : AutoMapper.Profile
    {
        /// <summary>
        /// Constructor.
        /// </summary>
        public DtoToEntityProfile()
        {
            CreateMap<MessageDto, Message>();
        }
    }
}