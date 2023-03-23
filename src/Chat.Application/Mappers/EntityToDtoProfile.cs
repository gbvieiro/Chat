using Chat.Application.DTOs;
using Chat.Domain.Models;

namespace Chat.Application.Mappers
{
    /// <summary>
    /// A class that defines auto mappers from Entity to DTO.
    /// </summary>
    public class EntityToDtoProfile : AutoMapper.Profile
    {
        /// <summary>
        /// Constructor.
        /// </summary>
        public EntityToDtoProfile()
        {
            CreateMap<Message, MessageDto>();
        }
    }
}