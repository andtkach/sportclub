using AutoMapper;
using Application.Features.Categories.Commands.CreateCateogry;
using Application.Features.Categories.Commands.UpdateCategory;
using Application.Features.Categories.Queries.GetCategoriesList;
using Application.Features.Categories.Queries.GetCategoriesListWithItems;
using Application.Features.Categories.Queries.GetCategoryDetail;
using Application.Features.Items.Commands.CreateItem;
using Application.Features.Items.Commands.UpdateItem;
using Application.Features.Items.Queries.GetIParticipanSportsList;
using Application.Features.Items.Queries.GetItemDetail;
using Application.Features.Items.Queries.GetItemsList;
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
