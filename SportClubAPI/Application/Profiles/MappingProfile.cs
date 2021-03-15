using AutoMapper;
using Application.Features.Participants.Commands.CreateParticipant;
using Application.Features.Participants.Commands.UpdateParticipant;
using Application.Features.Participants.Queries.GetParticipantDetail;
using Application.Features.Participants.Queries.GetParticipantList;
using Application.Features.Participants.Queries.GetParticipantSportsList;
using Application.Features.Sports.Commands.CreateSport;
using Application.Features.Sports.Commands.UpdateSport;
using Application.Features.Sports.Queries.GetSportDetail;
using Application.Features.Sports.Queries.GetSportsList;
using Application.Features.Sports.Queries.GetSportsListWithItems;
using Domain.Entities;

namespace Application.Profiles
{
    public class MappingProfile: Profile
    {
        public MappingProfile()
        {
            CreateMap<Participant, ParticipantListVm>().ReverseMap();
            CreateMap<Participant, CreateParticipantCommand>().ReverseMap();
            CreateMap<Participant, UpdateParticipantCommand>().ReverseMap();
            CreateMap<Participant, ParticipantDetailVm>().ReverseMap();
            CreateMap<Participant, SportParticipantDto>().ReverseMap();
            CreateMap<Participant, ParticipantSportsListVm>().ReverseMap();

            CreateMap<Sport, SportDto>();
            CreateMap<Sport, SportListVm>();
            CreateMap<Sport, SportParticipantListVm>();
            CreateMap<Sport, CreateSportCommand>();
            CreateMap<Sport, CreateSportDto>();
            CreateMap<Sport, UpdateSportCommand>().ReverseMap();
            CreateMap<Sport, SportDetailVm>().ReverseMap();
        }
    }
}
