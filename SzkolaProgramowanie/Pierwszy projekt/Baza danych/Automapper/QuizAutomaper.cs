using AutoMapper;
using Baza_danych.Dto;
using Quiz.Baza_danych.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace Baza_danych.Automapper
{
    //https://cezarywalenciuk.pl/blog/programing/automapper-z-aspnet-core
    //https://plawgo.pl/2019/01/08/entity-framework-automapper-oraz-projekcja/
    public class QuizAutomaper
    {
        public IMapper Mapper { get; private set; }
        MapperConfiguration configMapper;

        public QuizAutomaper()
        {
            configMapper = new MapperConfiguration(ConfigAutomapper);
            Mapper = configMapper.CreateMapper();
        }

        private void ConfigAutomapper(IMapperConfigurationExpression configurationExpression)
        {
            configurationExpression.CreateMap<Pytanie, PytanieReadDto>();
            configurationExpression.CreateMap<PytanieUpdateDto, Pytanie>();

            configurationExpression.CreateMap<Odpowiedz, OdpowiedzReadDto>();
            configurationExpression.CreateMap<OdpowiedzUpdateDto, Odpowiedz>();
            configurationExpression.CreateMap<OdpowiedzCreateDto, Odpowiedz>();
            configurationExpression.CreateMap<OdpowiedzDeleteDto, Odpowiedz>();
        }

    }
}
